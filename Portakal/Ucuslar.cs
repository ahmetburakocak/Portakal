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
    public partial class Ucuslar : Form
    {
        public Ucuslar()
        {
            InitializeComponent();
        }

        private void Ucuslar_Load(object sender, EventArgs e)
        {
            Ucus u = new Ucus();
            dgvUcuslar.DataSource = u.UcuslariGetir();
            dgvUcuslar.Columns[0].Visible = false;
            dgvUcuslar.Columns[4].Visible = false;
            dgvUcuslar.Columns[6].Visible = false;
            dgvUcuslar.Columns[2].Visible = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtBusinessFiyat.ReadOnly = false;
            txtEkonomiFiyat.ReadOnly = false;
            txtFirstFiyat.ReadOnly = false;
            txtEkstraBagaj.ReadOnly = false;

        }

        private void Temizle()
        {
            txtUcusAdi.Clear();
            txtUcusID.Clear();
            txtUcakID.Clear();
            txtUcakAdi.Clear();
            txtKalkisYeri.Clear();
            txtKalkisID.Clear();
            txtInisYeri.Clear();
            txtInisID.Clear();
            txtFirstFiyat.Text = "0";
            txtFirstClassKoltuk.Clear();
            txtEkstraBagaj.Text = "1";
            txtEkonomiKoltuk.Clear();
            txtEkonomiFiyat.Text = "0";
            txtBusinessKoltuk.Clear();
            txtBusinessFiyat.Text = "0";


        }

        private void btnUcakBul_Click(object sender, EventArgs e)
        {
            UcakSorgulama frm = new UcakSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
            txtBusinessKoltuk.Text = Genel.BusinessKoltuk.ToString();
            txtEkonomiKoltuk.Text = Genel.EkonomikKoltuk.ToString();
            txtFirstClassKoltuk.Text = Genel.FirstClassKoltuk.ToString();
            txtUcakAdi.Text = Genel.UcakAdi;
            txtUcakID.Text = Genel.UcakID.ToString();
        }

        private void btnKalkisBul_Click(object sender, EventArgs e)
        {
            KalkisYeriSorgulama frm = new KalkisYeriSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtKalkisID.Text = Convert.ToString(Genel.KalkisYeriID);
            txtKalkisYeri.Text = Genel.KalkisYeri;

        }

        private void btnInisBul_Click(object sender, EventArgs e)
        {
            InisYeriSorgulama frm = new InisYeriSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtInisYeri.Text = Genel.InisYeri;
            txtInisID.Text = Genel.InisYeriID.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ucus u = new Ucus();
            string isim = u.UcusAdiGetir(Genel.kisaltma);
            if ("" == isim)
            {
                MessageBox.Show("Hata var.");
            }
            else
            {
                txtUcusAdi.Text = isim;
            }

            if (txtUcusAdi.Text.Trim() != "" && txtUcakAdi.Text.Trim() != "" && txtInisYeri.Text.Trim() != "" && txtKalkisYeri.Text != "" && txtBusinessFiyat.Text != "" && txtEkonomiFiyat.Text != "" && txtFirstFiyat.Text != "" && txtInisID.Text != txtKalkisID.Text)
            {
                if (u.UcusVarMi(dtpYolculuk.Value, txtUcakID.Text))
                {
                    MessageBox.Show("Uçuş kayıtlı!");
                }
                else
                {
                    u.UcusTarihi = Convert.ToDateTime(dtpYolculuk.Value);
                    u.BusinessClassBosKoltuk = Convert.ToInt32(txtBusinessKoltuk.Text);
                    u.BusinessClassFiyat = Convert.ToDouble(txtBusinessFiyat.Text);
                    u.EkonomikBosKoltuk = Convert.ToInt32(txtEkonomiKoltuk.Text);
                    u.EkonomikFiyat = Convert.ToDouble(txtEkonomiFiyat.Text);
                    u.EkstraBagajFiyat = Convert.ToDouble(txtEkstraBagaj.Text);
                    u.FirstClassBosKoltuk = Convert.ToInt32(txtFirstClassKoltuk.Text);
                    u.FirstClassFiyat = Convert.ToDouble(txtFirstFiyat.Text);
                    u.InisYeriID = Convert.ToInt32(txtInisID.Text);
                    u.KalkisYeriID = Convert.ToInt32(txtKalkisID.Text);
                    u.UcakID = Convert.ToInt32(txtUcakID.Text);
                    u.UcusAdi = txtUcusAdi.Text;
                    if (u.UcusEkle(u))
                    {
                        MessageBox.Show("Uçuş başarı ile eklendi.");
                        dgvUcuslar.DataSource = u.UcuslariGetir();
                        Temizle();
                        btnKaydet.Enabled = false;
                        txtBusinessFiyat.ReadOnly = true;
                        txtEkonomiFiyat.ReadOnly = true;
                        txtFirstFiyat.ReadOnly = true;
                        txtEkstraBagaj.ReadOnly = true;

                    }
                    else
                    {
                        MessageBox.Show("Uçuş eklenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hiç bir alan boş bırakılamaz.");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            Ucus u = new Ucus();
            if (txtUcusAdi.Text.Trim() != "" && txtUcakAdi.Text.Trim() != "" && txtInisYeri.Text.Trim() != "" && txtKalkisYeri.Text != "" && txtBusinessFiyat.Text != "" && txtEkonomiFiyat.Text != "" && txtFirstFiyat.Text != "" && txtInisID.Text != txtKalkisID.Text)
            {

                    u.UcusID = Convert.ToInt32(txtUcusID.Text);
                    u.UcusTarihi = Convert.ToDateTime(dtpYolculuk.Value);
                    u.BusinessClassBosKoltuk = Convert.ToInt32(txtBusinessKoltuk.Text);
                    u.BusinessClassFiyat = Convert.ToDouble(txtBusinessFiyat.Text);
                    u.EkonomikBosKoltuk = Convert.ToInt32(txtEkonomiKoltuk.Text);
                    u.EkonomikFiyat = Convert.ToDouble(txtEkonomiFiyat.Text);
                    u.EkstraBagajFiyat = Convert.ToDouble(txtEkstraBagaj.Text);
                    u.FirstClassBosKoltuk = Convert.ToInt32(txtFirstClassKoltuk.Text);
                    u.FirstClassFiyat = Convert.ToDouble(txtFirstFiyat.Text);
                    u.InisYeriID = Convert.ToInt32(txtInisID.Text);
                    u.KalkisYeriID = Convert.ToInt32(txtKalkisID.Text);
                    u.UcakID = Convert.ToInt32(txtUcakID.Text);
                    u.UcusAdi = txtUcusAdi.Text;
                    if (u.UcusGuncelle(u))
                    {
                        MessageBox.Show("Uçuş bilgileri güncellendi.");
                        btnSil.Enabled = false;
                        btnDegistir.Enabled = false;
                        Temizle();
                        txtBusinessFiyat.ReadOnly = true;
                        txtEkonomiFiyat.ReadOnly = true;
                        txtFirstFiyat.ReadOnly = true;
                        txtEkstraBagaj.ReadOnly = true;
                        dgvUcuslar.DataSource = u.UcuslariGetir();
                    }
                    else
                    {
                        MessageBox.Show("Uçuş bilgileri güncellenemedi.");
                        txtEkonomiFiyat.Focus();
                    }
                
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int a = Convert.ToInt32(txtUcusID.Text);
                Ucus u = new Ucus();
                if (u.UcusSil(a))
                {
                    MessageBox.Show("Uçuş Silindi.");
                    dgvUcuslar.DataSource = u.UcuslariGetir();
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;

                }
            }
        }

        private void dgvUcuslar_DoubleClick(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
            txtUcusID.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[0].Value);
            txtUcusAdi.Text = dgvUcuslar.SelectedRows[0].Cells[1].Value.ToString();
            txtUcakID.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[2].Value);
            txtUcakAdi.Text = dgvUcuslar.SelectedRows[0].Cells[3].Value.ToString();
            txtKalkisID.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[4].Value);
            txtKalkisYeri.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[5].Value);
            txtInisID.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[6].Value);
            txtInisYeri.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[7].Value);
            txtEkonomiKoltuk.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[8].Value);
            txtBusinessKoltuk.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[9].Value);
            txtFirstClassKoltuk.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[10].Value);
            txtEkonomiFiyat.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[11].Value);
            txtBusinessFiyat.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[12].Value);
            txtFirstFiyat.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[13].Value);
            txtEkstraBagaj.Text = Convert.ToString(dgvUcuslar.SelectedRows[0].Cells[14].Value);
            dtpYolculuk.Value = Convert.ToDateTime(dgvUcuslar.SelectedRows[0].Cells[15].Value);
            Ucus u = new Ucus();
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            txtBusinessFiyat.ReadOnly = false;
            txtEkonomiFiyat.ReadOnly = false;
            txtFirstFiyat.ReadOnly = false;
            txtEkstraBagaj.ReadOnly = false;
            btnUcakBul.Enabled = false;
            dtpYolculuk.Enabled = false;

        }

        private void dtpYolculuk_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpYolculuk.Value.ToShortDateString();
        }


    }
}
