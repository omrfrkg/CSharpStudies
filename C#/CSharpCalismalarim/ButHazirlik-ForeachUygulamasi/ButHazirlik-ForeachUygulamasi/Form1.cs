using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_ForeachUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Random rnd = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0,50);
            }

            foreach (int i in sayilar)
            {
                label1.Text += i.ToString()+"\n";
            }
        }
    }
}
