namespace MarketOtomasyonu
{
    partial class GelirGiderKontrolu
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
            this.GGK = new System.Windows.Forms.Label();
            this.giderek = new System.Windows.Forms.Label();
            this.GGgğr = new System.Windows.Forms.Label();
            this.giderTutari = new System.Windows.Forms.TextBox();
            this.goruntule = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.goruntulemeTarih = new System.Windows.Forms.ComboBox();
            this.gider = new System.Windows.Forms.ComboBox();
            this.eklemeTarih = new System.Windows.Forms.ComboBox();
            this.giderekle = new System.Windows.Forms.Button();
            this.gelirGiderListe = new System.Windows.Forms.DataGridView();
            this.yillikGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderListe)).BeginInit();
            this.SuspendLayout();
            // 
            // GGK
            // 
            this.GGK.AutoSize = true;
            this.GGK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GGK.Location = new System.Drawing.Point(13, 10);
            this.GGK.Name = "GGK";
            this.GGK.Size = new System.Drawing.Size(148, 19);
            this.GGK.TabIndex = 0;
            this.GGK.Text = "Gelir Gider Kontrolü";
            // 
            // giderek
            // 
            this.giderek.AutoSize = true;
            this.giderek.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderek.Location = new System.Drawing.Point(4, 50);
            this.giderek.Name = "giderek";
            this.giderek.Size = new System.Drawing.Size(137, 17);
            this.giderek.TabIndex = 1;
            this.giderek.Text = "Gelir-Gider Ekleme";
            // 
            // GGgğr
            // 
            this.GGgğr.AutoSize = true;
            this.GGgğr.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GGgğr.Location = new System.Drawing.Point(338, 49);
            this.GGgğr.Name = "GGgğr";
            this.GGgğr.Size = new System.Drawing.Size(181, 17);
            this.GGgğr.TabIndex = 2;
            this.GGgğr.Text = "Gelir - Gider Görüntüleme";
            // 
            // giderTutari
            // 
            this.giderTutari.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderTutari.Location = new System.Drawing.Point(4, 145);
            this.giderTutari.Name = "giderTutari";
            this.giderTutari.Size = new System.Drawing.Size(201, 24);
            this.giderTutari.TabIndex = 3;
            this.giderTutari.Text = "Tutar Giriniz";
            // 
            // goruntule
            // 
            this.goruntule.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goruntule.Location = new System.Drawing.Point(341, 110);
            this.goruntule.Name = "goruntule";
            this.goruntule.Size = new System.Drawing.Size(171, 58);
            this.goruntule.TabIndex = 4;
            this.goruntule.Text = "Görüntüle";
            this.goruntule.UseVisualStyleBackColor = true;
            this.goruntule.Click += new System.EventHandler(this.goruntule_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisYap.Location = new System.Drawing.Point(671, 50);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(186, 65);
            this.cikisYap.TabIndex = 5;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // goruntulemeTarih
            // 
            this.goruntulemeTarih.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goruntulemeTarih.FormattingEnabled = true;
            this.goruntulemeTarih.Location = new System.Drawing.Point(341, 74);
            this.goruntulemeTarih.Name = "goruntulemeTarih";
            this.goruntulemeTarih.Size = new System.Drawing.Size(185, 25);
            this.goruntulemeTarih.TabIndex = 7;
            this.goruntulemeTarih.Text = "Tarih Seçiniz";
            // 
            // gider
            // 
            this.gider.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gider.FormattingEnabled = true;
            this.gider.Items.AddRange(new object[] {
            "UrunGiderleri",
            "PersonelGiderleri",
            "Elektrik",
            "Su",
            "Dogalgaz",
            "Vergiler",
            "Gelir"});
            this.gider.Location = new System.Drawing.Point(4, 75);
            this.gider.Name = "gider";
            this.gider.Size = new System.Drawing.Size(201, 25);
            this.gider.TabIndex = 8;
            this.gider.Text = "Gider Seçiniz";
            // 
            // eklemeTarih
            // 
            this.eklemeTarih.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eklemeTarih.FormattingEnabled = true;
            this.eklemeTarih.Location = new System.Drawing.Point(4, 110);
            this.eklemeTarih.Name = "eklemeTarih";
            this.eklemeTarih.Size = new System.Drawing.Size(201, 25);
            this.eklemeTarih.TabIndex = 9;
            this.eklemeTarih.Text = "Tarih Seçiniz";
            // 
            // giderekle
            // 
            this.giderekle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giderekle.Location = new System.Drawing.Point(4, 174);
            this.giderekle.Margin = new System.Windows.Forms.Padding(2);
            this.giderekle.Name = "giderekle";
            this.giderekle.Size = new System.Drawing.Size(176, 56);
            this.giderekle.TabIndex = 11;
            this.giderekle.Text = "Gider Ekle ";
            this.giderekle.UseVisualStyleBackColor = true;
            this.giderekle.Click += new System.EventHandler(this.giderekle_Click);
            // 
            // gelirGiderListe
            // 
            this.gelirGiderListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gelirGiderListe.Location = new System.Drawing.Point(4, 235);
            this.gelirGiderListe.Name = "gelirGiderListe";
            this.gelirGiderListe.RowTemplate.Height = 24;
            this.gelirGiderListe.Size = new System.Drawing.Size(853, 263);
            this.gelirGiderListe.TabIndex = 12;
            // 
            // yillikGoruntule
            // 
            this.yillikGoruntule.Location = new System.Drawing.Point(674, 171);
            this.yillikGoruntule.Name = "yillikGoruntule";
            this.yillikGoruntule.Size = new System.Drawing.Size(183, 58);
            this.yillikGoruntule.TabIndex = 13;
            this.yillikGoruntule.Text = "Tüm Listeyi Görüntüle";
            this.yillikGoruntule.UseVisualStyleBackColor = true;
            this.yillikGoruntule.Click += new System.EventHandler(this.yillikGoruntule_Click);
            // 
            // GelirGiderKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(869, 510);
            this.Controls.Add(this.yillikGoruntule);
            this.Controls.Add(this.gelirGiderListe);
            this.Controls.Add(this.giderekle);
            this.Controls.Add(this.eklemeTarih);
            this.Controls.Add(this.gider);
            this.Controls.Add(this.goruntulemeTarih);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.goruntule);
            this.Controls.Add(this.giderTutari);
            this.Controls.Add(this.GGgğr);
            this.Controls.Add(this.giderek);
            this.Controls.Add(this.GGK);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GelirGiderKontrolu";
            this.Text = "GelirGiderKontrolü";
            this.Load += new System.EventHandler(this.GelirGiderKontrolu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GGK;
        private System.Windows.Forms.Label giderek;
        private System.Windows.Forms.Label GGgğr;
        private System.Windows.Forms.TextBox giderTutari;
        private System.Windows.Forms.Button goruntule;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.ComboBox goruntulemeTarih;
        private System.Windows.Forms.ComboBox gider;
        private System.Windows.Forms.ComboBox eklemeTarih;
        private System.Windows.Forms.Button giderekle;
        private System.Windows.Forms.DataGridView gelirGiderListe;
        private System.Windows.Forms.Button yillikGoruntule;
    }
}