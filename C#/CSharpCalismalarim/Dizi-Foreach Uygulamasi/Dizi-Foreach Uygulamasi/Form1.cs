using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi_Foreach_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[7];

            dizi[0] = "Pazartesi";
            dizi[1] = "Salı";
            dizi[2] = "Çarşamba";
            dizi[3] = "Perşembe";
            dizi[4] = "Cuma";
            dizi[5] = "Cumartesi";
            dizi[6] = "Pazar";

            label1.Text = dizi[1].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] dizi = {5, 8, 4, 6, 3};
            int elemansayisi = dizi.Length;
            int toplam=0;
            for (int i = 0; i < dizi.Length; i++)
            {
                listBox1.Items.Add(dizi[i]);
                toplam += dizi[i];
            }
            label3.Text = toplam.ToString();
            label6.Text = elemansayisi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] dizi = { 5, 8, 4, 6, 3 };
            int toplam = 0;
            foreach(int item in dizi)
            {
                toplam += item;
            }
            label9.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] dizi = new int[5];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1,50);
                listBox4.Items.Add(dizi[i]);
                if (dizi[i]%2 == 0)
                {
                    listBox3.Items.Add(dizi[i]);
                }
                else
                {
                    listBox2.Items.Add(dizi[i]);
                }
            }



        }

        string[] dizi = new string[5];
        int sayac = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            
            
            dizi[sayac] = textBox1.Text;
            sayac++;
            if (sayac == 5)
            {
                sayac = 0;
            }
            label13.Text = ((sayac + 1) + ".İsmi Giriniz:").ToString();
            
            textBox1.Clear();
            textBox1.Focus();
            


        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < dizi.Length; i++)
            {
                listBox5.Items.Add(dizi[i]);
            }
        }
    }
}
