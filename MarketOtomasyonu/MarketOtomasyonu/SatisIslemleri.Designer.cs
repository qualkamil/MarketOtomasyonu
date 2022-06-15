namespace MarketOtomasyonu
{
    partial class SatisIslemleri
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
            this.cıkısYap = new System.Windows.Forms.Button();
            this.odeme = new System.Windows.Forms.Button();
            this.urunEkle = new System.Windows.Forms.Button();
            this.barkodNo = new System.Windows.Forms.TextBox();
            this.BKN = new System.Windows.Forms.Label();
            this.urunuek = new System.Windows.Forms.Label();
            this.odemetur = new System.Windows.Forms.Label();
            this.kk = new System.Windows.Forms.RadioButton();
            this.nakit = new System.Windows.Forms.RadioButton();
            this.fıyat = new System.Windows.Forms.Label();
            this.topfıyat = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.satısle = new System.Windows.Forms.Label();
            this.satisListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.satisListe)).BeginInit();
            this.SuspendLayout();
            // 
            // cıkısYap
            // 
            this.cıkısYap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkısYap.Location = new System.Drawing.Point(426, 338);
            this.cıkısYap.Name = "cıkısYap";
            this.cıkısYap.Size = new System.Drawing.Size(148, 54);
            this.cıkısYap.TabIndex = 31;
            this.cıkısYap.Text = "Personel Paneline Dön";
            this.cıkısYap.UseVisualStyleBackColor = true;
            this.cıkısYap.Click += new System.EventHandler(this.cıkısYap_Click);
            // 
            // odeme
            // 
            this.odeme.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odeme.Location = new System.Drawing.Point(398, 297);
            this.odeme.Name = "odeme";
            this.odeme.Size = new System.Drawing.Size(208, 31);
            this.odeme.TabIndex = 30;
            this.odeme.Text = "Ödemeyi Onayla";
            this.odeme.UseVisualStyleBackColor = true;
            this.odeme.Click += new System.EventHandler(this.odeme_Click);
            // 
            // urunEkle
            // 
            this.urunEkle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunEkle.Location = new System.Drawing.Point(96, 298);
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(138, 30);
            this.urunEkle.TabIndex = 29;
            this.urunEkle.Text = "Ekle";
            this.urunEkle.UseVisualStyleBackColor = true;
            this.urunEkle.Click += new System.EventHandler(this.urunEkle_Click);
            // 
            // barkodNo
            // 
            this.barkodNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodNo.Location = new System.Drawing.Point(96, 267);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(138, 24);
            this.barkodNo.TabIndex = 27;
            // 
            // BKN
            // 
            this.BKN.AutoSize = true;
            this.BKN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BKN.Location = new System.Drawing.Point(7, 269);
            this.BKN.Name = "BKN";
            this.BKN.Size = new System.Drawing.Size(89, 17);
            this.BKN.TabIndex = 25;
            this.BKN.Text = "Barkod No :";
            // 
            // urunuek
            // 
            this.urunuek.AutoSize = true;
            this.urunuek.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunuek.Location = new System.Drawing.Point(10, 243);
            this.urunuek.Name = "urunuek";
            this.urunuek.Size = new System.Drawing.Size(96, 17);
            this.urunuek.TabIndex = 24;
            this.urunuek.Text = "Ürün Ekleme";
            // 
            // odemetur
            // 
            this.odemetur.AutoSize = true;
            this.odemetur.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemetur.Location = new System.Drawing.Point(394, 267);
            this.odemetur.Name = "odemetur";
            this.odemetur.Size = new System.Drawing.Size(56, 17);
            this.odemetur.TabIndex = 23;
            this.odemetur.Text = "Ödeme";
            // 
            // kk
            // 
            this.kk.AutoSize = true;
            this.kk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kk.Location = new System.Drawing.Point(531, 266);
            this.kk.Name = "kk";
            this.kk.Size = new System.Drawing.Size(102, 21);
            this.kk.TabIndex = 22;
            this.kk.TabStop = true;
            this.kk.Text = "Kredi Kartı";
            this.kk.UseVisualStyleBackColor = true;
            // 
            // nakit
            // 
            this.nakit.AutoSize = true;
            this.nakit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nakit.Location = new System.Drawing.Point(452, 267);
            this.nakit.Name = "nakit";
            this.nakit.Size = new System.Drawing.Size(62, 21);
            this.nakit.TabIndex = 21;
            this.nakit.TabStop = true;
            this.nakit.Text = "Nakit";
            this.nakit.UseVisualStyleBackColor = true;
            // 
            // fıyat
            // 
            this.fıyat.AutoSize = true;
            this.fıyat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fıyat.Location = new System.Drawing.Point(501, 222);
            this.fıyat.Name = "fıyat";
            this.fıyat.Size = new System.Drawing.Size(44, 17);
            this.fıyat.TabIndex = 20;
            this.fıyat.Text = "Fiyat ";
            // 
            // topfıyat
            // 
            this.topfıyat.AutoSize = true;
            this.topfıyat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topfıyat.Location = new System.Drawing.Point(384, 222);
            this.topfıyat.Name = "topfıyat";
            this.topfıyat.Size = new System.Drawing.Size(101, 17);
            this.topfıyat.TabIndex = 19;
            this.topfıyat.Text = "Toplam Fiyat :";
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.Location = new System.Drawing.Point(10, 196);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(152, 44);
            this.sil.TabIndex = 18;
            this.sil.Text = "Seçili Ürün Kaldır";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // satısle
            // 
            this.satısle.AutoSize = true;
            this.satısle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satısle.Location = new System.Drawing.Point(10, 7);
            this.satısle.Name = "satısle";
            this.satısle.Size = new System.Drawing.Size(103, 19);
            this.satısle.TabIndex = 16;
            this.satısle.Text = "Satış işlemleri";
            // 
            // satisListe
            // 
            this.satisListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisListe.Location = new System.Drawing.Point(13, 29);
            this.satisListe.Name = "satisListe";
            this.satisListe.Size = new System.Drawing.Size(593, 152);
            this.satisListe.TabIndex = 32;
            // 
            // SatisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 416);
            this.Controls.Add(this.satisListe);
            this.Controls.Add(this.cıkısYap);
            this.Controls.Add(this.odeme);
            this.Controls.Add(this.urunEkle);
            this.Controls.Add(this.barkodNo);
            this.Controls.Add(this.BKN);
            this.Controls.Add(this.urunuek);
            this.Controls.Add(this.odemetur);
            this.Controls.Add(this.kk);
            this.Controls.Add(this.nakit);
            this.Controls.Add(this.fıyat);
            this.Controls.Add(this.topfıyat);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.satısle);
            this.Name = "SatisIslemleri";
            this.Text = "SatisIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.satisListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cıkısYap;
        private System.Windows.Forms.Button odeme;
        private System.Windows.Forms.Button urunEkle;
        private System.Windows.Forms.TextBox barkodNo;
        private System.Windows.Forms.Label BKN;
        private System.Windows.Forms.Label urunuek;
        private System.Windows.Forms.Label odemetur;
        private System.Windows.Forms.RadioButton kk;
        private System.Windows.Forms.RadioButton nakit;
        private System.Windows.Forms.Label fıyat;
        private System.Windows.Forms.Label topfıyat;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label satısle;
        private System.Windows.Forms.DataGridView satisListe;
    }
}