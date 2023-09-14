using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void yenile()
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=okul.accdb");     
            DataTable veritablosu = new DataTable();
            baglanti.Open();
            OleDbDataAdapter veri = new OleDbDataAdapter("select * from Dersler", baglanti);
            veri.Fill(veritablosu);
            dataGridView1.DataSource=veritablosu;
            baglanti.Close();        
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            yenile();
        }
        string ders3;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked)
            {
                ders3=radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                ders3 = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                ders3 = radioButton3.Text;
            }
            try
            {
                OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=okul.accdb");
                OleDbCommand komut = new OleDbCommand("insert into Dersler (Adi,Soyadi,Nosu,Ders1,Ders2,Ders3) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+comboBox1.Text+"','"+checkBox1.Text+","+checkBox2.Text+","+checkBox3.Text+"','"+ders3+"')",baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                yenile();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
                
            }
            
        }

       
    }
}
