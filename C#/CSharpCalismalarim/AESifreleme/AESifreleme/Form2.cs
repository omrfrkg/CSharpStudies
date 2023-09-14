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
namespace AESifreleme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        StreamWriter sw;
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }


        string belge_adi, belge_yolu;

        private void button2_Click(object sender, EventArgs e)
        {
            belge_adi = textBox1.Text;
            sw = File.CreateText(belge_yolu+"\\"+belge_adi+".txt");
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
