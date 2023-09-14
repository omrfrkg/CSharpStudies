using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tsl_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tspuan = 0;
        int gspuan = 0;
        int bjkpuan = 0;
        int fbpuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Random rast = new Random();
            int skor = rast.Next(0, 6);
            int skor2 = rast.Next(0, 6);
            int skor3 = rast.Next(0, 6);
            int skor4= rast.Next(0, 6);
           

            label5.Text = skor.ToString();
            label6.Text = skor2.ToString();
            label7.Text = skor3.ToString();
            label8.Text = skor4.ToString();


            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label6.Text))
            {
                tspuan = tspuan + 3;
                label36.Text = tspuan.ToString();
                
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                label35.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) == Convert.ToInt32(label5.Text))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                label36.Text = tspuan.ToString();
                label35.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label8.Text))
            {
                bjkpuan = bjkpuan + 3;
                label34.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label7.Text))
            {
                fbpuan = fbpuan + 3;
                label33.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label8.Text))
            {
                bjkpuan = bjkpuan + 1;
                fbpuan = fbpuan + 1;
                label34.Text = tspuan.ToString();
                label33.Text = gspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Random rast = new Random();
            int skor = rast.Next(0, 6);
            int skor2 = rast.Next(0, 6);
            int skor3 = rast.Next(0, 6);
            int skor4 = rast.Next(0, 6);
            label12.Text = skor.ToString();
            label11.Text = skor2.ToString();
            label10.Text = skor3.ToString();
            label9.Text = skor4.ToString();

            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label10.Text))
            {
                fbpuan = fbpuan + 3;
                label33.Text = fbpuan.ToString();
                

            }
            if (Convert.ToInt32(label10.Text) > Convert.ToInt32(label12.Text))
            {
                tspuan = tspuan + 3;
                label36.Text = tspuan.ToString();
               
            }
            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label10.Text))
            {
                tspuan = tspuan + 1;
                fbpuan = fbpuan + 1;
                label36.Text = tspuan.ToString();
                label33.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label9.Text))
            {
                gspuan = gspuan + 3;
                label35.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label9.Text) > Convert.ToInt32(label11.Text))
            {
                bjkpuan = bjkpuan + 3;
                label33.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label9.Text))
            {
                bjkpuan = bjkpuan + 1;
                gspuan = gspuan + 1;
                label34.Text = tspuan.ToString();
                label35.Text = gspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            Random rast = new Random();
            int skor = rast.Next(0, 6);
            int skor2 = rast.Next(0, 6);
            int skor3 = rast.Next(0, 6);
            int skor4 = rast.Next(0, 6);
            label20.Text = skor.ToString();
            label19.Text = skor2.ToString();
            label18.Text = skor3.ToString();
            label17.Text = skor4.ToString();

            if (Convert.ToInt32(label20.Text) > Convert.ToInt32(label18.Text))
            {
                tspuan = tspuan + 3;
                label36.Text = tspuan.ToString();
               

            }
            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label20.Text))
            {
                bjkpuan = bjkpuan + 3;
                label34.Text = bjkpuan.ToString();

            }
            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label10.Text))
            {
                tspuan = tspuan + 1;
                bjkpuan = bjkpuan + 1;
                label36.Text = tspuan.ToString();
                label34.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label19.Text) > Convert.ToInt32(label17.Text))
            {
                fbpuan = fbpuan + 3;
                label33.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label17.Text) > Convert.ToInt32(label19.Text))
            {
                gspuan = gspuan + 3;
                label35.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label19.Text) == Convert.ToInt32(label17.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                label35.Text = gspuan.ToString();
                label33.Text = fbpuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            Random rast = new Random();
            int skor = rast.Next(0, 6);
            int skor2 = rast.Next(0, 6);
            int skor3 = rast.Next(0, 6);
            int skor4 = rast.Next(0, 6);
            label28.Text = skor.ToString();
            label27.Text = skor2.ToString();
            label26.Text = skor3.ToString();
            label25.Text = skor4.ToString();

            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label28.Text))
            {
                tspuan = tspuan + 3;
                label36.Text = tspuan.ToString();

            }
            if (Convert.ToInt32(label28.Text) > Convert.ToInt32(label26.Text))
            {
                gspuan = gspuan + 3;
                label35.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label28.Text) == Convert.ToInt32(label26.Text))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                label36.Text = tspuan.ToString();
                label35.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label27.Text))
            {
                bjkpuan = bjkpuan + 3;
                label34.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label27.Text) > Convert.ToInt32(label25.Text))
            {
                fbpuan = fbpuan + 3;
                label33.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label27.Text) == Convert.ToInt32(label25.Text))
            {
                bjkpuan = bjkpuan + 1;
                fbpuan = fbpuan + 1;
                label34.Text = tspuan.ToString();
                label33.Text = gspuan.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label36.Text)> Convert.ToInt32(label35.Text) && Convert.ToInt32(label36.Text) > Convert.ToInt32(label34.Text)&& Convert.ToInt32(label36.Text) > Convert.ToInt32(label33.Text))
            {
                MessageBox.Show("Şampiyon TRABZONSPOR");
            }
            if (Convert.ToInt32(label35.Text) > Convert.ToInt32(label36.Text) && Convert.ToInt32(label35.Text) > Convert.ToInt32(label34.Text) && Convert.ToInt32(label35.Text) > Convert.ToInt32(label33.Text))
            {
                MessageBox.Show("Şampiyon GALATASARAY");
            }
            if (Convert.ToInt32(label34.Text) > Convert.ToInt32(label36.Text) && Convert.ToInt32(label34.Text) > Convert.ToInt32(label35.Text) && Convert.ToInt32(label34.Text) > Convert.ToInt32(label33.Text))
            {
                MessageBox.Show("Şampiyon BEŞİKTAŞ");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            label7.Text ="";
            label8.Text = "";
            label12.Text = "";
            label11.Text = "";
            label10.Text = "";
            label9.Text = "";
            label20.Text = "";
            label19.Text = "";
            label18.Text = "";
            label17.Text = "";
            label28.Text = "";
            label27.Text = "";
            label26.Text = "";
            label25.Text = "";
            label36.Text = "";
            label35.Text = "";
            label34.Text = "";
            label33.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
    }
}

