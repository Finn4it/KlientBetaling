using System;
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
    public partial class FormLogon : Form
    {
        public bool UserInfoOK;
        public bool Exit;

        public FormLogon()
        {
            InitializeComponent();
            Exit = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit = true;
        }

        private void textBoxOD_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBoxUS.Text == "") || (textBoxPW.Text == ""))
            {
                MessageBox.Show("Både User ID og password skal udfyldes", "Fejl", MessageBoxButtons.OK);
            }
            else
            {
                UserInfoOK = true;
                Exit = false;
                Close();
            }
        }

        private void textBoxPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
