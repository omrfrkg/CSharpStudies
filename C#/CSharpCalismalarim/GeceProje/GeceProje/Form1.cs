using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllgece;

namespace GeceProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Yeni ogrenci = new Yeni();
        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci.ad = textBox1.Text;
            ogrenci.soyad = textBox2.Text;
            ogrenci.okulno = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ogrenci.ad+" "+ogrenci.soyad+" "+ogrenci.okulno);
        }
    }
}
