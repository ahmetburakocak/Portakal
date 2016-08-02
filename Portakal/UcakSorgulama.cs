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
    public partial class UcakSorgulama : Form
    {
        public UcakSorgulama()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        private void UcakSorgulama_Load(object sender, EventArgs e)
        {
            Ucak u = new Ucak();
            ds = u.UcaklariGetir();
            dgvUcaklar.DataSource = ds.Tables["Ucaklar"];
        }

        private void dgvUcaklar_DoubleClick(object sender, EventArgs e)
        {
            Genel.EkonomikKoltuk = Convert.ToInt32(dgvUcaklar.SelectedRows[0].Cells[7].Value);
            Genel.BusinessKoltuk = Convert.ToInt32(dgvUcaklar.SelectedRows[0].Cells[8].Value);
            Genel.FirstClassKoltuk = Convert.ToInt32(dgvUcaklar.SelectedRows[0].Cells[9].Value);
            Genel.UcakID = Convert.ToInt32(dgvUcaklar.SelectedRows[0].Cells[0].Value);
            Genel.UcakAdi = dgvUcaklar.SelectedRows[0].Cells[1].Value.ToString();
            Genel.kisaltma = dgvUcaklar.SelectedRows[0].Cells[3].Value.ToString();
            this.Close();
        }
    }
}
