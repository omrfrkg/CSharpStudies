using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanici_girisi_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sifre;
            string kullanici_adi;
            kullanici_adi = Convert.ToString(textBox1.Text);
            sifre = Convert.ToInt32(textBox2.Text);
            if (kullanici_adi=="omrfrkg" && sifre!=123456)
            {
                MessageBox.Show("Şifrenizi Yanlış Girdiniz");
            }
            else if (kullanici_adi != "omrfrkg" && sifre == 123456)
            {
                MessageBox.Show("Kullanıcı Adınızı Yanlış Girdiniz");
            }
            else if (kullanici_adi != "omrfrkg" && sifre != 123456)
            {
                MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Yanlış Girdiniz");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı");
                Form2 gecis = new Form2();
                gecis.Show();
                this.Hide();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
