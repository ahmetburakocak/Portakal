namespace Portakal
{
    partial class Sehirler
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
            this.lvSehirler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.txtUlkeAdi = new System.Windows.Forms.TextBox();
            this.txtSehirKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUlkeKodu = new System.Windows.Forms.TextBox();
            this.btnUlkeBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(438, 84);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 24;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(438, 113);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(438, 55);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 26;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(438, 26);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 27;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lvSehirler
            // 
            this.lvSehirler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSehirler.FullRowSelect = true;
            this.lvSehirler.GridLines = true;
            this.lvSehirler.Location = new System.Drawing.Point(6, 170);
            this.lvSehirler.Name = "lvSehirler";
            this.lvSehirler.Size = new System.Drawing.Size(507, 241);
            this.lvSehirler.TabIndex = 23;
            this.lvSehirler.UseCompatibleStateImageBehavior = false;
            this.lvSehirler.View = System.Windows.Forms.View.Details;
            this.lvSehirler.DoubleClick += new System.EventHandler(this.lvSehirler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Şehir Kodu";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Şehir Adı";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ülke Adı";
            this.columnHeader3.Width = 158;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Açıklama";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ülke Kodu";
            this.columnHeader5.Width = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(125, 96);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(307, 68);
            this.txtAciklama.TabIndex = 19;
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(125, 51);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.ReadOnly = true;
            this.txtSehirAdi.Size = new System.Drawing.Size(307, 20);
            this.txtSehirAdi.TabIndex = 20;
            // 
            // txtUlkeAdi
            // 
            this.txtUlkeAdi.Location = new System.Drawing.Point(125, 74);
            this.txtUlkeAdi.Name = "txtUlkeAdi";
            this.txtUlkeAdi.ReadOnly = true;
            this.txtUlkeAdi.Size = new System.Drawing.Size(269, 20);
            this.txtUlkeAdi.TabIndex = 21;
            // 
            // txtSehirKodu
            // 
            this.txtSehirKodu.Location = new System.Drawing.Point(125, 25);
            this.txtSehirKodu.Name = "txtSehirKodu";
            this.txtSehirKodu.ReadOnly = true;
            this.txtSehirKodu.Size = new System.Drawing.Size(307, 20);
            this.txtSehirKodu.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ülke Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şehir Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Şehir Kodu:";
            // 
            // txtUlkeKodu
            // 
            this.txtUlkeKodu.Location = new System.Drawing.Point(6, 74);
            this.txtUlkeKodu.Name = "txtUlkeKodu";
            this.txtUlkeKodu.ReadOnly = true;
            this.txtUlkeKodu.Size = new System.Drawing.Size(10, 20);
            this.txtUlkeKodu.TabIndex = 28;
            // 
            // btnUlkeBul
            // 
            this.btnUlkeBul.Location = new System.Drawing.Point(395, 74);
            this.btnUlkeBul.Name = "btnUlkeBul";
            this.btnUlkeBul.Size = new System.Drawing.Size(37, 21);
            this.btnUlkeBul.TabIndex = 29;
            this.btnUlkeBul.Text = "BUL";
            this.btnUlkeBul.UseVisualStyleBackColor = true;
            this.btnUlkeBul.Click += new System.EventHandler(this.btnUlkeBul_Click);
            // 
            // Sehirler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 437);
            this.Controls.Add(this.btnUlkeBul);
            this.Controls.Add(this.txtUlkeKodu);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lvSehirler);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtSehirAdi);
            this.Controls.Add(this.txtUlkeAdi);
            this.Controls.Add(this.txtSehirKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sehirler";
            this.Text = "Şehirler";
            this.Load += new System.EventHandler(this.Sehirler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ListView lvSehirler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.TextBox txtUlkeAdi;
        private System.Windows.Forms.TextBox txtSehirKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUlkeKodu;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnUlkeBul;
    }
}