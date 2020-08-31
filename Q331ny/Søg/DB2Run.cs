using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q331ny
{
    public class Db2Run
    {
        private ODBC _odbc;

        // test test

        public Db2Run(ODBC odbc , string sqlQ )
        {
            _odbc = odbc;

            // antager at RunQuery skal kaldes her
            Console.WriteLine(sqlQ);
        }

        public void RunQuery(ODBC odbc, string _sqlQ)
        {
            string ConectStreng;
            ConectStreng = "DSN=BZDSNT;UID=z6fia;Pwd=xxxxxx";

            using (var conn = new OdbcConnection(ConectStreng))
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand(_sqlQ, conn);
                    cmd.CommandTimeout = 1000 * 60; // 5 minutter
                    conn.Open();
                    var schema = conn.GetSchema();
                    var datasource = conn.DataSource;
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //SqlResult res = new SqlResult();
                            //result.Add(res);
                            //Kolloner  col = new Kolloner();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string value;
                                //string dataType;
                                switch (reader.GetValue(i).GetType().Name)
                                {
                                    case "DateTime":
                                        //dt = reader.GetDateTime(i);
                                        //value = reader.GetDateTime(i).ToString("yyyy-MM-dd HH:mm:ss.ffffff");
                                        switch ((Int32)reader.GetSchemaTable().Rows[i]["ColumnSize"])
                                        {
                                            case 16:
                                                value = reader.GetDateTime(i).ToString("yyyy-MM-dd HH:mm:ss.ffffff");
                                                break;
                                            case 6:
                                                value = reader.GetDateTime(i).ToString("yyyy-MM-dd");
                                                break;
                                            default:
                                                throw new Exception("Wrong Date Handling");
                                        }
                                        break;
                                    case "String":

                                        value = reader.GetValue(i).ToString();
                                        break;
                                    case "Decimal":
                                        if (conn.Driver == "DB2CLI.DLL")
                                        {
                                            // scale er antallet af decimaler 
                                            NumberFormatInfo nfi = new NumberFormatInfo() { NumberDecimalSeparator = ",", NumberGroupSeparator = "." };
                                            var scale = Double.Parse(reader.GetSchemaTable().Rows[i]["NumericScale"].ToString());
                                            value = (Convert.ToDouble(reader.GetDecimal(i)) / Math.Pow(10D, scale)).ToString("0." + new String('0', (int)scale), nfi);
                                        }
                                        else
                                        { // SQLSRV32.DLL
                                            value = reader.GetValue(i).ToString();
                                        }
                                        break;
                                    default:
                                        value = reader.GetValue(i).ToString();
                                        break;
                                } // end switch
                                //res.Addkol(value);
                            }
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    if (ex.Message.Contains("USERNAME AND"))
                    {
                        MessageBox.Show("Formentlig password fejl. Der indhentes nyt ved næste SQL opslag." + "\n" + ex.Message);
                    }
                    else
                        MessageBox.Show(ex.Message);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    conn.Close();
                }

            }

        }
    }
}
