using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHazirlik7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi = Convert.ToInt32(textBox1.Text);
            int faktoriyel = 1;

            for(int i=1; i<=sayi; i++)
            {
                faktoriyel = faktoriyel * i;
                listBox1.Items.Add(i);
                
            }
            label5.Text = faktoriyel.ToString();
            if (sayi ==0 )
            {
                listBox1.Items.Add(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int sayi = Convert.ToInt32(textBox2.Text);

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
            }

            if (sayac != 0)
            {
                label6.Text = sayi + " sayisi asal sayi değidir.";
            }
            else
            {
                label6.Text = sayi + " sayisi asal sayıdır.";
            }
           
        }
    }
}
