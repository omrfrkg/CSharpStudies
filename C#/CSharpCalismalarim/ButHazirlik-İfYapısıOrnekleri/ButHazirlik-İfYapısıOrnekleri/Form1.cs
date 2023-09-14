using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_İfYapısıOrnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi;
            if (comboBox1.Text == "1")
            {
                sayi = rnd.Next(1,9);
                label1.Text = sayi.ToString();
            }
            else if (comboBox1.Text == "2")
            {
                sayi = rnd.Next(10,99);
                label1.Text = sayi.ToString();
            }
            else if (comboBox1.Text == "3")
            {
                sayi = rnd.Next(100, 999);
                label1.Text = sayi.ToString();
            }
            else
            {
                sayi = rnd.Next(1000, 9999);
                label1.Text = sayi.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "İstanbul")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Silivri");
                listBox1.Items.Add("Kadıköy");
                listBox1.Items.Add("Maltepe");
            }
            else if (comboBox2.Text == "Samsun")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Atakent");
                listBox1.Items.Add("Canik");
                listBox1.Items.Add("Kavak");
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Akkuş");
                listBox1.Items.Add("Altınordu");
                listBox1.Items.Add("Aybastı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bolunen = int.Parse(textBox1.Text);
            int bolen = int.Parse(textBox2.Text);
            int islem;
            if (textBox1.Text == null || textBox2.Text == "0")
            {
                MessageBox.Show("Hatalı Giriş Yaptınız"); 
            }
            islem =bolunen/bolen;
            label6.Text = islem.ToString();


        }
        int sayi;
        int sayi2;
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(0,100);
            sayi2 = rnd.Next(0,100);
            label10.Text = sayi.ToString();
            label7.Text = sayi2.ToString();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int islem;
            islem = sayi + sayi2;
            int tahmin = int.Parse(textBox3.Text);
       
            if (tahmin == islem)
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış,Doğru Cevap:"+islem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam;
            int saat = int.Parse(textBox5.Text);
            if (comboBox3.Text == "Taksi")
            {
                toplam = saat * 5;
                label11.Text = toplam.ToString();
            }
            else if (comboBox3.Text == "Minibüs")
            {
                toplam = saat * 10;
                label11.Text = toplam.ToString();
            }
            else
            {
                toplam = saat * 15;
                label11.Text = toplam.ToString();
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox4.Text);
            if (0<sayi && sayi<10)
            {
                label12.Text = "000"+sayi.ToString();
                    
            }
            else if (10 < sayi && sayi < 100)
            {
                label12.Text = "00" + sayi;
            }
            else if (100 < sayi && sayi < 1000)
            {
                label12.Text = "0" + sayi;
            }
            else
            {
                label12.Text =sayi.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == String.Empty)
            {
                int yol = int.Parse(textBox6.Text);
                int zaman = int.Parse(textBox8.Text);
                textBox7.Text = (yol / zaman).ToString();
            }
            else if (textBox6.Text == String.Empty)
            {
                int hiz = int.Parse(textBox7.Text);
                int zaman = int.Parse(textBox8.Text);
                textBox6.Text = (hiz * zaman).ToString();
                
            }
            else if (textBox8.Text == String.Empty)
            {
                int hiz = int.Parse(textBox7.Text);
                int yol = int.Parse(textBox6.Text);
                textBox6.Text = (yol/hiz).ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox3.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ad = Convert.ToString(textBox10.Text);
            string soyad = Convert.ToString(textBox9.Text);
            if (radioButton1.Checked)
            {
                label15.Text = "Hoşgeldiniz,Bay " + ad + " " + soyad;
                
            }
            else if (radioButton2.Checked)
            {
                label15.Text = "Hoşgeldiniz,Bayan  " + ad + " " + soyad;
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(textBox12.Text);
            if (not<20)
            {
                label22.Text ="0";
                label22.BackColor = Color.DarkRed;
            }
            else if (not<50)
            {
                label22.Text = "1";
                label22.BackColor = Color.Red;
            }
            else if (not<60)
            {
                label22.Text = "2";
                label22.BackColor = Color.Yellow;
            }
            else if (not<70)
            {
                label22.Text = "3";
                label22.BackColor = Color.LightYellow;
            }
            else if (not < 85)
            {
                label22.Text = "4";
                label22.BackColor = Color.Green;
            }
            else
            {
                label22.Text = "5";
                label22.BackColor = Color.DarkGreen;
            }
        }
    }
}
