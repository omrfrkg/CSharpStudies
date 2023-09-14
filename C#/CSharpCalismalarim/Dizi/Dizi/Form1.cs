using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[50];
            Random rnd = new Random();

            for (int i = 1; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1,51);
                listBox1.Items.Add(dizi[i]);
            }
            label2.Text = listBox1.Items.Count.ToString();
        }
    }
}
