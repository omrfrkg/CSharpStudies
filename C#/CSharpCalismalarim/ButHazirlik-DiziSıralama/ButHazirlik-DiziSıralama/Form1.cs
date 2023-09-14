using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_DiziSıralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] dizi = new int[10];
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1,50);
                label1.Text += dizi[i].ToString()+"\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int t = i+1; t < dizi.Length; t++)
                {
                    if (dizi[i]>dizi[t])
                    {
                        int gecici;
                        gecici = dizi[i];
                        dizi[i] = dizi[t];
                        dizi[t] = gecici;
                    }
                }
            }
            label1.Text = "";
            foreach(int sayi in dizi)
            {
                label1.Text += sayi.ToString() + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gsayi = int.Parse(textBox1.Text);
            int sayac = 0;
            foreach(int sayi in dizi)
            {
                if (sayi==gsayi)
                {
                    sayac++;
                }
            }
            if (sayac!=0)
            {
                MessageBox.Show(gsayi + " sayısından vardır.");
            }
            else
            {
                MessageBox.Show(gsayi + " sayısından yoktur.");
            }
        }
    }
}
