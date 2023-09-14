using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alan_ve_cevre_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button4.Visible = false;
            button3.Visible = true;
            label1.Text = "Bir Kenarı Giriniz :";
            label6.Visible = false;
            textBox2.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = " ";
            label5.Text = " ";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button3.Visible = false;
            button4.Visible = true;
            label1.Text = "Uzun Kenarı Giriniz :";
            label6.Visible = true;
            textBox2.Visible = true;
            textBox1.Clear();
            label3.Text = " ";
            label5.Text = " ";

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kenar,alan, cevre;
            kenar = Convert.ToInt32(textBox1.Text);

            cevre = kenar * kenar;
            alan = 4 * kenar;

            label3.Text = cevre.ToString();
            label5.Text = alan.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kısa, uzun, alan, cevre;
            kısa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);

            cevre = 2*(kısa + uzun);
            alan = kısa * uzun;

            label3.Text = cevre.ToString();
            label5.Text = alan.ToString();
        }
    }
}
