namespace Portakal
{
    partial class AracModel
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
            this.txtResimID = new System.Windows.Forms.TextBox();
            this.btnResimKaydet = new System.Windows.Forms.Button();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvModeller = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbVites = new System.Windows.Forms.ComboBox();
            this.cbKlima = new System.Windows.Forms.ComboBox();
            this.cbYakitTipi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.cbSiniflar = new System.Windows.Forms.ComboBox();
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSinifAdi = new System.Windows.Forms.TextBox();
            this.txtMarkaAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelID = new System.Windows.Forms.TextBox();
            this.txtSinifID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarkaID = new System.Windows.Forms.TextBox();
            this.txtModeleGoreArama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResimID
            // 
            this.txtResimID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResimID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResimID.Location = new System.Drawing.Point(319, 14);
            this.txtResimID.Name = "txtResimID";
            this.txtResimID.Size = new System.Drawing.Size(0, 13);
            this.txtResimID.TabIndex = 95;
            // 
            // btnResimKaydet
            // 
            this.btnResimKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimKaydet.Location = new System.Drawing.Point(448, 135);
            this.btnResimKaydet.Name = "btnResimKaydet";
            this.btnResimKaydet.Size = new System.Drawing.Size(75, 48);
            this.btnResimKaydet.TabIndex = 94;
            this.btnResimKaydet.Text = "Resim Kaydet";
            this.btnResimKaydet.UseVisualStyleBackColor = true;
            this.btnResimKaydet.Click += new System.EventHandler(this.btnResimKaydet_Click);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Resim";
            this.columnHeader11.Width = 0;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ModelID";
            this.columnHeader10.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MarkaID";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SınıfID";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Açıklama";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Yakıt Tipi";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vites Tipi";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Klima";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marka";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sınıf";
            this.columnHeader1.Width = 80;
            // 
            // lvModeller
            // 
            this.lvModeller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvModeller.FullRowSelect = true;
            this.lvModeller.GridLines = true;
            this.lvModeller.Location = new System.Drawing.Point(20, 270);
            this.lvModeller.Name = "lvModeller";
            this.lvModeller.Size = new System.Drawing.Size(535, 239);
            this.lvModeller.TabIndex = 93;
            this.lvModeller.UseCompatibleStateImageBehavior = false;
            this.lvModeller.View = System.Windows.Forms.View.Details;
            this.lvModeller.DoubleClick += new System.EventHandler(this.lvModeller_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbVites
            // 
            this.cbVites.FormattingEnabled = true;
            this.cbVites.Items.AddRange(new object[] {
            "Otomatik",
            "Manuel"});
            this.cbVites.Location = new System.Drawing.Point(95, 159);
            this.cbVites.Name = "cbVites";
            this.cbVites.Size = new System.Drawing.Size(114, 21);
            this.cbVites.TabIndex = 91;
            // 
            // cbKlima
            // 
            this.cbKlima.FormattingEnabled = true;
            this.cbKlima.Items.AddRange(new object[] {
            "Var",
            "Yok"});
            this.cbKlima.Location = new System.Drawing.Point(95, 132);
            this.cbKlima.Name = "cbKlima";
            this.cbKlima.Size = new System.Drawing.Size(114, 21);
            this.cbKlima.TabIndex = 92;
            // 
            // cbYakitTipi
            // 
            this.cbYakitTipi.DropDownWidth = 125;
            this.cbYakitTipi.FormattingEnabled = true;
            this.cbYakitTipi.Items.AddRange(new object[] {
            "Benzin",
            "Diesel",
            "Elektrik"});
            this.cbYakitTipi.Location = new System.Drawing.Point(95, 184);
            this.cbYakitTipi.Name = "cbYakitTipi";
            this.cbYakitTipi.Size = new System.Drawing.Size(114, 21);
            this.cbYakitTipi.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Yakıt Tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Vites Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Klima";
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbResim.Location = new System.Drawing.Point(356, 14);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(158, 107);
            this.pbResim.TabIndex = 86;
            this.pbResim.TabStop = false;
            // 
            // cbSiniflar
            // 
            this.cbSiniflar.DropDownWidth = 125;
            this.cbSiniflar.Enabled = false;
            this.cbSiniflar.FormattingEnabled = true;
            this.cbSiniflar.Location = new System.Drawing.Point(260, 46);
            this.cbSiniflar.Name = "cbSiniflar";
            this.cbSiniflar.Size = new System.Drawing.Size(16, 21);
            this.cbSiniflar.TabIndex = 83;
            this.cbSiniflar.SelectedIndexChanged += new System.EventHandler(this.cbSiniflar_SelectedIndexChanged);
            // 
            // cbMarkalar
            // 
            this.cbMarkalar.DropDownWidth = 125;
            this.cbMarkalar.Enabled = false;
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Location = new System.Drawing.Point(260, 72);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(16, 21);
            this.cbMarkalar.TabIndex = 84;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // btnResim
            // 
            this.btnResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.Location = new System.Drawing.Point(341, 135);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(75, 48);
            this.btnResim.TabIndex = 76;
            this.btnResim.Text = "Resim Yükle";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackgroundImage = global::Portakal.Resource.değiştir_jpg;
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.Location = new System.Drawing.Point(145, 6);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(47, 35);
            this.btnDegistir.TabIndex = 96;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = global::Portakal.Resource.sil;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(198, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(44, 35);
            this.btnSil.TabIndex = 77;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = global::Portakal.Resource.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(94, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(46, 35);
            this.btnKaydet.TabIndex = 78;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.Transparent;
            this.btnYeni.BackgroundImage = global::Portakal.Resource.yeni;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeni.Location = new System.Drawing.Point(42, 6);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(46, 35);
            this.btnYeni.TabIndex = 79;
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(95, 211);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(159, 53);
            this.txtAciklama.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(95, 101);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(159, 20);
            this.txtModel.TabIndex = 0;
            // 
            // txtSinifAdi
            // 
            this.txtSinifAdi.Location = new System.Drawing.Point(95, 47);
            this.txtSinifAdi.Name = "txtSinifAdi";
            this.txtSinifAdi.ReadOnly = true;
            this.txtSinifAdi.Size = new System.Drawing.Size(159, 20);
            this.txtSinifAdi.TabIndex = 73;
            // 
            // txtMarkaAd
            // 
            this.txtMarkaAd.Location = new System.Drawing.Point(95, 73);
            this.txtMarkaAd.Name = "txtMarkaAd";
            this.txtMarkaAd.ReadOnly = true;
            this.txtMarkaAd.Size = new System.Drawing.Size(159, 20);
            this.txtMarkaAd.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Model Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Sınıfı";
            // 
            // txtModelID
            // 
            this.txtModelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtModelID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelID.Location = new System.Drawing.Point(12, 101);
            this.txtModelID.Name = "txtModelID";
            this.txtModelID.ReadOnly = true;
            this.txtModelID.Size = new System.Drawing.Size(0, 13);
            this.txtModelID.TabIndex = 81;
            // 
            // txtSinifID
            // 
            this.txtSinifID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSinifID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinifID.Location = new System.Drawing.Point(12, 47);
            this.txtSinifID.Name = "txtSinifID";
            this.txtSinifID.ReadOnly = true;
            this.txtSinifID.Size = new System.Drawing.Size(0, 13);
            this.txtSinifID.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Marka Adı";
            // 
            // txtMarkaID
            // 
            this.txtMarkaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMarkaID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarkaID.Location = new System.Drawing.Point(12, 73);
            this.txtMarkaID.Name = "txtMarkaID";
            this.txtMarkaID.ReadOnly = true;
            this.txtMarkaID.Size = new System.Drawing.Size(0, 13);
            this.txtMarkaID.TabIndex = 82;
            // 
            // txtModeleGoreArama
            // 
            this.txtModeleGoreArama.Location = new System.Drawing.Point(341, 244);
            this.txtModeleGoreArama.Name = "txtModeleGoreArama";
            this.txtModeleGoreArama.Size = new System.Drawing.Size(214, 20);
            this.txtModeleGoreArama.TabIndex = 2;
            this.txtModeleGoreArama.TextChanged += new System.EventHandler(this.txtModeleGoreArama_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(338, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Modele Göre Arama";
            // 
            // AracModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(580, 459);
            this.Controls.Add(this.txtModeleGoreArama);
            this.Controls.Add(this.txtResimID);
            this.Controls.Add(this.btnResimKaydet);
            this.Controls.Add(this.lvModeller);
            this.Controls.Add(this.cbVites);
            this.Controls.Add(this.cbKlima);
            this.Controls.Add(this.cbYakitTipi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.cbSiniflar);
            this.Controls.Add(this.cbMarkalar);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtSinifAdi);
            this.Controls.Add(this.txtMarkaAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelID);
            this.Controls.Add(this.txtSinifID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarkaID);
            this.Name = "AracModel";
            this.Text = "MODELLER";
            this.Load += new System.EventHandler(this.AracModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResimID;
        private System.Windows.Forms.Button btnResimKaydet;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvModeller;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbVites;
        private System.Windows.Forms.ComboBox cbKlima;
        private System.Windows.Forms.ComboBox cbYakitTipi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.ComboBox cbSiniflar;
        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtSinifAdi;
        private System.Windows.Forms.TextBox txtMarkaAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelID;
        private System.Windows.Forms.TextBox txtSinifID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarkaID;
        private System.Windows.Forms.TextBox txtModeleGoreArama;
        private System.Windows.Forms.Label label8;
    }
}