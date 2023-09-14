using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcgenUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);

            if (sayi1 + sayi2 + sayi3 == 180)
            {
                if (sayi1 == 60 && sayi2 == 60 && sayi3 == 60)
                {
                    MessageBox.Show("Bu bir eşkenar üçgendir.");
                }
                else if (sayi1 == sayi2 || sayi1==sayi3 || sayi2 == sayi3)
                {
                    MessageBox.Show("Bu bir ikizkenar üçgendir.");
                }
                else
                {
                    MessageBox.Show("Bu bir çeşitkenar üçgendir.");
                }
            }
            else if (sayi1 <= 0 || sayi2 <= 0 || sayi3 <= 0)
            {
                MessageBox.Show("Bu bir üçgen değildir.", "Hata");
            }
            else
            {
                MessageBox.Show("Kenarlar 180den büyük olamaz.", "Hata");
            }
        }
    }
}
