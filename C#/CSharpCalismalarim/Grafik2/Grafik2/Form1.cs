using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int sayi1;
        int sayi2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = rnd.Next();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics ciz = this.CreateGraphics();
            Pen mavi = new Pen(Color.Blue,4);
            Pen kalem = new Pen(Color.Black,3);
            ciz.DrawRectangle(mavi,50,50,300,300);
            ciz.DrawEllipse(kalem,50,50,300,300);
            ciz.DrawEllipse(mavi, 100, 100, 200, 200);
            ciz.DrawEllipse(kalem, 150, 150, 100, 100);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = rnd.Next(30,370);
            sayi2 = rnd.Next(30, 370);
            Graphics atis = this.CreateGraphics();
            Pen nokta = new Pen(Color.Green,7);
            atis.DrawRectangle(nokta,sayi1,sayi2,3,3);
            if (sayi1 > 350 || sayi1 <50 || sayi2 <50 || sayi2 > 350 )
            {
                MessageBox.Show("ISKA");
            }
            else if (sayi1 > 100 || sayi1 <50 || sayi2 >100 || sayi2<150)
            {
                listBox1.Items.Add(10);
            }
            else if (sayi1 > 100 || sayi1 < 150|| sayi2 > 100 || sayi2 < 150)
            {
                listBox1.Items.Add(20);
            }
        }
    }
}
