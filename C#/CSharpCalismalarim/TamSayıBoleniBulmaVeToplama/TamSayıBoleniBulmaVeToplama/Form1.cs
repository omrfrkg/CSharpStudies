using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamSayıBoleniBulmaVeToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            int bolunensayisi=0;
            int toplam = 0;
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i < 100; i++)
            {
                if (i%sayi==0)
                {
                    bolunensayisi++;
                    toplam += i;
                    listBox1.Items.Add(i);
                }
            }
            label6.Text = bolunensayisi.ToString();
            label7.Text = toplam.ToString();
            textBox1.Text = "";
        }
    }
}
