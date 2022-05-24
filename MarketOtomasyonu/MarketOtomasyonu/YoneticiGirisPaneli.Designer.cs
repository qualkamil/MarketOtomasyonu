namespace MarketOtomasyonu
{
    partial class YoneticiGirisPaneli
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
            this.yonetıcıgirişpanel = new System.Windows.Forms.Label();
            this.kullanıcıad = new System.Windows.Forms.Label();
            this.sıfre = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.girisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yonetıcıgirişpanel
            // 
            this.yonetıcıgirişpanel.AutoSize = true;
            this.yonetıcıgirişpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yonetıcıgirişpanel.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yonetıcıgirişpanel.Location = new System.Drawing.Point(63, 53);
            this.yonetıcıgirişpanel.Name = "yonetıcıgirişpanel";
            this.yonetıcıgirişpanel.Size = new System.Drawing.Size(340, 46);
            this.yonetıcıgirişpanel.TabIndex = 0;
            this.yonetıcıgirişpanel.Text = "Yönetici Giriş Paneli";
            // 
            // kullanıcıad
            // 
            this.kullanıcıad.AutoSize = true;
            this.kullanıcıad.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanıcıad.Location = new System.Drawing.Point(12, 191);
            this.kullanıcıad.Name = "kullanıcıad";
            this.kullanıcıad.Size = new System.Drawing.Size(121, 23);
            this.kullanıcıad.TabIndex = 1;
            this.kullanıcıad.Text = "Kullanıcı Adi :";
            this.kullanıcıad.Click += new System.EventHandler(this.kullanıcıad_Click);
            // 
            // sıfre
            // 
            this.sıfre.AutoSize = true;
            this.sıfre.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sıfre.Location = new System.Drawing.Point(12, 260);
            this.sıfre.Name = "sıfre";
            this.sıfre.Size = new System.Drawing.Size(60, 23);
            this.sıfre.TabIndex = 2;
            this.sıfre.Text = "Şifre :";
            this.sıfre.Click += new System.EventHandler(this.sıfre_Click);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullaniciAdi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdi.Location = new System.Drawing.Point(232, 189);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(238, 28);
            this.kullaniciAdi.TabIndex = 3;
            // 
            // sifre
            // 
            this.sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre.Location = new System.Drawing.Point(232, 258);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(238, 28);
            this.sifre.TabIndex = 4;
            // 
            // girisYap
            // 
            this.girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisYap.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisYap.Location = new System.Drawing.Point(16, 445);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(454, 91);
            this.girisYap.TabIndex = 5;
            this.girisYap.Text = "Giriş Yap";
            this.girisYap.UseVisualStyleBackColor = true;
            // 
            // YoneticiGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.sıfre);
            this.Controls.Add(this.kullanıcıad);
            this.Controls.Add(this.yonetıcıgirişpanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YoneticiGirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoneticiGirisPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yonetıcıgirişpanel;
        private System.Windows.Forms.Label kullanıcıad;
        private System.Windows.Forms.Label sıfre;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button girisYap;
    }
}