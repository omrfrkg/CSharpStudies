using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int[] dizi = new int[50];
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1,50);
                listBox1.Items.Add(dizi[i]);
                if (dizi[i] == sayi)
                {
                    sayac++;
                }
            }
            label3.Text = "Listede " + sayi + " sayısından " + sayac + " kadar vardır.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
