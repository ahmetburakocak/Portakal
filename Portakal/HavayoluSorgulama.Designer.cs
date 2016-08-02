namespace Portakal
{
    partial class HavayoluSorgulama
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
            this.txtHavayoluAdi = new System.Windows.Forms.TextBox();
            this.txthavayoluKodu = new System.Windows.Forms.TextBox();
            this.txtUlkeAdi = new System.Windows.Forms.TextBox();
            this.lvHavayollari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtKisaltma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Havayolu Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ülke Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Havayolu Kodu:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(416, 29);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(84, 20);
            this.txtAciklama.TabIndex = 24;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // txtHavayoluAdi
            // 
            this.txtHavayoluAdi.Location = new System.Drawing.Point(95, 29);
            this.txtHavayoluAdi.Name = "txtHavayoluAdi";
            this.txtHavayoluAdi.Size = new System.Drawing.Size(90, 20);
            this.txtHavayoluAdi.TabIndex = 25;
            this.txtHavayoluAdi.TextChanged += new System.EventHandler(this.txtHavayoluAdi_TextChanged);
            // 
            // txthavayoluKodu
            // 
            this.txthavayoluKodu.Location = new System.Drawing.Point(12, 29);
            this.txthavayoluKodu.Name = "txthavayoluKodu";
            this.txthavayoluKodu.ReadOnly = true;
            this.txthavayoluKodu.Size = new System.Drawing.Size(80, 20);
            this.txthavayoluKodu.TabIndex = 26;
            // 
            // txtUlkeAdi
            // 
            this.txtUlkeAdi.Location = new System.Drawing.Point(264, 29);
            this.txtUlkeAdi.Name = "txtUlkeAdi";
            this.txtUlkeAdi.Size = new System.Drawing.Size(146, 20);
            this.txtUlkeAdi.TabIndex = 27;
            this.txtUlkeAdi.TextChanged += new System.EventHandler(this.txtUlkeAdi_TextChanged);
            // 
            // lvHavayollari
            // 
            this.lvHavayollari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHavayollari.FullRowSelect = true;
            this.lvHavayollari.GridLines = true;
            this.lvHavayollari.Location = new System.Drawing.Point(12, 55);
            this.lvHavayollari.Name = "lvHavayollari";
            this.lvHavayollari.Size = new System.Drawing.Size(491, 321);
            this.lvHavayollari.TabIndex = 23;
            this.lvHavayollari.UseCompatibleStateImageBehavior = false;
            this.lvHavayollari.View = System.Windows.Forms.View.Details;
            this.lvHavayollari.DoubleClick += new System.EventHandler(this.lvHavayollari_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Havayolu Kodu";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Havayolu Adı";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kısaltma";
            this.columnHeader5.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ülke Adı";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Açıklama";
            this.columnHeader4.Width = 84;
            // 
            // txtKisaltma
            // 
            this.txtKisaltma.Location = new System.Drawing.Point(191, 29);
            this.txtKisaltma.Name = "txtKisaltma";
            this.txtKisaltma.Size = new System.Drawing.Size(69, 20);
            this.txtKisaltma.TabIndex = 25;
            this.txtKisaltma.TextChanged += new System.EventHandler(this.txtKisaltma_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kısaltma:";
            // 
            // HavayoluSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 384);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKisaltma);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtHavayoluAdi);
            this.Controls.Add(this.txthavayoluKodu);
            this.Controls.Add(this.txtUlkeAdi);
            this.Controls.Add(this.lvHavayollari);
            this.Name = "HavayoluSorgulama";
            this.Text = "Havayolu Sorgulama";
            this.Load += new System.EventHandler(this.HavayoluSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtHavayoluAdi;
        private System.Windows.Forms.TextBox txthavayoluKodu;
        private System.Windows.Forms.TextBox txtUlkeAdi;
        private System.Windows.Forms.ListView lvHavayollari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtKisaltma;
        private System.Windows.Forms.Label label6;
    }
}