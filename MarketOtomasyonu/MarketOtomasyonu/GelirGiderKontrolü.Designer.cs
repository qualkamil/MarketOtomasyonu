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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GGK
            // 
            this.GGK.AutoSize = true;
            this.GGK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GGK.Location = new System.Drawing.Point(13, 10);
            this.GGK.Name = "GGK";
            this.GGK.Size = new System.Drawing.Size(188, 23);
            this.GGK.TabIndex = 0;
            this.GGK.Text = "Gelir Gider Kontrolü";
            this.GGK.Click += new System.EventHandler(this.label1_Click);
            // 
            // giderek
            // 
            this.giderek.AutoSize = true;
            this.giderek.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderek.Location = new System.Drawing.Point(13, 57);
            this.giderek.Name = "giderek";
            this.giderek.Size = new System.Drawing.Size(124, 22);
            this.giderek.TabIndex = 1;
            this.giderek.Text = "Gider Ekleme";
            this.giderek.Click += new System.EventHandler(this.label2_Click);
            // 
            // GGgğr
            // 
            this.GGgğr.AutoSize = true;
            this.GGgğr.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GGgğr.Location = new System.Drawing.Point(269, 27);
            this.GGgğr.Name = "GGgğr";
            this.GGgğr.Size = new System.Drawing.Size(227, 22);
            this.GGgğr.TabIndex = 2;
            this.GGgğr.Text = "Gelir - Gider Görüntüleme";
            // 
            // giderTutari
            // 
            this.giderTutari.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderTutari.Location = new System.Drawing.Point(11, 177);
            this.giderTutari.Name = "giderTutari";
            this.giderTutari.Size = new System.Drawing.Size(201, 28);
            this.giderTutari.TabIndex = 3;
            this.giderTutari.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // goruntule
            // 
            this.goruntule.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goruntule.Location = new System.Drawing.Point(325, 122);
            this.goruntule.Name = "goruntule";
            this.goruntule.Size = new System.Drawing.Size(171, 58);
            this.goruntule.TabIndex = 4;
            this.goruntule.Text = "Görüntüle";
            this.goruntule.UseVisualStyleBackColor = true;
            this.goruntule.Click += new System.EventHandler(this.cıkısYap_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisYap.Location = new System.Drawing.Point(565, 52);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(186, 65);
            this.cikisYap.TabIndex = 5;
            this.cikisYap.Text = "Yönetici Paneline Dön";
            this.cikisYap.UseVisualStyleBackColor = true;
            // 
            // goruntulemeTarih
            // 
            this.goruntulemeTarih.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goruntulemeTarih.FormattingEnabled = true;
            this.goruntulemeTarih.Location = new System.Drawing.Point(311, 71);
            this.goruntulemeTarih.Name = "goruntulemeTarih";
            this.goruntulemeTarih.Size = new System.Drawing.Size(185, 28);
            this.goruntulemeTarih.TabIndex = 7;
            this.goruntulemeTarih.Text = "Tarih Seşiniz";
            this.goruntulemeTarih.SelectedIndexChanged += new System.EventHandler(this.goruntuleme_SelectedIndexChanged);
            // 
            // gider
            // 
            this.gider.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gider.FormattingEnabled = true;
            this.gider.Location = new System.Drawing.Point(11, 89);
            this.gider.Name = "gider";
            this.gider.Size = new System.Drawing.Size(201, 28);
            this.gider.TabIndex = 8;
            this.gider.Text = "Gider Seçiniz";
            this.gider.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // eklemeTarih
            // 
            this.eklemeTarih.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eklemeTarih.FormattingEnabled = true;
            this.eklemeTarih.Location = new System.Drawing.Point(11, 133);
            this.eklemeTarih.Name = "eklemeTarih";
            this.eklemeTarih.Size = new System.Drawing.Size(201, 28);
            this.eklemeTarih.TabIndex = 9;
            this.eklemeTarih.Text = "Tarih Seçiniz";
            this.eklemeTarih.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // giderekle
            // 
            this.giderekle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giderekle.Location = new System.Drawing.Point(17, 225);
            this.giderekle.Margin = new System.Windows.Forms.Padding(2);
            this.giderekle.Name = "giderekle";
            this.giderekle.Size = new System.Drawing.Size(176, 56);
            this.giderekle.TabIndex = 11;
            this.giderekle.Text = "Gider Ekle ";
            this.giderekle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 145);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tarih";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Giderleri";
            this.Column2.Name = "Column2";
            this.Column2.Width = 155;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Personel Giderleri";
            this.Column3.Name = "Column3";
            this.Column3.Width = 165;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Elektrik";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Su";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Doğalgaz";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Vergiler";
            this.Column8.Name = "Column8";
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Gelir";
            this.Column9.Name = "Column9";
            this.Column9.Width = 60;
            // 
            // GelirGiderKontrolü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}