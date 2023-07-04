using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParolaDogruYanlis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
           
            if (metin.Length>=8 )
            {
                if (metin =="ahmet0658")
                {
                    label2.Text = "Parola Doğru";
                }
                
            }
            else
            {
                label2.Text = "Parola Yanlış";
            }
        }
    }
}
