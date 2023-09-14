using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;//www.gorselprogramlama.com
using System.Text;
using System.Windows.Forms;

namespace Live_Broadcast_for_Tv_channels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region MMS
        private void btnC1_Click(object sender, EventArgs e)
        {
            wmpTV.URL = "https://www.showtv.com.tr/canli-yayin";
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            wmpTV.URL = "mms://yayin3.canlitv.com/showtv";//www.gorselprogramlama.com
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            wmpTV.URL = "mms://yayin.canlitv.com/atv";
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            wmpTV.URL = "mms://yayin.canlitv.com/foxtv";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wmpTV.URL = "mms://yayin.canlitv.com/stv";
        }//www.gorselprogramlama.com

        private void button2_Click(object sender, EventArgs e)
        {
            wmpTV.URL = "mms://yayin.canlitv.com/kanalturk";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wmpTV.URL = "mms://85.111.3.55/ntv";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wmpTV.URL = "mms://85.111.3.55/cnbce";
        } 
        #endregion
    }
}//www.gorselprogramlama.com
