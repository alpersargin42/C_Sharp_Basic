using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Final3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.ForeColor = Color.DarkRed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona Tıkladınız");
            label2.Text = "Tıklandı";
            label2.ForeColor = Color.Yellow;
            button1.BackColor=Color.Aqua;
            this.BackColor = Color.DarkOrange;
        }
    }
}
