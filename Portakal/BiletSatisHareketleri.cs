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
    public partial class BiletSatisHareketleri : Form
    {
        public BiletSatisHareketleri()
        {
            InitializeComponent();
        }

        private void BiletSatisHareketleri_Load(object sender, EventArgs e)
        {
            txtPrimary.Text = GetTimestamp(DateTime.Now);
            Musteriler m = new Musteriler();
            m.MusterileriGetir(lvMusteiler);
            Ucus u = new Ucus();
            Ucus k = u.BilgiGetirFiyat(Genel.UcusIDGidis);
            if (Genel.BiletTipi == "Ekonomi")
            {
                txtBiletFiyati.Text = k.EkonomikFiyat.ToString();
            }
            else if (Genel.BiletTipi == "Business")
            {
                txtBiletFiyati.Text = k.BusinessClassFiyat.ToString();
            }
            else
            {
                txtBiletFiyati.Text = k.FirstClassFiyat.ToString();
            }
            Havayolu h = new Havayolu();
            txtHavayoluAdi.Text = h.HavayoluAdiGetir(Genel.UcusIDGidis);
            txtHavalimaniAdi1.Text = Genel.BiletKalkisYeri;
            txtHavalimaniAdi2.Text = Genel.BiletInisYeri;
            txtTarih.Text = Genel.BiletGidisTarihi.ToShortDateString();
            txtBiletTipi.Text = Genel.BiletTipi;
            txtKisiSayisi.Text = Genel.BiletKisiSayisi.ToString();
            txtEksKilo.Text = Convert.ToString(Genel.BiletBagajKilosu);
            txteksBagFiyat.Text = k.EkstraBagajFiyat.ToString();
            txtAraToplam.Text = (Convert.ToInt32(txtKisiSayisi.Text) * Convert.ToInt32(txtBiletFiyati.Text)).ToString();
            txtGidisToplam.Text = (Convert.ToInt32(txtAraToplam.Text) + (Convert.ToInt32(txteksBagFiyat.Text) * Convert.ToInt32(txtEksKilo.Text))).ToString();
            if (Genel.BiletTekYonMu == false)
            {
                k = u.BilgiGetirFiyat(Genel.UcusIDDonus);
                if (Genel.BiletTipi == "Ekonomi")
                {
                    txtBiletFiyati1.Text = k.EkonomikFiyat.ToString();
                }
                else if (Genel.BiletTipi == "Business")
                {
                    txtBiletFiyati1.Text = k.BusinessClassFiyat.ToString();
                }
                else
                {
                    txtBiletFiyati1.Text = k.FirstClassFiyat.ToString();
                }
                txtHavayoluAdi1.Text = h.HavayoluAdiGetir(Genel.UcusIDGidis);
                txtBiletTipi.Text = Genel.BiletTipi;
                txtKisiSayisi1.Text = Genel.BiletKisiSayisi.ToString();
                txteksBagFiyat1.Text = k.EkstraBagajFiyat.ToString();
                txtHavalimaniAdi11.Text = Genel.BiletKalkisYeriDonus;
                txtHavalimaniAdi21.Text = Genel.BiletInisYeriDonus;
                txtTarih1.Text = Genel.BiletDonusTarihi.ToShortDateString();
                txtEksKilo1.Text = Genel.EkstraBagajKilosuDonus.ToString();
                txtAraToplam1.Text = (Convert.ToInt32(txtKisiSayisi1.Text) * Convert.ToInt32(txtBiletFiyati1.Text)).ToString();
                txtDonusToplam.Text = (Convert.ToInt32(txtAraToplam1.Text) + (Convert.ToInt32(txteksBagFiyat1.Text) * Convert.ToInt32(txtEksKilo1.Text))).ToString();
            }
            else
            {
                txtDonusToplam.Text = "0";
            }


        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void btnSehirBul_Click(object sender, EventArgs e)
        {
            SehirSorgulama frm = new SehirSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtSehir.Text = Genel.SehirAdi;
            txtSehirID.Text = Genel.SehirID.ToString();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnEkle.Enabled = true;
            btnSil.Enabled = false;
            Temizle();
            txtMusteriAd.ReadOnly = false;
            txtSoyad.ReadOnly = false;
            txtEvTelefonu.ReadOnly = false;
            txtCepTelefonu.ReadOnly = false;
            txtAdres.ReadOnly = false;
            txtAciklama.ReadOnly = false;
            txtMusteriTc.ReadOnly = false;
        }

        private void txtTCNO_TextChanged(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusteriSorgulamaByTCNOyaGore(txtTCNO.Text, lvMusteiler);
        }

        private void lvMusteiler_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = lvMusteiler.SelectedItems[0].SubItems[0].Text;
            txtMusteriAd.Text = lvMusteiler.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = lvMusteiler.SelectedItems[0].SubItems[2].Text;
            txtEvTelefonu.Text = lvMusteiler.SelectedItems[0].SubItems[3].Text;
            txtCepTelefonu.Text = lvMusteiler.SelectedItems[0].SubItems[4].Text;
            txtAdres.Text = lvMusteiler.SelectedItems[0].SubItems[5].Text;
            txtSehirID.Text = lvMusteiler.SelectedItems[0].SubItems[6].Text;
            txtSehir.Text = lvMusteiler.SelectedItems[0].SubItems[7].Text;
            txtAciklama.Text = lvMusteiler.SelectedItems[0].SubItems[8].Text;
            txtMusteriTc.Text = lvMusteiler.SelectedItems[0].SubItems[9].Text;
            btnEkle.Enabled = false;
            btnSil.Enabled = true;
        }

        private void Temizle()
        {
            txtID.Clear();
            txtMusteriAd.Clear();
            txtSoyad.Clear();
            txtEvTelefonu.Clear();
            txtCepTelefonu.Clear();
            txtAdres.Clear();
            txtSehirID.Clear();
            txtSehir.Clear();
            txtAciklama.Clear();
            txtMusteriTc.Clear();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMusteriAd.Text != "" && txtSoyad.Text != "" && txtEvTelefonu.Text != "" && txtCepTelefonu.Text != "" && txtAdres.Text != "" && txtSehirID.Text != "" && txtMusteriTc.Text != "")
            {
                Musteriler m = new Musteriler();
                m.Aciklama = txtAciklama.Text;
                m.Adres = txtAdres.Text;
                m.CepTelefon = txtCepTelefonu.Text;
                m.EvTelefon = txtEvTelefonu.Text;
                m.KimlikNo = txtMusteriTc.Text;
                m.MusteriAd = txtMusteriAd.Text;
                m.SehirID = int.Parse(txtSehirID.Text);
                m.MusteriSoyad = txtSoyad.Text;
                if (m.MusteriEkle(m))
                {
                    MessageBox.Show("Müşteri kaydedildi.");
                    btnEkle.Enabled = false;
                    btnSil.Enabled = false;
                    m.MusterileriGetir(lvMusteiler);
                    Temizle();
                    txtTCNO.Focus();
                }
                else
                {
                    MessageBox.Show("Müşteri kaydedilemedi.");
                    txtTCNO.Focus();
                }
            }
            else
            {
                MessageBox.Show("Hiç bir alan boş bırakılamaz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Musteriler m = new Musteriler();
                if (m.MusteriSil(Convert.ToInt32(txtID.Text)))
                {
                    MessageBox.Show("Müşteri silindi.");
                    Temizle();
                    btnSil.Enabled = false;
                    btnEkle.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Müşteri silinemedi.");
                }
            }

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                SatisHareketleri sh = new SatisHareketleri();
                sh.Adet = Convert.ToInt32(txtKisiSayisi.Text);
                sh.BirimFiyat = Convert.ToDouble(txtBiletFiyati.Text);
                sh.EkstraBagajKilosu = Convert.ToInt32(txtEksKilo.Text);
                sh.MusteriID = Convert.ToInt32(txtID.Text);
                sh.Status = txtBiletTipi.Text;
                sh.TekilKod = txtPrimary.Text;
                sh.ToplamTutar = Convert.ToDouble(txtGidisToplam.Text);
                sh.Tutar = Convert.ToDouble(txtAraToplam.Text);
                sh.UcusID = Genel.UcusIDGidis;
                if (sh.HareketEkle(sh))
                {
                    if (Genel.BiletTekYonMu == false)
                    {
                        sh.BirimFiyat = Convert.ToDouble(txtBiletFiyati1.Text);
                        sh.EkstraBagajKilosu = Convert.ToInt32(txtEksKilo1.Text);
                        sh.ToplamTutar = Convert.ToDouble(txtGidisToplam.Text);
                        sh.Tutar = Convert.ToDouble(txtAraToplam.Text);
                        sh.UcusID = Genel.UcusIDDonus;
                        if (sh.HareketEkle(sh))
                        {
                            sh.KoltukAzalt(Genel.BiletTipi, Genel.BiletKisiSayisi, Genel.UcusIDDonus);
                            MessageBox.Show("Gidiş-dönüş kayıt yapıldı.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gidiş-dönüş kayıt yapılamadı.");
                        }
                    }
                    else
                    {
                        sh.KoltukAzalt(Genel.BiletTipi, Genel.BiletKisiSayisi, Genel.UcusIDGidis);
                        MessageBox.Show("Tek yön kayıt yapıldı.");
                    }
                }
                else
                {
                    MessageBox.Show("Hiçbir kayıt yapılamadı.");
                }
            }

            else
            {
                MessageBox.Show("Müşteri seçiniz.");
            }
        }
    }
}
