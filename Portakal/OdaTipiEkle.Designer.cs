namespace Portakal
{
    partial class OdaTipiEkle
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.cbOtel = new System.Windows.Forms.ComboBox();
            this.lbOzellikler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOzellik = new System.Windows.Forms.TextBox();
            this.txtOdaMiktari = new System.Windows.Forms.TextBox();
            this.txtStatuAd = new System.Windows.Forms.TextBox();
            this.txtSehirID = new System.Windows.Forms.TextBox();
            this.txtOtelID = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtOtel = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtTipAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(29, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(106, 175);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(85, 20);
            this.txtFiyat.TabIndex = 28;
            // 
            // cbSehir
            // 
            this.cbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSehir.DropDownWidth = 100;
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Location = new System.Drawing.Point(244, 8);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(28, 21);
            this.cbSehir.TabIndex = 27;
            this.cbSehir.SelectedIndexChanged += new System.EventHandler(this.cbSehir_SelectedIndexChanged);
            // 
            // cbOtel
            // 
            this.cbOtel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOtel.DropDownWidth = 100;
            this.cbOtel.FormattingEnabled = true;
            this.cbOtel.Location = new System.Drawing.Point(244, 34);
            this.cbOtel.Name = "cbOtel";
            this.cbOtel.Size = new System.Drawing.Size(28, 21);
            this.cbOtel.TabIndex = 26;
            this.cbOtel.SelectedIndexChanged += new System.EventHandler(this.cbOtel_SelectedIndexChanged);
            // 
            // lbOzellikler
            // 
            this.lbOzellikler.BackColor = System.Drawing.Color.Linen;
            this.lbOzellikler.FormattingEnabled = true;
            this.lbOzellikler.Location = new System.Drawing.Point(314, 8);
            this.lbOzellikler.Name = "lbOzellikler";
            this.lbOzellikler.Size = new System.Drawing.Size(221, 303);
            this.lbOzellikler.TabIndex = 25;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(419, 337);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 23);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(226, 289);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(45, 23);
            this.btnEkle.TabIndex = 23;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Özellik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Oda Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Oda Statu Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(42, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Şehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(42, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Otel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Oda Tip Adı";
            // 
            // txtOzellik
            // 
            this.txtOzellik.Location = new System.Drawing.Point(135, 291);
            this.txtOzellik.Name = "txtOzellik";
            this.txtOzellik.Size = new System.Drawing.Size(85, 20);
            this.txtOzellik.TabIndex = 14;
            // 
            // txtOdaMiktari
            // 
            this.txtOdaMiktari.Location = new System.Drawing.Point(106, 149);
            this.txtOdaMiktari.Name = "txtOdaMiktari";
            this.txtOdaMiktari.Size = new System.Drawing.Size(85, 20);
            this.txtOdaMiktari.TabIndex = 13;
            // 
            // txtStatuAd
            // 
            this.txtStatuAd.Location = new System.Drawing.Point(106, 123);
            this.txtStatuAd.Name = "txtStatuAd";
            this.txtStatuAd.Size = new System.Drawing.Size(136, 20);
            this.txtStatuAd.TabIndex = 12;
            // 
            // txtSehirID
            // 
            this.txtSehirID.Location = new System.Drawing.Point(15, 9);
            this.txtSehirID.Name = "txtSehirID";
            this.txtSehirID.ReadOnly = true;
            this.txtSehirID.Size = new System.Drawing.Size(21, 20);
            this.txtSehirID.TabIndex = 11;
            this.txtSehirID.TextChanged += new System.EventHandler(this.txtSehirID_TextChanged);
            // 
            // txtOtelID
            // 
            this.txtOtelID.Location = new System.Drawing.Point(15, 35);
            this.txtOtelID.Name = "txtOtelID";
            this.txtOtelID.ReadOnly = true;
            this.txtOtelID.Size = new System.Drawing.Size(21, 20);
            this.txtOtelID.TabIndex = 10;
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(93, 9);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.ReadOnly = true;
            this.txtSehir.Size = new System.Drawing.Size(136, 20);
            this.txtSehir.TabIndex = 9;
            this.txtSehir.TextChanged += new System.EventHandler(this.txtSehir_TextChanged);
            // 
            // txtOtel
            // 
            this.txtOtel.Location = new System.Drawing.Point(93, 35);
            this.txtOtel.Name = "txtOtel";
            this.txtOtel.ReadOnly = true;
            this.txtOtel.Size = new System.Drawing.Size(136, 20);
            this.txtOtel.TabIndex = 8;
            this.txtOtel.TextChanged += new System.EventHandler(this.txtOtel_TextChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(106, 203);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(136, 46);
            this.txtAciklama.TabIndex = 15;
            // 
            // txtTipAd
            // 
            this.txtTipAd.Location = new System.Drawing.Point(106, 98);
            this.txtTipAd.Name = "txtTipAd";
            this.txtTipAd.Size = new System.Drawing.Size(136, 20);
            this.txtTipAd.TabIndex = 7;
            // 
            // OdaTipiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 368);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.cbSehir);
            this.Controls.Add(this.cbOtel);
            this.Controls.Add(this.lbOzellikler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOzellik);
            this.Controls.Add(this.txtOdaMiktari);
            this.Controls.Add(this.txtStatuAd);
            this.Controls.Add(this.txtSehirID);
            this.Controls.Add(this.txtOtelID);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtOtel);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTipAd);
            this.Name = "OdaTipiEkle";
            this.Text = "OdaTipiEkle";
            this.Load += new System.EventHandler(this.OdaTipiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.ComboBox cbOtel;
        private System.Windows.Forms.ListBox lbOzellikler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOzellik;
        private System.Windows.Forms.TextBox txtOdaMiktari;
        private System.Windows.Forms.TextBox txtStatuAd;
        private System.Windows.Forms.TextBox txtSehirID;
        private System.Windows.Forms.TextBox txtOtelID;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtOtel;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtTipAd;
    }
}