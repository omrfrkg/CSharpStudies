using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsansorUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kat;
        private void button1_Click(object sender, EventArgs e)
        {
            kat = 2;
            timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kat = 0;
            timer1.Start();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = ımageList1.Images[0];
           
            if (kat == 2)
            {
                pictureBox2.Top -= 5;
                if (pictureBox2.Top <= 109)
                {
                    timer1.Stop();
                    pictureBox2.Image = ımageList1.Images[1];
                    pictureBox1.Image = ımageList1.Images[2];
                }
                
            }
            if (kat == 0)
            {
                
                pictureBox2.Top += 5;
                if (pictureBox2.Top >= 458)
                {
                    timer1.Stop();
                    if (pictureBox2.Top == 458)
                    {
                        pictureBox2.Image = ımageList1.Images[1];
                        pictureBox1.Image = ımageList1.Images[3];
                    }
                }
            }
        }
    }
}
