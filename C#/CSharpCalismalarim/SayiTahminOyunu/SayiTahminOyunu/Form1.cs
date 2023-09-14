using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        
        int hak = 5;
        int sayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(textBox1.Text);
           
            label4.Text = hak.ToString();
           
            
            
            label5.Text = sayi.ToString();
            if (hak == 0)
            {
                MessageBox.Show("Tahmin hakkınız kalmadı kaybettiniz.", "Kaybettiniz");
            }
            else 
            {
                if (tahmin > sayi)
                {
                    MessageBox.Show("İnin");
                    hak--;
                    label4.Text = hak.ToString();
                }
                else if (tahmin < sayi)
                {
                    MessageBox.Show("Çıkın");
                    hak--;
                    label4.Text = hak.ToString();
                }
                else
                {
                    MessageBox.Show("Tebrikler Kazandınız!!!");
                }
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           sayi = rnd.Next(2, 100);
        }
    }
}
