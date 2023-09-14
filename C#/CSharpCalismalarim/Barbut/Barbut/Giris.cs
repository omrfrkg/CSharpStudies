using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbut
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            List<TextBox> tbListesi = new List<TextBox>();
            List<TextBox> tbListesi2 = new List<TextBox>();
            List<Panel> panelListesi = new List<Panel>();
            Dictionary<TextBox, String> masa = new Dictionary<TextBox, String>();
            tbListesi.Add(textBox1);
            tbListesi.Add(textBox2);
            tbListesi.Add(textBox3);
            tbListesi.Add(textBox4);
            tbListesi.Add(textBox5);
            tbListesi2.Add(form1.tbad1);
            tbListesi2.Add(form1.tbad2);
            tbListesi2.Add(form1.tbad3);
            tbListesi2.Add(form1.tbad4);
            tbListesi2.Add(form1.tbad5);
            panelListesi.Add(form1.pnl1);
            panelListesi.Add(form1.pnl2);
            panelListesi.Add(form1.pnl3);
            panelListesi.Add(form1.pnl4);
            panelListesi.Add(form1.pnl5);
            byte bosDegilSayaci = 0;
            foreach (TextBox tb in tbListesi)
            {
                if (tb.Text != "")
                {
                    bosDegilSayaci++;
                }
            }
            if (bosDegilSayaci < 2)
            {
                MessageBox.Show("Oyuncu Girişi Yapılmadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                byte sayac = 0;
                foreach (TextBox tb in tbListesi)
                {
                    sayac++;
                    if (tb.Text != "")
                    {
                        masa.Add(tb, tb.Text);
                    }
                    else
                    {
                        masa.Add(tb, "");
                    }
                }
                sayac = 0;
                foreach (KeyValuePair<TextBox, String> item in masa)
                {
                    if (item.Value != "")
                    {
                        tbListesi2[sayac].Text = item.Key.Text.ToUpper();
                    }
                    else
                    {
                        tbListesi2[sayac].Text = "";
                        panelListesi[sayac].Visible = false;
                    }
                    sayac++;
                }
                form1.Show();
                this.Hide();
            }
        }
    }
}
