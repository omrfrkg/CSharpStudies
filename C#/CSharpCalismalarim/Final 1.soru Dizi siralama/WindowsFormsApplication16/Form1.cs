using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] dizi = new int[10];
        int girilen;
        int x = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            girilen = Convert.ToInt32(textBox1.Text);
            dizi[x] = girilen;
            listBox1.Items.Add(girilen);
            x++;
            textBox1.Text = "";
            if (x==10)
            {
                button1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gecici;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i+1; j < 10; j++)
                {
                    if (dizi[j]<dizi[i])
                    {
                        gecici = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }
            listBox1.Items.Clear();
            foreach (int sayi in dizi)
            {
                listBox1.Items.Add(sayi);
            }
        }
    }
}
