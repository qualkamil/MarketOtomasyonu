namespace MarketOtomasyonu
{
    partial class StokTakibi
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
            this.label1 = new System.Windows.Forms.Label();
            this.BKN = new System.Windows.Forms.Label();
            this.SKadı = new System.Windows.Forms.Label();
            this.Skm = new System.Windows.Forms.Label();
            this.SKadedi = new System.Windows.Forms.Label();
            this.sonfıyat = new System.Windows.Forms.Label();
            this.sonadet = new System.Windows.Forms.Label();
            this.sontarihi = new System.Windows.Forms.Label();
            this.barkodNo = new System.Windows.Forms.TextBox();
            this.stokAdi = new System.Windows.Forms.TextBox();
            this.stokMarka = new System.Windows.Forms.TextBox();
            this.stokAdet = new System.Windows.Forms.TextBox();
            this.birimFiyat = new System.Windows.Forms.TextBox();
            this.sonEklenenAdet = new System.Windows.Forms.TextBox();
            this.sonEklenennTarih = new System.Windows.Forms.DateTimePicker();
            this.BKNarama = new System.Windows.Forms.Label();
            this.barkodNoArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barkodArama = new System.Windows.Forms.Button();
            this.SKadıaramak = new System.Windows.Forms.Label();
            this.stokAdiArama = new System.Windows.Forms.TextBox();
            this.StokAdArama = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.stokEkle = new System.Windows.Forms.Button();
            this.stokSil = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.stokListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stokListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Takibi";
            // 
            // BKN
            // 
            this.BKN.AutoSize = true;
            this.BKN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BKN.Location = new System.Drawing.Point(4, 30);
            this.BKN.Name = "BKN";
            this.BKN.Size = new System.Drawing.Size(89, 17);
            this.BKN.TabIndex = 1;
            this.BKN.Text = "Barkod No :";
            // 
            // SKadı
            // 
            this.SKadı.AutoSize = true;
            this.SKadı.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SKadı.Location = new System.Drawing.Point(4, 55);
            this.SKadı.Name = "SKadı";
            this.SKadı.Size = new System.Drawing.Size(73, 17);
            this.SKadı.TabIndex = 2;
            this.SKadı.Text = "Stok Adı :";
            // 
            // Skm
            // 
            this.Skm.AutoSize = true;
            this.Skm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skm.Location = new System.Drawing.Point(4, 80);
            this.Skm.Name = "Skm";
            this.Skm.Size = new System.Drawing.Size(95, 17);
            this.Skm.TabIndex = 3;
            this.Skm.Text = "Stok Marka :";
            // 
            // SKadedi
            // 
            this.SKadedi.AutoSize = true;
            this.SKadedi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SKadedi.Location = new System.Drawing.Point(4, 105);
            this.SKadedi.Name = "SKadedi";
            this.SKadedi.Size = new System.Drawing.Size(89, 17);
            this.SKadedi.TabIndex = 4;
            this.SKadedi.Text = "Stok Adedi :";
            // 
            // sonfıyat
            // 
            this.sonfıyat.AutoSize = true;
            this.sonfıyat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonfıyat.Location = new System.Drawing.Point(4, 130);
            this.sonfıyat.Name = "sonfıyat";
            this.sonfıyat.Size = new System.Drawing.Size(163, 17);
            this.sonfıyat.TabIndex = 5;
            this.sonfıyat.Text = "Son Alınan Birim Fiyat :";
            // 
            // sonadet
            // 
            this.sonadet.AutoSize = true;
            this.sonadet.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonadet.Location = new System.Drawing.Point(4, 155);
            this.sonadet.Name = "sonadet";
            this.sonadet.Size = new System.Drawing.Size(135, 17);
            this.sonadet.TabIndex = 6;
            this.sonadet.Text = "Son Eklenen Adet :";
            // 
            // sontarihi
            // 
            this.sontarihi.AutoSize = true;
            this.sontarihi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sontarihi.Location = new System.Drawing.Point(3, 180);
            this.sontarihi.Name = "sontarihi";
            this.sontarihi.Size = new System.Drawing.Size(138, 17);
            this.sontarihi.TabIndex = 7;
            this.sontarihi.Text = "Son Eklenen Tarih :";
            // 
            // barkodNo
            // 
            this.barkodNo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.barkodNo.Location = new System.Drawing.Point(208, 30);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(194, 24);
            this.barkodNo.TabIndex = 8;
            // 
            // stokAdi
            // 
            this.stokAdi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokAdi.Location = new System.Drawing.Point(208, 55);
            this.stokAdi.Name = "stokAdi";
            this.stokAdi.Size = new System.Drawing.Size(194, 24);
            this.stokAdi.TabIndex = 9;
            // 
            // stokMarka
            // 
            this.stokMarka.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokMarka.Location = new System.Drawing.Point(208, 80);
            this.stokMarka.Name = "stokMarka";
            this.stokMarka.Size = new System.Drawing.Size(194, 24);
            this.stokMarka.TabIndex = 10;
            // 
            // stokAdet
            // 
            this.stokAdet.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokAdet.Location = new System.Drawing.Point(208, 105);
            this.stokAdet.Name = "stokAdet";
            this.stokAdet.Size = new System.Drawing.Size(194, 24);
            this.stokAdet.TabIndex = 11;
            // 
            // birimFiyat
            // 
            this.birimFiyat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimFiyat.Location = new System.Drawing.Point(208, 130);
            this.birimFiyat.Name = "birimFiyat";
            this.birimFiyat.Size = new System.Drawing.Size(194, 24);
            this.birimFiyat.TabIndex = 12;
            // 
            // sonEklenenAdet
            // 
            this.sonEklenenAdet.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonEklenenAdet.Location = new System.Drawing.Point(208, 155);
            this.sonEklenenAdet.Name = "sonEklenenAdet";
            this.sonEklenenAdet.Size = new System.Drawing.Size(194, 24);
            this.sonEklenenAdet.TabIndex = 13;
            // 
            // sonEklenennTarih
            // 
            this.sonEklenennTarih.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonEklenennTarih.Location = new System.Drawing.Point(208, 180);
            this.sonEklenennTarih.Name = "sonEklenennTarih";
            this.sonEklenennTarih.Size = new System.Drawing.Size(194, 24);
            this.sonEklenennTarih.TabIndex = 14;
            // 
            // BKNarama
            // 
            this.BKNarama.AutoSize = true;
            this.BKNarama.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BKNarama.Location = new System.Drawing.Point(523, 35);
            this.BKNarama.Name = "BKNarama";
            this.BKNarama.Size = new System.Drawing.Size(146, 17);
            this.BKNarama.TabIndex = 15;
            this.BKNarama.Text = "Barkod No ile Arama";
            // 
            // barkodNoArama
            // 
            this.barkodNoArama.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodNoArama.Location = new System.Drawing.Point(526, 55);
            this.barkodNoArama.Name = "barkodNoArama";
            this.barkodNoArama.Size = new System.Drawing.Size(165, 24);
            this.barkodNoArama.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 17;
            // 
            // barkodArama
            // 
            this.barkodArama.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodArama.Location = new System.Drawing.Point(526, 86);
            this.barkodArama.Name = "barkodArama";
            this.barkodArama.Size = new System.Drawing.Size(135, 48);
            this.barkodArama.TabIndex = 18;
            this.barkodArama.Text = "Ara";
            this.barkodArama.UseVisualStyleBackColor = true;
            this.barkodArama.Click += new System.EventHandler(this.barkodArama_Click);
            // 
            // SKadıaramak
            // 
            this.SKadıaramak.AutoSize = true;
            this.SKadıaramak.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SKadıaramak.Location = new System.Drawing.Point(523, 142);
            this.SKadıaramak.Name = "SKadıaramak";
            this.SKadıaramak.Size = new System.Drawing.Size(130, 17);
            this.SKadıaramak.TabIndex = 19;
            this.SKadıaramak.Text = "Stok Adı ile Arama";
            // 
            // stokAdiArama
            // 
            this.stokAdiArama.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokAdiArama.Location = new System.Drawing.Point(526, 162);
            this.stokAdiArama.Name = "stokAdiArama";
            this.stokAdiArama.Size = new System.Drawing.Size(165, 24);
            this.stokAdiArama.TabIndex = 20;
            // 
            // StokAdArama
            // 
            this.StokAdArama.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StokAdArama.Location = new System.Drawing.Point(526, 192);
            this.StokAdArama.Name = "StokAdArama";
            this.StokAdArama.Size = new System.Drawing.Size(142, 64);
            this.StokAdArama.TabIndex = 21;
            this.StokAdArama.Text = "Ara";
            this.StokAdArama.UseVisualStyleBackColor = true;
            this.StokAdArama.Click += new System.EventHandler(this.StokAdArama_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisYap.Location = new System.Drawing.Point(789, 43);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(164, 63);
            this.cikisYap.TabIndex = 22;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // stokEkle
            // 
            this.stokEkle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokEkle.Location = new System.Drawing.Point(6, 209);
            this.stokEkle.Name = "stokEkle";
            this.stokEkle.Size = new System.Drawing.Size(136, 47);
            this.stokEkle.TabIndex = 23;
            this.stokEkle.Text = "Stok Ekle";
            this.stokEkle.UseVisualStyleBackColor = true;
            this.stokEkle.Click += new System.EventHandler(this.stokEkle_Click);
            // 
            // stokSil
            // 
            this.stokSil.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokSil.Location = new System.Drawing.Point(157, 210);
            this.stokSil.Name = "stokSil";
            this.stokSil.Size = new System.Drawing.Size(115, 47);
            this.stokSil.TabIndex = 24;
            this.stokSil.Text = "Stok Sil";
            this.stokSil.UseVisualStyleBackColor = true;
            this.stokSil.Click += new System.EventHandler(this.stokSil_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(294, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 47);
            this.button4.TabIndex = 25;
            this.button4.Text = "Stok Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listele
            // 
            this.listele.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listele.Location = new System.Drawing.Point(780, 197);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(164, 59);
            this.listele.TabIndex = 27;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // stokListe
            // 
            this.stokListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokListe.Location = new System.Drawing.Point(7, 263);
            this.stokListe.Name = "stokListe";
            this.stokListe.Size = new System.Drawing.Size(946, 340);
            this.stokListe.TabIndex = 28;
            this.stokListe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.stokListe_RowEnter);
            // 
            // StokTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(965, 615);
            this.Controls.Add(this.stokListe);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.stokSil);
            this.Controls.Add(this.stokEkle);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.StokAdArama);
            this.Controls.Add(this.stokAdiArama);
            this.Controls.Add(this.SKadıaramak);
            this.Controls.Add(this.barkodArama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barkodNoArama);
            this.Controls.Add(this.BKNarama);
            this.Controls.Add(this.sonEklenennTarih);
            this.Controls.Add(this.sonEklenenAdet);
            this.Controls.Add(this.birimFiyat);
            this.Controls.Add(this.stokAdet);
            this.Controls.Add(this.stokMarka);
            this.Controls.Add(this.stokAdi);
            this.Controls.Add(this.barkodNo);
            this.Controls.Add(this.sontarihi);
            this.Controls.Add(this.sonadet);
            this.Controls.Add(this.sonfıyat);
            this.Controls.Add(this.SKadedi);
            this.Controls.Add(this.Skm);
            this.Controls.Add(this.SKadı);
            this.Controls.Add(this.BKN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "StokTakibi";
            this.Text = "Stok_Takibi";
            this.Load += new System.EventHandler(this.StokTakibi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BKN;
        private System.Windows.Forms.Label SKadı;
        private System.Windows.Forms.Label Skm;
        private System.Windows.Forms.Label SKadedi;
        private System.Windows.Forms.Label sonfıyat;
        private System.Windows.Forms.Label sonadet;
        private System.Windows.Forms.Label sontarihi;
        private System.Windows.Forms.TextBox barkodNo;
        private System.Windows.Forms.TextBox stokAdi;
        private System.Windows.Forms.TextBox stokMarka;
        private System.Windows.Forms.TextBox stokAdet;
        private System.Windows.Forms.TextBox birimFiyat;
        private System.Windows.Forms.TextBox sonEklenenAdet;
        private System.Windows.Forms.DateTimePicker sonEklenennTarih;
        private System.Windows.Forms.Label BKNarama;
        private System.Windows.Forms.TextBox barkodNoArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button barkodArama;
        private System.Windows.Forms.Label SKadıaramak;
        private System.Windows.Forms.TextBox stokAdiArama;
        private System.Windows.Forms.Button StokAdArama;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Button stokEkle;
        private System.Windows.Forms.Button stokSil;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.DataGridView stokListe;
    }
}