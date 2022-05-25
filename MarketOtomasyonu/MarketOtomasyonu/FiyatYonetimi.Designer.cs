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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cikisYap = new System.Windows.Forms.Button();
            this.fiyatGuncelle = new System.Windows.Forms.Button();
            this.arama = new System.Windows.Forms.Button();
            this.satisFiyati = new System.Windows.Forms.TextBox();
            this.barkodNo = new System.Windows.Forms.TextBox();
            this.satf = new System.Windows.Forms.Label();
            this.brk = new System.Windows.Forms.Label();
            this.fy = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(8, 323);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(785, 116);
            this.listView1.TabIndex = 17;
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
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisYap.Location = new System.Drawing.Point(537, 56);
            this.cikisYap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(213, 74);
            this.cikisYap.TabIndex = 16;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            // 
            // fiyatGuncelle
            // 
            this.fiyatGuncelle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiyatGuncelle.Location = new System.Drawing.Point(252, 191);
            this.fiyatGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fiyatGuncelle.Name = "fiyatGuncelle";
            this.fiyatGuncelle.Size = new System.Drawing.Size(174, 71);
            this.fiyatGuncelle.TabIndex = 15;
            this.fiyatGuncelle.Text = "Fiyat Güncelle";
            this.fiyatGuncelle.UseVisualStyleBackColor = true;
            // 
            // arama
            // 
            this.arama.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arama.Location = new System.Drawing.Point(35, 191);
            this.arama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(174, 71);
            this.arama.TabIndex = 14;
            this.arama.Text = "Ara";
            this.arama.UseVisualStyleBackColor = true;
            // 
            // satisFiyati
            // 
            this.satisFiyati.BackColor = System.Drawing.Color.White;
            this.satisFiyati.Location = new System.Drawing.Point(147, 103);
            this.satisFiyati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.satisFiyati.Name = "satisFiyati";
            this.satisFiyati.Size = new System.Drawing.Size(164, 20);
            this.satisFiyati.TabIndex = 13;
            // 
            // barkodNo
            // 
            this.barkodNo.BackColor = System.Drawing.Color.White;
            this.barkodNo.Location = new System.Drawing.Point(147, 56);
            this.barkodNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(164, 20);
            this.barkodNo.TabIndex = 12;
            // 
            // satf
            // 
            this.satf.AutoSize = true;
            this.satf.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satf.Location = new System.Drawing.Point(17, 103);
            this.satf.Name = "satf";
            this.satf.Size = new System.Drawing.Size(90, 19);
            this.satf.TabIndex = 11;
            this.satf.Text = "Satış Fiyatı :";
            // 
            // brk
            // 
            this.brk.AutoSize = true;
            this.brk.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brk.Location = new System.Drawing.Point(21, 56);
            this.brk.Name = "brk";
            this.brk.Size = new System.Drawing.Size(90, 19);
            this.brk.TabIndex = 10;
            this.brk.Text = "Barkod No :";
            // 
            // fy
            // 
            this.fy.AutoSize = true;
            this.fy.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fy.Location = new System.Drawing.Point(15, 11);
            this.fy.Name = "fy";
            this.fy.Size = new System.Drawing.Size(109, 20);
            this.fy.TabIndex = 9;
            this.fy.Text = "Fiyat Yönetimi";
            // 
            // FiyatYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "FiyatYönetimi";
            this.Text = "FiyatYönetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Button fiyatGuncelle;
        private System.Windows.Forms.Button arama;
        private System.Windows.Forms.TextBox satisFiyati;
        private System.Windows.Forms.TextBox barkodNo;
        private System.Windows.Forms.Label satf;
        private System.Windows.Forms.Label brk;
        private System.Windows.Forms.Label fy;
    }
}