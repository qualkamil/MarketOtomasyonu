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
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market Otomasyonu";
            // 
            // yoneticiGiris
            // 
            this.yoneticiGiris.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yoneticiGiris.Location = new System.Drawing.Point(145, 166);
            this.yoneticiGiris.Name = "yoneticiGiris";
            this.yoneticiGiris.Size = new System.Drawing.Size(460, 72);
            this.yoneticiGiris.TabIndex = 1;
            this.yoneticiGiris.Text = "Yönetici Girişi";
            this.yoneticiGiris.UseVisualStyleBackColor = true;
            // 
            // personelGiris
            // 
            this.personelGiris.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelGiris.Location = new System.Drawing.Point(145, 296);
            this.personelGiris.Name = "personelGiris";
            this.personelGiris.Size = new System.Drawing.Size(460, 72);
            this.personelGiris.TabIndex = 2;
            this.personelGiris.Text = "PersonelGirişi";
            this.personelGiris.UseVisualStyleBackColor = true;
            // 
            // MarketOtomasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
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