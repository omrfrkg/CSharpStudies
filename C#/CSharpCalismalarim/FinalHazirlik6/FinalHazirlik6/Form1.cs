using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHazirlik6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(1,800);
            int y = rnd.Next(1,800);
            int h = rnd.Next(1,800);
            int w = rnd.Next(1,800);

            Graphics cizim = this.CreateGraphics();
            Pen kalem = new Pen(Color.Red,7);
            cizim.DrawLine(kalem,x,y,h,w);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 800);
            int y = rnd.Next(1, 800);
            int h = rnd.Next(1, 800);
            int w = rnd.Next(1, 800);

            Graphics cizim = this.CreateGraphics();
            Pen kalem = new Pen(Color.Red, 7);
            cizim.DrawLine(kalem, x, y, h, w);
        }
    }
}
