using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hak=1;
        Random rnd = new Random();
        int sayi;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi = rnd.Next(1,100);
            label1.Text = hak.ToString() ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(textBox1.Text);
            if (hak>0)
            {
                if (sayi < tahmin)
                {
                    MessageBox.Show("Azalt");
                    hak--;
                    label1.Text = hak.ToString();
                }
                else if (sayi > tahmin)
                {
                    MessageBox.Show("Arttır");
                    hak--;
                    label1.Text = hak.ToString();
                }
                else
                {
                    MessageBox.Show("Tebrikler Kazandınız.");
                }
            }
            else
            {
                MessageBox.Show("Tahmin Hakkınız Bitti Kaybettiniz.Tahmin Etmeye Çalıştığınız Sayı "+sayi);
                button2.Enabled = false;
                label1.Text = hak.ToString();
            }
           
        }
    }
}
