using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görselprogramlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("http://nacikarakullukcu.com.tr/");
            linkLabel1.LinkVisited = true;
            //System.Diagnostics.Process.Start("calc.exe"); 1 LinkLabel'a birden fazla görev atanabilir.

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ımageList1.Images[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ımageList1.Images[1];
            //resmin boyutunu değiştirmek için imagelist görevlerinden görüntü boyutu ve görüntü derinliği ayarlarıyla oynamak lazım.
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://social.technet.microsoft.com/wiki/contents/articles/26605.c-da-flowlayoutpanel-kullanm-ve-ozellikleri-tr-tr.aspx");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/tr-tr/visualstudio/ide/step-4-lay-out-your-form-with-a-tablelayoutpanel-control?view=vs-2019");

        }
    }
}
