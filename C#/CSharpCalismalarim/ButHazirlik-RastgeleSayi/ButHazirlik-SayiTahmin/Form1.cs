using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_SayiTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayi, sayi2;
        int toplam;
       
        private void button2_Click(object sender, EventArgs e)
        {

            sayi = rnd.Next(1, 100);
            sayi2 = rnd.Next(1, 100);
            label3.Text =sayi.ToString();
            label4.Text =sayi2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam = sayi + sayi2;
            if (textBox1.Text != toplam.ToString())
            {
                MessageBox.Show("Hatalı Toplama Yaptınız,Sayıların Toplamı :"+toplam.ToString());
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Cevap Doğru");
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
