using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Toplam(){
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = sayi1 + sayi2;
            label7.Text = sonuc.ToString();
        }
        private int Fark(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            return sonuc;
        }
        private void Carp()
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = sayi1 * sayi2;
            label9.Text = sonuc.ToString();
        }
        private string Bolum(int sayi1,int sayi2) {

            double sonuc = sayi1 / sayi2;
            return sonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toplam();
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            label8.Text = Fark(sayi1, sayi2).ToString();
            Carp();
            label10.Text = Bolum(sayi1, sayi2);



        }
    }
}
