using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafik_lambasi_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kirmizi, sari, yeşil;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kirmizi = Convert.ToInt32(label1.Text);
            kirmizi++;
            label1.Text = kirmizi.ToString();
            if (kirmizi == 31)
            {
                
                button1.BackColor = Color.Empty;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Empty;
            }
            if (kirmizi == 41)
            {
                button1.BackColor = Color.Empty;
                button2.BackColor = Color.Empty;
                button3.BackColor = Color.Green;
                
            }
            if (kirmizi == 70)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Empty;
                button3.BackColor = Color.Empty;
                label1.Text = "0";
            }
           
        }
    }
}
