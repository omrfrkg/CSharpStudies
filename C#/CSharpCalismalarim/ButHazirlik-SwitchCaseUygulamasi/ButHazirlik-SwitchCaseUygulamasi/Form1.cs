using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButHazirlik_SwitchCaseUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not = int.Parse(textBox1.Text);

            switch (not)
            {
                case 1:MessageBox.Show("Çok Kötü Not"); break;
                case 2: MessageBox.Show("Kötü Not"); break;
                case 3: MessageBox.Show("Orta Not"); break;
                case 4: MessageBox.Show("İyi Not"); break;
                case 5: MessageBox.Show("Çok İyi Not"); break;
                default: MessageBox.Show("Hatalı Giriş!"); break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:MessageBox.Show("06");break;
                case 1: MessageBox.Show("34"); break;
                case 2: MessageBox.Show("35"); break;
                case 3: MessageBox.Show("17"); break;
                case 4: MessageBox.Show("55"); break;
                case 5: MessageBox.Show("41"); break;
                case 6: MessageBox.Show("59"); break;
                default: MessageBox.Show("Hatalı Giriş!"); break;

            }
        }
    }
}
