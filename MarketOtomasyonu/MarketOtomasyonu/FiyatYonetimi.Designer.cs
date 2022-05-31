namespace MarketOtomasyonu
{
    partial class FiyatYonetimi
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
            this.cikisYap = new System.Windows.Forms.Button();
            this.fiyatGuncelle = new System.Windows.Forms.Button();
            this.arama = new System.Windows.Forms.Button();
            this.satisFiyati = new System.Windows.Forms.TextBox();
            this.barkodNo = new System.Windows.Forms.TextBox();
            this.satf = new System.Windows.Forms.Label();
            this.brk = new System.Windows.Forms.Label();
            this.fy = new System.Windows.Forms.Label();
            this.fiyatListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatListe)).BeginInit();
            this.SuspendLayout();
            // 
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYap.Location = new System.Drawing.Point(401, 45);
            this.cikisYap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(187, 74);
            this.cikisYap.TabIndex = 16;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // fiyatGuncelle
            // 
            this.fiyatGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatGuncelle.Location = new System.Drawing.Point(192, 150);
            this.fiyatGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fiyatGuncelle.Name = "fiyatGuncelle";
            this.fiyatGuncelle.Size = new System.Drawing.Size(174, 71);
            this.fiyatGuncelle.TabIndex = 15;
            this.fiyatGuncelle.Text = "Fiyat Güncelle";
            this.fiyatGuncelle.UseVisualStyleBackColor = true;
            this.fiyatGuncelle.Click += new System.EventHandler(this.fiyatGuncelle_Click);
            // 
            // arama
            // 
            this.arama.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama.Location = new System.Drawing.Point(12, 150);
            this.arama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(174, 71);
            this.arama.TabIndex = 14;
            this.arama.Text = "Ara";
            this.arama.UseVisualStyleBackColor = true;
            this.arama.Click += new System.EventHandler(this.arama_Click);
            // 
            // satisFiyati
            // 
            this.satisFiyati.BackColor = System.Drawing.Color.White;
            this.satisFiyati.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisFiyati.Location = new System.Drawing.Point(132, 101);
            this.satisFiyati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.satisFiyati.Name = "satisFiyati";
            this.satisFiyati.Size = new System.Drawing.Size(164, 24);
            this.satisFiyati.TabIndex = 13;
            // 
            // barkodNo
            // 
            this.barkodNo.BackColor = System.Drawing.Color.White;
            this.barkodNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodNo.Location = new System.Drawing.Point(132, 54);
            this.barkodNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(164, 24);
            this.barkodNo.TabIndex = 12;
            // 
            // satf
            // 
            this.satf.AutoSize = true;
            this.satf.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satf.Location = new System.Drawing.Point(15, 102);
            this.satf.Name = "satf";
            this.satf.Size = new System.Drawing.Size(88, 17);
            this.satf.TabIndex = 11;
            this.satf.Text = "Satış Fiyatı :";
            // 
            // brk
            // 
            this.brk.AutoSize = true;
            this.brk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brk.Location = new System.Drawing.Point(15, 55);
            this.brk.Name = "brk";
            this.brk.Size = new System.Drawing.Size(89, 17);
            this.brk.TabIndex = 10;
            this.brk.Text = "Barkod No :";
            // 
            // fy
            // 
            this.fy.AutoSize = true;
            this.fy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fy.Location = new System.Drawing.Point(15, 11);
            this.fy.Name = "fy";
            this.fy.Size = new System.Drawing.Size(105, 19);
            this.fy.TabIndex = 9;
            this.fy.Text = "Fiyat Yönetimi";
            // 
            // fiyatListe
            // 
            this.fiyatListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fiyatListe.Location = new System.Drawing.Point(-1, 228);
            this.fiyatListe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fiyatListe.Name = "fiyatListe";
            this.fiyatListe.RowTemplate.Height = 24;
            this.fiyatListe.Size = new System.Drawing.Size(599, 138);
            this.fiyatListe.TabIndex = 17;
            // 
            // FiyatYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.fiyatListe);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.fiyatGuncelle);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.satisFiyati);
            this.Controls.Add(this.barkodNo);
            this.Controls.Add(this.satf);
            this.Controls.Add(this.brk);
            this.Controls.Add(this.fy);
            this.Name = "FiyatYonetimi";
            this.Text = "FiyatYönetimi";
            this.Load += new System.EventHandler(this.FiyatYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiyatListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Button fiyatGuncelle;
        private System.Windows.Forms.Button arama;
        private System.Windows.Forms.TextBox satisFiyati;
        private System.Windows.Forms.TextBox barkodNo;
        private System.Windows.Forms.Label satf;
        private System.Windows.Forms.Label brk;
        private System.Windows.Forms.Label fy;
        private System.Windows.Forms.DataGridView fiyatListe;
    }
}