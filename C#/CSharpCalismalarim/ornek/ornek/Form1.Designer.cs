namespace ornek
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
            this.topla = new System.Windows.Forms.Button();
            this.sayi1 = new System.Windows.Forms.TextBox();
            this.sayi2 = new System.Windows.Forms.TextBox();
            this.sonuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cikar = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.bol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topla
            // 
            this.topla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.topla.Location = new System.Drawing.Point(101, 281);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(127, 40);
            this.topla.TabIndex = 0;
            this.topla.Text = "topla";
            this.topla.UseVisualStyleBackColor = false;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // sayi1
            // 
            this.sayi1.Location = new System.Drawing.Point(101, 88);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(100, 20);
            this.sayi1.TabIndex = 1;
            // 
            // sayi2
            // 
            this.sayi2.Location = new System.Drawing.Point(101, 192);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(100, 20);
            this.sayi2.TabIndex = 2;
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Location = new System.Drawing.Point(162, 243);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(0, 13);
            this.sonuc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sonuç:";
            // 
            // cikar
            // 
            this.cikar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cikar.Location = new System.Drawing.Point(275, 281);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(127, 40);
            this.cikar.TabIndex = 5;
            this.cikar.Text = "Çıkar";
            this.cikar.UseVisualStyleBackColor = false;
            this.cikar.Click += new System.EventHandler(this.cikar_Click);
            // 
            // carp
            // 
            this.carp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carp.Location = new System.Drawing.Point(417, 281);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(127, 40);
            this.carp.TabIndex = 6;
            this.carp.Text = "Çarp";
            this.carp.UseVisualStyleBackColor = false;
            this.carp.Click += new System.EventHandler(this.carp_Click);
            // 
            // bol
            // 
            this.bol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bol.Location = new System.Drawing.Point(574, 281);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(127, 40);
            this.bol.TabIndex = 7;
            this.bol.Text = "Böl";
            this.bol.UseVisualStyleBackColor = false;
            this.bol.Click += new System.EventHandler(this.bol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bol);
            this.Controls.Add(this.carp);
            this.Controls.Add(this.cikar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.topla);
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.TextBox sayi1;
        private System.Windows.Forms.TextBox sayi2;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button bol;
    }
}

