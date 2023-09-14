using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletSatış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seans1 = 0;
        int seans1ucret = 0;
        int seans2 = 0;
        int seans2ucret = 0;
        int seans3 = 0;
        int seans3ucret = 0;
        int misirmiktar = 0;
        int misirfiyat = 0;
        int sumiktar = 0;
        int sufiyat = 0;
        int kolamiktar = 0;
        int kolafiyat = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            seans1++;
            textBox1.Text = seans1.ToString();
            if (radioButton1.Checked)
            {
                
                seans1ucret += 10;
                textBox2.Text = seans1ucret.ToString();
            }
            if (radioButton2.Checked)
            {
              
                seans1ucret += 15;
                textBox2.Text = seans1ucret.ToString();
            }

            if (seans1 == 10)
            {
                button1.Enabled = false;
                MessageBox.Show("Salon Maksimum Kişi Sayısına Ulaşmıştır.");
            }
            if (seans1 >= 0)
            {
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            textBox1.Text = seans1.ToString();
            if (radioButton1.Checked)
            {
               
                seans1ucret -= 10;
                textBox2.Text = seans1ucret.ToString();
            }
            if (radioButton2.Checked)
            {
               
                seans1ucret -= 15;
                textBox2.Text = seans1ucret.ToString();
            }

            if (seans1 == 0)
            {
                button2.Enabled = false;
            }
            if (seans1 <= 10)
            {
                button1.Enabled = true;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2++;
            textBox4.Text = seans2.ToString();
            if (radioButton4.Checked)
            {
                seans2ucret += 10;
                textBox3.Text = seans2ucret.ToString();
            }
            if (radioButton3.Checked)
            {
                seans2ucret += 15;
                textBox3.Text = seans2ucret.ToString();
            }
            if (seans2 == 10)
            {
                MessageBox.Show("Salon Maksimum Kişi Sayısına Ulaşmıştır.");
                button4.Enabled = false;
            }
            if (seans2 >= 0)
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2--;
            textBox4.Text = seans2.ToString();
            if (radioButton4.Checked)
            {
                seans2ucret -= 10;
                textBox3.Text = seans2ucret.ToString();
            }
            if (radioButton3.Checked)
            {
                seans2ucret -= 15;
                textBox3.Text = seans2ucret.ToString();
            }
            if (seans2 == 0)
            {
                button3.Enabled = false;
            }
            if (seans2 <= 10)
            {
                button4.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seans3++;
            textBox6.Text = seans3.ToString();
            if (radioButton6.Checked)
            {

                seans3ucret += 10;
                textBox5.Text = seans3ucret.ToString();
            }
            if (radioButton5.Checked)
            {

                seans3ucret += 15;
                textBox5.Text = seans3ucret.ToString();
            }

            if (seans3 == 10)
            {
                
                MessageBox.Show("Salon Maksimum Kişi Sayısına Ulaşmıştır.");
                button6.Enabled = false;
            }
            if (seans3 >= 0)
            {
                button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3--;
            textBox6.Text = seans3.ToString();
            if (radioButton6.Checked)
            {

                seans3ucret -= 10;
                textBox5.Text = seans3ucret.ToString();
            }
            if (radioButton5.Checked)
            {

                seans3ucret -= 15;
                textBox5.Text = seans3ucret.ToString();
            }

            if (seans3 == 0)
            {

                button5.Enabled = false;
            }
            if (seans3 <= 10)
            {
                button6.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            misirmiktar++;
            textBox7.Text = misirmiktar.ToString();
            misirfiyat += 5;
            textBox8.Text = misirfiyat.ToString();
            if (misirmiktar >= 0)
            {
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            misirmiktar--;
            textBox7.Text = misirmiktar.ToString();
            misirfiyat -= 5;
            textBox8.Text = misirfiyat.ToString();
            if (misirmiktar == 0)
            {
                button8.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kolamiktar++;
            textBox10.Text = kolamiktar.ToString();
            kolafiyat += 3;
            textBox9.Text = kolafiyat.ToString();
            if (kolamiktar >= 0)
            {
                button9.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kolamiktar--;
            textBox10.Text = kolamiktar.ToString();
            kolafiyat -= 3;
            textBox9.Text = kolafiyat.ToString();
            if (kolamiktar <= 0)
            {
                button9.Enabled = false;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            sumiktar++;
            textBox12.Text = sumiktar.ToString();
            sufiyat += 2;
            textBox11.Text = sufiyat.ToString();
            if (sumiktar>0)
            {
                button11.Enabled = true;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            sumiktar--;
            textBox12.Text = sumiktar.ToString();
            sufiyat -= 2;
            textBox11.Text = sufiyat.ToString();
            if (sumiktar <= 0)
            {
                button11.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int toplamizleyici = 0;
            int toplamucret = 0;
            toplamizleyici = seans1 + seans2 + seans3;
            toplamucret = seans1ucret + seans2ucret + seans3ucret;
            label12.Text = toplamizleyici.ToString();
            label13.Text = toplamucret.ToString()+"TL";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int toplamurun = 0;
            int toplamfiyat = 0;
            toplamurun = sumiktar + kolamiktar + misirmiktar;
            toplamfiyat = sufiyat + kolafiyat + misirfiyat;
            label17.Text = toplamurun.ToString();
            label15.Text = toplamfiyat.ToString()+"TL";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "D:\\C#\\CSharpCalismalarim\\SinemaBiletSatış\\1.mp3";
        }
    }
}
