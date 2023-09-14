using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PansiyonKayit
{

   
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M80OSA4\\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Musteriler",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                ekle.SubItems.Add(oku["CTarih"].ToString());
                

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
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Musteriler (id,Ad,Soyad,OdaNo,Tarih,Telefon,Hesap,CTarih) values ('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"','"+comboBox1.Text.ToString()+ "','" + dateTimePicker1.Text.ToString() + "','" + textBox5.Text.ToString()+ "','" + textBox6.Text.ToString() + "','" + dateTimePicker2.Text.ToString() + "')",baglanti);
            komut.ExecuteNonQuery();
            komut.CommandText = ("insert into doluoda(doluyerler) values('"+comboBox1.Text+"')");
            komut.ExecuteNonQuery();
            komut.CommandText = ("delete from bosoda where bosyerler='"+comboBox1.Text+"'");
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox text = (TextBox)item;
                }
            }
        }

        int id=0;
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Musteriler where id=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            komut.CommandText = ("insert into bosoda(bpsyerler) values('" + comboBox1.Text + "')");
            komut.ExecuteNonQuery();
            komut.CommandText = ("delete from doluoda where doluyerler='" + comboBox1.Text + "'");
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            dateTimePicker1.Text =listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Musteriler set id='"+textBox1.Text+"',Ad='"+textBox2.Text+"',Soyad='"+textBox3.Text+"',OdaNo='"+comboBox1.Text+"',Tarih='"+dateTimePicker1.Text+"',Telefon='"+textBox5.Text+"',Hesap='"+textBox6.Text+"',CTarih='"+dateTimePicker2.Text+"' where id=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Musteriler where id like '%" +textBox7.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                ekle.SubItems.Add(oku["CTarih"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from bosoda",baglanti);
            SqlDataReader oda = komut.ExecuteReader();
            while(oda.Read())
            {
                comboBox1.Items.Add(oda[0].ToString());
            }
            baglanti.Close();
        }
    }
}
