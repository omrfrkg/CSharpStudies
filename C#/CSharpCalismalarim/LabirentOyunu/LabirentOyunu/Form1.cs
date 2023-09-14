using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirentOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                x += 10;
            }
            if (e.KeyCode == Keys.Down)
            {
               y += 10;
            }
            if (e.KeyCode == Keys.Left)
            {
                x -= 10;
                
            }
            if (e.KeyCode == Keys.Up)
            {
                y -= 10;
            }
            if (pictureBox1.Right >= label9.Left)
            {
                x = 3;
                y = 45;
            }
            if (pictureBox1.Top <= label1.Bottom)
            {
                x = 3;
                y = 45;
            }
            if (pictureBox1.Bottom >= label2.Top)
            {
                x = 3;
                y = 45;
            }
            if (pictureBox1.Left >= label3.Right)
            {
                x = 3;
                y = 45;
            }
            pictureBox1.Location = new Point(x,y);
        }
    }
}
