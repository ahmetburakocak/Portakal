using Portakal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portakal
{
    public partial class Sozlesme : Form
    {
        public Sozlesme()
        {
            InitializeComponent();
        }

        private void Sozlesme_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Havalimani h = new Havalimani();
            h.HavaalanlariGetir(cbHavalimanlari);
            Sehir se = new Sehir();
            se.SehirleriGetir(cbSehir);
            txtPlakaKodu.Text = Genel.PlakaID.ToString();
            txtAlisNoktasi.Text = Genel.HavalimaniAdi;
            txtAlisTarihi.Text = Genel.TeslimAlmaTarihi.ToShortDateString().ToString();
            txtBirakisTarihi.Text = Genel.BirakmaTarihi.ToShortDateString().ToString();
            Sozlesmeler s = new Sozlesmeler();
            s.SozlesmeleriGetir(lvSozlesme);
            TimeSpan tarihfarki = Genel.BirakmaTarihi - Genel.TeslimAlmaTarihi;
            double gunfarki = tarihfarki.Days;
            txtToplamTutar.Text = (gunfarki * Genel.Fiyat).ToString();
        }

        private void cbHavalimanlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBirakisNoktasi.Text = cbHavalimanlari.SelectedItem.ToString();
            Havalimani h = new Havalimani();
            txtBirakisID.Text = h.HavalimaniIDGetir(txtBirakisNoktasi.Text).ToString();
        }

        private void txtAlisNoktasi_TextChanged(object sender, EventArgs e)
        {
            Havalimani h = new Havalimani();
            txtAlisID.Text = h.HavalimaniIDGetir(txtAlisNoktasi.Text).ToString();
        }
        private void Temizle()
        {
            txtAd.Clear();
            txtAdres.Clear();
            txtAlisID.Clear();
            txtAlisNoktasi.Clear();
            txtAlisTarihi.Clear();
            txtBirakisID.Clear();
            txtBirakisNoktasi.Clear();
            txtBirakisTarihi.Clear();
            txtCepTelefonu.Clear();
            txtEvTelefonu.Clear();
            txtKimlikNo.Clear();
            txtMusteriNo.Clear();
            txtPlakaKodu.Clear();
            txtSoyad.Clear();
            txtSozlesmeID.Clear();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKimlikNo.Text.Trim() != "")
            {
                Musteriler m = new Musteriler();
                if (m.MusteriVarMi(txtKimlikNo.Text))
                {
                    MessageBox.Show("Müşteri Bilgileri Kayıtlı!");
                }
                else
                {
                    m.MusteriAd = txtAd.Text;
                    m.MusteriSoyad = txtSoyad.Text;
                    m.EvTelefon = txtEvTelefonu.Text;
                    m.CepTelefon = txtCepTelefonu.Text;
                    m.Adres = txtAdres.Text;
                    m.KimlikNo = txtKimlikNo.Text;
                    m.SehirID = Convert.ToInt32(txtSehirID.Text);
                    m.Aciklama = "*";
                    if (m.MusteriEkle(m))
                    {
                        MessageBox.Show("Müşteri başarı ile eklendi.");

                    }
                    else
                    {
                        MessageBox.Show("Musteri Eklenemedi");
                    }
                }

                txtMusteriNo.Text = m.MusteriIDGetir(txtKimlikNo.Text).ToString();
                Sozlesmeler s = new Sozlesmeler();
                if (s.SozlesmeVarMi(txtKimlikNo.Text, Convert.ToInt32(txtPlakaKodu.Text)))
                {
                    MessageBox.Show("Sözleşme Kayıtlı!!");
                }
                else
                {
                    s.PlakaID = Convert.ToInt32(txtPlakaKodu.Text);
                    s.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                    s.KimlikNo = txtKimlikNo.Text;
                    s.Ad = txtAd.Text.ToUpper();
                    s.Soyad = txtSoyad.Text.ToUpper();
                    s.EvTelefonu = txtEvTelefonu.Text;
                    s.CepTelefonu = txtCepTelefonu.Text;
                    s.Adres = txtAdres.Text.ToUpper() + " " + txtSehir.Text;
                    s.AlisNoktasi = txtAlisNoktasi.Text;
                    s.AlisTarihi = Convert.ToDateTime(txtAlisTarihi.Text);
                    s.BirakisNoktasi = txtBirakisNoktasi.Text;
                    s.BirakisTarihi = Convert.ToDateTime(txtBirakisTarihi.Text);
                    s.ToplamTutar = Convert.ToDouble(txtToplamTutar.Text);

                    if (s.SozlesmeEkle(s))
                    {
                        MessageBox.Show("Sözleşme Eklendi");
                        s.SozlesmeleriGetir(lvSozlesme);
                        Araclar a = new Araclar();
                        a.AracKirala(Convert.ToInt32(txtPlakaKodu.Text));
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Sözleşme Eklenemedi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kimlik Numarasını Giriniz!");
                txtKimlikNo.Focus();
            }
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            if (txtKimlikNo.Text.Trim() != "")
            {
                Musteriler m = new Musteriler();
                if (m.MusteriVarMi(txtKimlikNo.Text))
                {
                    txtMusteriNo.Text = m.MusteriIDGetir(txtKimlikNo.Text).ToString();
                    MusterileriGetir(Convert.ToInt32(txtMusteriNo.Text));
                    MessageBox.Show("Müşteri Bulundu");
                }
                else
                {
                    MessageBox.Show("Müşteri Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Kimlik No Giriniz");
            }
        }
        SqlConnection conn = new SqlConnection(Genel.connStr);
        private void MusterileriGetir(int MusteriNo)
        {
            SqlCommand comm = new SqlCommand("select MusteriAdi,MusteriSoyadi,EvTelefonu,CepTelefonu,Adres from Musteriler where MusteriID=@MusteriNo and Silindi=0", conn);
            comm.Parameters.Add("MusteriNo", SqlDbType.Int).Value = MusteriNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        txtAd.Text = dr[0].ToString();
                        txtSoyad.Text = dr[1].ToString();
                        txtEvTelefonu.Text = dr[2].ToString();
                        txtCepTelefonu.Text = dr[3].ToString();
                        txtAdres.Text = dr[4].ToString();
                    }
                    dr.Close();
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); }
        }

        private void lvSozlesme_DoubleClick(object sender, EventArgs e)
        {
            txtPlakaKodu.Text = lvSozlesme.SelectedItems[0].SubItems[0].Text;
            txtKimlikNo.Text = lvSozlesme.SelectedItems[0].SubItems[1].Text;
            txtAd.Text = lvSozlesme.SelectedItems[0].SubItems[2].Text;
            txtSoyad.Text = lvSozlesme.SelectedItems[0].SubItems[3].Text;
            txtEvTelefonu.Text = lvSozlesme.SelectedItems[0].SubItems[4].Text;
            txtCepTelefonu.Text = lvSozlesme.SelectedItems[0].SubItems[5].Text;
            txtAdres.Text = lvSozlesme.SelectedItems[0].SubItems[6].Text;
            txtAlisNoktasi.Text = lvSozlesme.SelectedItems[0].SubItems[7].Text;
            txtAlisTarihi.Text = lvSozlesme.SelectedItems[0].SubItems[8].Text;
            txtBirakisNoktasi.Text = lvSozlesme.SelectedItems[0].SubItems[9].Text;
            txtBirakisTarihi.Text = lvSozlesme.SelectedItems[0].SubItems[10].Text;
            txtToplamTutar.Text = lvSozlesme.SelectedItems[0].SubItems[11].Text;
            txtSozlesmeID.Text = lvSozlesme.SelectedItems[0].SubItems[12].Text;
            txtMusteriNo.Text = lvSozlesme.SelectedItems[0].SubItems[13].Text;
            btnDegistir.Enabled = true;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtKimlikNo.Text.Trim() != "" && txtPlakaKodu.Text.Trim() != "")
            {
                Sozlesmeler s = new Sozlesmeler();
                if (s.SozlesmeVarMi(txtKimlikNo.Text, Convert.ToInt32(txtSozlesmeID.Text)))
                {
                    MessageBox.Show("Sözleşme zaten kayıtlı!");
                }
                else
                {
                    s.SozlesmeID = Convert.ToInt32(txtSozlesmeID.Text);
                    s.PlakaID = Convert.ToInt32(txtPlakaKodu.Text);
                    s.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                    s.KimlikNo = txtKimlikNo.Text;
                    s.Ad = txtAd.Text.ToUpper();
                    s.Soyad = txtSoyad.Text.ToUpper();
                    s.EvTelefonu = txtEvTelefonu.Text;
                    s.CepTelefonu = txtCepTelefonu.Text;
                    s.Adres = txtAdres.Text.ToUpper();
                    s.AlisNoktasi = txtAlisNoktasi.Text;
                    s.AlisTarihi = Convert.ToDateTime(txtAlisTarihi.Text);
                    s.BirakisNoktasi = txtBirakisNoktasi.Text;
                    s.BirakisTarihi = Convert.ToDateTime(txtBirakisTarihi.Text);
                    s.ToplamTutar = Convert.ToDouble(txtToplamTutar.Text);

                    if (s.SozlesmeGuncelle(s))
                    {
                        MessageBox.Show("Sözleşme başarı ile güncellendi.");
                        s.SozlesmeleriGetir(lvSozlesme);
                        Temizle();
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("Sözleşme güncellenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("KimlikNo ve Plaka Kodu boş bırakılamaz.");
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (txtPlakaKodu.Text.Trim() != "" && txtSozlesmeID.Text.Trim() != "")
            {
                Araclar a = new Araclar();
                bool Sonuc = a.AracTeslimAl(Convert.ToInt32(txtPlakaKodu.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Arac Teslim Alındı.");
                }
                Sozlesmeler s = new Sozlesmeler();
                bool Sonuc1 = s.SozlesmeKaldır(Convert.ToInt32(txtSozlesmeID.Text));
                if (Sonuc1)
                {
                    MessageBox.Show("Sözleşme Kaldırıldı.");
                }
                s.SozlesmeleriGetir(lvSozlesme);
                Temizle();
            }
        }

        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSehir.Text = cbSehir.SelectedItem.ToString();
            Sehir s = new Sehir();
            int a = s.SehirIDGetir(txtSehir.Text);
            txtSehirID.Text = a.ToString();
        }
    }
}
