using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj1 = textBox1.Text;
            label10.Text = mesaj1;
            string mesaj2 = textBox2.Text;
            label11.Text = mesaj2;
            string mesaj3 = textBox3.Text;
            label12.Text = mesaj3;
            string mesaj4 = textBox4.Text;
            label13.Text = mesaj4;
        }
    }
}
