namespace Portakal
{
    partial class SehirSorgulama
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.txtSehirKodu = new System.Windows.Forms.TextBox();
            this.txtUlkeAdi = new System.Windows.Forms.TextBox();
            this.lvSehirler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Şehir Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ülke Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Şehir Kodu:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(336, 30);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(149, 20);
            this.txtAciklama.TabIndex = 15;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(95, 30);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.Size = new System.Drawing.Size(90, 20);
            this.txtSehirAdi.TabIndex = 16;
            this.txtSehirAdi.TextChanged += new System.EventHandler(this.txtSehirAdi_TextChanged);
            // 
            // txtSehirKodu
            // 
            this.txtSehirKodu.Location = new System.Drawing.Point(12, 30);
            this.txtSehirKodu.Name = "txtSehirKodu";
            this.txtSehirKodu.ReadOnly = true;
            this.txtSehirKodu.Size = new System.Drawing.Size(80, 20);
            this.txtSehirKodu.TabIndex = 17;
            // 
            // txtUlkeAdi
            // 
            this.txtUlkeAdi.Location = new System.Drawing.Point(187, 30);
            this.txtUlkeAdi.Name = "txtUlkeAdi";
            this.txtUlkeAdi.Size = new System.Drawing.Size(146, 20);
            this.txtUlkeAdi.TabIndex = 18;
            this.txtUlkeAdi.TextChanged += new System.EventHandler(this.txtUlkeAdi_TextChanged);
            // 
            // lvSehirler
            // 
            this.lvSehirler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSehirler.FullRowSelect = true;
            this.lvSehirler.GridLines = true;
            this.lvSehirler.Location = new System.Drawing.Point(12, 56);
            this.lvSehirler.Name = "lvSehirler";
            this.lvSehirler.Size = new System.Drawing.Size(491, 321);
            this.lvSehirler.TabIndex = 14;
            this.lvSehirler.UseCompatibleStateImageBehavior = false;
            this.lvSehirler.View = System.Windows.Forms.View.Details;
            this.lvSehirler.DoubleClick += new System.EventHandler(this.lvSehirler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Şehir Kodu";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Şehir Adı";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ülke Adı";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Açıklama";
            this.columnHeader4.Width = 162;
            // 
            // SehirSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 384);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtSehirAdi);
            this.Controls.Add(this.txtSehirKodu);
            this.Controls.Add(this.txtUlkeAdi);
            this.Controls.Add(this.lvSehirler);
            this.Name = "SehirSorgulama";
            this.Text = "Şehir Sorgulama";
            this.Load += new System.EventHandler(this.SehirSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.TextBox txtSehirKodu;
        private System.Windows.Forms.TextBox txtUlkeAdi;
        private System.Windows.Forms.ListView lvSehirler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}