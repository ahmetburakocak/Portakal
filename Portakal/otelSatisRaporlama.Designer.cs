namespace Portakal
{
    partial class otelSatisRaporlama
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
            this.dgvOteller = new System.Windows.Forms.DataGridView();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatuyeGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSehireGore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOteller)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOteller
            // 
            this.dgvOteller.BackgroundColor = System.Drawing.Color.White;
            this.dgvOteller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOteller.Location = new System.Drawing.Point(8, 79);
            this.dgvOteller.Name = "dgvOteller";
            this.dgvOteller.RowHeadersVisible = false;
            this.dgvOteller.RowTemplate.Height = 50;
            this.dgvOteller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOteller.Size = new System.Drawing.Size(742, 317);
            this.dgvOteller.TabIndex = 9;
            this.dgvOteller.DoubleClick += new System.EventHandler(this.dgvOteller_DoubleClick);
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(12, 53);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(167, 20);
            this.txtAdaGore.TabIndex = 1;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otel Adına Göre Arama";
            // 
            // txtStatuyeGore
            // 
            this.txtStatuyeGore.Location = new System.Drawing.Point(211, 53);
            this.txtStatuyeGore.Name = "txtStatuyeGore";
            this.txtStatuyeGore.Size = new System.Drawing.Size(146, 20);
            this.txtStatuyeGore.TabIndex = 1;
            this.txtStatuyeGore.TextChanged += new System.EventHandler(this.txtStatuyeGore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Statüye Göre Arama";
            // 
            // txtSehireGore
            // 
            this.txtSehireGore.Location = new System.Drawing.Point(617, 53);
            this.txtSehireGore.Name = "txtSehireGore";
            this.txtSehireGore.Size = new System.Drawing.Size(133, 20);
            this.txtSehireGore.TabIndex = 1;
            this.txtSehireGore.TextChanged += new System.EventHandler(this.txtSehireGore_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şehire Göre Arama";
            // 
            // otelSatisRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSehireGore);
            this.Controls.Add(this.txtStatuyeGore);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.dgvOteller);
            this.Name = "otelSatisRaporlama";
            this.Text = "otelSatisRaporlama";
            this.Load += new System.EventHandler(this.otelSatisRaporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOteller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOteller;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatuyeGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSehireGore;
        private System.Windows.Forms.Label label3;
    }
}