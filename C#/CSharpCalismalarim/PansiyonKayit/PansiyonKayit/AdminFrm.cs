using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonKayit
{
    public partial class AdminFrm : Form
    {
        public AdminFrm()
        {
            InitializeComponent();
        }

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.Substring(1) + textBox3.Text.Substring(0, 1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Admin" && textBox2.Text=="18400016")
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adını Yada Şifreyi Yanlış Girdiniz Tekrar Deneyin.");
            }
        }
    }
}
