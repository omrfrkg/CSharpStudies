using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4buyuklerin_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi="oyuncu";
            int sifre = 123456;
            kullanici_adi = Convert.ToString(textBox1.Text);
            sifre = Convert.ToInt32(textBox2.Text);

            if (kullanici_adi == "oyuncu" && sifre ==123456)
            {
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

