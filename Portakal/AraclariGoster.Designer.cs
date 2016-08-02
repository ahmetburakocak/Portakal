namespace Portakal
{
    partial class AraclariGoster
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
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.btnIleri = new System.Windows.Forms.Button();
            this.cbFirmalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVites = new System.Windows.Forms.TextBox();
            this.txtYakit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Location = new System.Drawing.Point(12, 101);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.RowHeadersWidth = 40;
            this.dgvAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAraclar.Size = new System.Drawing.Size(1066, 315);
            this.dgvAraclar.TabIndex = 8;
            this.dgvAraclar.DoubleClick += new System.EventHandler(this.dgvAraclar_DoubleClick);
            // 
            // btnIleri
            // 
            this.btnIleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIleri.Location = new System.Drawing.Point(945, 422);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(133, 48);
            this.btnIleri.TabIndex = 7;
            this.btnIleri.Text = "İLERİ";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // cbFirmalar
            // 
            this.cbFirmalar.FormattingEnabled = true;
            this.cbFirmalar.Location = new System.Drawing.Point(12, 29);
            this.cbFirmalar.Name = "cbFirmalar";
            this.cbFirmalar.Size = new System.Drawing.Size(121, 21);
            this.cbFirmalar.TabIndex = 9;
            this.cbFirmalar.SelectedIndexChanged += new System.EventHandler(this.cbFirmalar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Firmalara Göre Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yakıt Tipine Göre ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vites Türüne Göre";
            // 
            // txtVites
            // 
            this.txtVites.Location = new System.Drawing.Point(139, 30);
            this.txtVites.Name = "txtVites";
            this.txtVites.Size = new System.Drawing.Size(100, 20);
            this.txtVites.TabIndex = 12;
            this.txtVites.TextChanged += new System.EventHandler(this.txtVites_TextChanged);
            // 
            // txtYakit
            // 
            this.txtYakit.Location = new System.Drawing.Point(245, 30);
            this.txtYakit.Name = "txtYakit";
            this.txtYakit.Size = new System.Drawing.Size(100, 20);
            this.txtYakit.TabIndex = 12;
            this.txtYakit.TextChanged += new System.EventHandler(this.txtYakit_TextChanged);
            // 
            // AraclariGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1094, 482);
            this.Controls.Add(this.txtYakit);
            this.Controls.Add(this.txtVites);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFirmalar);
            this.Controls.Add(this.dgvAraclar);
            this.Controls.Add(this.btnIleri);
            this.Name = "AraclariGoster";
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.AraclariGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAraclar;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.ComboBox cbFirmalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVites;
        private System.Windows.Forms.TextBox txtYakit;
    }
}