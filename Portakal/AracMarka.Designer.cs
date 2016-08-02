namespace Portakal
{
    partial class AracMarka
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSiniflar = new System.Windows.Forms.ComboBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.txtSinifAd = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSinifID = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarkaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarkaAd = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMarkalar = new System.Windows.Forms.ListView();
            this.btnSinifaGoreArama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cbSiniflar);
            this.groupBox1.Controls.Add(this.btnDegistir);
            this.groupBox1.Controls.Add(this.txtSinifAd);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtSinifID);
            this.groupBox1.Controls.Add(this.btnYeni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMarkaID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMarkaAd);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 235);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Markalar";
            // 
            // cbSiniflar
            // 
            this.cbSiniflar.DropDownWidth = 100;
            this.cbSiniflar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSiniflar.FormattingEnabled = true;
            this.cbSiniflar.Location = new System.Drawing.Point(252, 101);
            this.cbSiniflar.Name = "cbSiniflar";
            this.cbSiniflar.Size = new System.Drawing.Size(16, 24);
            this.cbSiniflar.TabIndex = 34;
            this.cbSiniflar.SelectedIndexChanged += new System.EventHandler(this.cbSiniflar_SelectedIndexChanged);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackgroundImage = global::Portakal.Resource.değiştir_jpg;
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.Location = new System.Drawing.Point(152, 19);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(55, 44);
            this.btnDegistir.TabIndex = 35;
            // 
            // txtSinifAd
            // 
            this.txtSinifAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinifAd.Location = new System.Drawing.Point(109, 101);
            this.txtSinifAd.Name = "txtSinifAd";
            this.txtSinifAd.ReadOnly = true;
            this.txtSinifAd.Size = new System.Drawing.Size(137, 22);
            this.txtSinifAd.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::Portakal.Resource.sil;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(213, 19);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(55, 44);
            this.btnSil.TabIndex = 29;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::Portakal.Resource.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(91, 19);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(55, 44);
            this.btnKaydet.TabIndex = 30;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSinifID
            // 
            this.txtSinifID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSinifID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinifID.Location = new System.Drawing.Point(8, 101);
            this.txtSinifID.Name = "txtSinifID";
            this.txtSinifID.ReadOnly = true;
            this.txtSinifID.Size = new System.Drawing.Size(0, 15);
            this.txtSinifID.TabIndex = 33;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.Transparent;
            this.btnYeni.BackgroundImage = global::Portakal.Resource.yeni;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeni.Location = new System.Drawing.Point(27, 19);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(58, 44);
            this.btnYeni.TabIndex = 31;
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
            // 
            // txtMarkaID
            // 
            this.txtMarkaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMarkaID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarkaID.Location = new System.Drawing.Point(8, 133);
            this.txtMarkaID.Name = "txtMarkaID";
            this.txtMarkaID.ReadOnly = true;
            this.txtMarkaID.Size = new System.Drawing.Size(0, 15);
            this.txtMarkaID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sınıf";
            // 
            // txtMarkaAd
            // 
            this.txtMarkaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarkaAd.Location = new System.Drawing.Point(109, 133);
            this.txtMarkaAd.Name = "txtMarkaAd";
            this.txtMarkaAd.ReadOnly = true;
            this.txtMarkaAd.Size = new System.Drawing.Size(159, 22);
            this.txtMarkaAd.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(109, 162);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(159, 53);
            this.txtAciklama.TabIndex = 1;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SınıfID";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MarkaID";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Açıklama";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka Adı";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sınıf";
            this.columnHeader4.Width = 80;
            // 
            // lvMarkalar
            // 
            this.lvMarkalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lvMarkalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMarkalar.FullRowSelect = true;
            this.lvMarkalar.GridLines = true;
            this.lvMarkalar.Location = new System.Drawing.Point(327, 53);
            this.lvMarkalar.Name = "lvMarkalar";
            this.lvMarkalar.Size = new System.Drawing.Size(426, 240);
            this.lvMarkalar.TabIndex = 36;
            this.lvMarkalar.UseCompatibleStateImageBehavior = false;
            this.lvMarkalar.View = System.Windows.Forms.View.Details;
            this.lvMarkalar.DoubleClick += new System.EventHandler(this.lvMarkalar_DoubleClick);
            // 
            // btnSinifaGoreArama
            // 
            this.btnSinifaGoreArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinifaGoreArama.Location = new System.Drawing.Point(327, 12);
            this.btnSinifaGoreArama.Name = "btnSinifaGoreArama";
            this.btnSinifaGoreArama.Size = new System.Drawing.Size(188, 35);
            this.btnSinifaGoreArama.TabIndex = 39;
            this.btnSinifaGoreArama.Text = "Sınıfa Göre Filtreleme";
            this.btnSinifaGoreArama.UseVisualStyleBackColor = true;
            this.btnSinifaGoreArama.Click += new System.EventHandler(this.btnSinifaGoreArama_Click);
            // 
            // AracMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(773, 316);
            this.Controls.Add(this.btnSinifaGoreArama);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvMarkalar);
            this.Name = "AracMarka";
            this.Text = "MARKALAR";
            this.Load += new System.EventHandler(this.AracMarka_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSiniflar;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox txtSinifAd;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSinifID;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarkaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarkaAd;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvMarkalar;
        private System.Windows.Forms.Button btnSinifaGoreArama;
    }
}