using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace zar_atma_uygulamasi
{
    public partial class Form1 : Form
    {
        Random rastgele = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer();
            string path = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\zar.wav";
            ses.SoundLocation = path;


            int zar = rastgele.Next(1,7);
            int zar2 = rastgele.Next(1,7);
            

            if (zar == 1 && zar2 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                ses.Play();
            }
            else if (zar == 1 && zar2 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                ses.Play();
            }
            else if (zar == 1 && zar2 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                ses.Play();

            }
            else if (zar == 1 && zar2 == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                ses.Play();

            }
            else if (zar == 1 && zar2 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                ses.Play();

            }
            else if (zar == 1 && zar2 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                ses.Play();

            }
            else if (zar == 2 && zar2 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                ses.Play();

            }
            else if (zar == 2 && zar2 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                ses.Play();
            }
            else if (zar == 2 && zar2 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                ses.Play();
            }
            else if (zar == 2 && zar2 == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                ses.Play();
            }
            else if (zar == 2 && zar2 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                ses.Play();
            }
            else if (zar == 2 && zar2 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                ses.Play();
            }
            else if (zar == 3 && zar2 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                ses.Play();
            }
            else if (zar == 3 && zar2 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                ses.Play();
            }
            else if (zar == 3 && zar2 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                ses.Play();
            }
            else if (zar == 3 && zar2 == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                ses.Play();
            }
            else if (zar == 3 && zar2 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                ses.Play();
            }
            else if (zar == 3 && zar2 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                ses.Play();
            }
            else if (zar == 4 && zar2 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                ses.Play();
            }
            else if (zar == 4 && zar2 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                ses.Play();
            }
            else if (zar == 4 && zar2 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                ses.Play();
            }
            else if (zar == 4 && zar2 == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                ses.Play();
            }
            else if (zar == 4 && zar2 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                ses.Play();
            }
            else if (zar == 4 && zar2 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                ses.Play();
            }
            else if (zar == 5 && zar2 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                ses.Play();
            }
            else if (zar == 5 && zar2 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                ses.Play();
            }
            else if (zar == 5 && zar2 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                ses.Play();
            }
            else if (zar == 5 && zar2 == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                ses.Play();
            }
            else if (zar == 5 && zar2 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                ses.Play();
            }
            else if (zar == 5 && zar2 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                ses.Play();
            }
            else if (zar == 6 && zar2 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\1.jpg";
                ses.Play();
            }
            else if (zar == 6 && zar2 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\2.jpg";
                ses.Play();
            }
            else if (zar == 6 && zar2 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\3.jpg";
                ses.Play();
            }
            else if (zar == 6 && zar2 == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\4.jpg";
                ses.Play();
            }
            else if (zar == 6 && zar2 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\5.jpg";
                ses.Play();
            }
            else if (zar == 6 && zar2 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                pictureBox2.ImageLocation = "C:\\Users\\omerr\\OneDrive\\Masaüstü\\C#\\6.jpg";
                ses.Play();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
