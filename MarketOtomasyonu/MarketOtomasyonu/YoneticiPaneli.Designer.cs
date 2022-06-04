namespace MarketOtomasyonu
{
    partial class YoneticiPaneli
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
            this.yonetıcıpanel = new System.Windows.Forms.Label();
            this.stokTakibi = new System.Windows.Forms.Button();
            this.fiyetYönetimi = new System.Windows.Forms.Button();
            this.gelirGiderKontrolu = new System.Windows.Forms.Button();
            this.personelYonetimi = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yonetıcıpanel
            // 
            this.yonetıcıpanel.AutoSize = true;
            this.yonetıcıpanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yonetıcıpanel.Location = new System.Drawing.Point(245, 18);
            this.yonetıcıpanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yonetıcıpanel.Name = "yonetıcıpanel";
            this.yonetıcıpanel.Size = new System.Drawing.Size(108, 19);
            this.yonetıcıpanel.TabIndex = 0;
            this.yonetıcıpanel.Text = "Yönetici Paneli";
            // 
            // stokTakibi
            // 
            this.stokTakibi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokTakibi.Location = new System.Drawing.Point(107, 89);
            this.stokTakibi.Margin = new System.Windows.Forms.Padding(2);
            this.stokTakibi.Name = "stokTakibi";
            this.stokTakibi.Size = new System.Drawing.Size(172, 57);
            this.stokTakibi.TabIndex = 1;
            this.stokTakibi.Text = "Stok Takibi";
            this.stokTakibi.UseVisualStyleBackColor = true;
            this.stokTakibi.Click += new System.EventHandler(this.button1_Click);
            // 
            // fiyetYönetimi
            // 
            this.fiyetYönetimi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyetYönetimi.Location = new System.Drawing.Point(328, 89);
            this.fiyetYönetimi.Margin = new System.Windows.Forms.Padding(2);
            this.fiyetYönetimi.Name = "fiyetYönetimi";
            this.fiyetYönetimi.Size = new System.Drawing.Size(179, 57);
            this.fiyetYönetimi.TabIndex = 2;
            this.fiyetYönetimi.Text = "Fiyat Yönetimi";
            this.fiyetYönetimi.UseVisualStyleBackColor = true;
            this.fiyetYönetimi.Click += new System.EventHandler(this.fiyetYönetimi_Click);
            // 
            // gelirGiderKontrolu
            // 
            this.gelirGiderKontrolu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirGiderKontrolu.Location = new System.Drawing.Point(107, 186);
            this.gelirGiderKontrolu.Margin = new System.Windows.Forms.Padding(2);
            this.gelirGiderKontrolu.Name = "gelirGiderKontrolu";
            this.gelirGiderKontrolu.Size = new System.Drawing.Size(172, 57);
            this.gelirGiderKontrolu.TabIndex = 3;
            this.gelirGiderKontrolu.Text = "Gelir Gider Kontrolü";
            this.gelirGiderKontrolu.UseVisualStyleBackColor = true;
            this.gelirGiderKontrolu.Click += new System.EventHandler(this.gelirGiderKontrolu_Click);
            // 
            // personelYonetimi
            // 
            this.personelYonetimi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelYonetimi.Location = new System.Drawing.Point(328, 186);
            this.personelYonetimi.Margin = new System.Windows.Forms.Padding(2);
            this.personelYonetimi.Name = "personelYonetimi";
            this.personelYonetimi.Size = new System.Drawing.Size(179, 57);
            this.personelYonetimi.TabIndex = 4;
            this.personelYonetimi.Text = "Personel Yönetimi";
            this.personelYonetimi.UseVisualStyleBackColor = true;
            this.personelYonetimi.Click += new System.EventHandler(this.personelYonetimi_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYap.Location = new System.Drawing.Point(216, 276);
            this.cikisYap.Margin = new System.Windows.Forms.Padding(2);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(172, 57);
            this.cikisYap.TabIndex = 5;
            this.cikisYap.Text = "Çıkış Yap";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.personelYonetimi);
            this.Controls.Add(this.gelirGiderKontrolu);
            this.Controls.Add(this.fiyetYönetimi);
            this.Controls.Add(this.stokTakibi);
            this.Controls.Add(this.yonetıcıpanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "YoneticiPaneli";
            this.Text = "YoneticiPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yonetıcıpanel;
        private System.Windows.Forms.Button stokTakibi;
        private System.Windows.Forms.Button fiyetYönetimi;
        private System.Windows.Forms.Button gelirGiderKontrolu;
        private System.Windows.Forms.Button personelYonetimi;
        private System.Windows.Forms.Button cikisYap;
    }
}