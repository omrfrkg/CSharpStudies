using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccessVeritabanı
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\omerr\\OneDrive\\Masaüstü\\bilgiler.mdb");
        private void verilerigoruntule()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From  Bilgiler");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Yaş"].ToString());
                ekle.SubItems.Add(oku["İlçe"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Bilgiler  (Ad,Soyad,Yaş,İlçe) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoruntule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Bilgiler where Yaş ='" + textBox5.Text +"'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoruntule();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "update Bilgiler set Ad='"+textBox1.Text+"',Soyad='"+textBox2.Text+"',İlçe='"+textBox4.Text+"'where Yaş='"+textBox3.Text+"'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoruntule();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
