﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebTarayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.facebook.com");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.twitter.com");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();

        }

        private void millitetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void fanatikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr/");
        }

        private void fotomaçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fotomac.com.tr/");
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser1.DocumentTitle.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser1.DocumentText.ToString());
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();

            toolStripStatusLabel2.Text = webBrowser1.StatusText;
            string zaman = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
            string zaman2 = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;

            FileStream f = new FileStream("Gecmis.txt", FileMode.Append);
            StreamWriter yaz = new StreamWriter(f);
            yaz.WriteLine(zaman + "/" + zaman2 + "/" + webBrowser1.Url);
            yaz.Close();
            gecmisyukle();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
            }
            catch (Exception)
            {

                toolStripProgressBar1.Minimum = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            gecmisyukle();
        }
        private void gecmisyukle()
        {
            listBox1.Items.Clear();
            StreamReader dosya = new StreamReader("Gecmis.txt");
            while (!dosya.EndOfStream)
            {
                listBox1.Items.Add(dosya.ReadLine());
            }
            dosya.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            StreamWriter dosya = new StreamWriter("Gecmis.txt");
            dosya.Write("");
            dosya.Close();
            gecmisyukle();

        }
    }
}
