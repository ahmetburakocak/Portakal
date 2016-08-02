namespace Portakal
{
    partial class AracEkle
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
            this.txtMarkaID = new System.Windows.Forms.TextBox();
            this.lvAraclar = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbFirmaAdi = new System.Windows.Forms.ComboBox();
            this.cbHavalimani = new System.Windows.Forms.ComboBox();
            this.cbModeller = new System.Windows.Forms.ComboBox();
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.txtMarkaAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlakaID = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtHavalimaniAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirmaID = new System.Windows.Forms.TextBox();
            this.txtHavalimaniID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelID = new System.Windows.Forms.TextBox();
            this.txtPlakayaGoreArama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarkaID
            // 
            this.txtMarkaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMarkaID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarkaID.Location = new System.Drawing.Point(36, 6);
            this.txtMarkaID.Name = "txtMarkaID";
            this.txtMarkaID.ReadOnly = true;
            this.txtMarkaID.Size = new System.Drawing.Size(0, 13);
            this.txtMarkaID.TabIndex = 83;
            // 
            // lvAraclar
            // 
            this.lvAraclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvAraclar.FullRowSelect = true;
            this.lvAraclar.GridLines = true;
            this.lvAraclar.Location = new System.Drawing.Point(42, 147);
            this.lvAraclar.Name = "lvAraclar";
            this.lvAraclar.Size = new System.Drawing.Size(621, 265);
            this.lvAraclar.TabIndex = 80;
            this.lvAraclar.UseCompatibleStateImageBehavior = false;
            this.lvAraclar.View = System.Windows.Forms.View.Details;
            this.lvAraclar.DoubleClick += new System.EventHandler(this.lvAraclar_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Plaka";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Marka";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Model";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Havalimanı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Firma";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KiradaMı";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ModelID";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "HavalimaniID";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "FirmaID";
            this.columnHeader9.Width = 0;
            // 
            // cbFirmaAdi
            // 
            this.cbFirmaAdi.DropDownWidth = 175;
            this.cbFirmaAdi.Enabled = false;
            this.cbFirmaAdi.FormattingEnabled = true;
            this.cbFirmaAdi.Location = new System.Drawing.Point(284, 84);
            this.cbFirmaAdi.Name = "cbFirmaAdi";
            this.cbFirmaAdi.Size = new System.Drawing.Size(25, 21);
            this.cbFirmaAdi.TabIndex = 79;
            this.cbFirmaAdi.SelectedIndexChanged += new System.EventHandler(this.cbFirmaAdi_SelectedIndexChanged);
            // 
            // cbHavalimani
            // 
            this.cbHavalimani.DropDownWidth = 175;
            this.cbHavalimani.Enabled = false;
            this.cbHavalimani.FormattingEnabled = true;
            this.cbHavalimani.Location = new System.Drawing.Point(284, 58);
            this.cbHavalimani.Name = "cbHavalimani";
            this.cbHavalimani.Size = new System.Drawing.Size(25, 21);
            this.cbHavalimani.TabIndex = 78;
            this.cbHavalimani.SelectedIndexChanged += new System.EventHandler(this.cbHavalimani_SelectedIndexChanged);
            // 
            // cbModeller
            // 
            this.cbModeller.DropDownWidth = 175;
            this.cbModeller.Enabled = false;
            this.cbModeller.FormattingEnabled = true;
            this.cbModeller.Location = new System.Drawing.Point(284, 32);
            this.cbModeller.Name = "cbModeller";
            this.cbModeller.Size = new System.Drawing.Size(25, 21);
            this.cbModeller.TabIndex = 77;
            this.cbModeller.SelectedIndexChanged += new System.EventHandler(this.cbModeller_SelectedIndexChanged);
            // 
            // cbMarkalar
            // 
            this.cbMarkalar.DropDownWidth = 125;
            this.cbMarkalar.Enabled = false;
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Location = new System.Drawing.Point(284, 5);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(25, 21);
            this.cbMarkalar.TabIndex = 84;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // txtMarkaAd
            // 
            this.txtMarkaAd.Location = new System.Drawing.Point(119, 6);
            this.txtMarkaAd.Name = "txtMarkaAd";
            this.txtMarkaAd.ReadOnly = true;
            this.txtMarkaAd.Size = new System.Drawing.Size(159, 20);
            this.txtMarkaAd.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Marka Adı";
            // 
            // txtPlakaID
            // 
            this.txtPlakaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPlakaID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlakaID.Location = new System.Drawing.Point(325, 5);
            this.txtPlakaID.Name = "txtPlakaID";
            this.txtPlakaID.ReadOnly = true;
            this.txtPlakaID.Size = new System.Drawing.Size(0, 13);
            this.txtPlakaID.TabIndex = 85;
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackgroundImage = global::Portakal.Resource.değiştir_jpg;
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(489, 6);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(47, 39);
            this.btnDegistir.TabIndex = 70;
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::Portakal.Resource.sil;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(542, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 39);
            this.btnSil.TabIndex = 71;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::Portakal.Resource.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(436, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(47, 39);
            this.btnKaydet.TabIndex = 72;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImage = global::Portakal.Resource.yeni;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeni.Location = new System.Drawing.Point(384, 6);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(46, 39);
            this.btnYeni.TabIndex = 73;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(150, 121);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(159, 20);
            this.txtFiyat.TabIndex = 0;
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Fiyat";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(119, 84);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.ReadOnly = true;
            this.txtFirmaAdi.Size = new System.Drawing.Size(159, 20);
            this.txtFirmaAdi.TabIndex = 68;
            // 
            // txtHavalimaniAdi
            // 
            this.txtHavalimaniAdi.Location = new System.Drawing.Point(119, 58);
            this.txtHavalimaniAdi.Name = "txtHavalimaniAdi";
            this.txtHavalimaniAdi.ReadOnly = true;
            this.txtHavalimaniAdi.Size = new System.Drawing.Size(159, 20);
            this.txtHavalimaniAdi.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Firma";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(119, 32);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(159, 20);
            this.txtModel.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Havalimanı";
            // 
            // txtFirmaID
            // 
            this.txtFirmaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFirmaID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirmaID.Location = new System.Drawing.Point(36, 84);
            this.txtFirmaID.Name = "txtFirmaID";
            this.txtFirmaID.ReadOnly = true;
            this.txtFirmaID.Size = new System.Drawing.Size(0, 13);
            this.txtFirmaID.TabIndex = 75;
            // 
            // txtHavalimaniID
            // 
            this.txtHavalimaniID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtHavalimaniID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHavalimaniID.Location = new System.Drawing.Point(36, 58);
            this.txtHavalimaniID.Name = "txtHavalimaniID";
            this.txtHavalimaniID.ReadOnly = true;
            this.txtHavalimaniID.Size = new System.Drawing.Size(0, 13);
            this.txtHavalimaniID.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Model Adı";
            // 
            // txtModelID
            // 
            this.txtModelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtModelID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelID.Location = new System.Drawing.Point(36, 32);
            this.txtModelID.Name = "txtModelID";
            this.txtModelID.ReadOnly = true;
            this.txtModelID.Size = new System.Drawing.Size(0, 13);
            this.txtModelID.TabIndex = 76;
            // 
            // txtPlakayaGoreArama
            // 
            this.txtPlakayaGoreArama.Location = new System.Drawing.Point(383, 124);
            this.txtPlakayaGoreArama.Name = "txtPlakayaGoreArama";
            this.txtPlakayaGoreArama.Size = new System.Drawing.Size(114, 20);
            this.txtPlakayaGoreArama.TabIndex = 1;
            this.txtPlakayaGoreArama.TextChanged += new System.EventHandler(this.txtPlakayaGoreArama_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Plakaya Göre Arama";
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(699, 417);
            this.Controls.Add(this.txtPlakayaGoreArama);
            this.Controls.Add(this.txtMarkaID);
            this.Controls.Add(this.lvAraclar);
            this.Controls.Add(this.cbFirmaAdi);
            this.Controls.Add(this.cbHavalimani);
            this.Controls.Add(this.cbModeller);
            this.Controls.Add(this.cbMarkalar);
            this.Controls.Add(this.txtMarkaAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlakaID);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.txtHavalimaniAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirmaID);
            this.Controls.Add(this.txtHavalimaniID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelID);
            this.Name = "AracEkle";
            this.Text = "Araç Tanımlanması";
            this.Load += new System.EventHandler(this.AracEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarkaID;
        private System.Windows.Forms.ListView lvAraclar;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ComboBox cbFirmaAdi;
        private System.Windows.Forms.ComboBox cbHavalimani;
        private System.Windows.Forms.ComboBox cbModeller;
        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.TextBox txtMarkaAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlakaID;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtHavalimaniAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirmaID;
        private System.Windows.Forms.TextBox txtHavalimaniID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelID;
        private System.Windows.Forms.TextBox txtPlakayaGoreArama;
        private System.Windows.Forms.Label label5;
    }
}