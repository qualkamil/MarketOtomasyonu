namespace MarketOtomasyonu
{
    partial class PersonelPaneli
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
            this.yoneticipanel = new System.Windows.Forms.Label();
            this.satisIslemleri = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yoneticipanel
            // 
            this.yoneticipanel.AutoSize = true;
            this.yoneticipanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticipanel.Location = new System.Drawing.Point(242, 42);
            this.yoneticipanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yoneticipanel.Name = "yoneticipanel";
            this.yoneticipanel.Size = new System.Drawing.Size(115, 19);
            this.yoneticipanel.TabIndex = 0;
            this.yoneticipanel.Text = "Personel paneli ";
            // 
            // satisIslemleri
            // 
            this.satisIslemleri.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisIslemleri.Location = new System.Drawing.Point(82, 158);
            this.satisIslemleri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.satisIslemleri.Name = "satisIslemleri";
            this.satisIslemleri.Size = new System.Drawing.Size(172, 57);
            this.satisIslemleri.TabIndex = 1;
            this.satisIslemleri.Text = "Satış İşlemleri";
            this.satisIslemleri.UseVisualStyleBackColor = true;
            this.satisIslemleri.Click += new System.EventHandler(this.satisIslemleri_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYap.Location = new System.Drawing.Point(356, 158);
            this.cikisYap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(172, 57);
            this.cikisYap.TabIndex = 2;
            this.cikisYap.Text = "Çıkış Yap";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // PersonelPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.satisIslemleri);
            this.Controls.Add(this.yoneticipanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PersonelPaneli";
            this.Text = "PersonelPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yoneticipanel;
        private System.Windows.Forms.Button satisIslemleri;
        private System.Windows.Forms.Button cikisYap;
    }
}