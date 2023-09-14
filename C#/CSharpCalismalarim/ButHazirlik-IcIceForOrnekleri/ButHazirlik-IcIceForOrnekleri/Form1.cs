using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_IcIceForOrnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            for (int i = 1; i < 11; i++)
            {
               
                for (int j = 0; j < i; j++)
                {
                    label2.Text += "*";
                }
                label2.Text += "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            for (int i = 2; i < 12; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    label3.Text +=j;
                }
                label3.Text += "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 10; j++)
                {
                    label1.Text += "*";
                }
                label1.Text += "\n";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            label4.Text = "";
            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    label4.Text += i;
                }
                label4.Text += "\n";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                label5.Text += i + " ";
                for (int j = 1; j <= i; j++)
                {
                    label5.Text +=i;
                }
                label5.Text += "\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                label6.Text += i + " ";
                for (int j = 1; j <= i; j++)
                {
                    label6.Text += j;
                }
                label6.Text += "\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            label7.Text ="*\n";
            for (int i = 1; i <= 9; i++)
            {
                label7.Text += "*";
                for (int j = 1; j <= i; j++)
                {
                    label7.Text +=" ";
                }
                label7.Text += "*\n";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
