using Portakal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portakal
{
    public partial class OtelEkle : Form
    {
        public OtelEkle()
        {
            InitializeComponent();
        }
        Otel o = new Otel();
        Sehir s = new Sehir();
        DataSet ds = new DataSet();
        ImageList documents = new ImageList();
        private void OtelEkle_Load(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
            ds = o.OtelleriListeleByOtelEkle();
            dgvOteller.DataSource = ds.Tables["Oteller"];
            ((DataGridViewImageColumn)dgvOteller.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            s.SehirleriGetirFromOtel(cbSehir);
            o.StatuGetir(cbStatu);
            dgvOteller.Columns[2].Width = 150;
            dgvOteller.Columns[1].Visible = false;
            dgvOteller.Columns[4].Visible = false;
            dgvOteller.Columns[8].Visible = false;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            Temizle();
        }

        public void Temizle()
        {
            txtOtelID.Clear();
            txtSehirID.Clear();
            txtSehir.Clear();
            txtOtel.Clear();
            txtStatuID.Clear();
            txtStatu.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOtel.Text) || string.IsNullOrEmpty(txtSehir.Text) || string.IsNullOrEmpty(txtStatu.Text))
            {
                MessageBox.Show("Sehir, Otel ve Statu boş bırakılamaz.");
                txtOtel.Focus();
            }
            else
            {
                if (txtSehirID.Text.Trim() != "" || txtStatuID.Text.Trim() != "")
                {
                    bool sonuc = false;
                    sonuc = o.OtelKontrol(txtSehirID.Text, txtOtel.Text);
                    if (sonuc)
                    {
                        MessageBox.Show("Böyle Bir Otel Zaten Kayıtlı!!");
                    }
                    else
                    {
                        o.SehirID = Convert.ToInt32(txtSehirID.Text);
                        o.OtelAd = txtOtel.Text;
                        o.StatuID = Convert.ToInt32(txtStatuID.Text);
                        o.Telefon = txtTelefon.Text;
                        o.Adres = txtAdres.Text;
                        sonuc = o.OtelEkle(o, pbFoto);
                        if (sonuc)
                        {
                            MessageBox.Show("Kayıt Başarıyla Eklendi");
                            ds = o.OtelleriListeleByOtelEkle();
                            dgvOteller.DataSource = ds.Tables["Oteller"];
                        }
                        else
                        {
                            MessageBox.Show("Kayıtta Bir Hata Oluştu");
                            txtOtel.Focus();
                        }
                    }
                }
            }
        }

        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sehir s = (Sehir)cbSehir.SelectedItem;
            txtSehir.Text = s.SehirAdi.ToString();
            txtSehirID.Text = s.SehirID.ToString();
        }

        private void cbStatu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Otel o = (Otel)cbStatu.SelectedItem;
            txtStatu.Text = o.StatuAd.ToString();
            txtStatuID.Text = o.StatuID.ToString();
        }


        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtSehir.Text.Trim() != "" || txtOtel.Text.Trim() != "")
            {
                bool sonuc;
                sonuc = o.OtelKontrolFromDegistir(txtSehirID.Text, txtOtel.Text);
                if (sonuc)
                {
                    MessageBox.Show("Böyle Bir Otel Zaten Kayıtlı");
                }
                else
                {
                    o.SehirID = Convert.ToInt32(txtSehirID.Text);
                    o.OtelID = Convert.ToInt32(txtOtelID.Text);
                    o.OtelAd = txtOtel.Text;
                    o.StatuID = Convert.ToInt32(txtStatuID.Text);
                    o.Telefon = txtTelefon.Text;
                    o.Adres = txtAdres.Text;
                    o.SehirID = Convert.ToInt32(txtSehirID.Text);
                    sonuc = o.OtelDegistir(o, pbFoto);
                    if (sonuc)
                    {
                        MessageBox.Show("Otel Bilgileri Güncellendi");
                        ds = o.OtelleriListeleByOtelEkle();
                        dgvOteller.DataSource = ds.Tables["Oteller"];
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme sırasında bir sorun oluştu");
                        txtOtel.Focus();
                    }
                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Otel Silinsin mi?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool sonuc = o.OtelSil(txtOtelID.Text, txtSehirID.Text);
                if (sonuc)
                {
                    MessageBox.Show("Kayıt Silindi");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Sırasında Bir Hata Oluştu!!");
                }
            }
        }

        private void txtSorguOtel_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            ds = o.OtelleriFiltreleByOtelEkle(txtSorguOtel.Text, txtSorguStatu.Text, txtSehir.Text);
            dgvOteller.DataSource = ds.Tables["Filtre"];
        }

        private void txtSorguStatu_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            ds = o.OtelleriFiltreleByOtelEkle(txtSorguOtel.Text, txtSorguStatu.Text, txtSehir.Text);
            dgvOteller.DataSource = ds.Tables["Filtre"];
        }

        private void txtSorguSehir_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            ds = o.OtelleriFiltreleByOtelEkle(txtSorguOtel.Text, txtSorguStatu.Text, txtSehir.Text);
            dgvOteller.DataSource = ds.Tables["Filtre"];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ofdFoto.InitialDirectory = "C:\\";
            ofdFoto.Filter = "AllFiles|*.*|Bitmap|*.bmp|GIF|*.gif|JPEG|*.jpg";
            ofdFoto.FilterIndex = 1;
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {

                pbFoto.Image = Image.FromFile(ofdFoto.FileName);
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFoto.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        private void dgvOteller_DoubleClick_1(object sender, EventArgs e)
        {
            txtOtelID.Text = dgvOteller.SelectedRows[0].Cells[1].Value.ToString();
            txtOtel.Text = dgvOteller.SelectedRows[0].Cells[2].Value.ToString();
            txtStatuID.Text = dgvOteller.SelectedRows[0].Cells[4].Value.ToString();
            txtStatu.Text = dgvOteller.SelectedRows[0].Cells[3].Value.ToString();
            txtTelefon.Text = dgvOteller.SelectedRows[0].Cells[5].Value.ToString();
            txtAdres.Text = dgvOteller.SelectedRows[0].Cells[6].Value.ToString();
            txtSehir.Text = dgvOteller.SelectedRows[0].Cells[7].Value.ToString();
            txtSehirID.Text = dgvOteller.SelectedRows[0].Cells[8].Value.ToString();
            if (dgvOteller.SelectedRows[0].Cells[0].Value.ToString()!= "")
            {
                var data = (Byte[])(dgvOteller.SelectedRows[0].Cells[0].Value);
                var stream = new MemoryStream(data);
                pbFoto.Image = Image.FromStream(stream);
            }
        }

        private void ofdFoto_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
