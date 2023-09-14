using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a, b,cikarma;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            cikarma = a - b;

            label5.Text = cikarma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, toplama;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            toplama = a + b;
            label5.Text = toplama.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b,carpma;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            carpma = a * b;
            label5.Text = carpma.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, bolme;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            bolme = a / b;
            label5.Text = bolme.ToString();
        }
    }
}
