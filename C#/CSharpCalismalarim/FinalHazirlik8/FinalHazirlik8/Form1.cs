using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHazirlik8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Toplama()
        {

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = sayi1 + sayi2;
            label7.Text = sonuc.ToString();
        }
        void Cikarma(int sayi1,int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            label8.Text = sonuc.ToString();
        }
        int Bolme(int sayi1,int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            return sonuc;
        }
        string Carpma(int sayi1,int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            return sonuc.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            Toplama();
            Cikarma(sayi1,sayi2);
            label9.Text = Bolme(sayi1, sayi2).ToString();
            label10.Text = Carpma(sayi1,sayi2);





        }
    }
}
