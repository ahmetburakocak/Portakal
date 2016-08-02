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
    public partial class Ucaklar : Form
    {
        public Ucaklar()
        {
            InitializeComponent();
        }

        private void Ucaklar_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Ucak u = new Ucak();
            u.UcaklariGetir(lvUcaklar);


        }
        private void Temizle()
        {
            txtAciklama.Clear();
            txtHavayollariAdi.Clear();
            txtHavayolllariID.Clear();
            txtModelAdi.Clear();
            txtModelID.Clear();
            txtUcakAdi.Clear();
            txtUcakID.Clear();
            txtAciklama.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUcakAdi.Text.Trim() != "" && txtModelAdi.Text.Trim() != "" && txtHavayollariAdi.Text.Trim() != "")
            {
                Ucak u = new Ucak();
                if (u.UcakVarMi(txtModelAdi.Text))
                {
                    MessageBox.Show("Uçak zaten kayıtlı!");
                }
                else
                {
                    u.Aciklama = txtAciklama.Text;
                    u.ModelID = Convert.ToInt32(txtModelID.Text);
                    u.UcakAdi = txtUcakAdi.Text;
                    u.HavayollariID = Convert.ToInt32(txtHavayolllariID.Text);
                    if (u.UcakEkle(u))
                    {
                        MessageBox.Show("Uçak başarı ile eklendi.");
                        u.UcaklariGetir(lvUcaklar);
                        Temizle();
                        btnKaydet.Enabled = false;
                        txtAciklama.ReadOnly = true;
                        txtAciklama.ReadOnly = true;

                    }
                    else
                    {
                        MessageBox.Show("Uçak eklenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Uçak adı, havayolları adı ve model adı adı boş bırakılamaz.");
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnDegistir.Enabled = false;
            Temizle();
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            txtAciklama.ReadOnly = false;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtUcakAdi.Text.Trim() != "" && txtModelAdi.Text.Trim() != "" && txtHavayollariAdi.Text.Trim() != "")
            {
                Ucak u = new Ucak();
                if (u.UcakVarMi(Convert.ToInt32(txtUcakID.Text), txtUcakAdi.Text))
                {
                    MessageBox.Show("Uçak zaten kayıtlı!");
                    txtAciklama.Focus();
                }
                else
                {
                    u.Aciklama = txtAciklama.Text;
                    u.ModelID = Convert.ToInt32(txtModelID.Text);
                    u.UcakAdi = txtUcakAdi.Text;
                    u.HavayollariID = Convert.ToInt32(txtHavayolllariID.Text);
                    u.UcakID = Convert.ToInt32(txtUcakID.Text);
                    if (u.UcakGuncelle(u))
                    {
                        MessageBox.Show("Uçak bilgileri güncellendi.");
                        btnSil.Enabled = false;
                        btnDegistir.Enabled = false;
                        Temizle();
                        txtAciklama.ReadOnly = true;
                        u.UcaklariGetir(lvUcaklar);
                    }
                    else
                    {
                        MessageBox.Show("Uçak bilgileri güncellenemedi.");
                        txtAciklama.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Uçak adı, havayolları adı ve model adı adı boş bırakılamaz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Ucak u = new Ucak();
                if (u.UcakSil(Convert.ToInt32(txtUcakID.Text)))
                {
                    MessageBox.Show("Uçak Silindi.");
                    u.UcaklariGetir(lvUcaklar);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;

                }
            }
        }

        private void lvUcaklar_DoubleClick(object sender, EventArgs e)
        {
            txtUcakID.Text = lvUcaklar.SelectedItems[0].SubItems[0].Text;
            txtUcakAdi.Text = lvUcaklar.SelectedItems[0].SubItems[1].Text;
            txtHavayollariAdi.Text = lvUcaklar.SelectedItems[0].SubItems[2].Text;
            txtHavayolllariID.Text = lvUcaklar.SelectedItems[0].SubItems[3].Text;
            txtModelAdi.Text = lvUcaklar.SelectedItems[0].SubItems[4].Text;
            txtModelID.Text = lvUcaklar.SelectedItems[0].SubItems[5].Text;
            txtAciklama.Text = lvUcaklar.SelectedItems[0].SubItems[6].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtAciklama.ReadOnly = false;
        }

        private void btnHavayoluBul_Click(object sender, EventArgs e)
        {
            HavayoluSorgulama frm = new HavayoluSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtHavayolllariID.Text = Genel.HavayoluID.ToString();
            txtHavayollariAdi.Text = Genel.HavayoluAdi;
            Ucak u = new Ucak();
            string isim = u.IsimBul(Genel.kisaltma);
            if ("" == isim)
            {
                MessageBox.Show("");
            }
            else
            {
                txtUcakAdi.Text = isim;
                Genel.kisaltma = "";
            }
        }

        private void btnModelBul_Click(object sender, EventArgs e)
        {
            ModelSorgulama frm = new ModelSorgulama();
            frm.ShowDialog();
            txtModelAdi.Text = Genel.ModelAdi;
            txtModelID.Text = Genel.ModelID.ToString();
        }

    }
}
