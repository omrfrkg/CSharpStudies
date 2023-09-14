using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            for (int saniye = 1; saniye < 61; saniye++)
            {
                comboBox2.Items.Add(saniye.ToString());
            }
            comboBox1.Items.Add("00");
            for (int saat = 1; saat < 25; saat++)
            {
                comboBox1.Items.Add(saat.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string a, b;
           
            a = DateTime.Now.Minute.ToString();
            b = DateTime.Now.Hour.ToString();
           
            if (comboBox2.Text == a.ToString() && comboBox1.Text==b.ToString())
            {
                
                axWindowsMediaPlayer1.URL = "D:\\C#\\alaram.mp3";
                timer1.Stop();
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
