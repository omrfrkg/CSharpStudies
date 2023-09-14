using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Yardıma tıklandı");
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("formdasın");
        }

        private void topla_Click(object sender, EventArgs e)
        {
            sonuc.Text = (int.Parse(sayi1.Text) + int.Parse(sayi2.Text)).ToString();
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            sonuc.Text = (int.Parse(sayi1.Text) - int.Parse(sayi2.Text)).ToString();
        }

        private void carp_Click(object sender, EventArgs e)
        {
            sonuc.Text = (int.Parse(sayi1.Text) * int.Parse(sayi2.Text)).ToString();
        }

        private void bol_Click(object sender, EventArgs e)
        {
            sonuc.Text = (Convert.ToDouble(sayi1.Text) / Convert.ToDouble(sayi2.Text)).ToString();
        }
    }
}
