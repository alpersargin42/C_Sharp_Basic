﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıTekCiftKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if ( sayi >0)
            {
                label2.Text = "Sayı pozitif "+sayi;
            }
            else if (sayi < 0)
            {
                label2.Text = "Sayı negatif "+sayi;
            }
            else
            {
                label2.Text = "Sayı "+sayi;
            }
        }
    }
}
