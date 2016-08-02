namespace Portakal
{
    partial class Havalimanlari
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
            this.btnSehirBul = new System.Windows.Forms.Button();
            this.txtKisaltmasi = new System.Windows.Forms.TextBox();
            this.txtSehirKodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.lvHavalimanlari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtHavalimaniAdi = new System.Windows.Forms.TextBox();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.txtHavalimaniKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSehirBul
            // 
            this.btnSehirBul.Location = new System.Drawing.Point(389, 50);
            this.btnSehirBul.Name = "btnSehirBul";
            this.btnSehirBul.Size = new System.Drawing.Size(37, 21);
            this.btnSehirBul.TabIndex = 48;
            this.btnSehirBul.Text = "BUL";
            this.btnSehirBul.UseVisualStyleBackColor = true;
            this.btnSehirBul.Click += new System.EventHandler(this.btnSehirBul_Click);
            // 
            // txtKisaltmasi
            // 
            this.txtKisaltmasi.Location = new System.Drawing.Point(308, 6);
            this.txtKisaltmasi.Multiline = true;
            this.txtKisaltmasi.Name = "txtKisaltmasi";
            this.txtKisaltmasi.ReadOnly = true;
            this.txtKisaltmasi.Size = new System.Drawing.Size(118, 20);
            this.txtKisaltmasi.TabIndex = 47;
            // 
            // txtSehirKodu
            // 
            this.txtSehirKodu.Location = new System.Drawing.Point(1, 51);
            this.txtSehirKodu.Name = "txtSehirKodu";
            this.txtSehirKodu.ReadOnly = true;
            this.txtSehirKodu.Size = new System.Drawing.Size(10, 20);
            this.txtSehirKodu.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Kısatlması:";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(432, 61);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 41;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(432, 90);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 42;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(432, 32);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 43;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(432, 3);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 44;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lvHavalimanlari
            // 
            this.lvHavalimanlari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvHavalimanlari.FullRowSelect = true;
            this.lvHavalimanlari.GridLines = true;
            this.lvHavalimanlari.Location = new System.Drawing.Point(12, 138);
            this.lvHavalimanlari.Name = "lvHavalimanlari";
            this.lvHavalimanlari.Size = new System.Drawing.Size(495, 250);
            this.lvHavalimanlari.TabIndex = 40;
            this.lvHavalimanlari.UseCompatibleStateImageBehavior = false;
            this.lvHavalimanlari.View = System.Windows.Forms.View.Details;
            this.lvHavalimanlari.DoubleClick += new System.EventHandler(this.lvHavalimanlari_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kodu";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kısaltma";
            this.columnHeader2.Width = 51;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Havalimanı Adı";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Şehir Adı";
            this.columnHeader4.Width = 134;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Açıklama";
            this.columnHeader5.Width = 159;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Şehir Kodu";
            this.columnHeader6.Width = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(119, 73);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(307, 59);
            this.txtAciklama.TabIndex = 36;
            // 
            // txtHavalimaniAdi
            // 
            this.txtHavalimaniAdi.Location = new System.Drawing.Point(119, 28);
            this.txtHavalimaniAdi.Name = "txtHavalimaniAdi";
            this.txtHavalimaniAdi.ReadOnly = true;
            this.txtHavalimaniAdi.Size = new System.Drawing.Size(307, 20);
            this.txtHavalimaniAdi.TabIndex = 37;
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(119, 51);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.ReadOnly = true;
            this.txtSehirAdi.Size = new System.Drawing.Size(268, 20);
            this.txtSehirAdi.TabIndex = 38;
            // 
            // txtHavalimaniKodu
            // 
            this.txtHavalimaniKodu.Location = new System.Drawing.Point(119, 6);
            this.txtHavalimaniKodu.Name = "txtHavalimaniKodu";
            this.txtHavalimaniKodu.ReadOnly = true;
            this.txtHavalimaniKodu.Size = new System.Drawing.Size(118, 20);
            this.txtHavalimaniKodu.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Havalimanı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Şehir Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Havalimanı Kodu:";
            // 
            // Havalimanlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 395);
            this.Controls.Add(this.btnSehirBul);
            this.Controls.Add(this.txtKisaltmasi);
            this.Controls.Add(this.txtSehirKodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lvHavalimanlari);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtHavalimaniAdi);
            this.Controls.Add(this.txtSehirAdi);
            this.Controls.Add(this.txtHavalimaniKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Havalimanlari";
            this.Text = "Havalimanları";
            this.Load += new System.EventHandler(this.Havalimanlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSehirBul;
        private System.Windows.Forms.TextBox txtKisaltmasi;
        private System.Windows.Forms.TextBox txtSehirKodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ListView lvHavalimanlari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtHavalimaniAdi;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.TextBox txtHavalimaniKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}