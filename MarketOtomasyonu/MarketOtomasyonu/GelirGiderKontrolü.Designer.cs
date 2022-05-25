namespace MarketOtomasyonu
{
    partial class GelirGiderKontrolü
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
            this.GGK = new System.Windows.Forms.Label();
            this.giderek = new System.Windows.Forms.Label();
            this.GGgğr = new System.Windows.Forms.Label();
            this.giderTutari = new System.Windows.Forms.TextBox();
            this.goruntule = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.goruntulemeTarih = new System.Windows.Forms.ComboBox();
            this.gider = new System.Windows.Forms.ComboBox();
            this.eklemeTarih = new System.Windows.Forms.ComboBox();
            this.giderekle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // GGK
            // 
            this.GGK.AutoSize = true;
            this.GGK.Location = new System.Drawing.Point(13, 10);
            this.GGK.Name = "GGK";
            this.GGK.Size = new System.Drawing.Size(150, 20);
            this.GGK.TabIndex = 0;
            this.GGK.Text = "Gelir Gider Kontrolü";
            this.GGK.Click += new System.EventHandler(this.label1_Click);
            // 
            // giderek
            // 
            this.giderek.AutoSize = true;
            this.giderek.Location = new System.Drawing.Point(13, 57);
            this.giderek.Name = "giderek";
            this.giderek.Size = new System.Drawing.Size(101, 20);
            this.giderek.TabIndex = 1;
            this.giderek.Text = "Gider Ekleme";
            this.giderek.Click += new System.EventHandler(this.label2_Click);
            // 
            // GGgğr
            // 
            this.GGgğr.AutoSize = true;
            this.GGgğr.Location = new System.Drawing.Point(246, 33);
            this.GGgğr.Name = "GGgğr";
            this.GGgğr.Size = new System.Drawing.Size(191, 20);
            this.GGgğr.TabIndex = 2;
            this.GGgğr.Text = "Gelir - Gider Görüntüleme";
            // 
            // giderTutari
            // 
            this.giderTutari.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giderTutari.Location = new System.Drawing.Point(12, 182);
            this.giderTutari.Name = "giderTutari";
            this.giderTutari.Size = new System.Drawing.Size(151, 28);
            this.giderTutari.TabIndex = 3;
            this.giderTutari.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // goruntule
            // 
            this.goruntule.Location = new System.Drawing.Point(260, 134);
            this.goruntule.Name = "goruntule";
            this.goruntule.Size = new System.Drawing.Size(149, 39);
            this.goruntule.TabIndex = 4;
            this.goruntule.Text = "Görüntüle";
            this.goruntule.UseVisualStyleBackColor = true;
            this.goruntule.Click += new System.EventHandler(this.cıkısYap_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.Location = new System.Drawing.Point(553, 52);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(186, 65);
            this.cikisYap.TabIndex = 5;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            // 
            // goruntulemeTarih
            // 
            this.goruntulemeTarih.FormattingEnabled = true;
            this.goruntulemeTarih.Location = new System.Drawing.Point(260, 76);
            this.goruntulemeTarih.Name = "goruntulemeTarih";
            this.goruntulemeTarih.Size = new System.Drawing.Size(149, 28);
            this.goruntulemeTarih.TabIndex = 7;
            this.goruntulemeTarih.Text = "Tarih Seşiniz";
            this.goruntulemeTarih.SelectedIndexChanged += new System.EventHandler(this.goruntuleme_SelectedIndexChanged);
            // 
            // gider
            // 
            this.gider.FormattingEnabled = true;
            this.gider.Location = new System.Drawing.Point(12, 89);
            this.gider.Name = "gider";
            this.gider.Size = new System.Drawing.Size(155, 28);
            this.gider.TabIndex = 8;
            this.gider.Text = "Gider Seçiniz";
            this.gider.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // eklemeTarih
            // 
            this.eklemeTarih.FormattingEnabled = true;
            this.eklemeTarih.Location = new System.Drawing.Point(15, 134);
            this.eklemeTarih.Name = "eklemeTarih";
            this.eklemeTarih.Size = new System.Drawing.Size(148, 28);
            this.eklemeTarih.TabIndex = 9;
            this.eklemeTarih.Text = "Tarih Seçiniz";
            this.eklemeTarih.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // giderekle
            // 
            this.giderekle.Location = new System.Drawing.Point(11, 233);
            this.giderekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.giderekle.Name = "giderekle";
            this.giderekle.Size = new System.Drawing.Size(152, 52);
            this.giderekle.TabIndex = 11;
            this.giderekle.Text = "Gider Ekle ";
            this.giderekle.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tarih,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 309);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(777, 130);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Gideri";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Personel Gideri";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Doğalgaz";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Vergiler";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Gelir";
            // 
            // GelirGiderKontrolü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.giderekle);
            this.Controls.Add(this.eklemeTarih);
            this.Controls.Add(this.gider);
            this.Controls.Add(this.goruntulemeTarih);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.goruntule);
            this.Controls.Add(this.giderTutari);
            this.Controls.Add(this.GGgğr);
            this.Controls.Add(this.giderek);
            this.Controls.Add(this.GGK);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GelirGiderKontrolü";
            this.Text = "GelirGiderKontrolü";
            this.Load += new System.EventHandler(this.GelirGiderKontrolü_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GGK;
        private System.Windows.Forms.Label giderek;
        private System.Windows.Forms.Label GGgğr;
        private System.Windows.Forms.TextBox giderTutari;
        private System.Windows.Forms.Button goruntule;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.ComboBox goruntulemeTarih;
        private System.Windows.Forms.ComboBox gider;
        private System.Windows.Forms.ComboBox eklemeTarih;
        private System.Windows.Forms.Button giderekle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}