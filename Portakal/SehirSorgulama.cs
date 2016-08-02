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
    public partial class SehirSorgulama : Form
    {
        public SehirSorgulama()
        {
            InitializeComponent();
        }

        Sehir s = new Sehir();
        private void SehirSorgulama_Load(object sender, EventArgs e)
        {
            s.SehirleriGetir(lvSehirler);
        }

        private void txtSehirAdi_TextChanged(object sender, EventArgs e)
        {
            s.SehirleriGetirBySorgulama(txtSehirAdi.Text, txtUlkeAdi.Text, txtAciklama.Text, lvSehirler);
        }

        private void txtUlkeAdi_TextChanged(object sender, EventArgs e)
        {
            s.SehirleriGetirBySorgulama(txtSehirAdi.Text, txtUlkeAdi.Text, txtAciklama.Text, lvSehirler);
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            s.SehirleriGetirBySorgulama(txtSehirAdi.Text, txtUlkeAdi.Text, txtAciklama.Text, lvSehirler);
        }

        private void lvSehirler_DoubleClick(object sender, EventArgs e)
        {
            Genel.SehirID = Convert.ToInt32(lvSehirler.SelectedItems[0].SubItems[0].Text);
            Genel.SehirAdi = lvSehirler.SelectedItems[0].SubItems[1].Text;
            this.Close();
        }
    }
}
