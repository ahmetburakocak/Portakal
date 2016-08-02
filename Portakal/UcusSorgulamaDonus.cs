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
    public partial class UcusSorgulamaDonus : Form
    {
        public UcusSorgulamaDonus()
        {
            InitializeComponent();
        }

        private void UcusSorgulamaDonus_Load(object sender, EventArgs e)
        {
            Ucus u = new Ucus();
            dgvUcuslar.DataSource = u.UcuslariGetirBySorgulama(Genel.BiletKalkisIDDonus, Genel.BiletVarisIDDonus, Genel.BiletDonusTarihi, Genel.BiletKisiSayisi, Genel.BiletTipi, Genel.BiletTekYonMu);

             
        }

        private void dgvUcuslar_DoubleClick(object sender, EventArgs e)
        {
            Genel.UcusIDDonus = Convert.ToInt32(dgvUcuslar.SelectedRows[0].Cells[0].Value);
            this.Close();
            BiletSatisHareketleri frm = new BiletSatisHareketleri();
            frm.ShowDialog();
        }
    }
}
