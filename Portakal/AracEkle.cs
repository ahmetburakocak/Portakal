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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Marka m = new Marka();
            m.MarkalariGetir(cbMarkalar);
            Havalimani h = new Havalimani();
            h.HavaalanlariGetir(cbHavalimani);
            Firmalar f = new Firmalar();
            f.FirmalarıGetir(cbFirmaAdi);
            Araclar a = new Araclar();
            a.AraclariGetir(lvAraclar);
        }
        private void Temizle()
        {
            txtMarkaAd.Clear();
            txtMarkaID.Clear();
            txtModelID.Clear();
            txtModel.Clear();
            txtHavalimaniID.Clear();
            txtHavalimaniAdi.Clear();
            txtFirmaID.Clear();
            txtFirmaAdi.Clear();
            txtFiyat.Text = "0";
        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMarkaAd.Text = cbMarkalar.SelectedItem.ToString();
            Marka m = new Marka();
            txtMarkaID.Text = m.MarkaIDGetir(txtMarkaAd.Text).ToString();
            txtModelID.Clear();
            txtModel.Clear();
            cbModeller.Items.Clear();
            Modeller mr = new Modeller();
            mr.ModelleriGetir(cbModeller, Convert.ToInt32(txtMarkaID.Text));
        }

        private void cbModeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModel.Text = cbModeller.SelectedItem.ToString();
            Modeller m = new Modeller();
            txtModelID.Text = m.ModelIDGetir(txtModel.Text).ToString();
        }

        private void cbHavalimani_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHavalimaniAdi.Text = cbHavalimani.SelectedItem.ToString();
            Havalimani h = new Havalimani();
            txtHavalimaniID.Text = h.HavalimaniIDGetir(txtHavalimaniAdi.Text).ToString(); 
        }

        private void cbFirmaAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFirmaAdi.Text = cbFirmaAdi.SelectedItem.ToString();
            Firmalar f = new Firmalar();
            txtFirmaID.Text = f.FirmaIDGetir(txtFirmaAdi.Text).ToString();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            cbFirmaAdi.Enabled = true;
            cbMarkalar.Enabled = true;
            cbHavalimani.Enabled = true;
            cbModeller.Enabled = true;
            btnKaydet.Enabled = true;
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMarkaAd.Text.Trim() != "" && txtModel.Text.Trim() != "" && txtHavalimaniAdi.Text.Trim() != "" && txtFirmaAdi.Text.Trim() != "")
            {
                Araclar a = new Araclar();
                a.FirmaID = Convert.ToInt32(txtFirmaID.Text);
                a.HavalimaniID = Convert.ToInt32(txtHavalimaniID.Text);
                a.ModelID = Convert.ToInt32(txtModelID.Text);
                a.Fiyat = Convert.ToDouble(txtFiyat.Text);

                if (a.AracEkle(a))
                {
                    MessageBox.Show("Araç Tanımlanması başarı ile eklendi.");
                    a.AraclariGetir(lvAraclar);
                    Temizle();
                    btnKaydet.Enabled = false;
                    btnDegistir.Enabled = true;
                    btnSil.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Araç eklenemedi.");
                }

            }
            else
            {
                MessageBox.Show("Firma Adı,Havalimani Adı,Model ve Marka Adı boş bırakılamaz.");
            }
        }

        private void lvAraclar_DoubleClick(object sender, EventArgs e)
        {
            txtPlakaID.Text = lvAraclar.SelectedItems[0].SubItems[0].Text;
            txtMarkaAd.Text = lvAraclar.SelectedItems[0].SubItems[1].Text;
            txtModel.Text = lvAraclar.SelectedItems[0].SubItems[2].Text;
            txtHavalimaniAdi.Text = lvAraclar.SelectedItems[0].SubItems[3].Text;
            txtFirmaAdi.Text = lvAraclar.SelectedItems[0].SubItems[4].Text;
            txtFiyat.Text = lvAraclar.SelectedItems[0].SubItems[5].Text;
            txtModelID.Text = lvAraclar.SelectedItems[0].SubItems[7].Text;
            txtHavalimaniID.Text = lvAraclar.SelectedItems[0].SubItems[8].Text;
            txtFirmaID.Text = lvAraclar.SelectedItems[0].SubItems[9].Text;
            cbFirmaAdi.Enabled = true;
            cbHavalimani.Enabled = true;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            txtFiyat.Focus();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtMarkaAd.Text.Trim() != "" && txtModel.Text.Trim() != "" && txtHavalimaniAdi.Text.Trim() != "" && txtFirmaAdi.Text.Trim() != "")
            {
                Araclar a = new Araclar();
                if (a.AracGuncelleVarmi(Convert.ToInt32(txtPlakaID.Text), txtFiyat.Text, Convert.ToInt32(txtFirmaID.Text), Convert.ToInt32(txtHavalimaniID.Text)))
                {
                    MessageBox.Show("Arac zaten kayıtlı!");
                }
                else
                {
                    a.PlakaID = Convert.ToInt32(txtPlakaID.Text);
                    a.ModelID = Convert.ToInt32(txtModelID.Text);
                    a.HavalimaniID = Convert.ToInt32(txtHavalimaniID.Text);
                    a.FirmaID = Convert.ToInt32(txtFirmaID.Text);
                    a.Fiyat = Convert.ToDouble(txtFiyat.Text);

                    if (a.AracGuncelle(a))
                    {
                        MessageBox.Show("Araç başarı ile güncellendi.");
                        a.AraclariGetir(lvAraclar);
                        Temizle();
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Araç güncellenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Havalimanı,Firma,Model ve Marka Adı boş bırakılamaz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Araclar a = new Araclar();
                if (a.AracSil(Convert.ToInt32(txtPlakaID.Text)))
                {
                    MessageBox.Show("Model Silindi.");
                    a.AraclariGetir(lvAraclar);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;

                }
            }
        }

        private void txtPlakayaGoreArama_TextChanged(object sender, EventArgs e)
        {
            Araclar a = new Araclar();
            a.AraclariGetirByPlakayaGore(txtPlakayaGoreArama.Text, lvAraclar);
        }
    }
}
