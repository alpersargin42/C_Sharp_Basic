using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary5
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kul_adı=Convert.ToString(textBox1.Text); 
            string sifre=Convert.ToString(textBox2.Text);   
            if(kul_adı=="admin")
            {
                if(sifre=="makif")
                {
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                }
            }

        }

       
    }
}
