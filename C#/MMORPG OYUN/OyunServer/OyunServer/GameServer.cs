﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunServer
{
    public partial class GameServer : Form
    {
        public GameServer()
        {
            InitializeComponent();
        }

        private void GameServer_Load(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Oyun Sunucusu Başlatılıyor");
            richTextBox2.AppendText("Oyun Sunucusu Başlatılıyor");
        }
    }
}