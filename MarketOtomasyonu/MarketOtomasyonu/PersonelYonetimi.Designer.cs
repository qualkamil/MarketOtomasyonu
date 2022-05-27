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
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.adiSoyadi = new System.Windows.Forms.TextBox();
            this.padı = new System.Windows.Forms.Label();
            this.psıfrar = new System.Windows.Forms.Label();
            this.padsoyad = new System.Windows.Forms.Label();
            this.cikisYap = new System.Windows.Forms.Button();
            this.personelEkle = new System.Windows.Forms.Button();
            this.personelSil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pyonetmek
            // 
            this.pyonetmek.AutoSize = true;
            this.pyonetmek.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyonetmek.Location = new System.Drawing.Point(3, 9);
            this.pyonetmek.Name = "pyonetmek";
            this.pyonetmek.Size = new System.Drawing.Size(162, 23);
            this.pyonetmek.TabIndex = 0;
            this.pyonetmek.Text = "Personel Yönetimi";
            // 
            // peklemek
            // 
            this.peklemek.AutoSize = true;
            this.peklemek.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peklemek.Location = new System.Drawing.Point(12, 55);
            this.peklemek.Name = "peklemek";
            this.peklemek.Size = new System.Drawing.Size(148, 22);
            this.peklemek.TabIndex = 1;
            this.peklemek.Text = "Personel Ekleme";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdi.Location = new System.Drawing.Point(159, 111);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(223, 28);
            this.kullaniciAdi.TabIndex = 2;
            // 
            // sifre
            // 
            this.sifre.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(159, 171);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(223, 28);
            this.sifre.TabIndex = 3;
            // 
            // adiSoyadi
            // 
            this.adiSoyadi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adiSoyadi.Location = new System.Drawing.Point(159, 223);
            this.adiSoyadi.Name = "adiSoyadi";
            this.adiSoyadi.Size = new System.Drawing.Size(223, 28);
            this.adiSoyadi.TabIndex = 4;
            // 
            // padı
            // 
            this.padı.AutoSize = true;
            this.padı.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padı.Location = new System.Drawing.Point(19, 114);
            this.padı.Name = "padı";
            this.padı.Size = new System.Drawing.Size(125, 22);
            this.padı.TabIndex = 5;
            this.padı.Text = "Kullanıcı Adı :";
            this.padı.Click += new System.EventHandler(this.label3_Click);
            // 
            // psıfrar
            // 
            this.psıfrar.AutoSize = true;
            this.psıfrar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psıfrar.Location = new System.Drawing.Point(19, 170);
            this.psıfrar.Name = "psıfrar";
            this.psıfrar.Size = new System.Drawing.Size(59, 22);
            this.psıfrar.TabIndex = 6;
            this.psıfrar.Text = "Şifre :";
            this.psıfrar.Click += new System.EventHandler(this.label4_Click);
            // 
            // padsoyad
            // 
            this.padsoyad.AutoSize = true;
            this.padsoyad.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padsoyad.Location = new System.Drawing.Point(16, 226);
            this.padsoyad.Name = "padsoyad";
            this.padsoyad.Size = new System.Drawing.Size(108, 22);
            this.padsoyad.TabIndex = 7;
            this.padsoyad.Text = "Adı Soyadı :";
            this.padsoyad.Click += new System.EventHandler(this.label5_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisYap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisYap.Location = new System.Drawing.Point(529, 108);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(227, 85);
            this.cikisYap.TabIndex = 8;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // personelEkle
            // 
            this.personelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelEkle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelEkle.Location = new System.Drawing.Point(159, 278);
            this.personelEkle.Name = "personelEkle";
            this.personelEkle.Size = new System.Drawing.Size(162, 51);
            this.personelEkle.TabIndex = 9;
            this.personelEkle.Text = "Personel Ekle";
            this.personelEkle.UseVisualStyleBackColor = true;
            this.personelEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // personelSil
            // 
            this.personelSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelSil.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelSil.Location = new System.Drawing.Point(375, 278);
            this.personelSil.Name = "personelSil";
            this.personelSil.Size = new System.Drawing.Size(155, 51);
            this.personelSil.TabIndex = 10;
            this.personelSil.Text = "Sil";
            this.personelSil.UseVisualStyleBackColor = true;
            this.personelSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // guncelle
            // 
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelle.Location = new System.Drawing.Point(597, 278);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(159, 51);
            this.guncelle.TabIndex = 11;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(7, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(791, 112);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kullanıcı Adı";
            this.Column1.Name = "Column1";
            this.Column1.Width = 296;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Şifre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adı Soyadı";
            this.Column3.Name = "Column3";
            this.Column3.Width = 295;
            // 
            // PersonelYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.personelSil);
            this.Controls.Add(this.personelEkle);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.padsoyad);
            this.Controls.Add(this.psıfrar);
            this.Controls.Add(this.padı);
            this.Controls.Add(this.adiSoyadi);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.peklemek);
            this.Controls.Add(this.pyonetmek);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PersonelYonetimi";
            this.Text = "PersonelYonetimi";
            this.Load += new System.EventHandler(this.PersonelYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pyonetmek;
        private System.Windows.Forms.Label peklemek;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox adiSoyadi;
        private System.Windows.Forms.Label padı;
        private System.Windows.Forms.Label psıfrar;
        private System.Windows.Forms.Label padsoyad;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Button personelEkle;
        private System.Windows.Forms.Button personelSil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}