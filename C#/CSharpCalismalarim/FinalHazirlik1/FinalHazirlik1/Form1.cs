using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHazirlik1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            int ideger = Convert.ToInt32(textBox1.Text);
            int sdeger = Convert.ToInt32(textBox2.Text);
            for (int i = ideger; i <= sdeger; i++)
            {
                if (radioButton1.Checked == true)
                {
                    if (i % 3 == 0)
                    {
                        label4.Text += i.ToString()+"\n";
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    if (i%5 == 0)
                    {
                        label4.Text += i.ToString()+"\n";
                    }
                }
                else
                {
                    if (i%8==0)
                    {
                        label4.Text +=i.ToString()+"\n";
                    }
                }
            }
        }
    }
}
