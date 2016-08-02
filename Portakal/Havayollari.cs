using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portakal.Model;

namespace Portakal
{
    public partial class Havayollari : Form
    {
        public Havayollari()
        {
            InitializeComponent();
        }

        private void Havayollari_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Havayolu h = new Havayolu();
            h.HavayollariniGetir(lvHavayolları);
        }

        private void Temizle()
        {
            txtHavayoluAdi.Clear();
            txtAciklama.Clear();
            txtHavayoluKodu.Clear();
            txtUlkeAdi.Clear();
            txtUlkeKodu.Clear();
            txtHavayoluAdi.Focus();
            txtKisaltmasi.Clear();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            Temizle();
            txtAciklama.ReadOnly = false;
            txtHavayoluAdi.ReadOnly = false;
            txtKisaltmasi.ReadOnly = false;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtHavayoluAdi.Text.Trim() != "" && txtUlkeAdi.Text.Trim() != "" && txtKisaltmasi.Text.Trim() != "")
            {
                Havayolu h = new Havayolu();
                if (h.HavayoluVarMi(txtHavayoluAdi.Text, txtKisaltmasi.Text))
                {
                    MessageBox.Show("Havayolu zaten kayıtlı!");
                }
                else
                {
                    h.Aciklama = txtAciklama.Text;
                    h.UlkeID = Convert.ToInt32(txtUlkeKodu.Text);
                    h.HavayoluAdi = txtHavayoluAdi.Text;
                    h.FotografID = 5;
                    h.Kisaltmasi = txtKisaltmasi.Text;
                    if (h.HavayoluEkle(h))
                    {
                        MessageBox.Show("Havayolu başarı ile eklendi.");
                        h.HavayollariniGetir(lvHavayolları);
                        Temizle();
                        btnKaydet.Enabled = false;
                        txtAciklama.ReadOnly = true;
                        txtHavayoluAdi.ReadOnly = true;

                    }
                    else
                    {
                        MessageBox.Show("Havayolu eklenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Havayolu adı, kısaltması ve ülke adı boş bırakılamaz.");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtHavayoluAdi.Text.Trim() != "" && txtUlkeAdi.Text.Trim() != "" && txtKisaltmasi.Text.Trim() != "")
            {
                Havayolu h = new Havayolu();
                if (h.HavayoluVarMi(txtHavayoluAdi.Text, Convert.ToInt32(txtHavayoluKodu.Text), txtKisaltmasi.Text))
                {
                    MessageBox.Show("Havayolu firması zaten kayıtlı!");
                    txtHavayoluAdi.Focus();
                }
                else
                {
                    h.UlkeID = Convert.ToInt32(txtUlkeKodu.Text);
                    h.HavayoluID = Convert.ToInt32(txtHavayoluKodu.Text);
                    h.HavayoluAdi = txtHavayoluAdi.Text;
                    h.Aciklama = txtAciklama.Text;
                    h.Kisaltmasi = txtKisaltmasi.Text;
                    if (h.HavayoluGuncelle(h))
                    {
                        MessageBox.Show("Havayolu bilgileri güncellendi.");
                        btnSil.Enabled = false;
                        btnDegistir.Enabled = false;
                        Temizle();
                        txtUlkeKodu.ReadOnly = true;
                        txtAciklama.ReadOnly = true;
                        txtUlkeAdi.ReadOnly = true;
                        txtHavayoluKodu.ReadOnly = true;
                        txtHavayoluAdi.ReadOnly = true;
                        txtKisaltmasi.ReadOnly = true;
                        h.HavayollariniGetir(lvHavayolları);
                    }
                    else
                    {
                        MessageBox.Show("Havayolu bilgileri güncellenemedi.");
                        txtHavayoluAdi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Havayolu adı, kısaltması ve ülke adı boş bırakılamaz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Havayolu h = new Havayolu();
                if (h.HavayoluSil(Convert.ToInt32(txtHavayoluKodu.Text)))
                {
                    MessageBox.Show("Havayolu Silindi.");
                    h.HavayollariniGetir(lvHavayolları);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;
                    txtUlkeKodu.ReadOnly = true;
                    txtAciklama.ReadOnly = true;
                    txtUlkeAdi.ReadOnly = true;
                    txtHavayoluKodu.ReadOnly = true;
                    txtHavayoluAdi.ReadOnly = true;
                    txtKisaltmasi.ReadOnly = true;
                }
            }
        }

        private void btnUlkeBul_Click(object sender, EventArgs e)
        {
            UlkeSorgulama frm = new UlkeSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtUlkeAdi.Text = Genel.UlkeAdi;
            txtUlkeKodu.Text = Genel.UlkeID.ToString();
            Genel.UlkeAdi = "";
            Genel.UlkeID = 0;
        }

        private void lvHavayolları_DoubleClick(object sender, EventArgs e)
        {
            txtHavayoluKodu.Text = lvHavayolları.SelectedItems[0].SubItems[0].Text;
            txtKisaltmasi.Text = lvHavayolları.SelectedItems[0].SubItems[1].Text;
            txtHavayoluAdi.Text = lvHavayolları.SelectedItems[0].SubItems[2].Text;
            txtUlkeAdi.Text = lvHavayolları.SelectedItems[0].SubItems[3].Text;
            txtAciklama.Text = lvHavayolları.SelectedItems[0].SubItems[4].Text;
            txtUlkeKodu.Text = lvHavayolları.SelectedItems[0].SubItems[5].Text;
            txtKisaltmasi.ReadOnly = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            txtAciklama.ReadOnly = false;
            txtHavayoluAdi.ReadOnly = false;
            btnKaydet.Enabled = false;
        }



    }
}
