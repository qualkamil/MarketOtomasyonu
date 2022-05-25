namespace MarketOtomasyonu
{
    partial class Stok_Takibi
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
            this.stoktakib = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.stokEkle = new System.Windows.Forms.Button();
            this.stokSil = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // stoktakib
            // 
            this.stoktakib.AutoSize = true;
            this.stoktakib.Location = new System.Drawing.Point(4, 9);
            this.stoktakib.Name = "stoktakib";
            this.stoktakib.Size = new System.Drawing.Size(84, 20);
            this.stoktakib.TabIndex = 0;
            this.stoktakib.Text = "Stok Takibi";
            // 
            // BKN
            // 
            this.BKN.AutoSize = true;
            this.BKN.Location = new System.Drawing.Point(4, 43);
            this.BKN.Name = "BKN";
            this.BKN.Size = new System.Drawing.Size(92, 20);
            this.BKN.TabIndex = 1;
            this.BKN.Text = "Barkod No :";
            this.BKN.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // SKadı
            // 
            this.SKadı.AutoSize = true;
            this.SKadı.Location = new System.Drawing.Point(4, 85);
            this.SKadı.Name = "SKadı";
            this.SKadı.Size = new System.Drawing.Size(76, 20);
            this.SKadı.TabIndex = 2;
            this.SKadı.Text = "Stok Adı :";
            this.SKadı.Click += new System.EventHandler(this.stokadı_Click);
            // 
            // Skm
            // 
            this.Skm.AutoSize = true;
            this.Skm.Location = new System.Drawing.Point(0, 124);
            this.Skm.Name = "Skm";
            this.Skm.Size = new System.Drawing.Size(96, 20);
            this.Skm.TabIndex = 3;
            this.Skm.Text = "Stok Marka :";
            // 
            // SKadedi
            // 
            this.SKadedi.AutoSize = true;
            this.SKadedi.Location = new System.Drawing.Point(0, 156);
            this.SKadedi.Name = "SKadedi";
            this.SKadedi.Size = new System.Drawing.Size(93, 20);
            this.SKadedi.TabIndex = 4;
            this.SKadedi.Text = "Stok Adedi :";
            // 
            // sonfıyat
            // 
            this.sonfıyat.AutoSize = true;
            this.sonfıyat.Location = new System.Drawing.Point(0, 210);
            this.sonfıyat.Name = "sonfıyat";
            this.sonfıyat.Size = new System.Drawing.Size(172, 20);
            this.sonfıyat.TabIndex = 5;
            this.sonfıyat.Text = "Son Alınan Birim Fiyat :";
            // 
            // sonadet
            // 
            this.sonadet.AutoSize = true;
            this.sonadet.Location = new System.Drawing.Point(0, 242);
            this.sonadet.Name = "sonadet";
            this.sonadet.Size = new System.Drawing.Size(139, 20);
            this.sonadet.TabIndex = 6;
            this.sonadet.Text = "Son Eklenen Adet :";
            // 
            // sontarihi
            // 
            this.sontarihi.AutoSize = true;
            this.sontarihi.Location = new System.Drawing.Point(4, 280);
            this.sontarihi.Name = "sontarihi";
            this.sontarihi.Size = new System.Drawing.Size(139, 20);
            this.sontarihi.TabIndex = 7;
            this.sontarihi.Text = "Son Eklenen Tarih :";
            // 
            // barkodNo
            // 
            this.barkodNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barkodNo.Location = new System.Drawing.Point(178, 37);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(141, 26);
            this.barkodNo.TabIndex = 8;
            this.barkodNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stokAdi
            // 
            this.stokAdi.Location = new System.Drawing.Point(178, 75);
            this.stokAdi.Name = "stokAdi";
            this.stokAdi.Size = new System.Drawing.Size(141, 27);
            this.stokAdi.TabIndex = 9;
            // 
            // stokMarka
            // 
            this.stokMarka.Enabled = false;
            this.stokMarka.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokMarka.Location = new System.Drawing.Point(178, 118);
            this.stokMarka.Name = "stokMarka";
            this.stokMarka.Size = new System.Drawing.Size(141, 26);
            this.stokMarka.TabIndex = 10;
            this.stokMarka.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // stokAdet
            // 
            this.stokAdet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokAdet.Location = new System.Drawing.Point(178, 156);
            this.stokAdet.Name = "stokAdet";
            this.stokAdet.Size = new System.Drawing.Size(141, 26);
            this.stokAdet.TabIndex = 11;
            // 
            // birimFiyat
            // 
            this.birimFiyat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birimFiyat.Location = new System.Drawing.Point(178, 204);
            this.birimFiyat.Name = "birimFiyat";
            this.birimFiyat.Size = new System.Drawing.Size(141, 26);
            this.birimFiyat.TabIndex = 12;
            this.birimFiyat.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // sonEklenenAdet
            // 
            this.sonEklenenAdet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonEklenenAdet.Location = new System.Drawing.Point(174, 242);
            this.sonEklenenAdet.Name = "sonEklenenAdet";
            this.sonEklenenAdet.Size = new System.Drawing.Size(145, 26);
            this.sonEklenenAdet.TabIndex = 13;
            this.sonEklenenAdet.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // sonEklenennTarih
            // 
            this.sonEklenennTarih.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonEklenennTarih.Location = new System.Drawing.Point(174, 274);
            this.sonEklenennTarih.Name = "sonEklenennTarih";
            this.sonEklenennTarih.Size = new System.Drawing.Size(145, 23);
            this.sonEklenennTarih.TabIndex = 14;
            this.sonEklenennTarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // BKNarama
            // 
            this.BKNarama.AutoSize = true;
            this.BKNarama.Location = new System.Drawing.Point(397, 37);
            this.BKNarama.Name = "BKNarama";
            this.BKNarama.Size = new System.Drawing.Size(155, 20);
            this.BKNarama.TabIndex = 15;
            this.BKNarama.Text = "Barkod No ile Arama";
            this.BKNarama.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // barkodNoArama
            // 
            this.barkodNoArama.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barkodNoArama.Location = new System.Drawing.Point(401, 60);
            this.barkodNoArama.Name = "barkodNoArama";
            this.barkodNoArama.Size = new System.Drawing.Size(151, 26);
            this.barkodNoArama.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 17;
            // 
            // barkodArama
            // 
            this.barkodArama.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodArama.Location = new System.Drawing.Point(401, 92);
            this.barkodArama.Name = "barkodArama";
            this.barkodArama.Size = new System.Drawing.Size(142, 48);
            this.barkodArama.TabIndex = 18;
            this.barkodArama.Text = "Ara";
            this.barkodArama.UseVisualStyleBackColor = true;
            // 
            // SKadıaramak
            // 
            this.SKadıaramak.AutoSize = true;
            this.SKadıaramak.Location = new System.Drawing.Point(397, 162);
            this.SKadıaramak.Name = "SKadıaramak";
            this.SKadıaramak.Size = new System.Drawing.Size(139, 20);
            this.SKadıaramak.TabIndex = 19;
            this.SKadıaramak.Text = "Stok Adı ile Arama";
            this.SKadıaramak.Click += new System.EventHandler(this.label3_Click);
            // 
            // stokAdiArama
            // 
            this.stokAdiArama.Location = new System.Drawing.Point(387, 185);
            this.stokAdiArama.Name = "stokAdiArama";
            this.stokAdiArama.Size = new System.Drawing.Size(165, 27);
            this.stokAdiArama.TabIndex = 20;
            this.stokAdiArama.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(387, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisYap.Location = new System.Drawing.Point(624, 77);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(164, 63);
            this.cikisYap.TabIndex = 22;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            // 
            // stokEkle
            // 
            this.stokEkle.Location = new System.Drawing.Point(12, 334);
            this.stokEkle.Name = "stokEkle";
            this.stokEkle.Size = new System.Drawing.Size(111, 35);
            this.stokEkle.TabIndex = 23;
            this.stokEkle.Text = "Stok Ekle";
            this.stokEkle.UseVisualStyleBackColor = true;
            // 
            // stokSil
            // 
            this.stokSil.Location = new System.Drawing.Point(152, 334);
            this.stokSil.Name = "stokSil";
            this.stokSil.Size = new System.Drawing.Size(106, 35);
            this.stokSil.TabIndex = 24;
            this.stokSil.Text = "stok Sil";
            this.stokSil.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(281, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 35);
            this.button4.TabIndex = 25;
            this.button4.Text = "stokGüncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 376);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 62);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BarkodNo";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stok Adı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stok Marka";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stok Adedi";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Son Alınan Birim Fiyat";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Son EklenenAdet";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Son Eklenen Tarih";
            this.columnHeader7.Width = 115;
            // 
            // Stok_Takibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.stokSil);
            this.Controls.Add(this.stokEkle);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.stoktakib);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Stok_Takibi";
            this.Text = "Stok_Takibi";
            this.Load += new System.EventHandler(this.Stok_Takibi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stoktakib;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Button stokEkle;
        private System.Windows.Forms.Button stokSil;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}