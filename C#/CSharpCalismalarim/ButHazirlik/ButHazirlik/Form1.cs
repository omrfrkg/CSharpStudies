using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int[] dizi = new int[10];
        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi = Convert.ToInt32(textBox1.Text);
            


            for (int i = 0; i < sayi; i++)
            {
                dizi[i] = rnd.Next(1,50);
                listBox1.Items.Add(dizi[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }
            label3.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }
            label4.Text = (toplam / listBox1.Items.Count).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Text = " ";
            foreach (int sayi in listBox1.Items)
            {
                if (sayi %2 == 0)
                {
                    label9.Text += sayi+" ".ToString();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label11.Text = " ";
            foreach (int sayi in listBox1.Items)
            {
                if (sayi %2 != 0)
                {
                    label11.Text += sayi+" ".ToString();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                dizi[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(dizi);
            label6.Text = dizi[0].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                dizi[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(dizi);
            label13.Text = dizi[dizi.Length-1].ToString();
        }
    }
}
