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

namespace Veritabani_Tablo_Alan_Ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        OleDbConnection baglanti =new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=veritabani.accdb");
        public void Yenile()
        {
            baglanti.Open();
            DataTable veritablosu = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From "+textBox2.Text+"",baglanti);
            adtr.Fill(veritablosu);
            dataGridView1.DataSource = veritablosu;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("CREATE TABLE ["  + textBox2.Text + "] ([ID] AUTOINCREMENT(100,1))",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo Oluşturulmuştur");
                Yenile();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("ALTER TABLE [" + textBox2.Text + "] Add COLUMN ["+textBox1.Text+"] TEXT(10)", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alan Eklenmiştir");
                Yenile();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
                baglanti.Close();
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("ALTER TABLE " + textBox2.Text + " DROP COLUMN " + textBox1.Text + "", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alan Silinmiştir");
                Yenile();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
                baglanti.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Drop TABLE " + textBox2.Text + "", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo Silinmiştir");
                Yenile();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
                baglanti.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
