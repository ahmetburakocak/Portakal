namespace Portakal
{
    partial class OtelEkle
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
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.dgvOteller = new System.Windows.Forms.DataGridView();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtSorguStatu = new System.Windows.Forms.TextBox();
            this.txtSorguSehir = new System.Windows.Forms.TextBox();
            this.txtSorguOtel = new System.Windows.Forms.TextBox();
            this.cbStatu = new System.Windows.Forms.ComboBox();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtStatu = new System.Windows.Forms.TextBox();
            this.txtOtel = new System.Windows.Forms.TextBox();
            this.txtOtelID = new System.Windows.Forms.TextBox();
            this.txtStatuID = new System.Windows.Forms.TextBox();
            this.txtSehirID = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOteller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            this.ofdFoto.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdFoto_FileOk);
            // 
            // dgvOteller
            // 
            this.dgvOteller.BackgroundColor = System.Drawing.Color.White;
            this.dgvOteller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOteller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOteller.Location = new System.Drawing.Point(9, 271);
            this.dgvOteller.Name = "dgvOteller";
            this.dgvOteller.RowHeadersVisible = false;
            this.dgvOteller.RowTemplate.Height = 50;
            this.dgvOteller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOteller.Size = new System.Drawing.Size(598, 229);
            this.dgvOteller.TabIndex = 9;
            this.dgvOteller.DoubleClick += new System.EventHandler(this.dgvOteller_DoubleClick_1);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.White;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoto.Location = new System.Drawing.Point(366, 8);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(242, 121);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 33;
            this.pbFoto.TabStop = false;
            // 
            // txtSorguStatu
            // 
            this.txtSorguStatu.Location = new System.Drawing.Point(164, 245);
            this.txtSorguStatu.Name = "txtSorguStatu";
            this.txtSorguStatu.Size = new System.Drawing.Size(86, 20);
            this.txtSorguStatu.TabIndex = 32;
            this.txtSorguStatu.Click += new System.EventHandler(this.txtSorguStatu_TextChanged);
            // 
            // txtSorguSehir
            // 
            this.txtSorguSehir.Location = new System.Drawing.Point(515, 245);
            this.txtSorguSehir.Name = "txtSorguSehir";
            this.txtSorguSehir.Size = new System.Drawing.Size(92, 20);
            this.txtSorguSehir.TabIndex = 31;
            this.txtSorguSehir.Click += new System.EventHandler(this.txtSorguSehir_TextChanged);
            // 
            // txtSorguOtel
            // 
            this.txtSorguOtel.Location = new System.Drawing.Point(9, 245);
            this.txtSorguOtel.Multiline = true;
            this.txtSorguOtel.Name = "txtSorguOtel";
            this.txtSorguOtel.Size = new System.Drawing.Size(149, 20);
            this.txtSorguOtel.TabIndex = 30;
            this.txtSorguOtel.Click += new System.EventHandler(this.txtSorguOtel_TextChanged);
            // 
            // cbStatu
            // 
            this.cbStatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatu.DropDownWidth = 100;
            this.cbStatu.FormattingEnabled = true;
            this.cbStatu.Location = new System.Drawing.Point(312, 61);
            this.cbStatu.Name = "cbStatu";
            this.cbStatu.Size = new System.Drawing.Size(19, 21);
            this.cbStatu.TabIndex = 29;
            this.cbStatu.TextChanged += new System.EventHandler(this.cbStatu_SelectedIndexChanged);
            // 
            // cbSehir
            // 
            this.cbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSehir.DropDownWidth = 100;
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Location = new System.Drawing.Point(312, 8);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(19, 21);
            this.cbSehir.TabIndex = 28;
            this.cbSehir.SelectedIndexChanged += new System.EventHandler(this.cbSehir_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(311, 184);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(230, 184);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 25;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(149, 184);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(533, 148);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 23;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(68, 184);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 27;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Statu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Otel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Şehir";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(140, 113);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(172, 58);
            this.txtAdres.TabIndex = 16;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(140, 87);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(172, 20);
            this.txtTelefon.TabIndex = 15;
            // 
            // txtStatu
            // 
            this.txtStatu.Location = new System.Drawing.Point(140, 61);
            this.txtStatu.Name = "txtStatu";
            this.txtStatu.ReadOnly = true;
            this.txtStatu.Size = new System.Drawing.Size(172, 20);
            this.txtStatu.TabIndex = 14;
            // 
            // txtOtel
            // 
            this.txtOtel.Location = new System.Drawing.Point(140, 35);
            this.txtOtel.Name = "txtOtel";
            this.txtOtel.Size = new System.Drawing.Size(172, 20);
            this.txtOtel.TabIndex = 13;
            // 
            // txtOtelID
            // 
            this.txtOtelID.Location = new System.Drawing.Point(57, 35);
            this.txtOtelID.Name = "txtOtelID";
            this.txtOtelID.ReadOnly = true;
            this.txtOtelID.Size = new System.Drawing.Size(21, 20);
            this.txtOtelID.TabIndex = 12;
            // 
            // txtStatuID
            // 
            this.txtStatuID.Location = new System.Drawing.Point(57, 60);
            this.txtStatuID.Name = "txtStatuID";
            this.txtStatuID.ReadOnly = true;
            this.txtStatuID.Size = new System.Drawing.Size(21, 20);
            this.txtStatuID.TabIndex = 11;
            // 
            // txtSehirID
            // 
            this.txtSehirID.Location = new System.Drawing.Point(57, 9);
            this.txtSehirID.Name = "txtSehirID";
            this.txtSehirID.ReadOnly = true;
            this.txtSehirID.Size = new System.Drawing.Size(21, 20);
            this.txtSehirID.TabIndex = 17;
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(140, 9);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.ReadOnly = true;
            this.txtSehir.Size = new System.Drawing.Size(172, 20);
            this.txtSehir.TabIndex = 10;
            // 
            // OtelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 508);
            this.Controls.Add(this.dgvOteller);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtSorguStatu);
            this.Controls.Add(this.txtSorguSehir);
            this.Controls.Add(this.txtSorguOtel);
            this.Controls.Add(this.cbStatu);
            this.Controls.Add(this.cbSehir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtStatu);
            this.Controls.Add(this.txtOtel);
            this.Controls.Add(this.txtOtelID);
            this.Controls.Add(this.txtStatuID);
            this.Controls.Add(this.txtSehirID);
            this.Controls.Add(this.txtSehir);
            this.Name = "OtelEkle";
            this.Text = "OtelEkle";
            this.Load += new System.EventHandler(this.OtelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOteller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.DataGridView dgvOteller;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtSorguStatu;
        private System.Windows.Forms.TextBox txtSorguSehir;
        private System.Windows.Forms.TextBox txtSorguOtel;
        private System.Windows.Forms.ComboBox cbStatu;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtStatu;
        private System.Windows.Forms.TextBox txtOtel;
        private System.Windows.Forms.TextBox txtOtelID;
        private System.Windows.Forms.TextBox txtStatuID;
        private System.Windows.Forms.TextBox txtSehirID;
        private System.Windows.Forms.TextBox txtSehir;
    }
}