using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = {1,2,3,4,5,6,7,8,9,10,0,-14,-3,-2,-5};
            foreach (int item in dizi)
            {
                if (item%2==0)
                {
                    listBox2.Items.Add(item);
                }
                else 
                {
                    listBox1.Items.Add(item);
                }

            }
        }
    }
}
