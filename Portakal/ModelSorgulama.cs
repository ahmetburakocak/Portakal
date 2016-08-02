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
    public partial class ModelSorgulama : Form
    {
        public ModelSorgulama()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void ModelSorgulama_Load(object sender, EventArgs e)
        {
            UcakModel m = new UcakModel();
            dgvModeller.DataSource = m.ModelleriGetir();
            dgvModeller.Columns["ModelID"].Visible = false;
            dgvModeller.Columns["Silindi"].Visible = false;

        }

        private void dgvModeller_DoubleClick(object sender, EventArgs e)
        {
            Genel.ModelID = int.Parse(dgvModeller.SelectedRows[0].Cells[0].Value.ToString());
            Genel.ModelAdi = dgvModeller.SelectedRows[0].Cells[1].Value.ToString();
            this.Close();

        }

        private void dgvModeller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
