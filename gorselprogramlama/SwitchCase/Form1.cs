using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text.ToUpper();            
            switch (metin)
            {
                case "OCAK":
                    label2.Text = "1";
                    break;
                case "SUBAT":
                    label2.Text = "2";
                    break;

                default:
                    label2.Text = "Böyle bir ay yok kardeşim";
                    break;
            }
        }
    }
}
