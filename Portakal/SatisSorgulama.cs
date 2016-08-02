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
    public partial class SatisSorgulama : Form
    {
        public SatisSorgulama()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void SatisSorgulama_Load(object sender, EventArgs e)
        {
            txtBaslangic.Text = dtpBaslangic.Value.ToShortDateString();
            txtBitis.Text = dtpBitis.Value.ToShortDateString();
            double ToplamTutar = 0;
            SatisHareketleri sh = new SatisHareketleri();
            dt = sh.SatislariGetir(Convert.ToDateTime(txtBaslangic.Text), Convert.ToDateTime(txtBitis.Text), txtHavayolu.Text);
            dgvSatislar.DataSource = dt;
            for (int i = 0; i < dgvSatislar.Rows.Count; i++)
            {
                ToplamTutar += Convert.ToDouble(dgvSatislar.Rows[i].Cells["ToplamTutar"].Value);
            }

            txtToplamTutar.Text = ToplamTutar.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtBaslangic.Text = dtpBaslangic.Value.ToShortDateString();

        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            txtBitis.Text = dtpBitis.Value.ToShortDateString();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            double toplamTutar=0;
            SatisHareketleri sh = new SatisHareketleri();
            dt = sh.SatislariGetir(Convert.ToDateTime(txtBaslangic.Text), Convert.ToDateTime(txtBitis.Text), txtHavayolu.Text);
            dgvSatislar.DataSource = dt;

            foreach (DataRow item in dt.Rows)
            {
                toplamTutar += Convert.ToDouble(item["ToplamTutar"]);
            }
            txtToplamTutar.Text = toplamTutar.ToString();
        }


    }
}
