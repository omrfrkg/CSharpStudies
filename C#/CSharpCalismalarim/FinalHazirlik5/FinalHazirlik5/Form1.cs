using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHazirlik5
{
    public partial class Form1 : Form
    {
        int sure = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sure--;
            label2.Text = sure.ToString();

            if (sure == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz Doldu Cevap Vermediniz.");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Yanlış");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Doğru");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Yanlış");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Yanlış");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Yanlış");
           
        }
    }
}
