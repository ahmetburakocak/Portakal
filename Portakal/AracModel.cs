using Portakal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portakal
{
    public partial class AracModel : Form
    {
        public AracModel()
        {
            InitializeComponent();
        }

        private void AracModel_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Sinif s = new Sinif();
            s.SiniflariGetir(cbSiniflar);

            Modeller md = new Modeller();
            md.ModelleriGetir(lvModeller);
            txtModel.Focus();
        }
        private void Temizle()
        {
            txtSinifID.Clear();
            txtSinifAdi.Clear();
            txtModelID.Clear();
            txtMarkaID.Clear();
            txtMarkaAd.Clear();
            txtModel.Clear();
            txtAciklama.Clear();
        }
        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marka m = new Marka();
            txtMarkaAd.Text = cbMarkalar.SelectedItem.ToString();
            txtMarkaID.Text = m.MarkaIDGetir(txtMarkaAd.Text).ToString();
        }
        private void cbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sinif s = new Sinif();
            txtSinifAdi.Text = cbSiniflar.SelectedItem.ToString();
            txtSinifID.Text = s.SinifIDGetir(txtSinifAdi.Text).ToString();
            txtMarkaID.Clear();
            txtMarkaAd.Clear();
            cbMarkalar.Items.Clear();
            Marka m = new Marka();
            m.MarkalariGetir(cbMarkalar, Convert.ToInt32(txtSinifID.Text));
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            cbSiniflar.Enabled = true;
            cbMarkalar.Enabled = true;
            cbKlima.Enabled = true;
            cbVites.Enabled = true;
            cbYakitTipi.Enabled = true;
            txtModel.ReadOnly = false;
            txtAciklama.ReadOnly = false;
            btnKaydet.Enabled = true;
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (txtSinifAdi.Text.Trim() != "" && txtMarkaAd.Text.Trim() != "" && txtModel.Text.Trim() != "")
            {
                Modeller m = new Modeller();
                txtResimID.Text = m.ResimIDGetir(txtModel.Text).ToString();
                if (m.ModelVarmi(Convert.ToInt32(txtMarkaID.Text), txtModel.Text))
                {
                    MessageBox.Show("Model zaten kayıtlı!");
                }
                else
                {
                    m.SinifID = Convert.ToInt32(txtSinifID.Text);
                    m.MarkaID = Convert.ToInt32(txtMarkaID.Text);
                    m.ModelAd = txtModel.Text.ToUpper();
                    m.Klima = cbKlima.SelectedItem.ToString();
                    m.YakitTipi = cbYakitTipi.SelectedItem.ToString();
                    m.VitesTipi = cbVites.SelectedItem.ToString();
                    m.Aciklama = txtAciklama.Text.ToUpper();
                    m.ModelResmi = Convert.ToInt32(txtResimID.Text);

                    if (m.ModelEkle(m))
                    {
                        MessageBox.Show("Model başarı ile eklendi.");
                        m.ModelleriGetir(lvModeller);
                        Temizle();
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = true;
                        btnSil.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Model eklenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sınıf Adı,Model ve Marka Adı boş bırakılamaz.");
            }
        }

        private void lvModeller_DoubleClick(object sender, EventArgs e)
        {
            txtSinifAdi.Text = lvModeller.SelectedItems[0].SubItems[0].Text;
            txtMarkaAd.Text = lvModeller.SelectedItems[0].SubItems[1].Text;
            txtModel.Text = lvModeller.SelectedItems[0].SubItems[2].Text;
            cbKlima.Text = lvModeller.SelectedItems[0].SubItems[3].Text;
            cbVites.Text = lvModeller.SelectedItems[0].SubItems[4].Text;
            cbYakitTipi.Text = lvModeller.SelectedItems[0].SubItems[5].Text;
            txtAciklama.Text = lvModeller.SelectedItems[0].SubItems[6].Text;
            txtSinifID.Text = lvModeller.SelectedItems[0].SubItems[7].Text;
            txtMarkaID.Text = lvModeller.SelectedItems[0].SubItems[8].Text;
            txtModelID.Text = lvModeller.SelectedItems[0].SubItems[9].Text;
            txtModel.ReadOnly = false;
            txtAciklama.ReadOnly = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            txtModel.Focus();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtSinifAdi.Text.Trim() != "" && txtMarkaAd.Text.Trim() != "" && txtModel.Text.Trim() != "")
            {
                Modeller m = new Modeller();
                if (m.ModelGuncelleVarmi(txtModel.Text, Convert.ToInt32(txtModelID.Text)))
                {
                    MessageBox.Show("Model zaten kayıtlı!");
                }
                else
                {
                    m.ModelID = Convert.ToInt32(txtModelID.Text);
                    m.SinifID = Convert.ToInt32(txtSinifID.Text);
                    m.MarkaID = Convert.ToInt32(txtMarkaID.Text);
                    m.ModelAd = txtModel.Text.ToUpper();
                    m.Klima = cbKlima.SelectedItem.ToString();
                    m.YakitTipi = cbYakitTipi.SelectedItem.ToString();
                    m.VitesTipi = cbVites.SelectedItem.ToString();
                    m.Aciklama = txtAciklama.Text.ToUpper();

                    if (m.ModelGuncelle(m))
                    {
                        MessageBox.Show("Model başarı ile güncellendi.");
                        m.ModelleriGetir(lvModeller);
                        Temizle();
                        btnKaydet.Enabled = false;
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Model güncellenemedi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sınıf Adı,Model ve Marka Adı boş bırakılamaz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Modeller m = new Modeller();
                if (m.ModelSil(Convert.ToInt32(txtModelID.Text)))
                {
                    MessageBox.Show("Model Silindi.");
                    m.ModelleriGetir(lvModeller);
                    Temizle();
                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;

                }
            }
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "AllFiles|*.*|Bitmap|*.bmp|GIF|*.gif|JPEG|*.jpg";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pbResim.Image = Image.FromFile(openFileDialog1.FileName);
                pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
                pbResim.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        SqlConnection conn = new SqlConnection(Genel.connStr);

        private void btnResimKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show("Lüften Model Giriniz!");
                txtModel.Focus();
            }
            else
            {
                SqlCommand comm = new SqlCommand("insert into AracResim (ModelAd,Resim) values(@ModelAd,@Resim)", conn);
                comm.Parameters.Add("@ModelAd", SqlDbType.VarChar).Value = txtModel.Text;
                MemoryStream ms = new MemoryStream();
                pbResim.Image.Save(ms, ImageFormat.Jpeg);
                byte[] byteData = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(byteData, 0, Convert.ToInt32(ms.Length));
                SqlParameter parametre = new SqlParameter("@Resim", SqlDbType.Image, byteData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, byteData);
                comm.Parameters.Add(parametre);
                conn.Open();
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    string hata = ex.Message;
                }

                conn.Close();
            }
            
            
        }

        private void txtModeleGoreArama_TextChanged(object sender, EventArgs e)
        {
            Modeller m = new Modeller();
            m.ModelleriGetirByAdaGore(txtModeleGoreArama.Text,lvModeller);
        }
    }
}
