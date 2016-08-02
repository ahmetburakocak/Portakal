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
    public partial class otelSatisRaporlama : Form
    {
        public otelSatisRaporlama()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void otelSatisRaporlama_Load(object sender, EventArgs e)
        {
            OtelRaporlama or = new OtelRaporlama(); 
            ds=or.otelleriGetir();
            dgvOteller.DataSource = ds.Tables["Oteller"];
            ((DataGridViewImageColumn)dgvOteller.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvOteller.Columns[1].Visible = false;
            dgvOteller.Columns[4].Visible = false;
            dgvOteller.Columns[8].Visible = false;
            dgvOteller.Columns[2].Width = 150;
            dgvOteller.Columns[6].Width = 150;
            dgvOteller.Columns[7].Width = 120;
        }

        private void txtSehireGore_TextChanged(object sender, EventArgs e)
        {
            OtelRaporlama or = new OtelRaporlama();
            ds=or.otelleriFiltrele(txtAdaGore.Text, txtStatuyeGore.Text, txtSehireGore.Text);
            dgvOteller.DataSource = ds.Tables["Filtre"];
        }

        private void txtStatuyeGore_TextChanged(object sender, EventArgs e)
        {
            OtelRaporlama or = new OtelRaporlama();
            ds=or.otelleriFiltrele(txtAdaGore.Text, txtStatuyeGore.Text, txtSehireGore.Text);
            dgvOteller.DataSource = ds.Tables["Filtre"];
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            OtelRaporlama or = new OtelRaporlama();
            ds=or.otelleriFiltrele(txtAdaGore.Text,txtStatuyeGore.Text,txtSehireGore.Text);
            dgvOteller.DataSource = ds.Tables["Filtre"];
        }

        private void dgvOteller_DoubleClick(object sender, EventArgs e)
        {
            otelDetayliSatisRaporlari frm = new otelDetayliSatisRaporlari();
            Genel.OtelID = Convert.ToInt32(dgvOteller.SelectedRows[0].Cells[1].Value);
            frm.ShowDialog();
            
        }
    }
}
