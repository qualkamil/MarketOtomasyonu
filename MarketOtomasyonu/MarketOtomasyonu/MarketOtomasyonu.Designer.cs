namespace MarketOtomasyonu
{
    partial class MarketOtomasyonu
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
            this.yoneticiGiris = new System.Windows.Forms.Button();
            this.personelGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market Otomasyonu";
            // 
            // yoneticiGiris
            // 
            this.yoneticiGiris.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiGiris.Location = new System.Drawing.Point(60, 162);
            this.yoneticiGiris.Name = "yoneticiGiris";
            this.yoneticiGiris.Size = new System.Drawing.Size(460, 72);
            this.yoneticiGiris.TabIndex = 1;
            this.yoneticiGiris.Text = "Yönetici Girişi";
            this.yoneticiGiris.UseVisualStyleBackColor = true;
            this.yoneticiGiris.Click += new System.EventHandler(this.yoneticiGiris_Click);
            // 
            // personelGiris
            // 
            this.personelGiris.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelGiris.Location = new System.Drawing.Point(60, 282);
            this.personelGiris.Name = "personelGiris";
            this.personelGiris.Size = new System.Drawing.Size(460, 72);
            this.personelGiris.TabIndex = 2;
            this.personelGiris.Text = "PersonelGirişi";
            this.personelGiris.UseVisualStyleBackColor = true;
            this.personelGiris.Click += new System.EventHandler(this.personelGiris_Click);
            // 
            // MarketOtomasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(572, 428);
            this.Controls.Add(this.personelGiris);
            this.Controls.Add(this.yoneticiGiris);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MarketOtomasyonu";
            this.Text = "MarketOtomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yoneticiGiris;
        private System.Windows.Forms.Button personelGiris;
    }
}