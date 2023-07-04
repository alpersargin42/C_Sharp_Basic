using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label11.Text = "";
            label10.Text = "";
            label9.Text = "";
            label5.Visible = false;
            textBox5.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32(textBox3.Text);
            int final = Convert.ToInt32(textBox4.Text);

            double ort = 0;
            if ((vize >= 0 && vize <= 100) && (final >= 0 && final <= 100))
            {
                if (textBox4.Text != "")
                {

                    if (final >= 40)
                    {
                        ort = (vize * 0.4) + (final * 0.6);
                        label13.Text = Convert.ToString(ort);
                        if (ort >= 60)
                        {
                            label11.Text = "Geçti";
                            label11.ForeColor=Color.Yellow;
                        }
                        else
                        {
                            label11.Text = "Kaldı"; 
                            label11.ForeColor = Color.DarkRed;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                listBox1.Items.Clear();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                label11.Text = "";
            }


            label9.Text = textBox1.Text;
            label10.Text = textBox2.Text;
            listBox1.Items.Add(label9.Text);
            listBox1.Items.Add(label10.Text);
            listBox1.Items.Add(label11.Text);
        }
    }
}
