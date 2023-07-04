using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Final8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Kac adim:";
            label2.Visible = false;
            textBox1.Text = "";
            textBox2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Sayi:";
            label2.Visible = false;
            textBox1.Text = "";
            textBox2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Sayi1:";
            label2.Visible = true;
            label2.Text = "Sayi2:";
            textBox1.Text = "";
            textBox2.Visible = true;
            textBox2.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Sayi1:";
            label2.Visible = true;
            label2.Text = "Sayi2:";
            textBox1.Text = "";
            textBox2.Visible = true;
            textBox2.Text = "";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Sayi1:";
            label2.Visible = true;
            label2.Text = "Sayi2:";
            textBox1.Text = "";
            textBox2.Visible = true;
            textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double a = Convert.ToDouble(textBox1.Text);
                int sayac = 0;
                for (int sayi = 2; sayi <= a; sayi++)
                {
                    int kontrol = 0;

                    for (int i = 2; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            kontrol = 1;
                            break;
                        }
                    }
                    if (kontrol == 1)
                    {
                        listBox1.Items.Add(sayi + " asal değidir");
                    }
                    else
                    {
                        listBox1.Items.Add(sayi + " asaldır");
                        sayac++;
                    }
                }
            }
            else if (radioButton2.Checked == true)
            {
                int sayac = 0;
                double sayi = Convert.ToDouble(textBox1.Text);
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;
                        break;
                    }
                }
                if (sayac == 0)
                {
                    listBox1.Items.Add(sayi + " Asaldır.");
                }
                else
                {
                    listBox1.Items.Add(sayi + " Asal Değildir.");
                }
            }
            else if (radioButton3.Checked == true)
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double kucukolanSayi;
                bool sonuc = false;
                kucukolanSayi = sayi2;
                if (sayi1 < sayi2)
                {
                    kucukolanSayi = sayi1;
                }

                for (double i = 2; i <= kucukolanSayi; i++)
                {
                    if (sayi1 % i == 0 && sayi2 % i == 0)
                    {
                        sonuc = true;
                    }
                }

                if (sonuc==true)
                {
                    listBox1.Items.Add("Aralarında Asal Değildir.");
                }
                else
                {
                    listBox1.Items.Add("Aralarında Asaldır.");
                }
            }
            else if (radioButton4.Checked == true)
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double max = sayi1 * sayi2;
                double ekok = 0;
                for (double i = max; i > 0; i--)
                {
                    if (i % sayi1 == 0 && i % sayi2 == 0)
                    {
                        ekok = i;
                    }
                }

                listBox1.Items.Add("Ekok:" + ekok);
            }
            else if (radioButton5.Checked == true)
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double ebob = 0;
                for (double i = 1; i < sayi1; i++)
                {
                    if (sayi1 % i == 0 && sayi2 % i == 0)
                    {
                        ebob = i;
                    }
                }

                listBox1.Items.Add("Ebob:" + ebob);
            }
        }
    }
}
