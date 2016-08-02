namespace Portakal
{
    partial class UcusSorgulama
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
            this.dgvUcuslar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUcuslar
            // 
            this.dgvUcuslar.AllowUserToAddRows = false;
            this.dgvUcuslar.AllowUserToDeleteRows = false;
            this.dgvUcuslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcuslar.Location = new System.Drawing.Point(12, 12);
            this.dgvUcuslar.Name = "dgvUcuslar";
            this.dgvUcuslar.ReadOnly = true;
            this.dgvUcuslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcuslar.Size = new System.Drawing.Size(1145, 517);
            this.dgvUcuslar.TabIndex = 63;
            this.dgvUcuslar.DoubleClick += new System.EventHandler(this.dgvUcuslar_DoubleClick);
            // 
            // UcusSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 541);
            this.Controls.Add(this.dgvUcuslar);
            this.Name = "UcusSorgulama";
            this.Text = "Uçuş Sorgulama";
            this.Load += new System.EventHandler(this.UcusSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUcuslar;

    }
}