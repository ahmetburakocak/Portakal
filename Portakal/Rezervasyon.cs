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
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }
        Rezerv r = new Rezerv();
        Otel o = new Otel();
        DataSet ds = new DataSet();
        private void Rezervasyon_Load(object sender, EventArgs e)
        {

            lblOtelAd.Text = Genel.OtelAd;
            lblOdaTipi.Text = Genel.OdaTipi;
            DateTime ct = Convert.ToDateTime(Genel.CikisTarihi);
            DateTime gt = Convert.ToDateTime(Genel.GirisTarihi);
            lblGirisTarihi.Text = gt.ToShortDateString();
            lblCikisTarihi.Text = ct.ToShortDateString();
            lblFiyat.Text = Genel.OdaFiyat;
            r.SehileriGetir(cbSehirler);
            ds = r.MusterileriGetir();
            dgvMusteriler.DataSource = ds.Tables["Musteriler"];
            dgvMusteriler.Columns[0].Visible = false;
            dgvMusteriler.Columns[8].Visible = false;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIsim.Text) || string.IsNullOrEmpty(txtSoyisim.Text) || string.IsNullOrEmpty(txtSehir.Text))
            {
                MessageBox.Show("İsim Soyisim ve Şehir Bilgilerini Boş Geçemezsiniz!!");
            }
            else
            {
                Rezerv r = new Rezerv();
                r.MusteriTc = txtTcNo.Text;
                r.MusteriAd = txtIsim.Text;
                r.MusteriSoyad = txtSoyisim.Text;
                r.EvTelefon = txtevtelefon.Text;
                r.CepTelefon = txtCepTelefon.Text;
                r.Adres = txtAdres.Text;
                r.SehirID = Convert.ToInt32(txtSehirID.Text);

                bool varmi = r.MusteriKontrol(r);
                if (varmi)
                {
                    r.MusteriID = Genel.MusteriID;
                    r.OtelID = Genel.OtelID;
                    r.TipID = Genel.OdaTipiID;
                    r.Adet = Convert.ToInt32(Genel.OdaAdet);
                    r.Fiyat = Convert.ToDecimal(Genel.OdaFiyat);
                    r.GirisTarihi = Genel.GirisTarihi;
                    r.CikisTarihi = Genel.CikisTarihi;
                    int rezno = r.rezervasyonKaydet(r);
                    r.RezervasyonID = rezno;
                    MessageBox.Show("Rezervasyon Bilgileri Kaydedildi");
                    o.OdaSayisiniGüncelle(Genel.OdaTipiID);
                    bool durum = r.RezervDurumuDegistir(r);
                    if (durum)
                    {
                        MessageBox.Show("Rezervasyon Durumu Güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Rezervasyon Durumunda Bir Hata Oluştu");
                    }
                }
                else
                {
                    int sonuc = r.MusteriKaydet(r);
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Müşteri Bilgileri Kaydedildi");
                        r.MusteriID = sonuc;
                        r.OtelID = Genel.OtelID;
                        r.TipID = Genel.OdaTipiID;
                        r.Adet = Convert.ToInt32(Genel.OdaAdet);
                        r.Fiyat = Convert.ToDecimal(Genel.OdaFiyat);
                        r.GirisTarihi = Genel.GirisTarihi;
                        r.CikisTarihi = Genel.CikisTarihi;
                        int rez = r.rezervasyonKaydet(r);
                        if (rez > 0)
                        {
                            MessageBox.Show("Rezervasyon Bilgileri Kaydedildi");
                            r.RezervasyonID = rez;
                            bool durum = r.RezervDurumuDegistir(r);
                            if (durum)
                            {
                                MessageBox.Show("Rezervasyon Durumu Güncellendi");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Rezervasyon Durumunda Bir Hata Oluştu");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Rezervasyon İşleminde Bir Sorun Oluştu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Müşteri Kaydı Sırasında Bir Hata Oluştu");
                    }

                }
            }
        }

        private void cbSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rezerv r = (Rezerv)cbSehirler.SelectedItem;
            txtSehir.Text = cbSehirler.SelectedItem.ToString();
            txtSehirID.Text = r.SehirID.ToString();
        }

        private void dgvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            txtSehirID.Text = dgvMusteriler.SelectedRows[0].Cells[8].Value.ToString();
            txtMusteriID.Text = dgvMusteriler.SelectedRows[0].Cells[0].Value.ToString();
            txtIsim.Text = dgvMusteriler.SelectedRows[0].Cells[1].Value.ToString();
            txtSoyisim.Text = dgvMusteriler.SelectedRows[0].Cells[2].Value.ToString();
            txtTcNo.Text = dgvMusteriler.SelectedRows[0].Cells[3].Value.ToString();
            txtCepTelefon.Text = dgvMusteriler.SelectedRows[0].Cells[4].Value.ToString();
            txtevtelefon.Text = dgvMusteriler.SelectedRows[0].Cells[5].Value.ToString();
            txtAdres.Text = dgvMusteriler.SelectedRows[0].Cells[6].Value.ToString();
            txtSehir.Text = dgvMusteriler.SelectedRows[0].Cells[7].Value.ToString();
            Genel.MusteriID = Convert.ToInt32(txtMusteriID.Text);
        }
    }
}
