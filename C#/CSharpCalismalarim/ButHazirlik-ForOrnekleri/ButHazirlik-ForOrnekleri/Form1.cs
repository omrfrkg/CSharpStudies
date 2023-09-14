using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_ForOrnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1900; i < 2020; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {

                    label1.Text += i.ToString() + "\n";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 1; i < 10; i++)
            {
                toplam += i;
            }
            label2.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam = 0;
            for (int i = sayi1; i < sayi2; i++)
            {
                toplam += i;
            }
            MessageBox.Show("Aralığı verdiğiniz sayıların toplamı :" + toplam);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int faktoryel = 1;
            int sayi = Convert.ToInt32(textBox4.Text);



            for (int i = 1; i <= sayi; i++)
            {
                faktoryel *= i;
            }
            MessageBox.Show(sayi + " sayısının faktöryeli " + faktoryel);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            int a = int.Parse(textBox3.Text);

            for (int i = 1; i <= 100; i = i + a)
            {
                label7.Text += i.ToString() + " ";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label10.Text = " ";
            int sayi = Convert.ToInt32(textBox6.Text);
            int sayi2 = Convert.ToInt32(textBox5.Text);
            for (int i = sayi; i <= sayi2; i++)
            {
                label10.Text += i.ToString() + " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label14.Text = " ";
            label15.Text = " ";
            label16.Text = " ";
            int sayi = Convert.ToInt32(textBox8.Text);
            for (int i = 1; i < 20; i++)
            {
                if (i % 5 == 0)
                {
                    label14.Text += i.ToString() + " ";
                }
                else if (5 % i == 0)
                {
                    label15.Text += i.ToString() + " ";
                }
                else if (i % sayi == 0)
                {
                    label16.Text += i.ToString() + " ";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox7.Text);
            int sayac = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }

            if (sayac == 0)
            {
                MessageBox.Show(sayi + " sayısı asal sayıdır.");
            }
            else
            {
                MessageBox.Show(sayi + " sayısı asal değildir");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
         
            for (int i = 0; i < 50; i++)
            {
                listBox2.Items.Add(rnd.Next(1, 50));
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (int sayi in listBox2.Items)
            {
                toplam += sayi;
            }
            label18.Text = toplam.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                comboBox1.Items.Add(i);
            }
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label20.Text = "";
            int islem;
            int sayi = Convert.ToInt32(comboBox1.Text);
            for (int i = 1; i < 10; i++)
            {
                islem = i * sayi;
                label20.Text += sayi + " x " + i + " = " + islem + "\n"; 
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label21.Text = "";
            int sayi1 = Convert.ToInt32(textBox9.Text);
            int sayi2 = Convert.ToInt32(textBox10.Text);
            int sayi3 = Convert.ToInt32(comboBox2.Text);
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % sayi3 == 0)
                {
                    label21.Text += "BOM"+"\n";
                }
                else
                {
                    label21.Text += i + "\n";
                }
                
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label28.Text = "";
            int sayi1 = int.Parse(textBox12.Text);
            int sayi2 = int.Parse(textBox11.Text);

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (radioButton1.Checked==true)
                {
                    if (i%3==0)
                    {
                        label28.Text += i +"\n";
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    if (i % 5 == 0)
                    {
                        label28.Text += i + "\n";
                    }
                }
                else if (radioButton3.Checked == true)
                {
                    if (i % 8 == 0)
                    {
                        label28.Text += i + "\n";
                    }
                }
            }
        }
    }
}
