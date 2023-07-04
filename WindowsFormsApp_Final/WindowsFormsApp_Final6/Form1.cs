using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Final6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    if (c.Text == "")
                    {
                        c.ForeColor = Color.DarkRed;
                        c.Text = "Bu alan boş olamaz";
                    }
                    else if (c.Text != "Bu alan boş olamaz")
                    {
                        c.ForeColor = Color.Black;

                    }
                }
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
