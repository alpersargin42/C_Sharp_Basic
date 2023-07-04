using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Final10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label6.Text = "00:00:00:00";
            for (int i = 1; i < 24; i++)
            {
                comboBox1.Items.Add(i).ToString("00");
            }
            for (int i = 1; i < 60; i++)
            {
                comboBox2.Items.Add(i);
            }
            for (int i = 1; i < 60; i++)
            {
                comboBox3.Items.Add(i);
            }
        }
        int[] b = { 0, 0, 0, 0 };
        int[] d = { 0, 0, 0 };
        public void set_time()
        {
            string[] t = new string[3];
            t[0] = DateTime.Now.Hour.ToString("00");
            t[1] = DateTime.Now.Minute.ToString("00");
            t[2] = DateTime.Now.Second.ToString("00");
            if (tabControl1.SelectedTab == tabPage1)
                label1.Text = string.Join(":", t);
            else if (tabControl1.SelectedTab == tabPage3)
                label10.Text = string.Join(":", t);
            string gun = DateTime.Now.DayOfWeek.ToString();
            string guns = "Pazar";
            switch (gun)
            {
                case "Monday":
                    guns = "Pazartesi";
                    break;
                case "Tuesday":
                    guns = "Salı";
                    break;
                case "Wednesday":
                    guns = "Çarşamba";
                    break;
                case "Thrusday":
                    guns = "Perşembe";
                    break;
                case "Friday":
                    guns = "Cuma";
                    break;
                case "Saturday":
                    guns = "Cumartesi";
                    break;
                case "Sunday":
                    guns = "Pazar";
                    break;

            }
            if (tabControl1.SelectedTab == tabPage1)
                label2.Text = guns;
            else if (tabControl1.SelectedTab == tabPage2)
                label9.Text = guns;

            t[0] = DateTime.Now.Day.ToString();
            t[1] = DateTime.Now.Month.ToString();
            t[2] = DateTime.Now.Year.ToString();
            if (tabControl1.SelectedTab == tabPage1)
                label3.Text = string.Join("/", t);
            else if (tabControl1.SelectedTab == tabPage3)
                label8.Text = string.Join("/", t);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            set_time();
            timer1.Interval = 100;
            if (tabControl1.SelectedTab == tabPage1)
            {

                if (button1.Enabled == false)
                {
                    if (numericUpDown1.Value == DateTime.Now.Hour && numericUpDown2.Value == DateTime.Now.Minute)
                    {
                        if (Convert.ToInt32(DateTime.Now.Second.ToString()) % 2 == 0)

                            label5.Visible = true;

                        else
                            label5.Visible = false;
                    }
                    else
                        label5.Visible = false;
                }
                else
                    label5.Visible = false;
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                if (button3.Enabled == false)

                {
                    b[3]++;
                    if (b[3] == 10)
                    {
                        b[3] = 0;
                        b[2]++;

                        if (b[2] == 60)
                        {
                            b[2] = 0;
                            b[1]++;
                            if (b[1] == 60)
                            {
                                b[1] = 0;
                                b[0]++;
                            }
                        }
                    }

                    string[] c = { b[0].ToString("00"), b[1].ToString("00"), b[2].ToString("00"), b[3].ToString("00") };
                    label6.Text = String.Join(":", c);
                }
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                timer1.Interval = 1000;
                if (button6.Enabled == false)
                {

                    label13.Visible = true;


                    d[2]--;
                    if (d[2] == -1)
                    {
                        d[2] = 59;
                        d[1]--;
                        if (d[1] == -1)
                        {
                            d[1] = 59;
                            d[0]--;
                            if (d[0] == -1)
                            {
                                d[0] = 0;
                                d[1] = 0;
                                d[2] = 0;
                            }
                        }
                    }
                    string[] c = { d[0].ToString("00"), d[1].ToString("00"), d[2].ToString("00") };
                    label13.Text = String.Join(":", c);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label6.Text = "00:00:00:00";
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label6.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
            int[] g = new int[3];
            g[0] = Convert.ToInt32(comboBox1.SelectedItem);
            g[1] = Convert.ToInt32(comboBox2.SelectedItem);
            g[2] = Convert.ToInt32(comboBox3.SelectedItem);
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button7.Enabled = false;
        }
    }
}

