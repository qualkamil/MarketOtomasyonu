namespace MarketOtomasyonu
{
    partial class Fiyat_Yönetimi
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
            this.fy = new System.Windows.Forms.Label();
            this.brk = new System.Windows.Forms.Label();
            this.satf = new System.Windows.Forms.Label();
            this.barkodNo = new System.Windows.Forms.TextBox();
            this.satisFiyati = new System.Windows.Forms.TextBox();
            this.arama = new System.Windows.Forms.Button();
            this.fiyatGuncelle = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // fy
            // 
            this.fy.AutoSize = true;
            this.fy.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fy.Location = new System.Drawing.Point(10, 9);
            this.fy.Name = "fy";
            this.fy.Size = new System.Drawing.Size(132, 25);
            this.fy.TabIndex = 0;
            this.fy.Text = "Fiyat Yönetimi";
            this.fy.Click += new System.EventHandler(this.label1_Click);
            // 
            // brk
            // 
            this.brk.AutoSize = true;
            this.brk.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brk.Location = new System.Drawing.Point(16, 54);
            this.brk.Name = "brk";
            this.brk.Size = new System.Drawing.Size(106, 23);
            this.brk.TabIndex = 1;
            this.brk.Text = "Barkod No :";
            // 
            // satf
            // 
            this.satf.AutoSize = true;
            this.satf.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satf.Location = new System.Drawing.Point(12, 101);
            this.satf.Name = "satf";
            this.satf.Size = new System.Drawing.Size(110, 23);
            this.satf.TabIndex = 2;
            this.satf.Text = "Satış Fiyatı :";
            this.satf.Click += new System.EventHandler(this.label3_Click);
            // 
            // barkodNo
            // 
            this.barkodNo.BackColor = System.Drawing.Color.White;
            this.barkodNo.Location = new System.Drawing.Point(142, 54);
            this.barkodNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(164, 27);
            this.barkodNo.TabIndex = 3;
            // 
            // satisFiyati
            // 
            this.satisFiyati.BackColor = System.Drawing.Color.White;
            this.satisFiyati.Location = new System.Drawing.Point(142, 101);
            this.satisFiyati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.satisFiyati.Name = "satisFiyati";
            this.satisFiyati.Size = new System.Drawing.Size(164, 27);
            this.satisFiyati.TabIndex = 4;
            // 
            // arama
            // 
            this.arama.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arama.Location = new System.Drawing.Point(30, 189);
            this.arama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(174, 71);
            this.arama.TabIndex = 5;
            this.arama.Text = "Ara";
            this.arama.UseVisualStyleBackColor = true;
            this.arama.Click += new System.EventHandler(this.button1_Click);
            // 
            // fiyatGuncelle
            // 
            this.fiyatGuncelle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiyatGuncelle.Location = new System.Drawing.Point(247, 189);
            this.fiyatGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fiyatGuncelle.Name = "fiyatGuncelle";
            this.fiyatGuncelle.Size = new System.Drawing.Size(174, 71);
            this.fiyatGuncelle.TabIndex = 6;
            this.fiyatGuncelle.Text = "Fiyat Güncelle";
            this.fiyatGuncelle.UseVisualStyleBackColor = true;
            // 
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisYap.Location = new System.Drawing.Point(532, 54);
            this.cikisYap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(213, 74);
            this.cikisYap.TabIndex = 7;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 321);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(785, 116);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Barkod No";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Marka";
            this.columnHeader3.Width = 157;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Birim Fiyat";
            this.columnHeader4.Width = 157;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Satış Fiyatı";
            this.columnHeader5.Width = 157;
            // 
            // Fiyat_Yönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.fiyatGuncelle);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.satisFiyati);
            this.Controls.Add(this.barkodNo);
            this.Controls.Add(this.satf);
            this.Controls.Add(this.brk);
            this.Controls.Add(this.fy);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Fiyat_Yönetimi";
            this.Text = "Fiyat_Yönetimi";
            this.Load += new System.EventHandler(this.Fiyat_Yönetimi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fy;
        private System.Windows.Forms.Label brk;
        private System.Windows.Forms.Label satf;
        private System.Windows.Forms.TextBox barkodNo;
        private System.Windows.Forms.TextBox satisFiyati;
        private System.Windows.Forms.Button arama;
        private System.Windows.Forms.Button fiyatGuncelle;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}