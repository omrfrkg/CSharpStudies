using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int soru = 0;
        int dogru = 0;
        int yanlis = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            dogru = Convert.ToInt32(label10.Text);
            yanlis = Convert.ToInt32(label8.Text);
            
            label4.Text = "20";
            timer1.Enabled = true;
            soru++;
            label2.Text = soru.ToString();
            if (soru == 6)
            {
                button1.Enabled = false;
            }
            if (soru == 1)
            {
                richTextBox1.Text = "Mehmet Akif İstiklal Marşını nerede yazmıştır?";
                button2.Text = "Ayasofya";
                button3.Text = "Ayaş Dergahı";
                button4.Text = "Keçiören Camisi";
                button5.Text = "Taceddin Dergahı";
                label12.Text = "Taceddin Dergahı";

            }
            if (soru == 2)
            {
                richTextBox1.Text = "Atatürk'ün yurt gezilerinde (1935-1938) yılları arasında kullandığı trenin adı nedir?";
                button2.Text = "Beyaz Tren";
                button3.Text = "Karaduman";
                button4.Text = "Demir Türk";
                button5.Text = "Anadolu";
                label12.Text = "Beyaz Tren";
                
            }
            if (soru == 3)
            {
                richTextBox1.Text = "Türkiye'nin ilk Safari Parkı hangi ilimizde açılmıştır?";
                button2.Text = "Mersin";
                button3.Text = "İzmir";
                button4.Text = "Gaziantep";
                button5.Text = "Konya";
                label12.Text = "Gaziantep";
                
            }
            if (soru == 4)
            {
                richTextBox1.Text = "Mehmet Akif Ersoy İstiklal Marşı telif ödülünü hangi kuruma bağışlamıştır?";
                button2.Text = "Darülfunun";
                button3.Text = "Darülbedai";
                button4.Text = "Darüleytam";
                button5.Text = "Darülmesai";
                label12.Text = "Darülmesai";
                
            }
            if (soru == 5)
            {
                richTextBox1.Text = "Birleşmiş Milletler Dünya Turizm Örgütü'nün kısa adı hangisidir?";
                button2.Text = "UNOWT";
                button3.Text = "UWT";
                button4.Text = "WTO";
                button5.Text = "UNWTO";
                label12.Text = "UNWTO";
                MessageBox.Show("Tebrikler Son Soruya Kadar Geldiniz Doğru Cevap Veririseniz Yarışmayı Kazanırsınız");
                
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int sure = Convert.ToInt32(label4.Text);
            sure--;
            label4.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Stop();
                MessageBox.Show("Verilen Süre İçerisinde Soruyu Cevaplamadınız", "Bilgilendirme Penceresi", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = button2.Text;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            if (button2.Text == label12.Text)
            {
                DialogResult secenek =MessageBox.Show("Doğru Cevap","Bilgilendirme Penceresi",MessageBoxButtons.OK);
                dogru++;
                label10.Text = dogru.ToString();
                timer1.Stop();
            }
            else
            {
                MessageBox.Show("Yanlış Cevap");
                yanlis++;
                label8.Text = yanlis.ToString();
                timer1.Stop();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            label11.Text = button3.Text;
            if (button3.Text == label12.Text)
            {
                MessageBox.Show("Doğru Cevap");
                dogru++;
                label10.Text = dogru.ToString();
                timer1.Stop();
            }
            else
            {
                MessageBox.Show("Yanlış Cevap");
                yanlis++;
                label8.Text = yanlis.ToString();
                timer1.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            label11.Text = button4.Text;
            if (button4.Text == label12.Text)
            {
                MessageBox.Show("Doğru Cevap");
                dogru++;
                label10.Text = dogru.ToString();
                timer1.Stop();
            }
            else
            {
                MessageBox.Show("Yanlış Cevap");
                yanlis++;
                label8.Text = yanlis.ToString();
                timer1.Stop();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false;
            label11.Text = button5.Text;
            if (button5.Text == label12.Text)
            {
                MessageBox.Show("Doğru Cevap");
                dogru++;
                label10.Text = dogru.ToString();
                timer1.Stop();
            }
            else
            {
                MessageBox.Show("Yanlış Cevap");
                yanlis++;
                label8.Text = yanlis.ToString();
                timer1.Stop();
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
