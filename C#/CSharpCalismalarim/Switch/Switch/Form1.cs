using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            switch (sayi)
            {
                case 1:MessageBox.Show("Ocak","Mevsimler"); break;
                case 2:MessageBox.Show("Şubat");break;
                case 3:MessageBox.Show("Mart");break;
                case 4: MessageBox.Show("Nisan");break;
                case 5: MessageBox.Show("Mayıs"); break;
                case 6: MessageBox.Show("Haziran"); break;
                case 7: MessageBox.Show("Temmuz"); break;
                case 8: MessageBox.Show("Ağustos"); break;
                case 9: MessageBox.Show("Eylül"); break;
                case 10: MessageBox.Show("Ekim"); break;
                case 11: MessageBox.Show("Kasım"); break;
                case 12: MessageBox.Show("Aralık"); break;
                default: break;
            }
        }
    }
}
