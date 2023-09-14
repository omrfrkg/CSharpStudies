using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Sayı_Aarasındaki_Asal_Sayıyı_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int bsayi = Convert.ToInt32(textBox1.Text);
            int ssayi = Convert.ToInt32(textBox2.Text);

            bool durum = true;

            while(bsayi<=ssayi)
            {
                bsayi++;
                for (int i = 2; i < bsayi; i++)
                {
                    if (bsayi%i == 0)
                    {
                        durum = false;
                    }
                }
                if (durum == true && bsayi!=1)
                {
                    listBox1.Items.Add(bsayi);
                }
                durum = true;
            }

        }
    }
}
