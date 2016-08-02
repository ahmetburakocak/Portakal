namespace Portakal
{
    partial class UcakModelleri
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
            this.txtFirstClass = new System.Windows.Forms.TextBox();
            this.txtBusiness = new System.Windows.Forms.TextBox();
            this.txtEkonomi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAirbus = new System.Windows.Forms.RadioButton();
            this.rbBoeing = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGenelAd = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvModeller = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtModelKodu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstClass
            // 
            this.txtFirstClass.Location = new System.Drawing.Point(90, 17);
            this.txtFirstClass.Name = "txtFirstClass";
            this.txtFirstClass.ReadOnly = true;
            this.txtFirstClass.Size = new System.Drawing.Size(35, 20);
            this.txtFirstClass.TabIndex = 0;
            this.txtFirstClass.Text = "0";
            this.txtFirstClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBusiness
            // 
            this.txtBusiness.Location = new System.Drawing.Point(90, 52);
            this.txtBusiness.Name = "txtBusiness";
            this.txtBusiness.ReadOnly = true;
            this.txtBusiness.Size = new System.Drawing.Size(35, 20);
            this.txtBusiness.TabIndex = 1;
            this.txtBusiness.Text = "0";
            this.txtBusiness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEkonomi
            // 
            this.txtEkonomi.Location = new System.Drawing.Point(90, 80);
            this.txtEkonomi.Name = "txtEkonomi";
            this.txtEkonomi.ReadOnly = true;
            this.txtEkonomi.Size = new System.Drawing.Size(35, 20);
            this.txtEkonomi.TabIndex = 2;
            this.txtEkonomi.Text = "0";
            this.txtEkonomi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Business Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ekonomi: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEkonomi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBusiness);
            this.groupBox1.Controls.Add(this.txtFirstClass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(155, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Koltuk Adetleri";
            // 
            // rbAirbus
            // 
            this.rbAirbus.AutoSize = true;
            this.rbAirbus.Checked = true;
            this.rbAirbus.Location = new System.Drawing.Point(6, 19);
            this.rbAirbus.Name = "rbAirbus";
            this.rbAirbus.Size = new System.Drawing.Size(54, 17);
            this.rbAirbus.TabIndex = 7;
            this.rbAirbus.TabStop = true;
            this.rbAirbus.Text = "Airbus";
            this.rbAirbus.UseVisualStyleBackColor = true;
            this.rbAirbus.CheckedChanged += new System.EventHandler(this.rbAirbus_CheckedChanged);
            // 
            // rbBoeing
            // 
            this.rbBoeing.AutoSize = true;
            this.rbBoeing.Location = new System.Drawing.Point(77, 19);
            this.rbBoeing.Name = "rbBoeing";
            this.rbBoeing.Size = new System.Drawing.Size(58, 17);
            this.rbBoeing.TabIndex = 8;
            this.rbBoeing.Text = "Boeing";
            this.rbBoeing.UseVisualStyleBackColor = true;
            this.rbBoeing.CheckedChanged += new System.EventHandler(this.rbBoeing_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAirbus);
            this.groupBox2.Controls.Add(this.rbBoeing);
            this.groupBox2.Location = new System.Drawing.Point(4, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 52);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uçak Markası:";
            // 
            // txtGenelAd
            // 
            this.txtGenelAd.Location = new System.Drawing.Point(4, 14);
            this.txtGenelAd.Name = "txtGenelAd";
            this.txtGenelAd.ReadOnly = true;
            this.txtGenelAd.Size = new System.Drawing.Size(145, 20);
            this.txtGenelAd.TabIndex = 10;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(60, 98);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(89, 20);
            this.txtModel.TabIndex = 11;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(60, 124);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(226, 20);
            this.txtAciklama.TabIndex = 12;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(292, 89);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 28;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(292, 121);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(292, 56);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 30;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(292, 22);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 31;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Açıklama:";
            // 
            // lvModeller
            // 
            this.lvModeller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvModeller.FullRowSelect = true;
            this.lvModeller.GridLines = true;
            this.lvModeller.Location = new System.Drawing.Point(10, 159);
            this.lvModeller.Name = "lvModeller";
            this.lvModeller.Size = new System.Drawing.Size(349, 207);
            this.lvModeller.TabIndex = 34;
            this.lvModeller.UseCompatibleStateImageBehavior = false;
            this.lvModeller.View = System.Windows.Forms.View.Details;
            this.lvModeller.DoubleClick += new System.EventHandler(this.lvModeller_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ModelID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Model Adı";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ekonomi";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Business";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 58;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "First Class";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 64;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Açıklama";
            // 
            // txtModelKodu
            // 
            this.txtModelKodu.Location = new System.Drawing.Point(44, 98);
            this.txtModelKodu.Name = "txtModelKodu";
            this.txtModelKodu.ReadOnly = true;
            this.txtModelKodu.Size = new System.Drawing.Size(10, 20);
            this.txtModelKodu.TabIndex = 35;
            // 
            // UcakModelleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(371, 378);
            this.Controls.Add(this.txtModelKodu);
            this.Controls.Add(this.lvModeller);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtGenelAd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcakModelleri";
            this.Text = "Uçak Modelleri";
            this.Load += new System.EventHandler(this.UcakModelleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstClass;
        private System.Windows.Forms.TextBox txtBusiness;
        private System.Windows.Forms.TextBox txtEkonomi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAirbus;
        private System.Windows.Forms.RadioButton rbBoeing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGenelAd;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvModeller;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtModelKodu;
    }
}