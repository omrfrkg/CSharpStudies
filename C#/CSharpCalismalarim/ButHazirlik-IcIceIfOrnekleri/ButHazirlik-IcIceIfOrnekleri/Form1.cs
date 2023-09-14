using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_IcIceIfOrnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty)
            {
                MessageBox.Show("Not Boş Girilemez.");
            }
            else
            {
                
                int not = int.Parse(textBox1.Text);
                int not2 = int.Parse(textBox2.Text);
                int not3 = int.Parse(textBox3.Text);
                int ortalama = (not + not2 + not3) / 3;
                if (not < 0 || not2 < 0 || not3 < 0 || not > 100 || not2 > 100 || not3 > 100)
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız.");
                }
                else
                {
                    if (ortalama<50)
                    {
                        MessageBox.Show("Kaldı");
                    }
                    else
                    {
                        MessageBox.Show("Geçti");
                    }
                }

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fiyat;
            int yas = Convert.ToInt32(textBox4.Text);
            if (comboBox1.Text=="Normal")
            {
                fiyat = 5;
                label7.Text = fiyat+" TL";
            }
            else if (comboBox1.Text == "Öğrenci -50")
            {
                if (yas>30)
                {
                    fiyat = 5;
                    label7.Text = fiyat + " TL";
                }
                else
                {
                    fiyat = 2.5;
                    label7.Text = fiyat + " TL";
                }
                
            }
            else if (comboBox1.Text == "Öğretmen -30")
            {
                if (yas<20 && yas>65)
                {
                    fiyat = 5;
                    label7.Text = fiyat + " TL";
                }
                else
                {
                    fiyat = 3.5;
                    label7.Text = fiyat + " TL";
                }
            }
            else if (comboBox1.Text == "Asker -50")
            {
                if (yas < 20 && yas > 40)
                {
                    fiyat = 5;
                    label7.Text = fiyat + " TL";
                }
                else
                {
                    fiyat = 2.5;
                    label7.Text = fiyat + " TL";
                }
            }
            else if (comboBox1.Text == "Engelli -75")
            {
                fiyat = 1.25;
                label7.Text = fiyat + " TL";
            }
            else if (comboBox1.Text == "Yaşlı -25")
            {
                if (yas < 60)
                {
                    fiyat = 5;
                    label7.Text = fiyat + " TL";
                }
                else
                {
                    fiyat = 3.75;
                    label7.Text = fiyat + " TL";
                }
            }
            else if (comboBox1.Text == "Gazi -100")
            {
                if (yas < 20)
                {
                    fiyat = 5;
                    label7.Text = fiyat + " TL";
                }
                else
                {
                    fiyat = 0;
                    label7.Text = fiyat + " TL";
                }
            }
        }
    }
}
