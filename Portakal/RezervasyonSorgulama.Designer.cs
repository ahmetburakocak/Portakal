namespace Portakal
{
    partial class RezervasyonSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonSorgulama));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtOtelAdi = new System.Windows.Forms.TextBox();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.dgvRezervasyon = new System.Windows.Forms.DataGridView();
            this.ppfDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Otel Adına Göre Ara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tc No\'ya göre Ara";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Location = new System.Drawing.Point(654, 31);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 69);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtOtelAdi
            // 
            this.txtOtelAdi.Location = new System.Drawing.Point(204, 124);
            this.txtOtelAdi.Name = "txtOtelAdi";
            this.txtOtelAdi.Size = new System.Drawing.Size(181, 20);
            this.txtOtelAdi.TabIndex = 7;
            this.txtOtelAdi.TextChanged += new System.EventHandler(this.txtOtelAdi_TextChanged);
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(25, 124);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(140, 20);
            this.txtTcKimlikNo.TabIndex = 8;
            this.txtTcKimlikNo.TextChanged += new System.EventHandler(this.txtTcKimlikNo_TextChanged);
            // 
            // dgvRezervasyon
            // 
            this.dgvRezervasyon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRezervasyon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervasyon.Location = new System.Drawing.Point(25, 150);
            this.dgvRezervasyon.Name = "dgvRezervasyon";
            this.dgvRezervasyon.RowHeadersVisible = false;
            this.dgvRezervasyon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervasyon.Size = new System.Drawing.Size(762, 257);
            this.dgvRezervasyon.TabIndex = 6;
            // 
            // ppfDialog
            // 
            this.ppfDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppfDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppfDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppfDialog.Document = this.printDocument1;
            this.ppfDialog.Enabled = true;
            this.ppfDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppfDialog.Icon")));
            this.ppfDialog.Name = "ppfDialog";
            this.ppfDialog.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // RezervasyonSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 438);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtOtelAdi);
            this.Controls.Add(this.txtTcKimlikNo);
            this.Controls.Add(this.dgvRezervasyon);
            this.Name = "RezervasyonSorgulama";
            this.Text = "RezervasyonSorgulama";
            this.Load += new System.EventHandler(this.RezervasyonSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtOtelAdi;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.DataGridView dgvRezervasyon;
        private System.Windows.Forms.PrintPreviewDialog ppfDialog;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}