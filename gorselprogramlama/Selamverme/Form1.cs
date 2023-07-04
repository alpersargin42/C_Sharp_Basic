using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selamverme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selamünaleyküm");
            label1.Text = "Aleykümselam";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp; 
            temp = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = temp;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
            label6.Text = textBox3.Text;
            label7.Text = textBox4.Text;
            label8.Text = comboBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
