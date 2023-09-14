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

namespace Görsel2FinalCalisma2
{
    
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=veritabani.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Yenile()
        {
            baglanti.Open();
            DataTable veritablosu = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from ["+textBox1.Text+"]",baglanti);
            adtr.Fill(veritablosu);
            dataGridView1.DataSource = veritablosu;
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("CREATE TABLE [" + textBox1.Text + "]", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo Oluşturuldu");
            }
            catch (Exception msj)
            {

                MessageBox.Show(msj.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("ALTER TABLE ["+textBox1.Text+"] ADD COLUMN ["+textBox2.Text+"]TEXT(20)",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alan Oluşturuldu");
                Yenile();
            }
            catch (Exception msj)
            {

                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            string veri = textBox3.Text;
            
            try
            {
                baglanti.Open();           
                for (int i = 0; i < 5; i++)
                {
                    string toplamveri = veri + sayac;
                    OleDbCommand komut = new OleDbCommand("INSERT INTO [" + textBox1.Text + "] (Ad) VALUES('" + toplamveri + "')", baglanti);
                    komut.ExecuteNonQuery();
                    sayac++;
                }
                
                baglanti.Close();
                Yenile();
            }
            catch (Exception msj)
            {

                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("DROP TABLE ["+textBox1.Text+"]",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo Silinmiştir.");
            }
            catch (Exception msj)
            {

                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("ALTER TABLE["+textBox1.Text+"] DROP COLUMN ["+textBox2.Text+"]",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alan Silinmiştir.");
            }
            catch (Exception msj)
            {

                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }
    }
}
