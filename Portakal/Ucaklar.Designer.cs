namespace Portakal
{
    partial class Ucaklar
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
            this.txtUcakAdi = new System.Windows.Forms.TextBox();
            this.txtHavayollariAdi = new System.Windows.Forms.TextBox();
            this.txtModelAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnHavayoluBul = new System.Windows.Forms.Button();
            this.btnModelBul = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.lvUcaklar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHavayolllariID = new System.Windows.Forms.TextBox();
            this.txtModelID = new System.Windows.Forms.TextBox();
            this.txtUcakID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUcakAdi
            // 
            this.txtUcakAdi.Location = new System.Drawing.Point(80, 13);
            this.txtUcakAdi.Name = "txtUcakAdi";
            this.txtUcakAdi.ReadOnly = true;
            this.txtUcakAdi.Size = new System.Drawing.Size(329, 20);
            this.txtUcakAdi.TabIndex = 0;
            // 
            // txtHavayollariAdi
            // 
            this.txtHavayollariAdi.Location = new System.Drawing.Point(80, 40);
            this.txtHavayollariAdi.Name = "txtHavayollariAdi";
            this.txtHavayollariAdi.ReadOnly = true;
            this.txtHavayollariAdi.Size = new System.Drawing.Size(288, 20);
            this.txtHavayollariAdi.TabIndex = 1;
            // 
            // txtModelAdi
            // 
            this.txtModelAdi.Location = new System.Drawing.Point(80, 67);
            this.txtModelAdi.Name = "txtModelAdi";
            this.txtModelAdi.ReadOnly = true;
            this.txtModelAdi.Size = new System.Drawing.Size(288, 20);
            this.txtModelAdi.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(80, 94);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(329, 20);
            this.txtAciklama.TabIndex = 3;
            // 
            // btnHavayoluBul
            // 
            this.btnHavayoluBul.Location = new System.Drawing.Point(372, 40);
            this.btnHavayoluBul.Name = "btnHavayoluBul";
            this.btnHavayoluBul.Size = new System.Drawing.Size(37, 21);
            this.btnHavayoluBul.TabIndex = 49;
            this.btnHavayoluBul.Text = "BUL";
            this.btnHavayoluBul.UseVisualStyleBackColor = true;
            this.btnHavayoluBul.Click += new System.EventHandler(this.btnHavayoluBul_Click);
            // 
            // btnModelBul
            // 
            this.btnModelBul.Location = new System.Drawing.Point(372, 67);
            this.btnModelBul.Name = "btnModelBul";
            this.btnModelBul.Size = new System.Drawing.Size(37, 21);
            this.btnModelBul.TabIndex = 50;
            this.btnModelBul.Text = "BUL";
            this.btnModelBul.UseVisualStyleBackColor = true;
            this.btnModelBul.Click += new System.EventHandler(this.btnModelBul_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(253, 120);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 51;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(334, 120);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 52;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(161, 120);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 53;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(80, 120);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 54;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lvUcaklar
            // 
            this.lvUcaklar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvUcaklar.FullRowSelect = true;
            this.lvUcaklar.GridLines = true;
            this.lvUcaklar.Location = new System.Drawing.Point(15, 158);
            this.lvUcaklar.Name = "lvUcaklar";
            this.lvUcaklar.Size = new System.Drawing.Size(411, 189);
            this.lvUcaklar.TabIndex = 55;
            this.lvUcaklar.UseCompatibleStateImageBehavior = false;
            this.lvUcaklar.View = System.Windows.Forms.View.Details;
            this.lvUcaklar.DoubleClick += new System.EventHandler(this.lvUcaklar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "UcakID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Uçak Adı";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Havayolları Adı";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Havayolları ID";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Model";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Model ID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Açıklama";
            this.columnHeader7.Width = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Uçak Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Havayolları:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Açıklama:";
            // 
            // txtHavayolllariID
            // 
            this.txtHavayolllariID.Location = new System.Drawing.Point(414, 40);
            this.txtHavayolllariID.Name = "txtHavayolllariID";
            this.txtHavayolllariID.ReadOnly = true;
            this.txtHavayolllariID.Size = new System.Drawing.Size(10, 20);
            this.txtHavayolllariID.TabIndex = 0;
            // 
            // txtModelID
            // 
            this.txtModelID.Location = new System.Drawing.Point(414, 68);
            this.txtModelID.Name = "txtModelID";
            this.txtModelID.ReadOnly = true;
            this.txtModelID.Size = new System.Drawing.Size(10, 20);
            this.txtModelID.TabIndex = 0;
            // 
            // txtUcakID
            // 
            this.txtUcakID.Location = new System.Drawing.Point(414, 13);
            this.txtUcakID.Name = "txtUcakID";
            this.txtUcakID.ReadOnly = true;
            this.txtUcakID.Size = new System.Drawing.Size(10, 20);
            this.txtUcakID.TabIndex = 0;
            // 
            // Ucaklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 359);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvUcaklar);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnModelBul);
            this.Controls.Add(this.btnHavayoluBul);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtModelAdi);
            this.Controls.Add(this.txtHavayollariAdi);
            this.Controls.Add(this.txtModelID);
            this.Controls.Add(this.txtUcakID);
            this.Controls.Add(this.txtHavayolllariID);
            this.Controls.Add(this.txtUcakAdi);
            this.Name = "Ucaklar";
            this.Text = "Uçaklar";
            this.Load += new System.EventHandler(this.Ucaklar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUcakAdi;
        private System.Windows.Forms.TextBox txtHavayollariAdi;
        private System.Windows.Forms.TextBox txtModelAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnHavayoluBul;
        private System.Windows.Forms.Button btnModelBul;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ListView lvUcaklar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHavayolllariID;
        private System.Windows.Forms.TextBox txtModelID;
        private System.Windows.Forms.TextBox txtUcakID;
    }
}