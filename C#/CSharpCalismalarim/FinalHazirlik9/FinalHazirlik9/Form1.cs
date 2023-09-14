using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHazirlik9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 15; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int bolensayi = 2;
            int sayac = 0;
            while(true)
            {
                if (sayi % bolensayi == 0)
                {
                    sayac++;
                    break;
                }
                bolensayi++;
            }
            if (sayac==0)
            {
                MessageBox.Show(sayi + " sayısı asal sayıdır");
            }
            else
            {
                MessageBox.Show(sayi + " sayısı asal sayı değildir");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                listBox3.Items.Add(i);
                i++;
            } while (i <= 15);
        }
    }
}
