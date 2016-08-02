namespace Portakal
{
    partial class FirmaEkle
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
            this.txtFirmaID = new System.Windows.Forms.TextBox();
            this.lvFirmalar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtFirmAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirmaID
            // 
            this.txtFirmaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFirmaID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirmaID.Location = new System.Drawing.Point(12, 16);
            this.txtFirmaID.Name = "txtFirmaID";
            this.txtFirmaID.ReadOnly = true;
            this.txtFirmaID.Size = new System.Drawing.Size(0, 13);
            this.txtFirmaID.TabIndex = 53;
            // 
            // lvFirmalar
            // 
            this.lvFirmalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvFirmalar.FullRowSelect = true;
            this.lvFirmalar.GridLines = true;
            this.lvFirmalar.Location = new System.Drawing.Point(37, 108);
            this.lvFirmalar.Name = "lvFirmalar";
            this.lvFirmalar.Size = new System.Drawing.Size(314, 169);
            this.lvFirmalar.TabIndex = 52;
            this.lvFirmalar.UseCompatibleStateImageBehavior = false;
            this.lvFirmalar.View = System.Windows.Forms.View.Details;
            this.lvFirmalar.DoubleClick += new System.EventHandler(this.lvFirmalar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Firma Adı";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Açıklama";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FirmaID";
            this.columnHeader3.Width = 0;
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackgroundImage = global::Portakal.Resource.değiştir_jpg;
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(271, 55);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(41, 29);
            this.btnDegistir.TabIndex = 48;
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::Portakal.Resource.sil;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(318, 55);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(41, 29);
            this.btnSil.TabIndex = 49;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::Portakal.Resource.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(318, 19);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(41, 30);
            this.btnKaydet.TabIndex = 50;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImage = global::Portakal.Resource.yeni;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeni.Location = new System.Drawing.Point(271, 19);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(41, 30);
            this.btnYeni.TabIndex = 51;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(95, 45);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(159, 53);
            this.txtAciklama.TabIndex = 46;
            // 
            // txtFirmAd
            // 
            this.txtFirmAd.Location = new System.Drawing.Point(95, 16);
            this.txtFirmAd.Name = "txtFirmAd";
            this.txtFirmAd.ReadOnly = true;
            this.txtFirmAd.Size = new System.Drawing.Size(159, 20);
            this.txtFirmAd.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Firma Adı";
            // 
            // FirmaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(376, 289);
            this.Controls.Add(this.txtFirmaID);
            this.Controls.Add(this.lvFirmalar);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtFirmAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FirmaEkle";
            this.Text = "FİRMALAR";
            this.Load += new System.EventHandler(this.FirmaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirmaID;
        private System.Windows.Forms.ListView lvFirmalar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtFirmAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}