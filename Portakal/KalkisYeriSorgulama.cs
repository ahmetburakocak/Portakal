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
    public partial class KalkisYeriSorgulama : Form
    {
        public KalkisYeriSorgulama()
        {
            InitializeComponent();
        }

        Havalimani h = new Havalimani();

        private void KalkisYeriSorgulama_Load(object sender, EventArgs e)
        {

            h.HavalimanlariniGetir(lvHavalimanlari);
        }

        private void txthavayoluKodu_TextChanged(object sender, EventArgs e)
        {
            h.HavalimanlariniGetir(txtHavalimaniAdi.Text, txtKisaltma.Text, txtSehirAd.Text, txtAciklama.Text, lvHavalimanlari);
        }

        private void txtSehirAd_TextChanged(object sender, EventArgs e)
        {
            h.HavalimanlariniGetir(txtHavalimaniAdi.Text, txtKisaltma.Text, txtSehirAd.Text, txtAciklama.Text, lvHavalimanlari);

        }

        private void txtKisaltma_TextChanged(object sender, EventArgs e)
        {

            h.HavalimanlariniGetir(txtHavalimaniAdi.Text, txtKisaltma.Text, txtSehirAd.Text, txtAciklama.Text, lvHavalimanlari);
        }

        private void txtHavalimaniAdi_TextChanged(object sender, EventArgs e)
        {

            h.HavalimanlariniGetir(txtHavalimaniAdi.Text, txtKisaltma.Text, txtSehirAd.Text, txtAciklama.Text, lvHavalimanlari);
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            h.HavalimanlariniGetir(txtHavalimaniAdi.Text, txtKisaltma.Text, txtSehirAd.Text, txtAciklama.Text, lvHavalimanlari);

        }

        private void lvHavalimanlari_DoubleClick(object sender, EventArgs e)
        {
            Genel.KalkisYeriID = Convert.ToInt32(lvHavalimanlari.SelectedItems[0].SubItems[0].Text);
            Genel.KalkisYeri = lvHavalimanlari.SelectedItems[0].SubItems[2].Text;
            this.Close();
        }
    }
}
