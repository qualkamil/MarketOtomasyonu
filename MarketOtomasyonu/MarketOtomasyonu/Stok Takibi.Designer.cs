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
            System.Windows.Forms.ColumnHeader columnHeader1;
            this.stoktakib = new System.Windows.Forms.Label();
            this.barkodno = new System.Windows.Forms.Label();
            this.stokadı = new System.Windows.Forms.Label();
            this.stokmarkaad = new System.Windows.Forms.Label();
            this.stokadedı = new System.Windows.Forms.Label();
            this.sonfıyat = new System.Windows.Forms.Label();
            this.soneklenenadet = new System.Windows.Forms.Label();
            this.sontarıh = new System.Windows.Forms.Label();
            this.BarKod = new System.Windows.Forms.TextBox();
            this.stokAdi = new System.Windows.Forms.TextBox();
            this.StokMarka = new System.Windows.Forms.TextBox();
            this.StokAdet = new System.Windows.Forms.TextBox();
            this.birimFiyat = new System.Windows.Forms.TextBox();
            this.sonEklenenTarih = new System.Windows.Forms.TextBox();
            this.sonEklenennTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.barkodNoİleArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butara1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stokAdiArama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ypdon = new System.Windows.Forms.Button();
            this.sek = new System.Windows.Forms.Button();
            this.ssil = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // stoktakib
            // 
            this.stoktakib.AutoSize = true;
            this.stoktakib.Location = new System.Drawing.Point(13, 13);
            this.stoktakib.Name = "stoktakib";
            this.stoktakib.Size = new System.Drawing.Size(84, 20);
            this.stoktakib.TabIndex = 0;
            this.stoktakib.Text = "Stok Takibi";
            // 
            // barkodno
            // 
            this.barkodno.AutoSize = true;
            this.barkodno.Location = new System.Drawing.Point(12, 57);
            this.barkodno.Name = "barkodno";
            this.barkodno.Size = new System.Drawing.Size(92, 20);
            this.barkodno.TabIndex = 1;
            this.barkodno.Text = "Barkod No :";
            this.barkodno.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // stokadı
            // 
            this.stokadı.AutoSize = true;
            this.stokadı.Location = new System.Drawing.Point(12, 108);
            this.stokadı.Name = "stokadı";
            this.stokadı.Size = new System.Drawing.Size(76, 20);
            this.stokadı.TabIndex = 2;
            this.stokadı.Text = "Stok Adı :";
            this.stokadı.Click += new System.EventHandler(this.stokadı_Click);
            // 
            // stokmarkaad
            // 
            this.stokmarkaad.AutoSize = true;
            this.stokmarkaad.Location = new System.Drawing.Point(12, 156);
            this.stokmarkaad.Name = "stokmarkaad";
            this.stokmarkaad.Size = new System.Drawing.Size(96, 20);
            this.stokmarkaad.TabIndex = 3;
            this.stokmarkaad.Text = "Stok Marka :";
            // 
            // stokadedı
            // 
            this.stokadedı.AutoSize = true;
            this.stokadedı.Location = new System.Drawing.Point(12, 211);
            this.stokadedı.Name = "stokadedı";
            this.stokadedı.Size = new System.Drawing.Size(93, 20);
            this.stokadedı.TabIndex = 4;
            this.stokadedı.Text = "Stok Adedi :";
            // 
            // sonfıyat
            // 
            this.sonfıyat.AutoSize = true;
            this.sonfıyat.Location = new System.Drawing.Point(12, 263);
            this.sonfıyat.Name = "sonfıyat";
            this.sonfıyat.Size = new System.Drawing.Size(172, 20);
            this.sonfıyat.TabIndex = 5;
            this.sonfıyat.Text = "Son Alınan Birim Fiyat :";
            // 
            // soneklenenadet
            // 
            this.soneklenenadet.AutoSize = true;
            this.soneklenenadet.Location = new System.Drawing.Point(12, 324);
            this.soneklenenadet.Name = "soneklenenadet";
            this.soneklenenadet.Size = new System.Drawing.Size(139, 20);
            this.soneklenenadet.TabIndex = 6;
            this.soneklenenadet.Text = "Son Eklenen Adet :";
            // 
            // sontarıh
            // 
            this.sontarıh.AutoSize = true;
            this.sontarıh.Location = new System.Drawing.Point(12, 376);
            this.sontarıh.Name = "sontarıh";
            this.sontarıh.Size = new System.Drawing.Size(139, 20);
            this.sontarıh.TabIndex = 7;
            this.sontarıh.Text = "Son Eklenen Tarih :";
            // 
            // BarKod
            // 
            this.BarKod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarKod.Location = new System.Drawing.Point(190, 57);
            this.BarKod.Name = "BarKod";
            this.BarKod.Size = new System.Drawing.Size(201, 26);
            this.BarKod.TabIndex = 8;
            this.BarKod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stokAdi
            // 
            this.stokAdi.Location = new System.Drawing.Point(190, 108);
            this.stokAdi.Name = "stokAdi";
            this.stokAdi.Size = new System.Drawing.Size(200, 27);
            this.stokAdi.TabIndex = 9;
            // 
            // StokMarka
            // 
            this.StokMarka.Enabled = false;
            this.StokMarka.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokMarka.Location = new System.Drawing.Point(190, 156);
            this.StokMarka.Name = "StokMarka";
            this.StokMarka.Size = new System.Drawing.Size(200, 26);
            this.StokMarka.TabIndex = 10;
            this.StokMarka.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // StokAdet
            // 
            this.StokAdet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokAdet.Location = new System.Drawing.Point(191, 204);
            this.StokAdet.Name = "StokAdet";
            this.StokAdet.Size = new System.Drawing.Size(200, 26);
            this.StokAdet.TabIndex = 11;
            // 
            // birimFiyat
            // 
            this.birimFiyat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birimFiyat.Location = new System.Drawing.Point(191, 263);
            this.birimFiyat.Name = "birimFiyat";
            this.birimFiyat.Size = new System.Drawing.Size(200, 26);
            this.birimFiyat.TabIndex = 12;
            this.birimFiyat.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // sonEklenenTarih
            // 
            this.sonEklenenTarih.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonEklenenTarih.Location = new System.Drawing.Point(191, 324);
            this.sonEklenenTarih.Name = "sonEklenenTarih";
            this.sonEklenenTarih.Size = new System.Drawing.Size(200, 26);
            this.sonEklenenTarih.TabIndex = 13;
            this.sonEklenenTarih.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // sonEklenennTarih
            // 
            this.sonEklenennTarih.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonEklenennTarih.Location = new System.Drawing.Point(191, 376);
            this.sonEklenennTarih.Name = "sonEklenennTarih";
            this.sonEklenennTarih.Size = new System.Drawing.Size(200, 26);
            this.sonEklenennTarih.TabIndex = 14;
            this.sonEklenennTarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Barkod No ile Arama";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // barkodNoİleArama
            // 
            this.barkodNoİleArama.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barkodNoİleArama.Location = new System.Drawing.Point(499, 108);
            this.barkodNoİleArama.Name = "barkodNoİleArama";
            this.barkodNoİleArama.Size = new System.Drawing.Size(165, 26);
            this.barkodNoİleArama.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 17;
            // 
            // butara1
            // 
            this.butara1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butara1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butara1.Location = new System.Drawing.Point(499, 156);
            this.butara1.Name = "butara1";
            this.butara1.Size = new System.Drawing.Size(165, 52);
            this.butara1.TabIndex = 18;
            this.butara1.Text = "Ara";
            this.butara1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Stok Adı ile Arama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // stokAdiArama
            // 
            this.stokAdiArama.Location = new System.Drawing.Point(502, 294);
            this.stokAdiArama.Name = "stokAdiArama";
            this.stokAdiArama.Size = new System.Drawing.Size(165, 27);
            this.stokAdiArama.TabIndex = 20;
            this.stokAdiArama.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(499, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 62);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ypdon
            // 
            this.ypdon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ypdon.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ypdon.Location = new System.Drawing.Point(953, 108);
            this.ypdon.Name = "ypdon";
            this.ypdon.Size = new System.Drawing.Size(251, 100);
            this.ypdon.TabIndex = 22;
            this.ypdon.Text = "Yönetici Paneline Dön";
            this.ypdon.UseVisualStyleBackColor = true;
            // 
            // sek
            // 
            this.sek.Location = new System.Drawing.Point(12, 472);
            this.sek.Name = "sek";
            this.sek.Size = new System.Drawing.Size(137, 35);
            this.sek.TabIndex = 23;
            this.sek.Text = "Stok Ekle";
            this.sek.UseVisualStyleBackColor = true;
            // 
            // ssil
            // 
            this.ssil.Location = new System.Drawing.Point(174, 472);
            this.ssil.Name = "ssil";
            this.ssil.Size = new System.Drawing.Size(137, 35);
            this.ssil.TabIndex = 24;
            this.ssil.Text = "stok Sil";
            this.ssil.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(339, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 35);
            this.button4.TabIndex = 25;
            this.button4.Text = "Stok Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 532);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1305, 156);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 0;
            columnHeader1.Text = "Stok Adı";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "BarkodNo";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stok Marka";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stok Adedi";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Son Alınan Birim Fiyat";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Son Eklenen Adet";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "son EklenenTarih";
            this.columnHeader7.Width = 229;
            // 
            // Stok_Takibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 700);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ssil);
            this.Controls.Add(this.sek);
            this.Controls.Add(this.ypdon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stokAdiArama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butara1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barkodNoİleArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sonEklenennTarih);
            this.Controls.Add(this.sonEklenenTarih);
            this.Controls.Add(this.birimFiyat);
            this.Controls.Add(this.StokAdet);
            this.Controls.Add(this.StokMarka);
            this.Controls.Add(this.stokAdi);
            this.Controls.Add(this.BarKod);
            this.Controls.Add(this.sontarıh);
            this.Controls.Add(this.soneklenenadet);
            this.Controls.Add(this.sonfıyat);
            this.Controls.Add(this.stokadedı);
            this.Controls.Add(this.stokmarkaad);
            this.Controls.Add(this.stokadı);
            this.Controls.Add(this.barkodno);
            this.Controls.Add(this.stoktakib);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stok_Takibi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok_Takibi";
            this.Load += new System.EventHandler(this.Stok_Takibi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stoktakib;
        private System.Windows.Forms.Label barkodno;
        private System.Windows.Forms.Label stokadı;
        private System.Windows.Forms.Label stokmarkaad;
        private System.Windows.Forms.Label stokadedı;
        private System.Windows.Forms.Label sonfıyat;
        private System.Windows.Forms.Label soneklenenadet;
        private System.Windows.Forms.Label sontarıh;
        private System.Windows.Forms.TextBox BarKod;
        private System.Windows.Forms.TextBox stokAdi;
        private System.Windows.Forms.TextBox StokMarka;
        private System.Windows.Forms.TextBox StokAdet;
        private System.Windows.Forms.TextBox birimFiyat;
        private System.Windows.Forms.TextBox sonEklenenTarih;
        private System.Windows.Forms.DateTimePicker sonEklenennTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barkodNoİleArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butara1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stokAdiArama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ypdon;
        private System.Windows.Forms.Button sek;
        private System.Windows.Forms.Button ssil;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}