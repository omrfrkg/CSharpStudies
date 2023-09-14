using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirilenDegeriToplama_Tek_ve_Cift_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplamcift = 0;
        int toplamtek = 0;

        int Cift(int sayi)
        {
            
            if (sayi%2==0)
            {
                listBox2.Items.Add(sayi);
                toplamcift += sayi;
            }
            
            return toplamcift;
        }
        int Tek(int sayi)
        {
            
            if (sayi%2!=0)
            {
                listBox1.Items.Add(sayi);
                toplamtek += sayi;
            }
            
            return toplamtek;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            label7.Text = Tek(sayi).ToString();
            label8.Text = Cift(sayi).ToString();


            
        }
    }
}
