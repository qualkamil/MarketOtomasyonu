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
            this.satisIşlemleri = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yoneticipanel
            // 
            this.yoneticipanel.AutoSize = true;
            this.yoneticipanel.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yoneticipanel.Location = new System.Drawing.Point(125, 40);
            this.yoneticipanel.Name = "yoneticipanel";
            this.yoneticipanel.Size = new System.Drawing.Size(263, 46);
            this.yoneticipanel.TabIndex = 0;
            this.yoneticipanel.Text = "Yönetici paneli ";
            // 
            // satisIşlemleri
            // 
            this.satisIşlemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisIşlemleri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisIşlemleri.Location = new System.Drawing.Point(12, 213);
            this.satisIşlemleri.Name = "satisIşlemleri";
            this.satisIşlemleri.Size = new System.Drawing.Size(230, 70);
            this.satisIşlemleri.TabIndex = 1;
            this.satisIşlemleri.Text = "Satış İşlemleri";
            this.satisIşlemleri.UseVisualStyleBackColor = true;
            // 
            // cikisYap
            // 
            this.cikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisYap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYap.Location = new System.Drawing.Point(321, 213);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(230, 70);
            this.cikisYap.TabIndex = 2;
            this.cikisYap.Text = "Çıkış Yap";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // PersonelPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 600);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.satisIşlemleri);
            this.Controls.Add(this.yoneticipanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yoneticipanel;
        private System.Windows.Forms.Button satisIşlemleri;
        private System.Windows.Forms.Button cikisYap;
    }
}