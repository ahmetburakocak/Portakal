namespace Portakal
{
    partial class Havayollari
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
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.lvHavayolları = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtHavayoluAdi = new System.Windows.Forms.TextBox();
            this.txtUlkeAdi = new System.Windows.Forms.TextBox();
            this.txtHavayoluKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUlkeKodu = new System.Windows.Forms.TextBox();
            this.txtKisaltmasi = new System.Windows.Forms.TextBox();
            this.btnUlkeBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(433, 75);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 24;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(433, 104);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(433, 46);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 26;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(433, 17);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 27;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lvHavayolları
            // 
            this.lvHavayolları.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvHavayolları.FullRowSelect = true;
            this.lvHavayolları.GridLines = true;
            this.lvHavayolları.Location = new System.Drawing.Point(6, 152);
            this.lvHavayolları.Name = "lvHavayolları";
            this.lvHavayolları.Size = new System.Drawing.Size(506, 250);
            this.lvHavayolları.TabIndex = 23;
            this.lvHavayolları.UseCompatibleStateImageBehavior = false;
            this.lvHavayolları.View = System.Windows.Forms.View.Details;
            this.lvHavayolları.DoubleClick += new System.EventHandler(this.lvHavayolları_DoubleClick);
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
            this.columnHeader3.Text = "Havayolları Adı";
            this.columnHeader3.Width = 162;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ülke Adı";
            this.columnHeader4.Width = 155;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Açıklama";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ülke Kodu";
            this.columnHeader6.Width = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 87);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(307, 59);
            this.txtAciklama.TabIndex = 19;
            // 
            // txtHavayoluAdi
            // 
            this.txtHavayoluAdi.Location = new System.Drawing.Point(120, 42);
            this.txtHavayoluAdi.Name = "txtHavayoluAdi";
            this.txtHavayoluAdi.ReadOnly = true;
            this.txtHavayoluAdi.Size = new System.Drawing.Size(307, 20);
            this.txtHavayoluAdi.TabIndex = 20;
            // 
            // txtUlkeAdi
            // 
            this.txtUlkeAdi.Location = new System.Drawing.Point(120, 65);
            this.txtUlkeAdi.Name = "txtUlkeAdi";
            this.txtUlkeAdi.ReadOnly = true;
            this.txtUlkeAdi.Size = new System.Drawing.Size(268, 20);
            this.txtUlkeAdi.TabIndex = 21;
            // 
            // txtHavayoluKodu
            // 
            this.txtHavayoluKodu.Location = new System.Drawing.Point(120, 20);
            this.txtHavayoluKodu.Name = "txtHavayoluKodu";
            this.txtHavayoluKodu.ReadOnly = true;
            this.txtHavayoluKodu.Size = new System.Drawing.Size(118, 20);
            this.txtHavayoluKodu.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Havayolu Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ülke Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Havayolu Kodu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Kısatlması:";
            // 
            // txtUlkeKodu
            // 
            this.txtUlkeKodu.Location = new System.Drawing.Point(2, 65);
            this.txtUlkeKodu.Name = "txtUlkeKodu";
            this.txtUlkeKodu.ReadOnly = true;
            this.txtUlkeKodu.Size = new System.Drawing.Size(10, 20);
            this.txtUlkeKodu.TabIndex = 29;
            // 
            // txtKisaltmasi
            // 
            this.txtKisaltmasi.Location = new System.Drawing.Point(309, 20);
            this.txtKisaltmasi.Multiline = true;
            this.txtKisaltmasi.Name = "txtKisaltmasi";
            this.txtKisaltmasi.ReadOnly = true;
            this.txtKisaltmasi.Size = new System.Drawing.Size(118, 20);
            this.txtKisaltmasi.TabIndex = 30;
            // 
            // btnUlkeBul
            // 
            this.btnUlkeBul.Location = new System.Drawing.Point(390, 64);
            this.btnUlkeBul.Name = "btnUlkeBul";
            this.btnUlkeBul.Size = new System.Drawing.Size(37, 21);
            this.btnUlkeBul.TabIndex = 31;
            this.btnUlkeBul.Text = "BUL";
            this.btnUlkeBul.UseVisualStyleBackColor = true;
            this.btnUlkeBul.Click += new System.EventHandler(this.btnUlkeBul_Click);
            // 
            // Havayollari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 412);
            this.Controls.Add(this.btnUlkeBul);
            this.Controls.Add(this.txtKisaltmasi);
            this.Controls.Add(this.txtUlkeKodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lvHavayolları);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtHavayoluAdi);
            this.Controls.Add(this.txtUlkeAdi);
            this.Controls.Add(this.txtHavayoluKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Havayollari";
            this.Text = "Havayolları";
            this.Load += new System.EventHandler(this.Havayollari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ListView lvHavayolları;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtHavayoluAdi;
        private System.Windows.Forms.TextBox txtUlkeAdi;
        private System.Windows.Forms.TextBox txtHavayoluKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUlkeKodu;
        private System.Windows.Forms.TextBox txtKisaltmasi;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnUlkeBul;
    }
}