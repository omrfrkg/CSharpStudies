using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrip_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void projeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni Proje Açıldı");
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void projeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proje Açıldı");
        }
    }
}
