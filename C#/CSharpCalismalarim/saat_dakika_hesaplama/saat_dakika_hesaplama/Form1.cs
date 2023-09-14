using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saat_dakika_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int sayi, saat, dakika;
            sayi = Convert.ToInt32(textBox1.Text);
            saat = sayi / 60;
            label3.Text = saat.ToString();
            dakika = sayi % 60;
            label5.Text = dakika.ToString();
        }
    }
}
