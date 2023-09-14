using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yks_puan_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkce, sosyal, mat, fen, ygs1, ygs2;
            turkce = Convert.ToInt32(textBox1.Text);
            sosyal = Convert.ToInt32(textBox2.Text);
            mat = Convert.ToInt32(textBox3.Text);
            fen = Convert.ToInt32(textBox4.Text);

            ygs1 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (mat * 3.998) + (fen * 2.999);
            label6.Text = ygs1.ToString();
            ygs2 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (mat * 2.999) + (fen * 3.998);
            label7.Text = ygs2.ToString();
        }
    }
}
