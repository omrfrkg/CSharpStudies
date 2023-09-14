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
using System.Media;
using FlappyBird.Properties;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> Boru1 = new List<int>();
        List<int> Boru2 = new List<int>();
        int BoruGenislik = 55;
        int FarkliBoruY = 140;
        int FarkliBoruX = 180;
        bool basla = true;
        bool ucus;
        int adim = 5;
        int OrjinalX, OrjinalY;
        bool BoruSifirla = false;
        int skor;
        bool boruda = false;
        int FarkliSkor;
        private int step;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Carpma()
        {
            ucus = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            button1.Visible = true;
            button1.Enabled = true;
            SkorGoster();
            skor = 0;pictureBox1.Location = new Point(OrjinalX, OrjinalY);
            BoruSifirla = true;
            Boru1.Clear();
        }
        private void SkorGoster()
        {
            using (StreamReader oku = new StreamReader("skor.ini"))
            {
                skor = int.Parse(oku.ReadToEnd());
                oku.Close();
                if (int.Parse(label1.Text)== 0 | int.Parse(label1.Text) > 0)
                {
                    FarkliSkor = skor - int.Parse(label1.Text) + 1;
                }
                if (skor < int.Parse(label1.Text))
                {
                    MessageBox.Show(string.Format("Tebrikler Eski Skorunuzu Geçtiniz{0}.Yeni Skorunuz{1}", skor, label1.Text), "Flappy Bird", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (StreamWriter yazma = new StreamWriter("skor.ini"))
                    {
                        yazma.Write(label1.Text);
                        yazma.Close();
                    }
                }
                if (skor > int.Parse(label1.Text))
                {
                    MessageBox.Show(string.Format("Yeni Skorunuz{0}.Eski Skorunuz{1}", FarkliSkor, skor), "Flappy Bird", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (skor == int.Parse(label1.Text))
                {
                    MessageBox.Show(string.Format("Tam olarak {0} Puan Yaptın",skor),"Flapp Bird", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void OyunuBaslat()
        {
            BoruSifirla = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            Random rnd = new Random();
            int sayi = rnd.Next(40,this.Height-this.FarkliBoruY);
            int sayi2 = sayi + FarkliBoruY;
            Boru1.Clear();
            Boru1.Add(this.Width);
            Boru1.Add(sayi);
            Boru1.Add(this.Width);
            Boru1.Add(sayi2);

            sayi = rnd.Next(40, this.Height - this.FarkliBoruY);
            sayi2 = sayi + FarkliBoruY;
            Boru2.Clear();
            Boru1.Add(this.Width + FarkliBoruX);
            Boru1.Add(sayi);
            Boru1.Add(this.Width + FarkliBoruX);
            Boru1.Add(sayi2);

            button1.Visible = false;
            button1.Enabled = false;
            ucus = true;
            Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Boru1[0] + BoruGenislik <= 0 | basla == true)
            {
                Random random = new Random();
                int px = this.Width;
                int py = random.Next(40,(this.Height-FarkliBoruY));
                var p2x = px;
                var p2y = py + FarkliBoruY;
                Boru1.Clear();
                Boru1.Add(px);
                Boru1.Add(py);
                Boru1.Add(p2x);
                Boru1.Add(p2y);
            }
            else
            {
                Boru1[0] = Boru1[0] - 2;
                Boru1[2] = Boru1[2] - 2;
            }
            if (Boru2[0] + BoruGenislik <= 0 )
            {
                Random random = new Random();
                int px = this.Width;
                int py = random.Next(40, (this.Height - FarkliBoruY));
                var p2x = px;
                var p2y = py + FarkliBoruY;
                int[] p1 = {px,py,p2x,p2y};
                Boru2.Clear();
                Boru2.Add(px);
                Boru2.Add(py);
                Boru2.Add(p2x);
                Boru2.Add(p2y);
            }
            else
            {
                Boru2[0] = Boru1[0] - 2;
                Boru2[2] = Boru1[2] - 2;
            }
            if (basla == true)
            {
                basla = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!BoruSifirla && Boru1.Any() && Boru2.Any())
            {
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Boru1[0], 0, BoruGenislik, Boru1[1]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Boru1[0]-10,Boru1[3]-FarkliBoruY, 75, 15));

                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Boru1[2], Boru1[3], BoruGenislik,this.Width-Boru1[3]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Boru1[2] - 10, Boru1[3] - FarkliBoruY, 75, 15));

                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Boru2[0], 0, BoruGenislik, Boru2[1]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Boru2[0] - 10, Boru2[3] - FarkliBoruY, 75, 15));

                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Boru2[2], Boru2[3], BoruGenislik, this.Width - Boru2[3]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(Boru2[2] - 10, Boru2[3] ,75, 15));

            }
        }
        private void Kontro()
        {
            Rectangle rec = pictureBox1.Bounds;
            Rectangle rec1 = new Rectangle(Boru1[2] + 20,Boru1[3]-FarkliBoruY,15,FarkliBoruY);
            Rectangle rec2 = new Rectangle(Boru2[2] + 20, Boru2[3] - FarkliBoruY, 15, FarkliBoruY);
            Rectangle kesisim1 = Rectangle.Intersect(rec, rec1);
            Rectangle kesisim2 = Rectangle.Intersect(rec1, rec2);
            if (!BoruSifirla | basla)
            {
                if (kesisim1 != Rectangle.Empty | kesisim2 !=Rectangle.Empty)
                {
                    if (!boruda)
                    {
                        skor++;
                        SoundPlayer sp = new SoundPlayer(FlappyBird.Properties.Resources.puan);
                        sp.Play();
                        boruda = true;

                    }
                    else
                    {
                        boruda = false;
                    }
                }
            }
        }
        private void Carpisma()
        {
            Rectangle rec = pictureBox1.Bounds;
            Rectangle rec1 = new Rectangle(Boru1[0],0,BoruGenislik,Boru1[1]);
            Rectangle rec2 = new Rectangle(Boru1[2], Boru1[3], BoruGenislik,this.Height-Boru1[3]);
            Rectangle rec3 = new Rectangle(Boru2[0], 0, BoruGenislik, Boru2[1]);
            Rectangle rec4= new Rectangle(Boru2[2], Boru2[3], BoruGenislik, this.Height - Boru2[3]);
            Rectangle kesisim1 = Rectangle.Intersect(rec, rec1);
            Rectangle kesisim2 = Rectangle.Intersect(rec, rec2);
            Rectangle kesisim3 = Rectangle.Intersect(rec, rec3);
            Rectangle kesisim4 = Rectangle.Intersect(rec, rec4);
            if (!BoruSifirla | basla)
            {
                if (kesisim1 != Rectangle.Empty | kesisim2 != Rectangle.Empty | kesisim3 != Rectangle.Empty | kesisim4 != Rectangle.Empty)
                {
                    SoundPlayer sp = new SoundPlayer(FlappyBird.Properties.Resources.carpma);
                    sp.Play();
                    Carpma();
                    
                }

            }
        }

        private void axWindowsMediaPlayer1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    step = -5;
                    pictureBox1.Image = Resources.bird;
                    break;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + step);
            if (pictureBox1.Location.Y<0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, 0);
            }
            if (pictureBox1.Location.Y+pictureBox1.Height+5 >this.ClientSize.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, this.ClientSize.Height - pictureBox1.Height);
            }
            Carpisma();
            if (ucus)
            {
                Kontro();
            }
            label1.Text = Convert.ToString(skor);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    step = 5;
                    pictureBox1.Image = Resources.bird;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrjinalX = pictureBox1.Location.X;
            OrjinalY = pictureBox1.Location.Y;
            if (!File.Exists("skor.ini"))
            {
                File.Create("skor.ini").Dispose();
            }
        }
    }
}
