﻿namespace MarketOtomasyonu
{
    partial class Satisıslemleri
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
            this.satısle = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sil = new System.Windows.Forms.Button();
            this.topfıyat = new System.Windows.Forms.Label();
            this.fıyat = new System.Windows.Forms.Label();
            this.nakıt = new System.Windows.Forms.RadioButton();
            this.kk = new System.Windows.Forms.RadioButton();
            this.odemetur = new System.Windows.Forms.Label();
            this.urunuek = new System.Windows.Forms.Label();
            this.BKN = new System.Windows.Forms.Label();
            this.adett = new System.Windows.Forms.Label();
            this.barkodNo = new System.Windows.Forms.TextBox();
            this.urunAdedi = new System.Windows.Forms.TextBox();
            this.urunEkle = new System.Windows.Forms.Button();
            this.odeme = new System.Windows.Forms.Button();
            this.cıkısYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // satısle
            // 
            this.satısle.AutoSize = true;
            this.satısle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satısle.Location = new System.Drawing.Point(12, 9);
            this.satısle.Name = "satısle";
            this.satısle.Size = new System.Drawing.Size(150, 28);
            this.satısle.TabIndex = 0;
            this.satısle.Text = "Satış işlemleri";
            this.satısle.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 145);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Barkod No";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Adı";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürün Marka";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Adet";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Satış Fiyati";
            this.columnHeader9.Width = 200;
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.Location = new System.Drawing.Point(12, 220);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(188, 48);
            this.sil.TabIndex = 2;
            this.sil.Text = "Seçili Ürün Kaldır";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // topfıyat
            // 
            this.topfıyat.AutoSize = true;
            this.topfıyat.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topfıyat.Location = new System.Drawing.Point(468, 220);
            this.topfıyat.Name = "topfıyat";
            this.topfıyat.Size = new System.Drawing.Size(96, 17);
            this.topfıyat.TabIndex = 3;
            this.topfıyat.Text = "Toplam Fiyat :";
            this.topfıyat.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // fıyat
            // 
            this.fıyat.AutoSize = true;
            this.fıyat.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fıyat.Location = new System.Drawing.Point(605, 220);
            this.fıyat.Name = "fıyat";
            this.fıyat.Size = new System.Drawing.Size(42, 17);
            this.fıyat.TabIndex = 4;
            this.fıyat.Text = "Fiyat ";
            // 
            // nakıt
            // 
            this.nakıt.AutoSize = true;
            this.nakıt.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nakıt.Location = new System.Drawing.Point(552, 269);
            this.nakıt.Name = "nakıt";
            this.nakıt.Size = new System.Drawing.Size(62, 21);
            this.nakıt.TabIndex = 5;
            this.nakıt.TabStop = true;
            this.nakıt.Text = "Nakit";
            this.nakıt.UseVisualStyleBackColor = true;
            this.nakıt.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // kk
            // 
            this.kk.AutoSize = true;
            this.kk.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kk.Location = new System.Drawing.Point(648, 271);
            this.kk.Name = "kk";
            this.kk.Size = new System.Drawing.Size(94, 21);
            this.kk.TabIndex = 6;
            this.kk.TabStop = true;
            this.kk.Text = "Kredi Kartı";
            this.kk.UseVisualStyleBackColor = true;
            // 
            // odemetur
            // 
            this.odemetur.AutoSize = true;
            this.odemetur.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odemetur.Location = new System.Drawing.Point(477, 273);
            this.odemetur.Name = "odemetur";
            this.odemetur.Size = new System.Drawing.Size(52, 17);
            this.odemetur.TabIndex = 7;
            this.odemetur.Text = "Ödeme";
            // 
            // urunuek
            // 
            this.urunuek.AutoSize = true;
            this.urunuek.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunuek.Location = new System.Drawing.Point(9, 289);
            this.urunuek.Name = "urunuek";
            this.urunuek.Size = new System.Drawing.Size(86, 17);
            this.urunuek.TabIndex = 8;
            this.urunuek.Text = "Ürün Ekleme";
            this.urunuek.Click += new System.EventHandler(this.urunuek_Click);
            // 
            // BKN
            // 
            this.BKN.AutoSize = true;
            this.BKN.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BKN.Location = new System.Drawing.Point(9, 327);
            this.BKN.Name = "BKN";
            this.BKN.Size = new System.Drawing.Size(81, 17);
            this.BKN.TabIndex = 9;
            this.BKN.Text = "Barkod No :";
            // 
            // adett
            // 
            this.adett.AutoSize = true;
            this.adett.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adett.Location = new System.Drawing.Point(14, 362);
            this.adett.Name = "adett";
            this.adett.Size = new System.Drawing.Size(45, 17);
            this.adett.TabIndex = 10;
            this.adett.Text = "Adet :";
            // 
            // barkodNo
            // 
            this.barkodNo.Location = new System.Drawing.Point(108, 319);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(138, 25);
            this.barkodNo.TabIndex = 11;
            // 
            // urunAdedi
            // 
            this.urunAdedi.Location = new System.Drawing.Point(108, 359);
            this.urunAdedi.Name = "urunAdedi";
            this.urunAdedi.Size = new System.Drawing.Size(138, 25);
            this.urunAdedi.TabIndex = 12;
            // 
            // urunEkle
            // 
            this.urunEkle.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunEkle.Location = new System.Drawing.Point(108, 394);
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(138, 44);
            this.urunEkle.TabIndex = 13;
            this.urunEkle.Text = "Ekle";
            this.urunEkle.UseVisualStyleBackColor = true;
            // 
            // odeme
            // 
            this.odeme.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odeme.Location = new System.Drawing.Point(480, 319);
            this.odeme.Name = "odeme";
            this.odeme.Size = new System.Drawing.Size(262, 38);
            this.odeme.TabIndex = 14;
            this.odeme.Text = "Ödemeyi Onayla";
            this.odeme.UseVisualStyleBackColor = true;
            // 
            // cıkısYap
            // 
            this.cıkısYap.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cıkısYap.Location = new System.Drawing.Point(552, 375);
            this.cıkısYap.Name = "cıkısYap";
            this.cıkısYap.Size = new System.Drawing.Size(190, 63);
            this.cıkısYap.TabIndex = 15;
            this.cıkısYap.Text = "Personel Paneline Dön";
            this.cıkısYap.UseVisualStyleBackColor = true;
            // 
            // Satisıslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cıkısYap);
            this.Controls.Add(this.odeme);
            this.Controls.Add(this.urunEkle);
            this.Controls.Add(this.urunAdedi);
            this.Controls.Add(this.barkodNo);
            this.Controls.Add(this.adett);
            this.Controls.Add(this.BKN);
            this.Controls.Add(this.urunuek);
            this.Controls.Add(this.odemetur);
            this.Controls.Add(this.kk);
            this.Controls.Add(this.nakıt);
            this.Controls.Add(this.fıyat);
            this.Controls.Add(this.topfıyat);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.satısle);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Satisıslemleri";
            this.Text = "Satisıslemleri";
            this.Load += new System.EventHandler(this.Satisıslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label satısle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label topfıyat;
        private System.Windows.Forms.Label fıyat;
        private System.Windows.Forms.RadioButton nakıt;
        private System.Windows.Forms.RadioButton kk;
        private System.Windows.Forms.Label odemetur;
        private System.Windows.Forms.Label urunuek;
        private System.Windows.Forms.Label BKN;
        private System.Windows.Forms.Label adett;
        private System.Windows.Forms.TextBox barkodNo;
        private System.Windows.Forms.TextBox urunAdedi;
        private System.Windows.Forms.Button urunEkle;
        private System.Windows.Forms.Button odeme;
        private System.Windows.Forms.Button cıkısYap;
    }
}