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
    public partial class AracMarka : Form
    {
        public AracMarka()
        {
            InitializeComponent();
        }

        private void AracMarka_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Marka m = new Marka();
            m.MarkalariGetir(lvMarkalar);
            txtMarkaAd.Focus();
            Sinif s = new Sinif();
            s.SiniflariGetir(cbSiniflar);
        }
        private void Temizle()
        {
            txtMarkaID.Clear();
            txtMarkaAd.Clear();
            txtAciklama.Clear();
        }
        private void cbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSinifAd.Text = cbSiniflar.SelectedItem.ToString();
            Sinif s = new Sinif();
            txtSinifID.Text = s.SinifIDGetir(txtSinifAd.Text).ToString();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtMarkaAd.ReadOnly = false;
            txtAciklama.ReadOnly = false;
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
            txtMarkaAd.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMarkaAd.Text.Trim() != "")
            {
                Marka m = new Marka();
                if (m.MarkaVarmi(txtMarkaAd.Text, Convert.ToInt32(txtSinifID.Text)))
                {
                    MessageBox.Show("Marka zaten kayıtlı!");
                }
                else
                {
                    m.MarkaAd = txtMarkaAd.Text.ToUpper();
                    m.Aciklama = txtAciklama.Text.ToUpper();
                    m.SinifID = Convert.ToInt32(txtSinifID.Text);
                    if (m.MarkaEkle(m))
                    {
                        MessageBox.Show("Marka başarı ile eklendi.");
                        m.MarkalariGetir(lvMarkalar);
                        Temizle();
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = true;
                        btnSil.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Marka eklenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Marka Adı boş bırakılamaz.");
            }
        }

        private void lvMarkalar_DoubleClick(object sender, EventArgs e)
        {
            txtSinifAd.Text = lvMarkalar.SelectedItems[0].SubItems[0].Text;
            txtMarkaAd.Text = lvMarkalar.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = lvMarkalar.SelectedItems[0].SubItems[2].Text;
            txtMarkaID.Text = lvMarkalar.SelectedItems[0].SubItems[3].Text;
            txtSinifID.Text = lvMarkalar.SelectedItems[0].SubItems[4].Text;
            txtAciklama.ReadOnly = false;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtMarkaAd.Text.Trim() != "")
            {
                Marka m = new Marka();
                if (m.MarkaGuncelleVarmi(txtMarkaAd.Text, Convert.ToInt32(txtMarkaID.Text)))
                {
                    MessageBox.Show("Marka zaten kayıtlı!");
                }
                else
                {
                    m.MarkaID = Convert.ToInt32(txtMarkaID.Text);
                    m.MarkaAd = txtMarkaAd.Text.ToUpper();
                    m.Aciklama = txtAciklama.Text.ToUpper();
                    if (m.MarkaGuncelle(m))
                    {
                        MessageBox.Show("Marka başarı ile güncellendi.");
                        m.MarkalariGetir(lvMarkalar);
                        Temizle();
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Marka güncellenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Marka Adı boş bırakılamaz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Marka m = new Marka();
                if (m.MarkaSil(Convert.ToInt32(txtMarkaID.Text)))
                {
                    MessageBox.Show("Marka Silindi.");
                    m.MarkalariGetir(lvMarkalar);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;

                }
            }
        }

        private void btnSinifaGoreArama_Click(object sender, EventArgs e)
        {
            Sinif s = new Sinif();
            s.SinifaGoreArama(lvMarkalar, Convert.ToInt32(txtSinifID.Text));
        }
    }
}
