using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int x;
        int y;
        int x2;
        int y2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = rnd.Next(50, 500);
            y = rnd.Next(50, 500);
            x2 = rnd.Next(50, 500);
            y2 = rnd.Next(50, 500);
            Graphics ciz = this.CreateGraphics();
            Pen kalem = new Pen(Color.Aquamarine,7);
            ciz.DrawLine(kalem,x,y,x2,y2);

        }
    }
}
