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
    public partial class Havalimanlari : Form
    {
        public Havalimanlari()
        {
            InitializeComponent();
        }

        private void Havalimanlari_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Havalimani h = new Havalimani();
            h.HavalimanlariniGetir(lvHavalimanlari);
        }

        private void Temizle()
        {
            txtHavalimaniAdi.Clear();
            txtAciklama.Clear();
            txtHavalimaniKodu.Clear();
            txtSehirAdi.Clear();
            txtSehirKodu.Clear();
            txtHavalimaniAdi.Focus();
            txtKisaltmasi.Clear();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            Temizle();
            txtAciklama.ReadOnly = false;
            txtHavalimaniAdi.ReadOnly = false;
            txtKisaltmasi.ReadOnly = false;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtHavalimaniAdi.Text.Trim() != "" && txtSehirAdi.Text.Trim() != "" && txtKisaltmasi.Text.Trim() != "")
            {
                Havalimani h = new Havalimani();
                if (h.HavalimaniVarMi(txtHavalimaniAdi.Text, txtKisaltmasi.Text))
                {
                    MessageBox.Show("Havalımanızaten kayıtlı!");
                }
                else
                {
                    h.Aciklama = txtAciklama.Text;
                    h.SehirID = Convert.ToInt32(txtSehirKodu.Text);
                    h.HavalimaniAdi = txtHavalimaniAdi.Text;
                    h.Kisaltmasi = txtKisaltmasi.Text;
                    if (h.HavalimaniEkle(h))
                    {
                        MessageBox.Show("Havalimanı başarı ile eklendi.");
                        h.HavalimanlariniGetir(lvHavalimanlari);
                        Temizle();
                        btnKaydet.Enabled = false;
                        txtAciklama.ReadOnly = true;
                        txtHavalimaniAdi.ReadOnly = true;
                        txtKisaltmasi.ReadOnly = true;

                    }
                    else
                    {
                        MessageBox.Show("Havalimanı eklenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Havalimanı adı, kısaltması ve şehir adı boş bırakılamaz.");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtHavalimaniAdi.Text.Trim() != "" && txtSehirAdi.Text.Trim() != "" && txtKisaltmasi.Text.Trim() != "")
            {
                Havalimani h = new Havalimani();
                if (h.HavayoluVarMi(txtHavalimaniAdi.Text, Convert.ToInt32(txtHavalimaniKodu.Text), txtKisaltmasi.Text))
                {
                    MessageBox.Show("Havalimanı firması zaten kayıtlı!");
                    txtHavalimaniAdi.Focus();
                }
                else
                {
                    h.HavalimaniID = Convert.ToInt32(txtHavalimaniKodu.Text);
                    h.Aciklama = txtAciklama.Text;
                    h.SehirID = Convert.ToInt32(txtSehirKodu.Text);
                    h.HavalimaniAdi = txtHavalimaniAdi.Text;
                    h.Kisaltmasi = txtKisaltmasi.Text;
                    if (h.HavalimaniGuncelle(h))
                    {
                        MessageBox.Show("Havalimanı bilgileri güncellendi.");
                        btnSil.Enabled = false;
                        btnDegistir.Enabled = false;
                        Temizle();
                        txtHavalimaniAdi.ReadOnly = true;
                        txtAciklama.ReadOnly = true;
                        txtSehirAdi.ReadOnly = true;
                        txtHavalimaniKodu.ReadOnly = true;
                        txtSehirKodu.ReadOnly = true;
                        txtKisaltmasi.ReadOnly = true;
                        h.HavalimanlariniGetir(lvHavalimanlari);
                    }
                    else
                    {
                        MessageBox.Show("Havalimanı bilgileri güncellenemedi.");
                        txtHavalimaniAdi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Havalimanı adı, kısaltması ve şehir adı boş bırakılamaz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Havalimani h = new Havalimani();
                if (h.HavalimaniSil(Convert.ToInt32(txtHavalimaniKodu.Text)))
                {
                    MessageBox.Show("Havayolu Silindi.");
                    h.HavalimanlariniGetir(lvHavalimanlari);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;
                    txtHavalimaniAdi.ReadOnly = true;
                    txtAciklama.ReadOnly = true;
                    txtSehirAdi.ReadOnly = true;
                    txtHavalimaniKodu.ReadOnly = true;
                    txtSehirKodu.ReadOnly = true;
                    txtKisaltmasi.ReadOnly = true;
                }
            }
        }

        private void lvHavalimanlari_DoubleClick(object sender, EventArgs e)
        {
            txtHavalimaniKodu.Text = lvHavalimanlari.SelectedItems[0].SubItems[0].Text;
            txtKisaltmasi.Text = lvHavalimanlari.SelectedItems[0].SubItems[1].Text;
            txtHavalimaniAdi.Text = lvHavalimanlari.SelectedItems[0].SubItems[2].Text;
            txtSehirAdi.Text = lvHavalimanlari.SelectedItems[0].SubItems[3].Text;
            txtAciklama.Text = lvHavalimanlari.SelectedItems[0].SubItems[4].Text;
            txtSehirKodu.Text = lvHavalimanlari.SelectedItems[0].SubItems[5].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtHavalimaniAdi.ReadOnly = false;
            txtKisaltmasi.ReadOnly = false;
            txtAciklama.ReadOnly = false;

        }

        private void btnSehirBul_Click(object sender, EventArgs e)
        {
            SehirSorgulama frm = new SehirSorgulama();
            frm.ShowDialog();
            frm.StartPosition = FormStartPosition.CenterScreen;
            txtSehirAdi.Text = Genel.SehirAdi;
            txtSehirKodu.Text = Genel.SehirID.ToString();

        }
    }
}
