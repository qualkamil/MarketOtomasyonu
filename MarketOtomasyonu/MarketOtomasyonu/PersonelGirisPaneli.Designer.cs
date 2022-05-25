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
            this.label1.Location = new System.Drawing.Point(208, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Giriş Paneli";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kullancıad
            // 
            this.kullancıad.AutoSize = true;
            this.kullancıad.Location = new System.Drawing.Point(34, 187);
            this.kullancıad.Name = "kullancıad";
            this.kullancıad.Size = new System.Drawing.Size(121, 23);
            this.kullancıad.TabIndex = 1;
            this.kullancıad.Text = "Kullanıcı Adı :";
            // 
            // şıfra
            // 
            this.şıfra.AutoSize = true;
            this.şıfra.Location = new System.Drawing.Point(43, 258);
            this.şıfra.Name = "şıfra";
            this.şıfra.Size = new System.Drawing.Size(60, 23);
            this.şıfra.TabIndex = 2;
            this.şıfra.Text = "Şifre :";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullaniciAdi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdi.Location = new System.Drawing.Point(449, 182);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(334, 28);
            this.kullaniciAdi.TabIndex = 3;
            // 
            // sifre
            // 
            this.sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre.Location = new System.Drawing.Point(449, 253);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(334, 28);
            this.sifre.TabIndex = 4;
            // 
            // girisYap
            // 
            this.girisYap.BackColor = System.Drawing.SystemColors.Control;
            this.girisYap.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisYap.Location = new System.Drawing.Point(38, 347);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(736, 91);
            this.girisYap.TabIndex = 5;
            this.girisYap.Text = "Giriş Yap";
            this.girisYap.UseVisualStyleBackColor = false;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // PersonelGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.şıfra);
            this.Controls.Add(this.kullancıad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelGirisPaneli";
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