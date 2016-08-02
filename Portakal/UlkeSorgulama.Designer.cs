namespace Portakal
{
    partial class UlkeSorgulama
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
            this.lvUlkeler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUlkeAdi = new System.Windows.Forms.TextBox();
            this.txtUlkeKodu = new System.Windows.Forms.TextBox();
            this.txtTelefonKodu = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvUlkeler
            // 
            this.lvUlkeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvUlkeler.FullRowSelect = true;
            this.lvUlkeler.GridLines = true;
            this.lvUlkeler.Location = new System.Drawing.Point(12, 59);
            this.lvUlkeler.Name = "lvUlkeler";
            this.lvUlkeler.Size = new System.Drawing.Size(491, 321);
            this.lvUlkeler.TabIndex = 11;
            this.lvUlkeler.UseCompatibleStateImageBehavior = false;
            this.lvUlkeler.View = System.Windows.Forms.View.Details;
            this.lvUlkeler.DoubleClick += new System.EventHandler(this.lvUlkeler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ülke Kodu";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ülke Adı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon Kodu";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Açıklama";
            this.columnHeader4.Width = 150;
            // 
            // txtUlkeAdi
            // 
            this.txtUlkeAdi.Location = new System.Drawing.Point(98, 33);
            this.txtUlkeAdi.Name = "txtUlkeAdi";
            this.txtUlkeAdi.Size = new System.Drawing.Size(148, 20);
            this.txtUlkeAdi.TabIndex = 12;
            this.txtUlkeAdi.TextChanged += new System.EventHandler(this.TxtUlkeAdi_TextChanged);
            // 
            // txtUlkeKodu
            // 
            this.txtUlkeKodu.Location = new System.Drawing.Point(12, 33);
            this.txtUlkeKodu.Name = "txtUlkeKodu";
            this.txtUlkeKodu.ReadOnly = true;
            this.txtUlkeKodu.Size = new System.Drawing.Size(80, 20);
            this.txtUlkeKodu.TabIndex = 12;
            this.txtUlkeKodu.TextChanged += new System.EventHandler(this.txtUlkeKodu_TextChanged);
            // 
            // txtTelefonKodu
            // 
            this.txtTelefonKodu.Location = new System.Drawing.Point(252, 33);
            this.txtTelefonKodu.Name = "txtTelefonKodu";
            this.txtTelefonKodu.Size = new System.Drawing.Size(90, 20);
            this.txtTelefonKodu.TabIndex = 12;
            this.txtTelefonKodu.TextChanged += new System.EventHandler(this.txtTelefonKodu_TextChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(348, 33);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(147, 20);
            this.txtAciklama.TabIndex = 12;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ülke Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ülke Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon Kodu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Açıklama:";
            // 
            // UlkeSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 394);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTelefonKodu);
            this.Controls.Add(this.txtUlkeKodu);
            this.Controls.Add(this.txtUlkeAdi);
            this.Controls.Add(this.lvUlkeler);
            this.Name = "UlkeSorgulama";
            this.Text = "Ülke Sorgulama";
            this.Load += new System.EventHandler(this.UlkeSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUlkeler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtUlkeAdi;
        private System.Windows.Forms.TextBox txtUlkeKodu;
        private System.Windows.Forms.TextBox txtTelefonKodu;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}