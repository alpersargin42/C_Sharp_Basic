using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Final5_Update2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string kul_adi = Convert.ToString(textBox1.Text);
            string sifre = Convert.ToString(textBox2.Text);
            if (kul_adi == "admin")
            {
                if (sifre == "adminpage")
                {
                    Form2 frm = new Form2();
                    frm.Show();
                }
                else
                {
                    label3.Text = "Sifre Yanlis";
                    label3.ForeColor = Color.DarkRed;
                    label2.ForeColor = Color.DarkRed;
                    MessageBox.Show("Sifre Yanlis");
                }
            }
            else
            {
                label3.Text = "Kullanici Adi Yanlis";
                label3.ForeColor = Color.DarkRed;
                label1.ForeColor = Color.DarkRed;
                MessageBox.Show("Kullanici Adi Yanlis");
            }
        }
    }
}
