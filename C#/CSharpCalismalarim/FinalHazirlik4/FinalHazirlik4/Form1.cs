using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHazirlik4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool b = true;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 20;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Doldu");
            }
            
            if (b == true)
            {
                pictureBox1.Image = ımageList1.Images[0];
                pictureBox2.Image = ımageList1.Images[1];
                b = false;
            }
            else
            {
                pictureBox1.Image = ımageList1.Images[1];
                pictureBox2.Image = ımageList1.Images[0];
                b = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
