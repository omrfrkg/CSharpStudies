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

namespace BiletYolcuBilgiler
{
    
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\C#\\CSharpCalismalarim\\BiletYolcuBilgiler\\kayit.mdb");
        public Form1()
        {
            InitializeComponent();
        }
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from kayitlar";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Seferno"].ToString();
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Biniş"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "insert into kayitlar (Seferno,Tarih,Saat,AdSoyad,Telefon,KoltukNo,Ücret,Cinsiyet,Biniş) values('"+textBox1.Text+"','"+textBox4.Text+"','"+textBox3.Text+"','"+textBox2.Text+"','"+textBox8.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+comboBox1.Text+"','"+comboBox2.Text+"')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = 1.ToString();
            button4.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = 2.ToString();
            button5.BackColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = 3.ToString();
            button6.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = 4.ToString();
            button7.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = 5.ToString();
            button8.BackColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Text = 6.ToString();
            button9.BackColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox5.Text = 7.ToString();
            button10.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox5.Text = 8.ToString();
            button11.BackColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "delete from kayitlar where Seferno='"+textBox7.Text+"'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "update kayitlar set  Seferno ='" + textBox1.Text + "',Tarih ='" + textBox4.Text + "',Saat ='" + textBox3.Text + "',AdSoyad ='" + textBox2.Text + "',Telefon='" + textBox8.Text + "',KoltukNo ='" + textBox5.Text + "',Ücret='" + textBox6.Text + "',Cinsiyet ='" + comboBox1.Text + "',Biniş='" + comboBox2.Text + "' where Seferno='"+textBox10.Text+"'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

        }
    }
}
