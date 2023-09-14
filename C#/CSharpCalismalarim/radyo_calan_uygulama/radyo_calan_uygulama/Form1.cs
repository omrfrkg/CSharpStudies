using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radyo_calan_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text =="KRAL FM")
            {
                axWindowsMediaPlayer1.URL = "http://kralwmp.radyotvonline.com:80/";
            }
            if (comboBox1.Text == "POWER FM")
            {
                axWindowsMediaPlayer1.URL = "http://powerfm.listenpowerapp.com/powerfm/mpeg/icecast.audio";
            }
            if (comboBox1.Text == "ALEM FM")
            {
                axWindowsMediaPlayer1.URL = "http://scturkmedya.radyotvonline.com/stream/80/";
            }
            if (comboBox1.Text == "BEST FM")
            {
                axWindowsMediaPlayer1.URL = "http://46.20.7.126/;stream.mp3";
            }
            if (comboBox1.Text== "KAFA RADYO")
            {
                axWindowsMediaPlayer1.URL = "http://46.20.3.246/stream/507/";
            }
            if (comboBox1.Text == "NUMBER ONE TÜRK")
            {
                axWindowsMediaPlayer1.URL = "https://n10101m.mediatriple.net/videoonlylive/mtkgeuihrlfwlive/u_stream_5c9e30cf8d28e_1/playlist.m3u8 ";
            }
            if (comboBox1.Text == "POWER TÜRK")
            {
                axWindowsMediaPlayer1.URL = "	http://icast.powergroup.com.tr/PowerTurk/mpeg/128/home";
            }
            if (comboBox1.Text == "RADYO VİVA")
            {
                axWindowsMediaPlayer1.URL = "http://46.20.3.194:80/show/viva64/viva64/playlist.m3u8 ";
            }
            if (comboBox1.Text == "SÜPER FM")
            {
                axWindowsMediaPlayer1.URL = "https://17733.live.streamtheworld.com/SUPER_FM.mp3 ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
