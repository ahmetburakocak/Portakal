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
    public partial class HavayoluSorgulama : Form
    {
        public HavayoluSorgulama()
        {
            InitializeComponent();
        }

        Havayolu h = new Havayolu();


        private void HavayoluSorgulama_Load(object sender, EventArgs e)
        {
            h.HavayollariniGetir(lvHavayollari);
        }

        private void txtHavayoluAdi_TextChanged(object sender, EventArgs e)
        {
            h.HavayollariniGetirBySorgulama(txtHavayoluAdi.Text, txtKisaltma.Text, txtUlkeAdi.Text, txtAciklama.Text, lvHavayollari);
        }

        private void txtKisaltma_TextChanged(object sender, EventArgs e)
        {
            h.HavayollariniGetirBySorgulama(txtHavayoluAdi.Text, txtKisaltma.Text, txtUlkeAdi.Text, txtAciklama.Text, lvHavayollari);
        }

        private void txtUlkeAdi_TextChanged(object sender, EventArgs e)
        {
            h.HavayollariniGetirBySorgulama(txtHavayoluAdi.Text, txtKisaltma.Text, txtUlkeAdi.Text, txtAciklama.Text, lvHavayollari);
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            h.HavayollariniGetirBySorgulama(txtHavayoluAdi.Text, txtKisaltma.Text, txtUlkeAdi.Text, txtAciklama.Text, lvHavayollari);
        }

        private void lvHavayollari_DoubleClick(object sender, EventArgs e)
        {
            Genel.HavayoluAdi = lvHavayollari.SelectedItems[0].SubItems[2].Text;
            Genel.HavayoluID = Convert.ToInt32(lvHavayollari.SelectedItems[0].SubItems[0].Text);
            Genel.kisaltma = lvHavayollari.SelectedItems[0].SubItems[1].Text;
            this.Close();
        }
    }
}
