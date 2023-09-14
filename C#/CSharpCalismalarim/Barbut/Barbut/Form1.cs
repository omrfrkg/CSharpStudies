using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                //Seçili elemanı ikinci listeye ekle
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                //seçili elemanı birinci listeden çıkar
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                //Seçili elemanı ikinci listeye ekle
                listBox1.Items.Add(listBox2.SelectedItems[i]);
                //seçili elemanı birinci listeden çıkar
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
            }
        }

        public void radioGizle()
        {
            rb1sol.Visible = false;
            rb1sag.Visible = false;
            rb2sol.Visible = false;
            rb2sag.Visible = false;
            rb3sol.Visible = false;
            rb3sag.Visible = false;
            rb4sol.Visible = false;
            rb4sag.Visible = false;
            rb5sol.Visible = false;
            rb5sag.Visible = false;

        }
        public void radioGoster()
        {
            rb1sol.Visible = true;
            rb1sag.Visible = true;
            rb2sol.Visible = true;
            rb2sag.Visible = true;
            rb3sol.Visible = true;
            rb3sag.Visible = true;
            rb4sol.Visible = true;
            rb4sag.Visible = true;
            rb5sol.Visible = true;
            rb5sag.Visible = true;

        }
        public void ileriSifirla()
        {
            tbileri1.Clear();
            tbileri2.Clear();
            tbileri3.Clear();
            tbileri4.Clear();
            tbileri5.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (pnl1.Visible == true)
            {
                if (rb1sol.Checked == true)
                {
                    listBox1.Items.Add(tbad1.Text);
                }
                else if(rb1sag.Checked == true)
                {
                    listBox2.Items.Add(tbad1.Text);
                }
            }
            if (pnl2.Visible == true)
            {
                if (rb2sol.Checked == true)
                {
                    listBox1.Items.Add(tbad2.Text);
                }
                else if (rb2sag.Checked == true)
                {
                    listBox2.Items.Add(tbad2.Text);
                }
            }
            if (pnl3.Visible == true)
            {
                if (rb3sol.Checked == true)
                {
                    listBox1.Items.Add(tbad3.Text);
                }
                else if (rb3sag.Checked == true)
                {
                    listBox2.Items.Add(tbad3.Text);
                }
            }
            if (pnl4.Visible == true)
            {
                if (rb4sol.Checked == true)
                {
                    listBox1.Items.Add(tbad4.Text);
                }
                else if (rb4sag.Checked == true)
                {
                    listBox2.Items.Add(tbad4.Text);
                }
            }
            if (pnl5.Visible == true)
            {
                if (rb5sol.Checked == true)
                {
                    listBox1.Items.Add(tbad5.Text);
                }
                else if (rb5sag.Checked == true)
                {
                    listBox2.Items.Add(tbad5.Text);
                }
            }
            radioGizle();
            btntrfEkle.Enabled = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pnl1.Visible == true)
            {
                if (tbileri1.Text != "" && tbbky1.Text != "0")
                {
                    tbbky1.Text = (Convert.ToInt32(tbbky1.Text) - Convert.ToInt32(tbileri1.Text)).ToString();
                    kasa.Text = (Convert.ToInt32(kasa.Text) + Convert.ToInt32(tbileri1.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("1. Oyuncunun Bakiye: 0 veya İleri Sürülen Para Girilmemiş!");
                }
                
            }
            if (pnl2.Visible == true)
            {
                if (tbileri2.Text != "" && tbbky2.Text != "0")
                {
                    tbbky2.Text = (Convert.ToInt32(tbbky2.Text) - Convert.ToInt32(tbileri2.Text)).ToString();
                    kasa.Text = (Convert.ToInt32(kasa.Text) + Convert.ToInt32(tbileri2.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("2. Oyuncunun Bakiye: 0 veya İleri Sürülen Para Girilmemiş!");
                }
            }
            if (pnl3.Visible == true)
            {
                if (tbileri3.Text != "" && tbbky3.Text != "0")
                {
                    tbbky3.Text = (Convert.ToInt32(tbbky3.Text) - Convert.ToInt32(tbileri3.Text)).ToString();
                    kasa.Text = (Convert.ToInt32(kasa.Text) + Convert.ToInt32(tbileri3.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("3. Oyuncunun Bakiye: 0 veya İleri Sürülen Para Girilmemiş!");
                }
            }
            if (pnl4.Visible == true)
            {
                if (tbileri4.Text != "" && tbbky4.Text != "0")
                {
                    tbbky4.Text = (Convert.ToInt32(tbbky4.Text) - Convert.ToInt32(tbileri4.Text)).ToString();
                    kasa.Text = (Convert.ToInt32(kasa.Text) + Convert.ToInt32(tbileri4.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("4. Oyuncunun Bakiye: 0 veya İleri Sürülen Para Girilmemiş!");
                }
            }
            if (pnl5.Visible == true)
            {
                if (tbileri5.Text != "" && tbbky5.Text != "0")
                {
                    tbbky5.Text = (Convert.ToInt32(tbbky5.Text) - Convert.ToInt32(tbileri5.Text)).ToString();
                    kasa.Text = (Convert.ToInt32(kasa.Text) + Convert.ToInt32(tbileri5.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("5. Oyuncunun Bakiye: 0 veya İleri Sürülen Para Girilmemiş!");
                }
            }
            ileriSifirla();
        }
        public void bakiyeyeEklelb1(int eklenecekPara)
        {
            
            if (pnl1.Visible == true)
            {
                foreach (var item in listBox1.Items)
                {
                    if (tbad1.Text == item.ToString())
                    {
                        tbbky1.Text = (Convert.ToInt32(tbbky1.Text) + eklenecekPara).ToString();
                    }
                }   
            }
            if (pnl2.Visible == true)
            {
                foreach (var item in listBox1.Items)
                {
                    if (tbad2.Text == item.ToString())
                    {
                        tbbky2.Text = (Convert.ToInt32(tbbky2.Text) + eklenecekPara).ToString();
                    }
                }
            }
            if (pnl3.Visible == true)
            {
                foreach (var item in listBox1.Items)
                {
                    if (tbad3.Text == item.ToString())
                    {
                        tbbky3.Text = (Convert.ToInt32(tbbky3.Text) + eklenecekPara).ToString();
                    }
                }
            }
            if (pnl4.Visible == true)
            {
                foreach (var item in listBox1.Items)
                {
                    if (tbad4.Text == item.ToString())
                    {
                        tbbky4.Text = (Convert.ToInt32(tbbky4.Text) + eklenecekPara).ToString();
                    }
                }
            }
            if (pnl5.Visible == true)
            {
                foreach (var item in listBox1.Items)
                {
                    if (tbad5.Text == item.ToString())
                    {
                        tbbky5.Text = (Convert.ToInt32(tbbky5.Text) + eklenecekPara).ToString();
                    }
                }
            }
        }
        public void bakiyeyeEklelb2(int eklenecekPara)
        {

            if (pnl1.Visible == true)
            {
                foreach (var item in listBox2.Items)
                {
                    if (tbad1.Text == item.ToString())
                    {
                        tbbky1.Text = (Convert.ToInt32(tbbky1.Text) + eklenecekPara).ToString();
                    }
                }
            }
            if (pnl2.Visible == true)
            {
                foreach (var item in listBox2.Items)
                {
                    if (tbad2.Text == item.ToString())
                    {
                        tbbky2.Text = (Convert.ToInt32(tbbky2.Text) + eklenecekPara).ToString();
                    }
                }
            }
            if (pnl3.Visible == true)
            {
                foreach (var item in listBox2.Items)
                {
                    if (tbad3.Text == item.ToString())
                    {
                        tbbky3.Text = (Convert.ToInt32(tbbky3.Text) + eklenecekPara).ToString();
                    }
                }
            }
            if (pnl4.Visible == true)
            {
                foreach (var item in listBox2.Items)
                {
                    if (tbad4.Text == item.ToString())
                    {
                        tbbky4.Text = (Convert.ToInt32(tbbky4.Text) + eklenecekPara).ToString();
                    }
                }
            }
            if (pnl5.Visible == true)
            {
                foreach (var item in listBox2.Items)
                {
                    if (tbad5.Text == item.ToString())
                    {
                        tbbky5.Text = (Convert.ToInt32(tbbky5.Text) + eklenecekPara).ToString();
                    }
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            btnKsEkle.Enabled = false;
            Random rnd = new Random();
            int zar1 = rnd.Next(1, 7);
            int zar2 = rnd.Next(1, 7);
            string zarlar = zar1.ToString() + zar2.ToString();
            pictureBox1.Image = ımageList1.Images[zar1 - 1];
            pictureBox2.Image = ımageList1.Images[zar2 - 1];
            while (true) {
                if (rbSag.Checked == true || rbSol.Checked == true)
                {
                    break;
                }
                else
                {
                    MessageBox.Show("Zar atan tarafı seçiniz.");
                    break;
                }
            }
            if ((zarlar == "66")|| (zarlar == "55")|| (zarlar == "33")|| (zarlar == "21")|| (zarlar == "12"))
            {
                if (rbSol.Checked == true)
                {
                    int aktarilacakPara = Convert.ToInt32(kasa.Text) / listBox1.Items.Count;
                    bakiyeyeEklelb1(aktarilacakPara);
                    kasa.Text = "0";
                    btntrfEkle.Enabled = true;
                    btnKsEkle.Enabled = true;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    rbSol.Checked = false;
                    rbSag.Checked = false;
                    MessageBox.Show("Kazanan: 1. Grup");
                    radioGoster();
                }else if(rbSag.Checked == true)
                {
                    int aktarilacakPara = Convert.ToInt32(kasa.Text) / listBox2.Items.Count;
                    bakiyeyeEklelb2(aktarilacakPara);
                    kasa.Text = "0";
                    btntrfEkle.Enabled = true;
                    btnKsEkle.Enabled = true;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    rbSol.Checked = false;
                    rbSag.Checked = false;
                    MessageBox.Show("Kazanan: 2. Grup");
                    radioGoster();
                }
            }
            else if ((zarlar == "44") || (zarlar == "22") || (zarlar == "11") || (zarlar == "65") || (zarlar == "56"))
            {
                if (rbSol.Checked == true)
                {
                    int aktarilacakPara = Convert.ToInt32(kasa.Text) / listBox2.Items.Count;
                    bakiyeyeEklelb2(aktarilacakPara);
                    kasa.Text = "0";
                    btntrfEkle.Enabled = true;
                    btnKsEkle.Enabled = true;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    rbSol.Checked = false;
                    rbSag.Checked = false;
                    MessageBox.Show("Kazanan: 2. Grup");
                    radioGoster();
                }
                else if (rbSag.Checked == true)
                {
                    int aktarilacakPara = Convert.ToInt32(kasa.Text) / listBox1.Items.Count;
                    bakiyeyeEklelb1(aktarilacakPara);
                    kasa.Text = "0";
                    btntrfEkle.Enabled = true;
                    btnKsEkle.Enabled = true;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    rbSol.Checked = false;
                    rbSag.Checked = false;
                    MessageBox.Show("Kazanan: 1. Grup");
                    radioGoster();
                }
            }
            else
            {
                if (rbSag.Checked == true)
                {
                    rbSag.Checked = false;
                    rbSol.Checked = true;
                }
                else
                {
                    rbSol.Checked = false;
                    rbSag.Checked = true;
                }
                MessageBox.Show("Karşı taraf zar çekecek.");
            }
        }
    }
}
