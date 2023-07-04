using System;
using System.Windows.Forms;

namespace WindowsFormsApp_Final9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool optDurum=false;
        private double sonuc = 0;
        private string opt = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if (textBox1.Text=="0"||optDurum)
            {
                textBox1.Clear();
            }

            optDurum = false;
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void OptHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            label1.Text = label1.Text + " " + textBox1.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+":
                    textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString();
                    break;

            }

            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();

            opt = yeniOpt;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+":
                    textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString();
                    break;

            }

            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();

            opt = " ";

        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text=="0")
            {
                textBox1.Text = "0";
            }
            else if (optDurum==true)
            {
                textBox1.Text = "0";
            }

            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }

            optDurum = false;
        }
    }
}
