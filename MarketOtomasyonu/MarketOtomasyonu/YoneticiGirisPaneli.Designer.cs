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
            this.yonetıcıgirişpanel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yonetıcıgirişpanel.Location = new System.Drawing.Point(89, 66);
            this.yonetıcıgirişpanel.Name = "yonetıcıgirişpanel";
            this.yonetıcıgirişpanel.Size = new System.Drawing.Size(260, 31);
            this.yonetıcıgirişpanel.TabIndex = 0;
            this.yonetıcıgirişpanel.Text = "Yönetici Giriş Paneli";
            // 
            // kullanıcıad
            // 
            this.kullanıcıad.AutoSize = true;
            this.kullanıcıad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanıcıad.Location = new System.Drawing.Point(43, 191);
            this.kullanıcıad.Name = "kullanıcıad";
            this.kullanıcıad.Size = new System.Drawing.Size(101, 17);
            this.kullanıcıad.TabIndex = 1;
            this.kullanıcıad.Text = "Kullanıcı Adi :";
            // 
            // sıfre
            // 
            this.sıfre.AutoSize = true;
            this.sıfre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.sıfre.Location = new System.Drawing.Point(43, 258);
            this.sıfre.Name = "sıfre";
            this.sıfre.Size = new System.Drawing.Size(47, 17);
            this.sıfre.TabIndex = 2;
            this.sıfre.Text = "Şifre :";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullaniciAdi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdi.Location = new System.Drawing.Point(173, 191);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(230, 24);
            this.kullaniciAdi.TabIndex = 3;
            // 
            // sifre
            // 
            this.sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre.Location = new System.Drawing.Point(173, 253);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(230, 24);
            this.sifre.TabIndex = 4;
            // 
            // girisYap
            // 
            this.girisYap.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYap.Location = new System.Drawing.Point(47, 312);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(356, 68);
            this.girisYap.TabIndex = 5;
            this.girisYap.Text = "Giriş Yap";
            this.girisYap.UseVisualStyleBackColor = true;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // YoneticiGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(430, 448);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.sıfre);
            this.Controls.Add(this.kullanıcıad);
            this.Controls.Add(this.yonetıcıgirişpanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "YoneticiGirisPaneli";
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