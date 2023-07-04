using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Final2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double topla = sayi1 + sayi2;
            textBox3.Text = Convert.ToString(topla);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double cikar = sayi1 - sayi2;
            textBox3.Text = Convert.ToString(cikar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double carp = sayi1 * sayi2;
            textBox3.Text = Convert.ToString(carp);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double bol = sayi1 / sayi2;
            textBox3.Text = Convert.ToString(bol);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(textBox4.Text);
            double final = Convert.ToDouble(textBox5.Text);
            double ort = (vize * 0.4) + (final * 0.6);
            textBox6.Text = Convert.ToString(ort);
            if (ort<60||final<40)
            {
                label8.Text = "Kaldınız";
                label8.ForeColor = Color.DarkRed;
            }
            else
            {
                label8.Text = "Geçtiniz";
                label8.ForeColor = Color.Yellow;
            }
        }
    }
}
