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
    public partial class UlkeSorgulama : Form
    {
        public UlkeSorgulama()
        {
            InitializeComponent();
        }

        Ulke u = new Ulke();
        private void UlkeSorgulama_Load(object sender, EventArgs e)
        {
            u.UlkeleriGetir(lvUlkeler);
        }

        private void txtUlkeKodu_TextChanged(object sender, EventArgs e)
        {

            u.UlkeleriGetirBySorgulama(txtUlkeAdi.Text, txtTelefonKodu.Text, txtAciklama.Text, lvUlkeler);
        }

        private void TxtUlkeAdi_TextChanged(object sender, EventArgs e)
        {
            u.UlkeleriGetirBySorgulama(txtUlkeAdi.Text, txtTelefonKodu.Text, txtAciklama.Text, lvUlkeler);
        }

        private void txtTelefonKodu_TextChanged(object sender, EventArgs e)
        {
            u.UlkeleriGetirBySorgulama(txtUlkeAdi.Text, txtTelefonKodu.Text, txtAciklama.Text, lvUlkeler);
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            u.UlkeleriGetirBySorgulama(txtUlkeAdi.Text, txtTelefonKodu.Text, txtAciklama.Text, lvUlkeler);
        }

        private void lvUlkeler_DoubleClick(object sender, EventArgs e)
        {
            Genel.UlkeAdi = lvUlkeler.SelectedItems[0].SubItems[1].Text;
            Genel.UlkeID = Convert.ToInt32(lvUlkeler.SelectedItems[0].SubItems[0].Text);
            this.Close();
        }
    }
}
