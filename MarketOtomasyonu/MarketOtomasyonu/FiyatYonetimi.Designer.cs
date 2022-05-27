namespace MarketOtomasyonu
{
    partial class FiyatYonetimi
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
            this.cikisYap = new System.Windows.Forms.Button();
            this.fiyatGuncelle = new System.Windows.Forms.Button();
            this.arama = new System.Windows.Forms.Button();
            this.satisFiyati = new System.Windows.Forms.TextBox();
            this.barkodNo = new System.Windows.Forms.TextBox();
            this.satf = new System.Windows.Forms.Label();
            this.brk = new System.Windows.Forms.Label();
            this.fy = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYap.Location = new System.Drawing.Point(503, 61);
            this.cikisYap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(249, 91);
            this.cikisYap.TabIndex = 16;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // fiyatGuncelle
            // 
            this.fiyatGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatGuncelle.Location = new System.Drawing.Point(283, 185);
            this.fiyatGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fiyatGuncelle.Name = "fiyatGuncelle";
            this.fiyatGuncelle.Size = new System.Drawing.Size(232, 87);
            this.fiyatGuncelle.TabIndex = 15;
            this.fiyatGuncelle.Text = "Fiyat Güncelle";
            this.fiyatGuncelle.UseVisualStyleBackColor = true;
            this.fiyatGuncelle.Click += new System.EventHandler(this.fiyatGuncelle_Click);
            // 
            // arama
            // 
            this.arama.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama.Location = new System.Drawing.Point(28, 185);
            this.arama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(232, 87);
            this.arama.TabIndex = 14;
            this.arama.Text = "Ara";
            this.arama.UseVisualStyleBackColor = true;
            this.arama.Click += new System.EventHandler(this.arama_Click);
            // 
            // satisFiyati
            // 
            this.satisFiyati.BackColor = System.Drawing.Color.White;
            this.satisFiyati.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisFiyati.Location = new System.Drawing.Point(176, 124);
            this.satisFiyati.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.satisFiyati.Name = "satisFiyati";
            this.satisFiyati.Size = new System.Drawing.Size(217, 28);
            this.satisFiyati.TabIndex = 13;
            // 
            // barkodNo
            // 
            this.barkodNo.BackColor = System.Drawing.Color.White;
            this.barkodNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodNo.Location = new System.Drawing.Point(176, 66);
            this.barkodNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(217, 28);
            this.barkodNo.TabIndex = 12;
            // 
            // satf
            // 
            this.satf.AutoSize = true;
            this.satf.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satf.Location = new System.Drawing.Point(20, 126);
            this.satf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.satf.Name = "satf";
            this.satf.Size = new System.Drawing.Size(112, 22);
            this.satf.TabIndex = 11;
            this.satf.Text = "Satış Fiyatı :";
            // 
            // brk
            // 
            this.brk.AutoSize = true;
            this.brk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brk.Location = new System.Drawing.Point(20, 68);
            this.brk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brk.Name = "brk";
            this.brk.Size = new System.Drawing.Size(111, 22);
            this.brk.TabIndex = 10;
            this.brk.Text = "Barkod No :";
            // 
            // fy
            // 
            this.fy.AutoSize = true;
            this.fy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fy.Location = new System.Drawing.Point(20, 14);
            this.fy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fy.Name = "fy";
            this.fy.Size = new System.Drawing.Size(132, 23);
            this.fy.TabIndex = 9;
            this.fy.Text = "Fiyat Yönetimi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 170);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Barkod No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ürün Marka";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Birim Fiyatı";
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Satış Fiyatı";
            this.Column5.Name = "Column5";
            this.Column5.Width = 159;
            // 
            // FiyatYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.fiyatGuncelle);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.satisFiyati);
            this.Controls.Add(this.barkodNo);
            this.Controls.Add(this.satf);
            this.Controls.Add(this.brk);
            this.Controls.Add(this.fy);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FiyatYonetimi";
            this.Text = "FiyatYönetimi";
            this.Load += new System.EventHandler(this.FiyatYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Button fiyatGuncelle;
        private System.Windows.Forms.Button arama;
        private System.Windows.Forms.TextBox satisFiyati;
        private System.Windows.Forms.TextBox barkodNo;
        private System.Windows.Forms.Label satf;
        private System.Windows.Forms.Label brk;
        private System.Windows.Forms.Label fy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}