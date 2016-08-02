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
    public partial class otelDetayliSatisRaporlari : Form
    {
        public otelDetayliSatisRaporlari()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void otelDetayliSatisRaporlari_Load(object sender, EventArgs e)
        {
            OtelRaporlama or = new OtelRaporlama();
            ds=or.SatisRaporlariniGetir();
            dgvDetayliSatis.DataSource = ds.Tables["Raporlar"];
            dgvDetayliSatis.Columns[0].Visible = false;
            dgvDetayliSatis.Columns[3].Visible = false;
            dgvDetayliSatis.Columns[7].Visible = false;
            int tfiyat = 0;
            for (int i = 0; i < dgvDetayliSatis.Rows.Count; i++)
            {
                tfiyat += Convert.ToInt32(dgvDetayliSatis.Rows[i].Cells[6].Value);
            }
            txtToplamFiyat.Text = tfiyat.ToString();
        }

        private void dtpFirst_ValueChanged(object sender, EventArgs e)
        {
            OtelRaporlama or = new OtelRaporlama();
            ds=or.SatislariFiltrele(dtpFirst,dtpLast);
            dgvDetayliSatis.DataSource = ds.Tables["Satislar"];
            int tfiyat = 0;
            for (int i = 0; i < dgvDetayliSatis.Rows.Count; i++)
            {
                tfiyat += Convert.ToInt32(dgvDetayliSatis.Rows[i].Cells[6].Value);
            }
            txtToplamFiyat.Text = tfiyat.ToString();
        }

        private void dtpLast_ValueChanged(object sender, EventArgs e)
        {
            OtelRaporlama or = new OtelRaporlama();
            ds = or.SatislariFiltrele(dtpFirst, dtpLast);
            dgvDetayliSatis.DataSource = ds.Tables["Satislar"];
            int tfiyat = 0;
            for (int i = 0; i < dgvDetayliSatis.Rows.Count; i++)
            {
                tfiyat += Convert.ToInt32(dgvDetayliSatis.Rows[i].Cells[6].Value);
            }
            txtToplamFiyat.Text = tfiyat.ToString();
        }
    }
}
