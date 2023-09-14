using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktoriyel_bulan_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            int sayi = 0;
            sayi = Convert.ToInt32(textBox1.Text);
           
            for (int i = 1; i <= sayi; i++)
            {
                
                faktoriyel =faktoriyel* i;
                
            }
            label3.Text = faktoriyel.ToString();
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
