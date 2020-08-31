using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q331ny.Søg;
using System.IO;

namespace Q331ny
{
    public partial class Q331 : Form
    {
        public ODBC _Odbc;
        public Q331()
        {
            InitializeComponent();
            OpbygForm();
        }

        private void OpbygForm()
        {
            var path = @"C:\Klientbetaling";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                path += @"\ODBC";
                Directory.CreateDirectory(path);
                _Odbc = new ODBC() { OdbcNavn = "BZDSNT", };
                path += @"\BZDSNT.xml";
                _Odbc.gemSetting(_Odbc, path);
            }

            //_Odbc = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            søgBtn.Text = "Mainframe is god";

        }

        private void søgBtn_Click(object sender, EventArgs e)
        {

            List<SqlResult> res1 = new List<SqlResult>();

            string sqlQ = "Select A.ADM_ENH_ID_KLI"
                        + " , A.KLIENT_NUMMER"
                        + " ,A.KLIENT_TYPE"
                        + " ,A.KLI_STAM_TLFNR"
                        + " , B.SAG_OPRET_DATO"
                        + " , B.SAG_AFSLUT_DATO"
                        + " , B.ÆLP_SAGSTYPE"
                        + " , B.SAGSBEH_ID"
                        + " FROM UDVM.QF00100T A"
                        + "    , UDVM.QF00900T B"
                        + " WHERE A.ADM_ENH_ID_KLI = 50225"
                        + " AND B.ADM_ENH_ID_KLI = A.ADM_ENH_ID_KLI"
                        + " AND A.KLIENT_NUMMER = B.KLIENT_NUMMER"
                        + " AND A.KLIENT_TYPE IN('A','B')"
                        + " AND A.KLIENT_TYPE = B.KLIENT_TYPE"
                        + " AND B.ÆLP_SAGSTYPE = 'KB'"
                        + " AND B.SAG_AFSLUT_DATO = '0001-01-01'"
                        + " FETCH FIRST 10 ROWS ONLY ";

            //string sql1 = "Select ADM_ENH_ID_KLI "
            //+ " FROM UDVM.QF00100T "
            //+ " WHERE ADM_ENH_ID_KLI = 50225 ";

            // nedenstående skal nok laves et andet sted
            _Odbc = new ODBC() { OdbcNavn = "BZDSNT", };

            Db2Run run = new Db2Run(_Odbc , sqlQ );
            run.RunQuery(_Odbc, sqlQ);

            //KlientOversigt k1 = new KlientOversigt(run.result);


            //k1.dataGridView1.DataSource = run.result;

            //k1.ShowDialog();
        }
    }
}
