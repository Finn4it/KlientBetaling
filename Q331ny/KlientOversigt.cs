using Q331ny.Søg;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q331ny
{
    public partial class KlientOversigt : Form, IEnumerable
    {
        List<SqlResult> result;
        public KlientOversigt(List<SqlResult> res)
        {
            result = res;
            InitializeComponent();
            Opstart();
        }

        private void Opstart()
        {
            List<string> ud = new List<string>();
            DataTable dt = new DataTable();

            int i = 0;
            foreach (var s1 in result)
            {
                dt.Columns.Add(i.ToString());
                i++;
                foreach (var s2 in s1.Col)
                {
                    textBox1.AppendText(s2.Felt + "   ");
                    ud.Add(s2.Felt);
                    dt.Rows.Add(s2.Felt);
                    //foreach (var s3 in s2.Felt)
                    //{
                    //    textBox1.AppendText(s3 + Environment.NewLine);
                    //}

                }
                textBox1.AppendText(Environment.NewLine);
                //textBox1.Text = s1.Col.ToString();

            }
            dataGridView1.DataSource = dt.Rows;

        }

        private void KlientOversigt_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
