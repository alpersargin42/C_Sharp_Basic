﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            //alarm iptal et 
            textBox1.Text = DateTime.Now.ToShortDateString();
            textBox2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color c;
            c = label3.BackColor;
            label3.BackColor = label3.ForeColor;
            label3.ForeColor = c;
            label3.Text = DateTime.Now.ToShortTimeString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (textBox1.Text == DateTime.Now.ToShortDateString() && textBox2.Text == DateTime.Now.ToLongTimeString())
            {
                label3.Text = "Alarm çalıyor";
                MessageBox.Show("Alarm Çalıyor");
                timer1.Enabled = true;
                SoundPlayer palyer = new SoundPlayer();
                string sarkiyol = Application.StartupPath + "/alarm.wav";
                palyer.SoundLocation = sarkiyol;
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }
    }
}
