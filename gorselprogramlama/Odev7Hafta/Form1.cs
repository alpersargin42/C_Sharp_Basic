using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev7Hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Clear();
                textBox2.Visible = false;
                label2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int a = 1, b = 1;
                int al;
                int d;
                al = int.Parse(textBox1.Text);
                listBox1.Items.Add(a);
                listBox1.Items.Add(b);
                for (int i = 2; i < al; i++)
                {
                    d = a + b;
                    b =a;
                    a = d;
                    listBox1.Items.Add(d);
                }
            }
            else if (radioButton3.Checked ==true)
            {
                int sayi1 = int.Parse(textBox1.Text);
                int sayi2 = int.Parse(textBox2.Text);
                int ebob = 0;

                for (int i = 1; i < sayi1; i++)
                {
                    if (sayi1 % i == 0 && sayi2 % i == 0)
                    {
                        ebob = i;
                    }
                }
                listBox1.Items.Add(ebob);
            }
            else if (radioButton4.Checked ==true)
            {
                listBox1.Items.Clear();
                int sayi1 = int.Parse(textBox1.Text);
                int sayi2 = int.Parse(textBox2.Text);
                int max = sayi1 * sayi2;
                int ekok = 0;
                /* 2 sayı eger aralarında asal ise ekoku
                çarpımlarıdır. Yanı 2 sayının ekoku maximum çarpımlarıdır.*/

                for (int i = max; i > 0; i--)
                {
                    if (i % sayi1 == 0 && i % sayi2 == 0)
                    {
                        ekok = i;
                    }
                }
                listBox1.Items.Add(ekok);
            }
            else if (radioButton2.Checked ==true )
            {
                listBox1.Items.Clear();
                int sayi1 = int.Parse(textBox1.Text);
                int sayi2 = int.Parse(textBox2.Text);
                int kontrol = 0;
                if (sayi1>sayi2)
                {
                    for (int a = sayi2; a <sayi1 ; a++)
                    {
                        kontrol = 0;
                        for (int i = 2; i < a; i++)
                        {
                            if (a % i == 0)
                            {
                                kontrol++;
                                break;
                            }
                        }
                        if (kontrol ==0)
                        {
                            listBox1.Items.Add(a);
                        }
                    }
                }
                else if (sayi2 > sayi1)
                {
                    for (int a = sayi1; a < sayi2; a++)
                    {
                        kontrol = 0;
                        for (int i = 2; i < a; i++)
                        {
                            if (a % i == 0)
                            {
                                kontrol++;
                                break;
                            }
                        }
                        if (kontrol == 0)
                        {
                            listBox1.Items.Add(a);
                        }
                    }
                }
            }
            else if (radioButton5.Checked ==true)
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked ==true)
            {
                listBox1.Items.Clear();
            }
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox2.Visible = false;
            label2.Visible = false;
        }
    }
}
