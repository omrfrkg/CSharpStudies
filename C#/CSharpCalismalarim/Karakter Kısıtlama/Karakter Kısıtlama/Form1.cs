using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karakter_Kısıtlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 15;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.MaxLength.ToString();

            if (textBox1.TextLength == 15)
            {
                MessageBox.Show("Karakter Hakkınız Dolmuştur");
                textBox1.Enabled = true;
            }
        }
    }
}
