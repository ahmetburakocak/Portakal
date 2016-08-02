namespace Portakal
{
    partial class ModelSorgulama
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
            this.dgvModeller = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeller)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModeller
            // 
            this.dgvModeller.AllowUserToAddRows = false;
            this.dgvModeller.AllowUserToDeleteRows = false;
            this.dgvModeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModeller.Location = new System.Drawing.Point(12, 12);
            this.dgvModeller.Name = "dgvModeller";
            this.dgvModeller.ReadOnly = true;
            this.dgvModeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModeller.Size = new System.Drawing.Size(534, 405);
            this.dgvModeller.TabIndex = 0;
            this.dgvModeller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModeller_CellContentClick);
            this.dgvModeller.DoubleClick += new System.EventHandler(this.dgvModeller_DoubleClick);
            // 
            // ModelSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 429);
            this.Controls.Add(this.dgvModeller);
            this.Name = "ModelSorgulama";
            this.Text = "Model Sorgulama";
            this.Load += new System.EventHandler(this.ModelSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModeller;
    }
}