using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = Convert.ToString(textBox1.Text);
            char harf = Convert.ToChar(textBox2.Text);
            int sayac=0;
            
            cumle = cumle.ToLower();
            for (int i = 0; i < cumle.Length; i++)
            {
                
                if (cumle[i] == harf)
                {
                    sayac++;
                }
            }

            label4.Text = "Cümlede aranılan harften " + sayac + " tane vardır.";


        }
    }
}
