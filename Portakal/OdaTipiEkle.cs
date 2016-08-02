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
    public partial class OdaTipiEkle : Form
    {
        public OdaTipiEkle()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        Oda o = new Oda();
        private void OdaTipiEkle_Load(object sender, EventArgs e)
        {
            o.SehirleriGetir(cbSehir);
        }
        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbOtel.Items.Clear();
            txtOtel.Clear();
            txtOtelID.Clear();
            txtSehir.Text = cbSehir.SelectedItem.ToString();
        }

        private void txtSehir_TextChanged(object sender, EventArgs e)
        {
            txtSehirID.Text = o.SehirIDGetir(txtSehir.Text);

        }

        private void txtSehirID_TextChanged(object sender, EventArgs e)
        {
            o.OtelGetir(cbOtel, Convert.ToInt32(txtSehirID.Text));
        }

        private void cbOtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOtel.Text = cbOtel.SelectedItem.ToString();
        }

        private void cbOtel_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSehirID.Text))
            {
                MessageBox.Show("Önce Şehir Seçimini Yapınız!!");
            }
        }

        private void txtOtel_TextChanged(object sender, EventArgs e)
        {
            txtOtelID.Text = o.OtelIDGetir(txtOtel.Text);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbOzellikler.Items.Add(txtOzellik.Text);
            txtOzellik.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool varmi = o.StatuKontrol(txtStatuAd.Text);
            if (varmi)
            {
                MessageBox.Show("Böyle bir statu zaten kayıtlı");
                txtStatuAd.Focus();
            }
            else
            {
                int statuId = o.OdaStatuEkle(txtStatuAd.Text);
                o.OzellikEkle(lbOzellikler, statuId);
                bool kontrol = o.OdaTipiKontrol(txtOtelID.Text, txtTipAd.Text);
                if (kontrol)
                {
                    MessageBox.Show("Böyle bir oda tipi zaten kayıtlı");
                    txtTipAd.Focus();
                }
                else
                {
                    o.OdaTipiEkle(txtTipAd.Text, txtOdaMiktari.Text, txtOtelID.Text, statuId, txtFiyat.Text, txtAciklama.Text);
                    MessageBox.Show("Kayıt eklendi");
                    Temizle();
                }
            }
        }

        private void Temizle()
        {
            //txtSehirID.Clear();
          //txtSehir.Clear();
            txtOtelID.Clear();
            txtOtel.Clear();
            txtTipAd.Clear();
            txtStatuAd.Clear();
            txtOdaMiktari.Clear();
            txtAciklama.Clear();
            txtFiyat.Clear();
            txtOzellik.Clear();
        }
    }
}
