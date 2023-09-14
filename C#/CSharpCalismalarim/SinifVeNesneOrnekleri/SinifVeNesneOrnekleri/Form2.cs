using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinifVeNesneOrnekleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil();
            oto.marka = "Mercedes";
            oto.model = "AMG";
            oto.modelyili = 2018;
            oto.renk = "Beyaz";
            oto.vitestipi = "Otomatik";

            string marka = oto.markagetir();

            label6.Text = oto.marka.ToString();
            label7.Text = oto.model.ToString();
            label8.Text = oto.modelyili.ToString();
            label9.Text = oto.renk.ToString();
            label10.Text = oto.vitestipi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
