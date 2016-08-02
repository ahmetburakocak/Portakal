namespace Portakal
{
    partial class UcakSorgulama
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
            this.dgvUcaklar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcaklar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUcaklar
            // 
            this.dgvUcaklar.AllowUserToAddRows = false;
            this.dgvUcaklar.AllowUserToDeleteRows = false;
            this.dgvUcaklar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUcaklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcaklar.Location = new System.Drawing.Point(12, 24);
            this.dgvUcaklar.Name = "dgvUcaklar";
            this.dgvUcaklar.ReadOnly = true;
            this.dgvUcaklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcaklar.Size = new System.Drawing.Size(432, 345);
            this.dgvUcaklar.TabIndex = 0;
            this.dgvUcaklar.DoubleClick += new System.EventHandler(this.dgvUcaklar_DoubleClick);
            // 
            // UcakSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 395);
            this.Controls.Add(this.dgvUcaklar);
            this.Name = "UcakSorgulama";
            this.Text = "Uçak Sorgulama";
            this.Load += new System.EventHandler(this.UcakSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcaklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUcaklar;
    }
}