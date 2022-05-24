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
            this.pyonetmek = new System.Windows.Forms.Label();
            this.peklemek = new System.Windows.Forms.Label();
            this.kullanıcıAdı = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.adiSoyadi = new System.Windows.Forms.TextBox();
            this.padı = new System.Windows.Forms.Label();
            this.psıfrar = new System.Windows.Forms.Label();
            this.padsoyad = new System.Windows.Forms.Label();
            this.cikisYap = new System.Windows.Forms.Button();
            this.personelEkle = new System.Windows.Forms.Button();
            this.personelSil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // pyonetmek
            // 
            this.pyonetmek.AutoSize = true;
            this.pyonetmek.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyonetmek.Location = new System.Drawing.Point(13, 13);
            this.pyonetmek.Name = "pyonetmek";
            this.pyonetmek.Size = new System.Drawing.Size(207, 31);
            this.pyonetmek.TabIndex = 0;
            this.pyonetmek.Text = "Personel Yönetimi";
            // 
            // peklemek
            // 
            this.peklemek.AutoSize = true;
            this.peklemek.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peklemek.Location = new System.Drawing.Point(16, 68);
            this.peklemek.Name = "peklemek";
            this.peklemek.Size = new System.Drawing.Size(166, 28);
            this.peklemek.TabIndex = 1;
            this.peklemek.Text = "Personel Ekleme";
            // 
            // kullanıcıAdı
            // 
            this.kullanıcıAdı.Location = new System.Drawing.Point(181, 115);
            this.kullanıcıAdı.Name = "kullanıcıAdı";
            this.kullanıcıAdı.Size = new System.Drawing.Size(221, 25);
            this.kullanıcıAdı.TabIndex = 2;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(181, 171);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(221, 25);
            this.sifre.TabIndex = 3;
            // 
            // adiSoyadi
            // 
            this.adiSoyadi.Location = new System.Drawing.Point(181, 224);
            this.adiSoyadi.Name = "adiSoyadi";
            this.adiSoyadi.Size = new System.Drawing.Size(221, 25);
            this.adiSoyadi.TabIndex = 4;
            // 
            // padı
            // 
            this.padı.AutoSize = true;
            this.padı.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padı.Location = new System.Drawing.Point(19, 114);
            this.padı.Name = "padı";
            this.padı.Size = new System.Drawing.Size(121, 23);
            this.padı.TabIndex = 5;
            this.padı.Text = "Kullanıcı Adı :";
            this.padı.Click += new System.EventHandler(this.label3_Click);
            // 
            // psıfrar
            // 
            this.psıfrar.AutoSize = true;
            this.psıfrar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psıfrar.Location = new System.Drawing.Point(19, 170);
            this.psıfrar.Name = "psıfrar";
            this.psıfrar.Size = new System.Drawing.Size(60, 23);
            this.psıfrar.TabIndex = 6;
            this.psıfrar.Text = "Şifre :";
            this.psıfrar.Click += new System.EventHandler(this.label4_Click);
            // 
            // padsoyad
            // 
            this.padsoyad.AutoSize = true;
            this.padsoyad.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padsoyad.Location = new System.Drawing.Point(16, 226);
            this.padsoyad.Name = "padsoyad";
            this.padsoyad.Size = new System.Drawing.Size(107, 23);
            this.padsoyad.TabIndex = 7;
            this.padsoyad.Text = "Adı Soyadı :";
            this.padsoyad.Click += new System.EventHandler(this.label5_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisYap.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisYap.Location = new System.Drawing.Point(934, 83);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(273, 113);
            this.cikisYap.TabIndex = 8;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // personelEkle
            // 
            this.personelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelEkle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelEkle.Location = new System.Drawing.Point(181, 358);
            this.personelEkle.Name = "personelEkle";
            this.personelEkle.Size = new System.Drawing.Size(221, 51);
            this.personelEkle.TabIndex = 9;
            this.personelEkle.Text = "Personel Ekle";
            this.personelEkle.UseVisualStyleBackColor = true;
            this.personelEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // personelSil
            // 
            this.personelSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelSil.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelSil.Location = new System.Drawing.Point(522, 358);
            this.personelSil.Name = "personelSil";
            this.personelSil.Size = new System.Drawing.Size(220, 51);
            this.personelSil.TabIndex = 10;
            this.personelSil.Text = "Sil";
            this.personelSil.UseVisualStyleBackColor = true;
            this.personelSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // guncelle
            // 
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelle.Location = new System.Drawing.Point(843, 358);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(220, 51);
            this.guncelle.TabIndex = 11;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 456);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1241, 211);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcı Adı";
            this.columnHeader1.Width = 527;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Şifre";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adı Soyadı";
            this.columnHeader3.Width = 500;
            // 
            // PersonelYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 700);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.personelSil);
            this.Controls.Add(this.personelEkle);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.padsoyad);
            this.Controls.Add(this.psıfrar);
            this.Controls.Add(this.padı);
            this.Controls.Add(this.adiSoyadi);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullanıcıAdı);
            this.Controls.Add(this.peklemek);
            this.Controls.Add(this.pyonetmek);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelYonetimi";
            this.Load += new System.EventHandler(this.PersonelYonetimi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pyonetmek;
        private System.Windows.Forms.Label peklemek;
        private System.Windows.Forms.TextBox kullanıcıAdı;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox adiSoyadi;
        private System.Windows.Forms.Label padı;
        private System.Windows.Forms.Label psıfrar;
        private System.Windows.Forms.Label padsoyad;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Button personelEkle;
        private System.Windows.Forms.Button personelSil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}