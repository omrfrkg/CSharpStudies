using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_WhileOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deneme = 0;
            int tahmin = 0;
            int sayi = int.Parse(textBox1.Text);
            label5.Text = "";
            Random rnd = new Random();
            tahmin = rnd.Next(1,100);
            label5.Text += tahmin.ToString()+"\n";
            while (sayi != tahmin)
            {
                tahmin = rnd.Next(1, 100);
                deneme++;
                label2.Text = deneme.ToString();
                label5.Text += tahmin.ToString() + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            Random rnd = new Random();
            int sayi = 0 ;
        
         
            
            while(sayi<=15)
            {
                sayi = rnd.Next(1, 20);
                label6.Text += sayi.ToString()+"\n";

            }
        }

        int toplam = 0;
        private void button3_Click(object sender, EventArgs e)
        { 
            
            int sayi = int.Parse(textBox2.Text);
            toplam += sayi;
            while (sayi == 0)
            {
                label10.Text = toplam.ToString();
            }
            
            
        }
    }
}
