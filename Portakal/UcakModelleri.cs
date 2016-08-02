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
    public partial class UcakModelleri : Form
    {
        public UcakModelleri()
        {
            InitializeComponent();
        }

        private void UcakModelleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            UcakModel u = new UcakModel();
            u.ModelleriGetir(lvModeller);
            txtGenelAd.Text = "Airbus ";
        }
        private void Temizle()
        {
            txtAciklama.Clear();
            txtBusiness.Text = "0";
            txtEkonomi.Text = "0";
            txtFirstClass.Text = "0";
            txtGenelAd.Clear();
            txtModel.Clear();
            txtModelKodu.Clear();


        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            Temizle();
            txtAciklama.ReadOnly = false;
            txtModel.ReadOnly = false;
            btnSil.Enabled = false;
            txtBusiness.ReadOnly = false;
            txtEkonomi.ReadOnly = false;
            txtFirstClass.ReadOnly = false;
            if (rbAirbus.Checked)
            {
                txtGenelAd.Text += "Airbus ";
                txtModel.Clear();
            }
            else
            {
                txtGenelAd.Text = "Boeing ";
                txtModel.Clear();
            }
        }

        private void rbAirbus_CheckedChanged(object sender, EventArgs e)
        {
            txtGenelAd.Clear();
            txtGenelAd.Text += "Airbus ";
            txtModel.Clear();
        }

        private void rbBoeing_CheckedChanged(object sender, EventArgs e)
        {
            txtGenelAd.Clear();
            txtGenelAd.Text = "Boeing ";
            txtModel.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtGenelAd.Text.Trim() != "" && txtModel.Text.Trim() != "")
            {
                UcakModel u = new UcakModel();
                if (u.UcakModelVarMi(txtGenelAd.Text))
                {
                    MessageBox.Show("Model zaten kayıtlı!");
                }
                else
                {

                    u.Aciklama = txtAciklama.Text;
                    u.BusinessKoltukAdeti = Convert.ToInt32(txtBusiness.Text);
                    u.EkoKoltukAdeti = Convert.ToInt32(txtEkonomi.Text);
                    u.FirstKoltukAdeti = Convert.ToInt32(txtFirstClass.Text);
                    txtGenelAd.Text += txtModel.Text;
                    u.ModelAdi = txtGenelAd.Text;
                    if (u.UcakModelEkle(u))
                    {
                        MessageBox.Show("Uçak modeli başarı ile eklendi.");
                        u.ModelleriGetir(lvModeller);
                        Temizle();
                        btnKaydet.Enabled = false;
                        txtAciklama.ReadOnly = true;
                        txtModel.ReadOnly = true;
                        txtFirstClass.ReadOnly = true;
                        txtEkonomi.ReadOnly = true;
                        txtBusiness.ReadOnly = true;

                    }
                    else
                    {
                        MessageBox.Show("Uçak modeli eklenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Model boş bırakılamaz.");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtGenelAd.Text.Trim() != "" && txtModel.Text.Trim() != "")
            {
                UcakModel u = new UcakModel();
                if (u.UcakModelVarMi(txtGenelAd.Text, Convert.ToInt32(txtModelKodu.Text)))
                {
                    MessageBox.Show("Uçak zaten kayıtlı!");
                    txtModel.Focus();
                }
                else
                {

                    txtGenelAd.Text += txtModel.Text;
                    u.Aciklama = txtAciklama.Text;
                    u.BusinessKoltukAdeti = Convert.ToInt32(txtBusiness.Text);
                    u.EkoKoltukAdeti = Convert.ToInt32(txtEkonomi.Text);
                    u.FirstKoltukAdeti = Convert.ToInt32(txtFirstClass.Text);
                    u.ModelAdi = txtGenelAd.Text;
                    u.ModelID = Convert.ToInt32(txtModelKodu.Text);
                    if (u.UcakModelGuncelle(u))
                    {
                        MessageBox.Show("Model bilgileri güncellendi.");
                        btnSil.Enabled = false;
                        btnDegistir.Enabled = false;
                        Temizle();
                        txtModel.ReadOnly = true;
                        txtAciklama.ReadOnly = true;
                        txtFirstClass.ReadOnly = true;
                        txtEkonomi.ReadOnly = true;
                        txtBusiness.ReadOnly = true;
                        u.ModelleriGetir(lvModeller);
                    }
                    else
                    {
                        MessageBox.Show("Model bilgileri güncellenemedi.");
                        txtModel.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Model boş bırakılamaz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                UcakModel u = new UcakModel();
                if (u.UcakModelSil(Convert.ToInt32(txtModelKodu.Text)))
                {
                    MessageBox.Show("Model Silindi.");
                    u.ModelleriGetir(lvModeller);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;

                }
            }
        }

        private void lvModeller_DoubleClick(object sender, EventArgs e)
        {
            txtModelKodu.Text = lvModeller.SelectedItems[0].SubItems[0].Text;
            txtEkonomi.Text = lvModeller.SelectedItems[0].SubItems[2].Text;
            txtBusiness.Text = lvModeller.SelectedItems[0].SubItems[3].Text;
            txtAciklama.Text = lvModeller.SelectedItems[0].SubItems[5].Text;
            txtFirstClass.Text = lvModeller.SelectedItems[0].SubItems[4].Text;
            string[] iki = lvModeller.SelectedItems[0].SubItems[1].Text.Split(' ');
            txtModel.Text = iki[1];
            if (lvModeller.SelectedItems[0].SubItems[1].Text.StartsWith("A"))
            {
                txtGenelAd.Text = "Airbus ";
                rbAirbus.Checked = true;

            }
            else
            {
                txtGenelAd.Text = "Boeing ";
                rbBoeing.Checked = true;

            }
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            txtAciklama.ReadOnly = false;
            btnKaydet.Enabled = false;
            txtModel.ReadOnly = false;
            txtAciklama.ReadOnly = false;
            txtBusiness.ReadOnly = false;
            txtEkonomi.ReadOnly = false;
            txtFirstClass.ReadOnly = false;

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            //string a = txtModel.Text;
            //txtGenelAd.Text += a; 
        }


    }
}
