namespace Portakal
{
    partial class KalkisYeriSorgulama
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKisaltma = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtSehirAd = new System.Windows.Forms.TextBox();
            this.txtHavalimaniKodu = new System.Windows.Forms.TextBox();
            this.txtHavalimaniAdi = new System.Windows.Forms.TextBox();
            this.lvHavalimanlari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Şehir Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Kısaltma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Havalimanı Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Kodu:";
            // 
            // txtKisaltma
            // 
            this.txtKisaltma.Location = new System.Drawing.Point(57, 25);
            this.txtKisaltma.Name = "txtKisaltma";
            this.txtKisaltma.Size = new System.Drawing.Size(68, 20);
            this.txtKisaltma.TabIndex = 34;
            this.txtKisaltma.TextChanged += new System.EventHandler(this.txtKisaltma_TextChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(379, 25);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(109, 20);
            this.txtAciklama.TabIndex = 33;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // txtSehirAd
            // 
            this.txtSehirAd.Location = new System.Drawing.Point(131, 25);
            this.txtSehirAd.Name = "txtSehirAd";
            this.txtSehirAd.Size = new System.Drawing.Size(91, 20);
            this.txtSehirAd.TabIndex = 35;
            this.txtSehirAd.TextChanged += new System.EventHandler(this.txtSehirAd_TextChanged);
            // 
            // txtHavalimaniKodu
            // 
            this.txtHavalimaniKodu.Location = new System.Drawing.Point(12, 25);
            this.txtHavalimaniKodu.Name = "txtHavalimaniKodu";
            this.txtHavalimaniKodu.ReadOnly = true;
            this.txtHavalimaniKodu.Size = new System.Drawing.Size(39, 20);
            this.txtHavalimaniKodu.TabIndex = 36;
            this.txtHavalimaniKodu.TextChanged += new System.EventHandler(this.txthavayoluKodu_TextChanged);
            // 
            // txtHavalimaniAdi
            // 
            this.txtHavalimaniAdi.Location = new System.Drawing.Point(228, 25);
            this.txtHavalimaniAdi.Name = "txtHavalimaniAdi";
            this.txtHavalimaniAdi.Size = new System.Drawing.Size(145, 20);
            this.txtHavalimaniAdi.TabIndex = 37;
            this.txtHavalimaniAdi.TextChanged += new System.EventHandler(this.txtHavalimaniAdi_TextChanged);
            // 
            // lvHavalimanlari
            // 
            this.lvHavalimanlari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.lvHavalimanlari.FullRowSelect = true;
            this.lvHavalimanlari.GridLines = true;
            this.lvHavalimanlari.Location = new System.Drawing.Point(12, 51);
            this.lvHavalimanlari.Name = "lvHavalimanlari";
            this.lvHavalimanlari.Size = new System.Drawing.Size(491, 321);
            this.lvHavalimanlari.TabIndex = 32;
            this.lvHavalimanlari.UseCompatibleStateImageBehavior = false;
            this.lvHavalimanlari.View = System.Windows.Forms.View.Details;
            this.lvHavalimanlari.DoubleClick += new System.EventHandler(this.lvHavalimanlari_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kodu";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kısaltması";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Havalimanı Adi";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 2;
            this.columnHeader5.Text = "Şehir Adı";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Açıklama";
            this.columnHeader4.Width = 115;
            // 
            // KalkisYeriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 378);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKisaltma);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtSehirAd);
            this.Controls.Add(this.txtHavalimaniKodu);
            this.Controls.Add(this.txtHavalimaniAdi);
            this.Controls.Add(this.lvHavalimanlari);
            this.Name = "KalkisYeriSorgulama";
            this.Text = "Kalkış Yeri Sorgulama";
            this.Load += new System.EventHandler(this.KalkisYeriSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKisaltma;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtSehirAd;
        private System.Windows.Forms.TextBox txtHavalimaniKodu;
        private System.Windows.Forms.TextBox txtHavalimaniAdi;
        private System.Windows.Forms.ListView lvHavalimanlari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}