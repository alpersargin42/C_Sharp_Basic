using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracSatis
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    
                   
                    if (c.Text =="")
                    {
                        c.ForeColor = Color.Red;
                        c.Text = "Bu alan boş geçilemez";
                        

                    }

                    listBox2.Items.Add(c.Text + "\t");
                }
                else if (c is GroupBox)
                {
                    foreach (Control a in c.Controls)
                    {
                        if (a is TextBox || a is ComboBox)
                        {


                            if (a.Text == "")
                            {
                                a.ForeColor = Color.Red;
                                a.Text = "Bu alan boş geçilemez";
                                

                            }
                            
                        }
                        listBox1.Items.Add(a.Text + "\t");
                    }
                    
                }
                
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
