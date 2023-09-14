using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDV_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplamtutar,tutar,kdv = 0;

            double fiyat = Convert.ToDouble(textBox1.Text);
            double aded = Convert.ToDouble(textBox2.Text);

            tutar = fiyat * aded;

            if (radioButton1.Checked == true)
            {
                kdv = tutar * 0.01;
            }
            if (radioButton2.Checked == true)
            {
                kdv = tutar * 0.08;
            }
            if (radioButton3.Checked == true)
            {
                kdv = tutar * 0.18;
            }

            toplamtutar = tutar + kdv;

            label7.Text = kdv.ToString();
            label6.Text = toplamtutar.ToString();

        }
    }
}
