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

namespace DataGridViewOrnek2
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M80OSA4\\SQLEXPRESS;Initial Catalog=Bilgi;Integrated Security=True");

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Kisiler");
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
           

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kisiler(Ad,Soyad,Yaş,İlçe,Meslek) values(@ad,@soyad,@yas,@ilce,@meslek)",baglanti);
            komut.Parameters.AddWithValue("@ad",textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@yas", textBox3.Text);
            komut.Parameters.AddWithValue("@ilce", textBox4.Text);
            komut.Parameters.AddWithValue("@meslek", textBox5.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Kisiler");
            baglanti.Close();


        }
        
private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Kisiler where Ad=@ad",baglanti);
            komut.Parameters.AddWithValue("@ad",textBox6.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster("Select  * from Kisiler");
            textBox6.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kisiler where Ad like '%" + textBox7.Text + "%'",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
           
            textBox7.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string soyad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string yas = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string ilce = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string meslek = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();

            textBox1.Text = ad;
            textBox2.Text = soyad;
            textBox3.Text = yas;
            textBox4.Text = ilce;
            textBox5.Text = meslek;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  Kisiler set Soyad='"+textBox2.Text+"',Yaş='"+textBox3.Text+"',İlçe='"+textBox4.Text+"',Meslek='"+textBox5.Text+"' where Ad='"+textBox1.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("Select  * from Kisiler");
            baglanti.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox8.Text);
            comboBox1.Text = comboBox1.Items[sayi].ToString();
        }
    }
}
