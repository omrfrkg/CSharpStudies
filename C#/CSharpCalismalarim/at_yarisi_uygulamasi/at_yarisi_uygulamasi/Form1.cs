using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarisi_uygulamasi
{
    public partial class Form1 : Form
    {
        int birinciatinsolauzakligi, ikinciatinsolauzakligi, ucuncuatinsolauzakligi;
        Random yeni = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int salise = Convert.ToInt32(label8.Text) ;
            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;
            int bitiscizgisi = label4.Left;
            salise++;
            label8.Text = salise.ToString();
            pictureBox1.Left = pictureBox1.Left + yeni.Next(5,10);
            pictureBox2.Left = pictureBox2.Left + yeni.Next(5,10);
            pictureBox3.Left = pictureBox3.Left + yeni.Next(5,10);
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label5.Text = "Beş Numaralı At Atağa Geçti";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label5.Text = "Bir Numaralı At Ani Bir Atakla Öne Geçti";
            }
            if (pictureBox3.Left  > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left+5)
            {
                label5.Text = "İki Numaralı At Yarışı Önde Götürüyor";
            }
            if (birinciatgenislik + pictureBox1.Left >= bitiscizgisi)
            { 
                timer1.Enabled = false;
                MessageBox.Show("YARIŞI BEŞ NUMARALI AT KAZANDI..");
            }
            if (ikinciatgenislik + pictureBox2.Left >= bitiscizgisi)
            {
                timer1.Enabled = false;
                MessageBox.Show("YARIŞI BİR NUMARALI AT KAZANDI..");
            }
            if (ucuncuatgenislik + pictureBox3.Left >= bitiscizgisi)
            {
                timer1.Enabled = false;
                MessageBox.Show("YARIŞI İKİ NUMARALI AT KAZANDI..");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            birinciatinsolauzakligi = pictureBox1.Left;
            ikinciatinsolauzakligi = pictureBox2.Left;
            ucuncuatinsolauzakligi = pictureBox3.Left;

        }
    }
}
