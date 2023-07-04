using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Final5_update
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Moral FM -- axWindowsMediaPlayer1.URL = "http://yayin2.canliyayin.org:8886/;stream.mp3";
            axWindowsMediaPlayer1.URL ="https://playerservices.streamtheworld.com/api/livestream-redirect/METRO_FM.mp3";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.enableContextMenu = false;
        }
    }
}
