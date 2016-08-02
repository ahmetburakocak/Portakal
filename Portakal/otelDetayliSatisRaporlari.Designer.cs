namespace Portakal
{
    partial class otelDetayliSatisRaporlari
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
            this.dgvDetayliSatis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFirst = new System.Windows.Forms.DateTimePicker();
            this.dtpLast = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetayliSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetayliSatis
            // 
            this.dgvDetayliSatis.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetayliSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetayliSatis.Location = new System.Drawing.Point(12, 41);
            this.dgvDetayliSatis.Name = "dgvDetayliSatis";
            this.dgvDetayliSatis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetayliSatis.Size = new System.Drawing.Size(617, 258);
            this.dgvDetayliSatis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Fiyat";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(500, 305);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.ReadOnly = true;
            this.txtToplamFiyat.Size = new System.Drawing.Size(79, 20);
            this.txtToplamFiyat.TabIndex = 2;
            this.txtToplamFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TL";
            // 
            // dtpFirst
            // 
            this.dtpFirst.Location = new System.Drawing.Point(49, 12);
            this.dtpFirst.Name = "dtpFirst";
            this.dtpFirst.Size = new System.Drawing.Size(200, 20);
            this.dtpFirst.TabIndex = 3;
            this.dtpFirst.ValueChanged += new System.EventHandler(this.dtpFirst_ValueChanged);
            // 
            // dtpLast
            // 
            this.dtpLast.Location = new System.Drawing.Point(302, 12);
            this.dtpLast.Name = "dtpLast";
            this.dtpLast.Size = new System.Drawing.Size(200, 20);
            this.dtpLast.TabIndex = 3;
            this.dtpLast.ValueChanged += new System.EventHandler(this.dtpLast_ValueChanged);
            // 
            // otelDetayliSatisRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 334);
            this.Controls.Add(this.dtpLast);
            this.Controls.Add(this.dtpFirst);
            this.Controls.Add(this.txtToplamFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetayliSatis);
            this.Name = "otelDetayliSatisRaporlari";
            this.Text = "otelDetayliSatisRaporlari";
            this.Load += new System.EventHandler(this.otelDetayliSatisRaporlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetayliSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetayliSatis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFirst;
        private System.Windows.Forms.DateTimePicker dtpLast;
    }
}