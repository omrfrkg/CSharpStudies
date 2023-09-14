namespace GorselProgramlama2Odev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOgrenciNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOgrenciAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIlkKayit = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnSonKayit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.tbYeniKayitOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbYeniKayitOgrenciAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbYeniKayitOgrenciNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydiBul = new System.Windows.Forms.Button();
            this.tbGuncellenecekOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGuncellenecekOgrenciNo = new System.Windows.Forms.TextBox();
            this.tbGuncellenecekOgrenciAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbArananOgrenciNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbSilinecekOgrenciNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(272, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(516, 366);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci No";
            // 
            // tbOgrenciNo
            // 
            this.tbOgrenciNo.Enabled = false;
            this.tbOgrenciNo.Location = new System.Drawing.Point(41, 52);
            this.tbOgrenciNo.Name = "tbOgrenciNo";
            this.tbOgrenciNo.Size = new System.Drawing.Size(100, 20);
            this.tbOgrenciNo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // tbOgrenciAd
            // 
            this.tbOgrenciAd.Enabled = false;
            this.tbOgrenciAd.Location = new System.Drawing.Point(197, 52);
            this.tbOgrenciAd.Name = "tbOgrenciAd";
            this.tbOgrenciAd.Size = new System.Drawing.Size(100, 20);
            this.tbOgrenciAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad";
            // 
            // tbOgrenciSoyad
            // 
            this.tbOgrenciSoyad.Enabled = false;
            this.tbOgrenciSoyad.Location = new System.Drawing.Point(356, 52);
            this.tbOgrenciSoyad.Name = "tbOgrenciSoyad";
            this.tbOgrenciSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbOgrenciSoyad.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbOgrenciSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbOgrenciNo);
            this.groupBox1.Controls.Add(this.tbOgrenciAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(272, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // btnIlkKayit
            // 
            this.btnIlkKayit.Location = new System.Drawing.Point(334, 531);
            this.btnIlkKayit.Name = "btnIlkKayit";
            this.btnIlkKayit.Size = new System.Drawing.Size(75, 23);
            this.btnIlkKayit.TabIndex = 0;
            this.btnIlkKayit.Text = "İlk Kayıt";
            this.btnIlkKayit.UseVisualStyleBackColor = true;
            this.btnIlkKayit.Click += new System.EventHandler(this.btnIlkKayit_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(441, 531);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "<";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(545, 531);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(75, 23);
            this.btnIleri.TabIndex = 2;
            this.btnIleri.Text = ">";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnSonKayit
            // 
            this.btnSonKayit.Location = new System.Drawing.Point(659, 531);
            this.btnSonKayit.Name = "btnSonKayit";
            this.btnSonKayit.Size = new System.Drawing.Size(75, 23);
            this.btnSonKayit.TabIndex = 3;
            this.btnSonKayit.Text = "Son Kayıt";
            this.btnSonKayit.UseVisualStyleBackColor = true;
            this.btnSonKayit.Click += new System.EventHandler(this.btnSonKayit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKayitEkle);
            this.groupBox2.Controls.Add(this.tbYeniKayitOgrenciSoyad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbYeniKayitOgrenciAd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbYeniKayitOgrenciNo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 181);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kayıt Bilgileri";
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Location = new System.Drawing.Point(73, 141);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(136, 23);
            this.btnKayitEkle.TabIndex = 3;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // tbYeniKayitOgrenciSoyad
            // 
            this.tbYeniKayitOgrenciSoyad.Location = new System.Drawing.Point(73, 105);
            this.tbYeniKayitOgrenciSoyad.Name = "tbYeniKayitOgrenciSoyad";
            this.tbYeniKayitOgrenciSoyad.Size = new System.Drawing.Size(136, 20);
            this.tbYeniKayitOgrenciSoyad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Soyad";
            // 
            // tbYeniKayitOgrenciAd
            // 
            this.tbYeniKayitOgrenciAd.Location = new System.Drawing.Point(73, 69);
            this.tbYeniKayitOgrenciAd.Name = "tbYeniKayitOgrenciAd";
            this.tbYeniKayitOgrenciAd.Size = new System.Drawing.Size(136, 20);
            this.tbYeniKayitOgrenciAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ad";
            // 
            // tbYeniKayitOgrenciNo
            // 
            this.tbYeniKayitOgrenciNo.Location = new System.Drawing.Point(73, 34);
            this.tbYeniKayitOgrenciNo.Name = "tbYeniKayitOgrenciNo";
            this.tbYeniKayitOgrenciNo.Size = new System.Drawing.Size(136, 20);
            this.tbYeniKayitOgrenciNo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Öğrenci No";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuncelle);
            this.groupBox3.Controls.Add(this.btnKaydiBul);
            this.groupBox3.Controls.Add(this.tbGuncellenecekOgrenciSoyad);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbGuncellenecekOgrenciNo);
            this.groupBox3.Controls.Add(this.tbGuncellenecekOgrenciAd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbArananOgrenciNo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 256);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıt Güncelleme";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(15, 218);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(208, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydiBul
            // 
            this.btnKaydiBul.Location = new System.Drawing.Point(41, 64);
            this.btnKaydiBul.Name = "btnKaydiBul";
            this.btnKaydiBul.Size = new System.Drawing.Size(155, 23);
            this.btnKaydiBul.TabIndex = 1;
            this.btnKaydiBul.Text = "Kaydı Bul";
            this.btnKaydiBul.UseVisualStyleBackColor = true;
            this.btnKaydiBul.Click += new System.EventHandler(this.btnKaydiBul_Click);
            // 
            // tbGuncellenecekOgrenciSoyad
            // 
            this.tbGuncellenecekOgrenciSoyad.Location = new System.Drawing.Point(106, 185);
            this.tbGuncellenecekOgrenciSoyad.Name = "tbGuncellenecekOgrenciSoyad";
            this.tbGuncellenecekOgrenciSoyad.Size = new System.Drawing.Size(117, 20);
            this.tbGuncellenecekOgrenciSoyad.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Öğrenci No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Soyad";
            // 
            // tbGuncellenecekOgrenciNo
            // 
            this.tbGuncellenecekOgrenciNo.Location = new System.Drawing.Point(106, 107);
            this.tbGuncellenecekOgrenciNo.Name = "tbGuncellenecekOgrenciNo";
            this.tbGuncellenecekOgrenciNo.Size = new System.Drawing.Size(117, 20);
            this.tbGuncellenecekOgrenciNo.TabIndex = 2;
            // 
            // tbGuncellenecekOgrenciAd
            // 
            this.tbGuncellenecekOgrenciAd.Location = new System.Drawing.Point(106, 146);
            this.tbGuncellenecekOgrenciAd.Name = "tbGuncellenecekOgrenciAd";
            this.tbGuncellenecekOgrenciAd.Size = new System.Drawing.Size(117, 20);
            this.tbGuncellenecekOgrenciAd.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ad";
            // 
            // tbArananOgrenciNo
            // 
            this.tbArananOgrenciNo.Location = new System.Drawing.Point(147, 36);
            this.tbArananOgrenciNo.Name = "tbArananOgrenciNo";
            this.tbArananOgrenciNo.Size = new System.Drawing.Size(100, 20);
            this.tbArananOgrenciNo.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Güncellenecek Öğrenci No";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(15, 56);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(222, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Controls.Add(this.tbSilinecekOgrenciNo);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(12, 473);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 85);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kayıt Silme";
            // 
            // tbSilinecekOgrenciNo
            // 
            this.tbSilinecekOgrenciNo.Location = new System.Drawing.Point(123, 19);
            this.tbSilinecekOgrenciNo.Name = "tbSilinecekOgrenciNo";
            this.tbSilinecekOgrenciNo.Size = new System.Drawing.Size(114, 20);
            this.tbSilinecekOgrenciNo.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Silinecek Öğrenci No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSonKayit);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnIlkKayit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOgrenciNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOgrenciAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOgrenciSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIlkKayit;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnSonKayit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.TextBox tbYeniKayitOgrenciSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbYeniKayitOgrenciAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbYeniKayitOgrenciNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbArananOgrenciNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGuncellenecekOgrenciSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGuncellenecekOgrenciNo;
        private System.Windows.Forms.TextBox tbGuncellenecekOgrenciAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydiBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbSilinecekOgrenciNo;
        private System.Windows.Forms.Label label11;
    }
}

