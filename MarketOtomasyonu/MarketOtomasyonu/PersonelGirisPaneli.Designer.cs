namespace MarketOtomasyonu
{
    partial class PersonelGirisPaneli
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
            this.kullancıad = new System.Windows.Forms.Label();
            this.şıfra = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.girisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Giriş Paneli";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kullancıad
            // 
            this.kullancıad.AutoSize = true;
            this.kullancıad.Location = new System.Drawing.Point(12, 191);
            this.kullancıad.Name = "kullancıad";
            this.kullancıad.Size = new System.Drawing.Size(121, 23);
            this.kullancıad.TabIndex = 1;
            this.kullancıad.Text = "Kullanıcı Adı :";
            // 
            // şıfra
            // 
            this.şıfra.AutoSize = true;
            this.şıfra.Location = new System.Drawing.Point(12, 260);
            this.şıfra.Name = "şıfra";
            this.şıfra.Size = new System.Drawing.Size(60, 23);
            this.şıfra.TabIndex = 2;
            this.şıfra.Text = "Şifre :";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullaniciAdi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdi.Location = new System.Drawing.Point(232, 189);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(242, 28);
            this.kullaniciAdi.TabIndex = 3;
            // 
            // sifre
            // 
            this.sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre.Location = new System.Drawing.Point(232, 258);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(242, 28);
            this.sifre.TabIndex = 4;
            // 
            // girisYap
            // 
            this.girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisYap.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisYap.Location = new System.Drawing.Point(16, 438);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(454, 91);
            this.girisYap.TabIndex = 5;
            this.girisYap.Text = "button1";
            this.girisYap.UseVisualStyleBackColor = true;
            // 
            // PersonelGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.şıfra);
            this.Controls.Add(this.kullancıad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonelGirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelGirisPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kullancıad;
        private System.Windows.Forms.Label şıfra;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button girisYap;
    }
}