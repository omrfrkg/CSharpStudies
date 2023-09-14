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

namespace Gorsel2SonHazirlikVize
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=veritabani.accdb");

        private void verileri_goster()
        {
            baglanti.Open();
            DataTable veritablosu = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from ["+textBox9.Text+"]",baglanti);
            adtr.Fill(veritablosu);
            dataGridView1.DataSource = veritablosu;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("CREATE TABLE ["+textBox9.Text+"] ([ID] AUTOINCREMENT(1,1))",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo Oluşturulmuştur");
                
            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            verileri_goster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("DROP TABLE [" + textBox9.Text + "]", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo Silinmiştir");

            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("ALTER TABLE [" + textBox9.Text + "] ADD COLUMN ["+textBox8.Text+"]TEXT(20)", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alan Eklenmiştir");
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
                OleDbCommand komut = new OleDbCommand("ALTER TABLE [" + textBox9.Text + "] DROP COLUMN [" + textBox8.Text + "]", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alan Silinmiştir");
            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO ["+textBox9.Text+"] (OkulNo,Adi,Soyadi,Sinifi,Yasi,Il) VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veriler Eklenmiştir");

            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("UPDATE ["+textBox9.Text+ "] SET OkulNo='" + textBox1.Text+"',Adi='"+textBox2.Text+"',Soyadi='"+textBox3.Text+"',Sinifi='"+textBox4.Text+"',Yasi='"+textBox5.Text+"',Il='"+textBox6.Text+"' where OkulNo='"+textBox7.Text+"'",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veriler Güncellenmiştir");

            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("DELETE FROM ["+textBox9.Text+"] WHERE OkulNo='"+textBox7.Text+"'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veri Silinmiştir.");

            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }
        string sorgu;
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                sorgu = textBox10.Text;
                DataTable veritablosu = new DataTable();
                baglanti.Open();
                OleDbDataAdapter komut = new OleDbDataAdapter(sorgu,baglanti);
                komut.Fill(veritablosu);
                dataGridView1.DataSource=veritablosu;
                baglanti.Close();

            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            verileri_goster();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select * From ["+textBox9.Text+"]",baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add(oku["Adi"] + " " + oku["Soyadi"]);
                    listBox2.Items.Add(oku["Yasi"]);
                }
                baglanti.Close();
            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
                baglanti.Close();
            }
        }
    }
}
