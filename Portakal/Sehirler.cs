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
    public partial class Sehirler : Form
    {
        public Sehirler()
        {
            InitializeComponent();
        }

        private void Sehirler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Sehir s = new Sehir();
            s.SehirleriGetir(lvSehirler);
            txtSehirAdi.Focus();
        }
        private void Temizle()
        {
            txtAciklama.Clear();
            txtSehirKodu.Clear();
            txtUlkeAdi.Clear();
            txtUlkeKodu.Clear();
            txtSehirAdi.Clear();
            txtSehirAdi.Focus();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            Temizle();
            txtAciklama.ReadOnly = false;
            txtSehirAdi.ReadOnly = false;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSehirAdi.Text.Trim() != "" && txtUlkeAdi.Text.Trim() != "")
            {
                Sehir s = new Sehir();
                if (s.SehirVarMi(txtSehirAdi.Text, txtUlkeAdi.Text))
                {
                    MessageBox.Show("Şehir zaten kayıtlı!");
                }
                else
                {
                    s.Aciklama = txtAciklama.Text;
                    s.UlkeID = Convert.ToInt32(txtUlkeKodu.Text);
                    s.SehirAdi = txtSehirAdi.Text;
                    if (s.SehirEkle(s))
                    {
                        MessageBox.Show("Şehir başarı ile eklendi.");
                        s.SehirleriGetir(lvSehirler);
                        Temizle();
                        btnKaydet.Enabled = false;
                        txtAciklama.ReadOnly = true;
                        txtSehirAdi.ReadOnly = true;

                    }
                    else
                    {
                        MessageBox.Show("Şehir eklenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Şehir adı ve ülke adı boş bırakılamaz.");
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

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtSehirAdi.Text.Trim() != "" && txtUlkeAdi.Text.Trim() != "")
            {
                Sehir s = new Sehir();
                if (s.SehirVarMiForGuncelle(txtSehirAdi.Text, Convert.ToInt32(txtSehirKodu.Text)))
                {
                    MessageBox.Show("Sehir zaten kayıtlı!");
                    txtSehirAdi.Focus();
                }
                else
                {
                    s.SehirID = Convert.ToInt32(txtSehirKodu.Text);
                    s.Aciklama = txtAciklama.Text;
                    s.UlkeID = Convert.ToInt32(txtUlkeKodu.Text);
                    s.SehirAdi = txtSehirAdi.Text;
                    if (s.SehirGuncelle(s))
                    {
                        MessageBox.Show("Şehir bilgileri güncellendi.");
                        btnSil.Enabled = false;
                        btnDegistir.Enabled = false;
                        Temizle();
                        txtUlkeKodu.ReadOnly = true;
                        txtAciklama.ReadOnly = true;
                        txtUlkeAdi.ReadOnly = true;
                        txtSehirKodu.ReadOnly = true;
                        txtSehirAdi.ReadOnly = true;
                        s.SehirleriGetir(lvSehirler);
                    }
                    else
                    {
                        MessageBox.Show("Şehir bilgileri güncellenemedi.");
                        txtSehirAdi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Şehir adı ve ülke adı boş bırakılamaz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Sehir s = new Sehir();
                if (s.SehirSil(Convert.ToInt32(txtSehirKodu.Text)))
                {
                    MessageBox.Show("Şehir Silindi.");
                    s.SehirleriGetir(lvSehirler);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;
                    txtUlkeKodu.ReadOnly = true;
                    txtAciklama.ReadOnly = true;
                    txtUlkeAdi.ReadOnly = true;
                    txtSehirKodu.ReadOnly = true;
                    txtSehirAdi.ReadOnly = true;
                }
            }
        }

        private void lvSehirler_DoubleClick(object sender, EventArgs e)
        {
            txtSehirKodu.Text = lvSehirler.SelectedItems[0].SubItems[0].Text;
            txtUlkeKodu.Text = lvSehirler.SelectedItems[0].SubItems[4].Text;
            txtUlkeAdi.Text = lvSehirler.SelectedItems[0].SubItems[2].Text;
            txtAciklama.Text = lvSehirler.SelectedItems[0].SubItems[3].Text;
            txtSehirAdi.Text = lvSehirler.SelectedItems[0].SubItems[1].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtAciklama.ReadOnly = false;
            txtSehirAdi.ReadOnly = false;
            txtSehirAdi.Focus();
        }




    }
}
