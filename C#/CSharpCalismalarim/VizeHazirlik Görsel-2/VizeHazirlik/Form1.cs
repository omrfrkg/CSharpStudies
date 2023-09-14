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
namespace VizeHazirlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=veritabani.accdb");
        private void yenile()
        {
            baglanti.Open();
            DataTable veritablosu = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From ["+comboBox1.Text+"]",baglanti);
            adtr.Fill(veritablosu);
            dataGridView1.DataSource = veritablosu;
            baglanti.Close();
        }

        private void vt_cek()
        {
            baglanti.Open();
            DataTable veritablosu = baglanti.GetSchema("Tables");
            for (int i = 0; i < veritablosu.Rows.Count; i++)
            {
                if (veritablosu.Rows[i]["TABLE_TYPE"].ToString() == "TABLE")
                {
                    comboBox1.Items.Add(veritablosu.Rows[i]["TABLE_NAME"]);
                }
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            vt_cek();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("CREATE TABLE ["+ textBox9.Text +"] ([ID] AUTOINCREMENT(1,1))",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo Oluşturulmuştur");
                yenile();
                vt_cek();

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
                baglanti.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("DROP TABLE ["+comboBox1.Text+"]",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo Silinmiştir.","Silme İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox10.Text = "";
                textBox9.Text = "";
                
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("ALTER TABLE ["+comboBox1.Text+"] ADD COLUMN ["+textBox10.Text+"] TEXT(20) ",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(comboBox1.Text + " tablosuna "+textBox10.Text+" alan adı eklenmiştir.");
                yenile();
                textBox10.Text = "";
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
                baglanti.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("ALTER TABLE ["+ comboBox1.Text + "]DROP COLUMN ["+textBox10.Text+"]",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Alan silme işlemi başarılıyla tamamlanmıştır.");
                yenile();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
                baglanti.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO [" + comboBox1.Text + "](OkulNo,Adı,Soyadı,Sınıfı,Yaşı,İli) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Eklenmiştir.");
                yenile();
                foreach (Control item in Application.OpenForms["Form1"].Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
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
                OleDbCommand komut = new OleDbCommand("UPDATE  [" + comboBox1.Text + "] SET OkulNo='" + textBox1.Text + "',Adı='" + textBox2.Text + "',Soyadı='" + textBox3.Text + "',Sınıfı='" + textBox4.Text + "',Yaşı='" + textBox5.Text + "',İli='" + textBox6.Text + "' where OkulNo='" + textBox7.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Güncellenmiştir");
                yenile();
            }
            catch (Exception hata )
            {

                MessageBox.Show(hata.ToString());
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("DELETE FROM ["+ comboBox1.Text + "] where OkulNo='"+textBox7.Text+"'",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silinmiştir");
                yenile();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
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

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu;
            sorgu=textBox8.Text;
            baglanti.Open();
            DataTable veritablosu = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter(sorgu,baglanti);
            adtr.Fill(veritablosu);
            dataGridView1.DataSource = veritablosu;
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            yenile();
        }
    }
}
