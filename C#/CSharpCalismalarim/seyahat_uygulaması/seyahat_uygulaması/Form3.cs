using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seyahat_uygulaması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button16.Enabled = false;
            button15.Enabled = false;
            button13.Enabled = false;
            button20.Enabled = false;
            button19.Enabled = false;

            if (radioButton1.Checked == false)
            {
                button1.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button3.Enabled = true;
                button16.Enabled = true;
                button15.Enabled = true;
                button13.Enabled = true;
                button20.Enabled = true;
                button19.Enabled = true;
            }
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button12.Enabled = false;
            button18.Enabled = false;
            button17.Enabled = false;
            button14.Enabled = false;

            if (radioButton2.Checked == false)
            {
                button2.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button12.Enabled = true;
                button18.Enabled = true;
                button17.Enabled = true;
                button14.Enabled = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox1.Items.Add(textBox1.Text);
            yeni3.listBox2.Items.Add(textBox2.Text);
            yeni3.listBox3.Items.Add(textBox3.Text);
            yeni3.listBox4.Items.Add(radioButton1.Text);
            yeni3.listBox4.Items.Add(radioButton2.Text);
            yeni3.listBox5.Items.Add(comboBox1.Text);
            yeni3.Show();
            MessageBox.Show("Biletiniz Alınmıştır.İyi Yolculuklar");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("4");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("7");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("9");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("8");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("12");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("16");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("15");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("13");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("6");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("15");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("16");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("20");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.listBox6.Items.Add("18");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
