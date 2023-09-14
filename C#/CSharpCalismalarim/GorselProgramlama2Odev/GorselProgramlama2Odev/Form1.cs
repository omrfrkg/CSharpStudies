using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
namespace GorselProgramlama2Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Okul.accdb");
        void KayitGetir()
        {
            baglanti.Open();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM Ogrenci", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Rows[0].Selected = true;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand kayitVarMi = new OleDbCommand("SELECT COUNT(OgrenciNo) FROM Ogrenci WHERE OgrenciNo= @ogrenciNo", baglanti);
            kayitVarMi.Parameters.AddWithValue("@ogrenciNo", tbYeniKayitOgrenciNo.Text);
            if ((int)kayitVarMi.ExecuteScalar()!=0)
            {
                MessageBox.Show("Kayıt zaten mevcuttur!");
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("INSERT INTO Ogrenci VALUES(@ogrenciNo,@ogrenciAd,@ogrenciSoyad)", baglanti);
                komut.Parameters.AddWithValue("@ogrenciNo", tbYeniKayitOgrenciNo.Text);
                komut.Parameters.AddWithValue("@ogrenciAd", tbYeniKayitOgrenciAd.Text);
                komut.Parameters.AddWithValue("@ogrenciSoyad", tbYeniKayitOgrenciSoyad.Text);
                komut.ExecuteNonQuery();
            }
            
            baglanti.Close();
            KayitGetir();
            tbYeniKayitOgrenciNo.Text = string.Empty;
            tbYeniKayitOgrenciAd.Text = string.Empty;
            tbYeniKayitOgrenciSoyad.Text = string.Empty;
        }

        private void btnKaydiBul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT OgrenciNo, OgrenciAd, OgrenciSoyad FROM Ogrenci WHERE OgrenciNo=@ogrenciNo", baglanti);
            komut.Parameters.AddWithValue("@ogrenciNo", tbArananOgrenciNo.Text);
            OleDbDataReader dataReader =  komut.ExecuteReader();
            if (!dataReader.HasRows)
            {
                tbArananOgrenciNo.Text = string.Empty;
                tbGuncellenecekOgrenciNo.Text = string.Empty;
                tbGuncellenecekOgrenciAd.Text = string.Empty;
                tbGuncellenecekOgrenciSoyad.Text = string.Empty;
                MessageBox.Show("Kayıt Bulunamadı!");
            }
            while (dataReader.Read())
            {
                tbGuncellenecekOgrenciNo.Text = dataReader["OgrenciNo"].ToString();
                tbGuncellenecekOgrenciAd.Text = dataReader["OgrenciAd"].ToString();
                tbGuncellenecekOgrenciSoyad.Text = dataReader["OgrenciSoyad"].ToString();
            }
            dataReader.Close();
            baglanti.Close();  
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand kayitVarMi = new OleDbCommand("SELECT COUNT(OgrenciNo) FROM Ogrenci WHERE OgrenciNo= @ogrenciNo", baglanti);
            kayitVarMi.Parameters.AddWithValue("@ogrenciNo", tbGuncellenecekOgrenciNo.Text);
            if ((int)kayitVarMi.ExecuteScalar() != 0)
            {
                MessageBox.Show("Kayıt zaten mevcuttur!");
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("UPDATE Ogrenci SET OgrenciNo=@ogrenciNo, OgrenciAd=@ogrenciAd, OgrenciSoyad=@ogrenciSoyad WHERE OgrenciNo=@arananOgrenciNo", baglanti);
                komut.Parameters.AddWithValue("@ogrenciNo", tbGuncellenecekOgrenciNo.Text);
                komut.Parameters.AddWithValue("@ogrenciAd", tbGuncellenecekOgrenciAd.Text);
                komut.Parameters.AddWithValue("@ogrenciSoyad", tbGuncellenecekOgrenciSoyad.Text);
                komut.Parameters.AddWithValue("@arananOgrenciNo", tbArananOgrenciNo.Text);
                komut.ExecuteNonQuery();
                tbArananOgrenciNo.Text = string.Empty;
                tbGuncellenecekOgrenciNo.Text = string.Empty;
                tbGuncellenecekOgrenciAd.Text = string.Empty;
                tbGuncellenecekOgrenciSoyad.Text = string.Empty;
            }
            baglanti.Close();
            KayitGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("DELETE FROM Ogrenci WHERE OgrenciNo=@silinecekOgrenci",baglanti);
            komut.Parameters.AddWithValue("@silinecekOgrenci", tbSilinecekOgrenciNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            KayitGetir();
            tbSilinecekOgrenciNo.Text = string.Empty;
        }

        private void btnIlkKayit_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Index > 0)
            {
                index = dataGridView1.SelectedRows[0].Index - 1;
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Index < dataGridView1.Rows.Count - 2)
            {
                index = dataGridView1.SelectedRows[0].Index + 1;
                dataGridView1.Rows[index].Selected = true;
            }
            
        }

        private void btnSonKayit_Click(object sender, EventArgs e)
        {            
            dataGridView1.Rows[dataGridView1.RowCount - 2].Selected = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    tbOgrenciNo.Text = row.Cells[0].Value.ToString();
                    tbOgrenciAd.Text = row.Cells[1].Value.ToString();
                    tbOgrenciSoyad.Text = row.Cells[2].Value.ToString();
                }
            }
        }
    }
}
