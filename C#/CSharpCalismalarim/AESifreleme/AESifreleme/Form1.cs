using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        aesSifreleVeCoz AES_Ogrendik = new aesSifreleVeCoz();
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = AES_Ogrendik.AESsifrele(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Şifrelenecek veri bulunamadı");
            }
            else
            {
                richTextBox2.Text = AES_Ogrendik.AESsifre_coz(richTextBox1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kaynakDosya = @"C:\Users\omrfrkg\Desktop\deneme.txt";
            var hedefDosya = @"C:\Users\omrfrkg\Desktop\deneme2.txt";

            using (var fsOkuyucu = new FileStream(kaynakDosya, FileMode.Open))
            using (var fsYazici = new FileStream(hedefDosya, FileMode.CreateNew))
            {
                fsYazici.SetLength(fsOkuyucu.Length);
                byte[] tampon = new byte[2048];
                int okunanByte = 0;
                while ((okunanByte = fsOkuyucu.Read(tampon, 0, tampon.Length)) > 0)
                {
                    fsYazici.Write(tampon, 0, okunanByte);
                }
            }
            

        }
    }
}
