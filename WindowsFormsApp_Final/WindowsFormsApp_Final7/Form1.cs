using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Final7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla Kaydedildi.","Kayıt Başarılı");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Konya")
            {
                comboBox2.Items.Clear();
                string[] a = new string[] { "Meram", "Selçuklu" };
                for (int i = 0; i < a.Length; i++)
                {
                    comboBox2.Items.AddRange(new[] { a[i] });
                }

                if (comboBox2.Text == "Meram")
                {
                    string[] b = new string[] { "Yaka mah.", "Dere mah." };
                    for (int i = 0; i < b.Length; i++)
                    {
                        comboBox3.Items.AddRange(new[] { b[i] });
                    }
                }
                else if (comboBox2.Text == "Selçuklu")
                {
                    string[] b = new string[] { "Feritpaşa mah.", "Sille mah." };
                    for (int i = 0; i < b.Length; i++)
                    {
                        comboBox3.Items.AddRange(new[] { b[i] });
                    }
                }
            }
            else if (comboBox1.Text == "Karaman")
            {
                comboBox2.Items.Clear();
                string[] a = new string[] { "Merkez", "Ayrancı" };
                for (int i = 0; i < a.Length; i++)
                {
                    comboBox2.Items.AddRange(new[] { a[i] });
                }
                if (comboBox2.Text == "Merkez")
                {
                    string[] b = new string[] { "X mah.", "Y mah." };
                    for (int i = 0; i < b.Length; i++)
                    {
                        comboBox3.Items.AddRange(new[] { b[i] });
                    }
                }
                else if (comboBox2.Text == "Ayrancı")
                {
                    string[] b = new string[] { "Z mah.", "W mah." };
                    for (int i = 0; i < b.Length; i++)
                    {
                        comboBox3.Items.AddRange(new[] { b[i] });
                    }
                }
            }
            else if (comboBox1.Text == "Ankara")
            {
                comboBox2.Items.Clear();
                string[] a = new string[] { "Çankaya", "Pursaklar" };
                for (int i = 0; i < a.Length; i++)
                {
                    comboBox2.Items.AddRange(new[] { a[i] });
                }
                if (comboBox2.Text == "Çankaya")
                {
                    string[] b = new string[] { "K mah.", "L mah." };
                    for (int i = 0; i < b.Length; i++)
                    {
                        comboBox3.Items.AddRange(new[] { b[i] });
                    }
                }
                else if (comboBox2.Text == "Pursaklar")
                {
                    string[] b = new string[] { "M mah.", "O mah." };
                    for (int i = 0; i < b.Length; i++)
                    {
                        comboBox3.Items.AddRange(new[] { b[i] });
                    }
                }
            }
        }
    }
}
