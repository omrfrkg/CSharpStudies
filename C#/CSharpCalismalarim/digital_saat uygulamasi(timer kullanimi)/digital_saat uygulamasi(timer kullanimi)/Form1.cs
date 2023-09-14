using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digital_saat_uygulamasi_timer_kullanimi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.Hour.ToString();
            label5.Text = DateTime.Now.Minute.ToString();
            label6.Text = DateTime.Now.Second.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int saniye = 0, dakika = 0,salise =0;
            salise =Convert.ToInt32(label11.Text);
            salise ++;
            saniye = Convert.ToInt32(label7.Text);
            dakika =Convert.ToInt32(label8.Text);
            label11.Text = salise.ToString();
            if (salise == 59)
            {
                label11.Text = "0";
                saniye++;
                label7.Text = saniye.ToString();
            }
            if (saniye == 59)
            {
                label7.Text = "0";
                dakika++;
                label8.Text = dakika.ToString();
            }
            
        }
    }
}
