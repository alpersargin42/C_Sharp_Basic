using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int[] dizi = new int[a];

            dizi[0] = 1;
            dizi[1] = 1;
            
            for (int i = 2; i <a; i++)
            {
                dizi[i] = dizi[i - 1] + dizi[i - 2];
            }
            for (int i = 0; i < a; i++)
            {
                listBox1.Items.Add(dizi[i] + " \t");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
        }
    }
}
