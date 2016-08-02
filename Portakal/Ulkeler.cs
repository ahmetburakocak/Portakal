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
    public partial class Ulkeler : Form
    {
        public Ulkeler()
        {
            InitializeComponent();
        }

        private void Ulkeler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Ulke u = new Ulke();
            u.UlkeleriGetir(lvUlkeler);
            txtUlkeKodu.Focus();

        }
        private void Temizle()
        {
            txtAciklama.Clear();
            txtUlkeAdi.Clear();
            txtUlkeKodu.Clear();
            txtTelefonKodu.Clear();
            txtUlkeAdi.Focus();

        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            Temizle();
            txtTelefonKodu.ReadOnly = false;
            txtAciklama.ReadOnly = false;
            txtUlkeAdi.ReadOnly = false;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUlkeAdi.Text.Trim() != "" && txtTelefonKodu.Text.Trim() != "")
            {
                Ulke u = new Ulke();
                if (u.UlkeVarMi(txtTelefonKodu.Text, txtUlkeAdi.Text))
                {
                    MessageBox.Show("Ülke zaten kayıtlı!");
                }
                else
                {
                    u.Aciklama = txtAciklama.Text;
                    u.UlkeAdi = txtUlkeAdi.Text;
                    u.UlkeTelCode = txtTelefonKodu.Text;
                    if (u.UlkeEkle(u))
                    {
                        MessageBox.Show("Ülke başarı ile eklendi.");
                        u.UlkeleriGetir(lvUlkeler);
                        Temizle();
                        btnKaydet.Enabled = false;
                        txtTelefonKodu.ReadOnly = true;
                        txtAciklama.ReadOnly = true;
                        txtUlkeAdi.ReadOnly = true;
                        txtUlkeKodu.ReadOnly = true;

                    }
                    else
                    {
                        MessageBox.Show("Ülke eklenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ülke telefon kodu ve ülke adı boş bırakılamaz.");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtUlkeAdi.Text.Trim() != "" && txtTelefonKodu.Text.Trim() != "")
            {
                Ulke u = new Ulke();
                if (u.UlkeVarMiForGuncelle(txtUlkeAdi.Text, Convert.ToInt32(txtUlkeKodu.Text)))
                {
                    MessageBox.Show("Ülke zaten kayıtlı!");
                    txtUlkeAdi.Focus();
                }
                else
                {
                    u.Aciklama = txtAciklama.Text;
                    u.UlkeAdi = txtUlkeAdi.Text;
                    u.UlkeID = Convert.ToInt32(txtUlkeKodu.Text);
                    u.UlkeTelCode = txtTelefonKodu.Text;
                    if (u.UlkeGuncelle(u))
                    {
                        MessageBox.Show("Ülke bilgileri güncellendi.");
                        btnSil.Enabled = false;
                        btnDegistir.Enabled = false;
                        Temizle();
                        txtTelefonKodu.ReadOnly = true;
                        txtAciklama.ReadOnly = true;
                        txtUlkeAdi.ReadOnly = true;
                        txtUlkeKodu.ReadOnly = true;
                        u.UlkeleriGetir(lvUlkeler);
                    }
                    else
                    {
                        MessageBox.Show("Ülke bilgileri güncellenemedi.");
                        txtUlkeAdi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Ülke telefon kodu ve ülke adı boş bırakılamaz.");
            }
        }

        private void lvUlkeler_DoubleClick(object sender, EventArgs e)
        {
            txtUlkeKodu.Text = lvUlkeler.SelectedItems[0].SubItems[0].Text;
            txtUlkeAdi.Text = lvUlkeler.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = lvUlkeler.SelectedItems[0].SubItems[3].Text;
            txtTelefonKodu.Text = lvUlkeler.SelectedItems[0].SubItems[2].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtTelefonKodu.ReadOnly = false;
            txtAciklama.ReadOnly = false;
            txtUlkeAdi.ReadOnly = false;
            txtUlkeAdi.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Ulke u = new Ulke();
                if (u.UlkeSil(Convert.ToInt32(txtUlkeKodu.Text)))
                {
                    MessageBox.Show("Ülke Silindi.");
                    u.UlkeleriGetir(lvUlkeler);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;

                }
            }
        }
    }
}
