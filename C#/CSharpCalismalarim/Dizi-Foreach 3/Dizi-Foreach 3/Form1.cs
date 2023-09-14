using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi_Foreach_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString()) ;
            }
            Array.Sort(sayilar);
            label2.Text = sayilar[sayilar.Length - 1].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayilar);
            label5.Text = sayilar[0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            foreach (int item in sayilar)
            {
                toplam += item;
            }
            label7.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            foreach (int item in sayilar)
            {
                toplam += item;
            }
            ortalama = toplam / listBox1.Items.Count;
            label9.Text = (ortalama).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
                if (sayilar[i]%2==0)
                {
                    
                    label11.Text += sayilar[i] + " ".ToString();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label13.Text = "";
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
                if (sayilar[i] % 2 != 0)
                {

                    label13.Text += sayilar[i] + " ".ToString();
                }
            }
        }
    }
}
