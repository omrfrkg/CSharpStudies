using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seyahat_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = "yolcu",admin="yönetici";
            int sifre =123 ,sifre2= 18400016;
            kadi = Convert.ToString(textBox1.Text);
            sifre = Convert.ToInt32(textBox2.Text);

            if (kadi != "yolcu" && sifre == 123)
            {
                MessageBox.Show("Kullanıcı Adı Yanlış!!!");
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (kadi == "yolcu" && sifre != 123)
            {
                MessageBox.Show("Sifre Yanlış!!!");
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (kadi == "yolcu" && sifre == 123)
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
                
            }

            else if (admin =="yönetici" && sifre == 18400016)
            {
                Form4 yeni3 = new Form4();
                yeni3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Sifre Yanlış!!!");
                textBox1.Clear();
                textBox2.Clear();
            }
                
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;

            if (checkBox1.Checked == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            
        }
    }
}
