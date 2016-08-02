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
    public partial class FirmaEkle : Form
    {
        public FirmaEkle()
        {
            InitializeComponent();
        }

        private void FirmaEkle_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Firmalar f = new Firmalar();
            f.FirmalarıGetir(lvFirmalar);
            txtFirmAd.Focus();
        }
        private void Temizle()
        {
            txtFirmaID.Clear();
            txtFirmAd.Clear();
            txtAciklama.Clear();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtFirmAd.ReadOnly = false;
            txtAciklama.ReadOnly = false;
            btnKaydet.Enabled = true;
            Temizle();
            txtFirmAd.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFirmAd.Text.Trim() != "")
            {
                Firmalar f = new Firmalar();
                if (f.FirmaVarmi(txtFirmAd.Text, txtAciklama.Text))
                {
                    MessageBox.Show("Firma zaten kayıtlı!");
                }
                else
                {
                    f.FirmaAd = txtFirmAd.Text.ToUpper();
                    f.Aciklama = txtAciklama.Text.ToUpper();
                    if (f.FirmaEkle(f))
                    {
                        MessageBox.Show("Firma başarı ile eklendi.");
                        f.FirmalarıGetir(lvFirmalar);
                        Temizle();
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = true;
                        btnSil.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Firma eklenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Firma Adı boş bırakılamaz.");
            }
        }

        private void lvFirmalar_DoubleClick(object sender, EventArgs e)
        {
            txtFirmAd.Text = lvFirmalar.SelectedItems[0].SubItems[0].Text;
            txtAciklama.Text = lvFirmalar.SelectedItems[0].SubItems[1].Text;
            txtFirmaID.Text = lvFirmalar.SelectedItems[0].SubItems[2].Text;
            txtAciklama.ReadOnly = false;
            txtFirmAd.ReadOnly = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFirmAd.Text.Trim() != "")
            {
                Firmalar f = new Firmalar();
                if (f.FirmaGuncelleVarmi(txtFirmAd.Text, Convert.ToInt32(txtFirmaID.Text), txtAciklama.Text))
                {
                    MessageBox.Show("Firma zaten kayıtlı!");
                }
                else
                {
                    f.FirmaID = Convert.ToInt32(txtFirmaID.Text);
                    f.FirmaAd = txtFirmAd.Text.ToUpper();
                    f.Aciklama = txtAciklama.Text.ToUpper();
                    if (f.FirmaGuncelle(f))
                    {
                        MessageBox.Show("Firma başarı ile güncellendi.");
                        f.FirmalarıGetir(lvFirmalar);
                        Temizle();
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Firma güncellenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Firma Adı boş bırakılamaz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Firmalar f = new Firmalar();
                if (f.FirmaSil(Convert.ToInt32(txtFirmaID.Text)))
                {
                    MessageBox.Show("Marka Silindi.");
                    f.FirmalarıGetir(lvFirmalar);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;

                }
            }
        }
    }
}
