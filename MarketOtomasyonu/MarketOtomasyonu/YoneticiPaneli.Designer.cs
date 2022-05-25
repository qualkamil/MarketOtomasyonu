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
            this.gelirGiderKontrolü = new System.Windows.Forms.Button();
            this.personelYonetimi = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yonetıcıpanel
            // 
            this.yonetıcıpanel.AutoSize = true;
            this.yonetıcıpanel.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yonetıcıpanel.Location = new System.Drawing.Point(261, 9);
            this.yonetıcıpanel.Name = "yonetıcıpanel";
            this.yonetıcıpanel.Size = new System.Drawing.Size(244, 45);
            this.yonetıcıpanel.TabIndex = 0;
            this.yonetıcıpanel.Text = "Yönetici Paneli";
            // 
            // stokTakibi
            // 
            this.stokTakibi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokTakibi.Location = new System.Drawing.Point(143, 110);
            this.stokTakibi.Name = "stokTakibi";
            this.stokTakibi.Size = new System.Drawing.Size(230, 70);
            this.stokTakibi.TabIndex = 1;
            this.stokTakibi.Text = "STOK Takibi";
            this.stokTakibi.UseVisualStyleBackColor = true;
            this.stokTakibi.Click += new System.EventHandler(this.button1_Click);
            // 
            // fiyetYönetimi
            // 
            this.fiyetYönetimi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyetYönetimi.Location = new System.Drawing.Point(437, 110);
            this.fiyetYönetimi.Name = "fiyetYönetimi";
            this.fiyetYönetimi.Size = new System.Drawing.Size(239, 70);
            this.fiyetYönetimi.TabIndex = 2;
            this.fiyetYönetimi.Text = "Fiyat Yönetimi";
            this.fiyetYönetimi.UseVisualStyleBackColor = true;
            this.fiyetYönetimi.Click += new System.EventHandler(this.button2_Click);
            // 
            // gelirGiderKontrolü
            // 
            this.gelirGiderKontrolü.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirGiderKontrolü.Location = new System.Drawing.Point(143, 229);
            this.gelirGiderKontrolü.Name = "gelirGiderKontrolü";
            this.gelirGiderKontrolü.Size = new System.Drawing.Size(230, 70);
            this.gelirGiderKontrolü.TabIndex = 3;
            this.gelirGiderKontrolü.Text = "Gelir Gider Kontrolü";
            this.gelirGiderKontrolü.UseVisualStyleBackColor = true;
            // 
            // personelYonetimi
            // 
            this.personelYonetimi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelYonetimi.Location = new System.Drawing.Point(437, 229);
            this.personelYonetimi.Name = "personelYonetimi";
            this.personelYonetimi.Size = new System.Drawing.Size(239, 70);
            this.personelYonetimi.TabIndex = 4;
            this.personelYonetimi.Text = "Personel Yönetimi";
            this.personelYonetimi.UseVisualStyleBackColor = true;
            this.personelYonetimi.Click += new System.EventHandler(this.button4_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYap.Location = new System.Drawing.Point(275, 358);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(230, 70);
            this.cikisYap.TabIndex = 5;
            this.cikisYap.Text = "Çıkış Yap";
            this.cikisYap.UseVisualStyleBackColor = true;
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.personelYonetimi);
            this.Controls.Add(this.gelirGiderKontrolü);
            this.Controls.Add(this.fiyetYönetimi);
            this.Controls.Add(this.stokTakibi);
            this.Controls.Add(this.yonetıcıpanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "YoneticiPaneli";
            this.Text = "YoneticiPaneli";
            this.Load += new System.EventHandler(this.YoneticiPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yonetıcıpanel;
        private System.Windows.Forms.Button stokTakibi;
        private System.Windows.Forms.Button fiyetYönetimi;
        private System.Windows.Forms.Button gelirGiderKontrolü;
        private System.Windows.Forms.Button personelYonetimi;
        private System.Windows.Forms.Button cikisYap;
    }
}