using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreOlusturmaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            Random ata = new Random();
            int dizim;
            string sifre=" ";
            if (cmdsecim.Text == "Güçlü")
            {
                MessageBox.Show("Doğru giriş");
               for(int i = 0; i < a; i++)
                    {
                    dizim = ata.Next(255);
                    sifre += Convert.ToChar(dizim);
                }
                MessageBox.Show(sifre);
            }
            else if (cmdsecim.Text == "Orta")
            {
                for (int i = 0; i < a; i++)
                {
                    dizim = ata.Next(55);
                    sifre += Convert.ToChar(dizim);
                }
                listBox1.Items.Add(sifre);
            }
            else if (cmdsecim.Text == "Zayıf")
            {
                for (int i = 0; i < a; i++)
                {
                    dizim = ata.Next(10);
                    sifre += Convert.ToChar(dizim);
                }
                listBox1.Items.Add(sifre);
            }
        }
    }
}
