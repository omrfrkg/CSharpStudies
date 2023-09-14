using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_RakamlarCarpimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sayi =textBox1.Text;
            int a = Convert.ToInt32(sayi[0].ToString());
            int b = Convert.ToInt32(sayi[1].ToString());
            int c = Convert.ToInt32(sayi[2].ToString());
            int islem = (a * b * c) % (a + b + c);
            label2.Text = islem.ToString();

        }
    }
}
