using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackOyunu
{
    public partial class Form1 : Form
    {
        int deste = 52;

        Random rnd = new Random();
        void Basla()
        {
            int sayi = rnd.Next(1, 53);
            int sayi2 = rnd.Next(1, 53);
            int sayi3 = rnd.Next(1, 53);
            pictureBox4.Image = ımageList1.Images[sayi];
            pictureBox7.Image = ımageList1.Images[sayi2];
            pictureBox9.Image = ımageList1.Images[sayi3];
            label29.Text = sayi.ToString();
            label34.Text = (sayi2 + sayi3).ToString();
           
        }
        void Deste(){
            

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basla();
        }
    }
}
