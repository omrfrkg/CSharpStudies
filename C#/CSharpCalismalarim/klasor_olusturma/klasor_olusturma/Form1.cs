using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace klasor_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(file.FileName);
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(file.FileName);
                }
                else
                {

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyası|*.txt";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                Kayit.WriteLine(textBox1.Text);
                Kayit.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog Renk = new ColorDialog();
            Renk.ShowDialog();
            // Renk.AllowFullOpen = false;Palet üzerinde bulunan özel renk tanımla butonunu 
            // pasif etmek için AllowFullOpen false yapılmalıdır.
            // Renk.FullOpen = true;Özel renk tanımla bölümünün ShowDialog() ile açılır halde 
            //gelmesi için FullOpen true yapılmalıdır.
            //  Renk.Reset();Reset metodu ile setlenmiş ayarlarını resetleyip varsayılan ayarlarına 
            //dördürmeyi sağlayabilirsiniz.
            button3.BackColor = Renk.Color;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Klasor = new FolderBrowserDialog();
            Klasor.ShowDialog();
            string KlasorYolu;
            KlasorYolu = Klasor.SelectedPath;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FontDialog Font = new FontDialog();
            Font.ShowDialog();
            textBox1.Font = Font.Font;
        }
    }
}
