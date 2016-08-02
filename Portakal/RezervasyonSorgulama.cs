using Portakal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portakal
{
    public partial class RezervasyonSorgulama : Form
    {
        public RezervasyonSorgulama()
        {
            InitializeComponent();
        }
        Font fntBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        SolidBrush sb = new SolidBrush(Color.Black);
        DataSet ds = new DataSet();
        private void RezervasyonSorgulama_Load(object sender, EventArgs e)
        {
            RezervasyonSorgu rez = new RezervasyonSorgu();
            ds = rez.rezervasyonlariGetir();
            dgvRezervasyon.DataSource = ds.Tables["Rezervasyonlar"];
            dgvRezervasyon.Columns[0].Visible = false;
            dgvRezervasyon.Columns[4].Visible = false;
            dgvRezervasyon.Columns[7].Visible = false;
            dgvRezervasyon.Columns[11].Visible = false;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ppfDialog.ShowDialog();
        }
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Rezervasyon Tarihi : " + dgvRezervasyon.SelectedRows[0].Cells[1].Value.ToString(), fntBaslik, sb, 100, 150);
            e.Graphics.DrawString("Müşteri AdSoyad : " + dgvRezervasyon.SelectedRows[0].Cells[5].Value.ToString(), fntBaslik, sb, 100, 180);
            e.Graphics.DrawString("Giriş Tarihi : " + dgvRezervasyon.SelectedRows[0].Cells[2].Value.ToString(), fntBaslik, sb, 100, 210);
            e.Graphics.DrawString("Çıkış Tarihi : " + dgvRezervasyon.SelectedRows[0].Cells[3].Value.ToString(), fntBaslik, sb, 100, 240);
            e.Graphics.DrawString("Otel : " + dgvRezervasyon.SelectedRows[0].Cells[8].Value.ToString(), fntBaslik, sb, 100, 270);
            e.Graphics.DrawString("Oda Tipi :" + dgvRezervasyon.SelectedRows[0].Cells[9].Value.ToString(), fntBaslik, sb, 100, 300);
            e.Graphics.DrawString("Fiyat :" + dgvRezervasyon.SelectedRows[0].Cells[10].Value.ToString(), fntBaslik, sb, 300, 330);
        }
        private void txtTcKimlikNo_TextChanged(object sender, EventArgs e)
        {
            RezervasyonSorgu rs = new RezervasyonSorgu();
            ds = rs.rezervasyonlariFiltrele(txtTcKimlikNo.Text, txtOtelAdi.Text);
            dgvRezervasyon.DataSource = ds.Tables["Rezervasyonlar"];
        }

        private void txtOtelAdi_TextChanged(object sender, EventArgs e)
        {
            RezervasyonSorgu rs = new RezervasyonSorgu();
            ds = rs.rezervasyonlariFiltrele(txtTcKimlikNo.Text, txtOtelAdi.Text);
            dgvRezervasyon.DataSource = ds.Tables["Rezervasyonlar"];
        }

     
    }
}
