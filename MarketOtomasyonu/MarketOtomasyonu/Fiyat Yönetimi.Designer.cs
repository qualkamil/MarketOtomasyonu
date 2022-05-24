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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.fy.Location = new System.Drawing.Point(13, 13);
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
            this.brk.Location = new System.Drawing.Point(14, 95);
            this.brk.Name = "brk";
            this.brk.Size = new System.Drawing.Size(106, 23);
            this.brk.TabIndex = 1;
            this.brk.Text = "Barkod No :";
            // 
            // satf
            // 
            this.satf.AutoSize = true;
            this.satf.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satf.Location = new System.Drawing.Point(10, 168);
            this.satf.Name = "satf";
            this.satf.Size = new System.Drawing.Size(110, 23);
            this.satf.TabIndex = 2;
            this.satf.Text = "Satış Fiyatı :";
            this.satf.Click += new System.EventHandler(this.label3_Click);
            // 
            // barkodNo
            // 
            this.barkodNo.BackColor = System.Drawing.Color.White;
            this.barkodNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barkodNo.Location = new System.Drawing.Point(170, 95);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(182, 25);
            this.barkodNo.TabIndex = 3;
            // 
            // satisFiyati
            // 
            this.satisFiyati.BackColor = System.Drawing.Color.White;
            this.satisFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.satisFiyati.Location = new System.Drawing.Point(170, 168);
            this.satisFiyati.Name = "satisFiyati";
            this.satisFiyati.Size = new System.Drawing.Size(182, 25);
            this.satisFiyati.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(281, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Fiyat Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(793, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 63);
            this.button3.TabIndex = 7;
            this.button3.Text = "Yönetici Paneline Dön";
            this.button3.UseVisualStyleBackColor = true;
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
            this.listView1.Location = new System.Drawing.Point(12, 377);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1199, 222);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Barkod No";
            this.columnHeader1.Width = 233;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Marka";
            this.columnHeader3.Width = 230;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Birim Fiyat";
            this.columnHeader4.Width = 230;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Satış Fiyatı";
            this.columnHeader5.Width = 230;
            // 
            // Fiyat_Yönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 611);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.satisFiyati);
            this.Controls.Add(this.barkodNo);
            this.Controls.Add(this.satf);
            this.Controls.Add(this.brk);
            this.Controls.Add(this.fy);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fiyat_Yönetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}