namespace MarketOtomasyonu
{
    partial class PersonelYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.peklemek = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.padı = new System.Windows.Forms.Label();
            this.psıfrar = new System.Windows.Forms.Label();
            this.pAd = new System.Windows.Forms.Label();
            this.cikisYap = new System.Windows.Forms.Button();
            this.personelEkle = new System.Windows.Forms.Button();
            this.personelSil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.personelListe = new System.Windows.Forms.DataGridView();
            this.soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personelListe)).BeginInit();
            this.SuspendLayout();
            // 
            // peklemek
            // 
            this.peklemek.AutoSize = true;
            this.peklemek.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peklemek.Location = new System.Drawing.Point(12, 12);
            this.peklemek.Name = "peklemek";
            this.peklemek.Size = new System.Drawing.Size(121, 17);
            this.peklemek.TabIndex = 1;
            this.peklemek.Text = "Personel Ekleme";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdi.Location = new System.Drawing.Point(159, 43);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(223, 24);
            this.kullaniciAdi.TabIndex = 2;
            // 
            // sifre
            // 
            this.sifre.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(159, 79);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(223, 24);
            this.sifre.TabIndex = 3;
            // 
            // ad
            // 
            this.ad.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.Location = new System.Drawing.Point(159, 116);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(223, 24);
            this.ad.TabIndex = 4;
            // 
            // padı
            // 
            this.padı.AutoSize = true;
            this.padı.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padı.Location = new System.Drawing.Point(19, 46);
            this.padı.Name = "padı";
            this.padı.Size = new System.Drawing.Size(101, 17);
            this.padı.TabIndex = 5;
            this.padı.Text = "Kullanıcı Adı :";
            // 
            // psıfrar
            // 
            this.psıfrar.AutoSize = true;
            this.psıfrar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psıfrar.Location = new System.Drawing.Point(19, 82);
            this.psıfrar.Name = "psıfrar";
            this.psıfrar.Size = new System.Drawing.Size(47, 17);
            this.psıfrar.TabIndex = 6;
            this.psıfrar.Text = "Şifre :";
            // 
            // pAd
            // 
            this.pAd.AutoSize = true;
            this.pAd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAd.Location = new System.Drawing.Point(19, 119);
            this.pAd.Name = "pAd";
            this.pAd.Size = new System.Drawing.Size(40, 17);
            this.pAd.TabIndex = 7;
            this.pAd.Text = "Adı :";
            // 
            // cikisYap
            // 
            this.cikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisYap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisYap.Location = new System.Drawing.Point(561, 18);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(227, 85);
            this.cikisYap.TabIndex = 8;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // personelEkle
            // 
            this.personelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelEkle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelEkle.Location = new System.Drawing.Point(22, 187);
            this.personelEkle.Name = "personelEkle";
            this.personelEkle.Size = new System.Drawing.Size(116, 51);
            this.personelEkle.TabIndex = 9;
            this.personelEkle.Text = "Personel Ekle";
            this.personelEkle.UseVisualStyleBackColor = true;
            this.personelEkle.Click += new System.EventHandler(this.personelEkle_Click);
            // 
            // personelSil
            // 
            this.personelSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelSil.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelSil.Location = new System.Drawing.Point(144, 187);
            this.personelSil.Name = "personelSil";
            this.personelSil.Size = new System.Drawing.Size(116, 51);
            this.personelSil.TabIndex = 10;
            this.personelSil.Text = "Sil";
            this.personelSil.UseVisualStyleBackColor = true;
            this.personelSil.Click += new System.EventHandler(this.personelSil_Click);
            // 
            // guncelle
            // 
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelle.Location = new System.Drawing.Point(266, 187);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(116, 51);
            this.guncelle.TabIndex = 11;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // personelListe
            // 
            this.personelListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelListe.Location = new System.Drawing.Point(22, 244);
            this.personelListe.Name = "personelListe";
            this.personelListe.RowTemplate.Height = 24;
            this.personelListe.Size = new System.Drawing.Size(766, 303);
            this.personelListe.TabIndex = 12;
            this.personelListe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelListe_RowEnter);
            // 
            // soyad
            // 
            this.soyad.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyad.Location = new System.Drawing.Point(159, 157);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(223, 24);
            this.soyad.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Soyadı :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(388, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonelYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.personelListe);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.personelSil);
            this.Controls.Add(this.personelEkle);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.pAd);
            this.Controls.Add(this.psıfrar);
            this.Controls.Add(this.padı);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.peklemek);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PersonelYonetimi";
            this.Text = "PersonelYonetimi";
            this.Load += new System.EventHandler(this.PersonelYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label peklemek;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label padı;
        private System.Windows.Forms.Label psıfrar;
        private System.Windows.Forms.Label pAd;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Button personelEkle;
        private System.Windows.Forms.Button personelSil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.DataGridView personelListe;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}