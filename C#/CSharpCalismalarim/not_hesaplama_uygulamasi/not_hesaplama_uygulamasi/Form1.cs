using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_hesaplama_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, ortalama;
            sayi1 = Convert.ToInt32(textBox3.Text);
            sayi2 = Convert.ToInt32(textBox4.Text);
            ortalama = (sayi1 + sayi2) / 2;

            if (ortalama<50)
            {
                listBox4.Items.Add("Kaldın");
            }
            else if (ortalama>=50)
            {
                listBox4.Items.Add("Geçtin");
            }
            

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox5.Items.Add(textBox4.Text);
            listBox6.Items.Add(ortalama);
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }
    }
}
