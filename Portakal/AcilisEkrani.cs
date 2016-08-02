using Portakal.Model;
using System;
using System.Collections;
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
    public partial class AcilisEkrani : Form
    {
        public AcilisEkrani()
        {
            InitializeComponent();
        }
        
        private void AcilisEkrani_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Havalimani h = new Havalimani();
            h.HavaalanlariGetir(cbTeslimAlmaNoktasi);
            nudDonus.Visible = false;
            cbBiletTipi.SelectedItem = cbBiletTipi.Items[0];
            txtKalkisTarihi.Text = dtpKalkisTarihi.Value.ToShortDateString();
            Oda o = new Oda();
            //o.OdaTipleriniGetir(cbOdaTipi);
            Sehir sh = new Sehir();
            sh.SehirleriGetir(cbSehirler);

        }

        private void cbTeslimAlmaNoktasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTeslimAlma.Text = cbTeslimAlmaNoktasi.SelectedItem.ToString();
            Genel.HavalimaniAdi = txtTeslimAlma.Text;
        }
        private void dtpTeslimAlma_ValueChanged(object sender, EventArgs e)
        {
            Genel.TeslimAlmaTarihi = dtpTeslimAlma.Value;
            textBox1.Text = dtpTeslimAlma.Value.ToShortDateString();
        }

        private void dtpAraciBirakma_ValueChanged(object sender, EventArgs e)
        {
            Genel.BirakmaTarihi = dtpAraciBirakma.Value;
            textBox2.Text = dtpAraciBirakma.Value.ToShortDateString();
        }
        private void btnAracAra_Click(object sender, EventArgs e)
        {
            if (txtTeslimAlma.Text.Trim() != "")
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
                {
                    TimeSpan fark = dtpAraciBirakma.Value - dtpTeslimAlma.Value;
                    int sonuc = fark.Days;
                    if (sonuc <= 0)
                    {
                        MessageBox.Show("En az 1 günlük kiralama yapılabilir!");
                    }
                    else
                    {
                        AraclariGoster ag = new AraclariGoster();
                        ag.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Alış ve Bırakış Tarihi Belirleyiniz");
                }
            }

            else
            {
                MessageBox.Show("Havalimanı Seçiniz");
            }
        }


        private void btnKalkisBul_Click(object sender, EventArgs e)
        {
            KalkisYeriSorgulama frm = new KalkisYeriSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtKalkis.Text = Genel.KalkisYeri;
            txtKalkisID.Text = Convert.ToString(Genel.KalkisYeriID);
        }

        private void btnVarisBul_Click(object sender, EventArgs e)
        {
            InisYeriSorgulama frm = new InisYeriSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtVaris.Text = Genel.InisYeri;
            txtVarisID.Text = Genel.InisYeriID.ToString();
        }

        private void rbTekYon_CheckedChanged(object sender, EventArgs e)
        {
            dtpKalkisTarihi.Visible = true;
            nudDonus.Visible = false;
            dtpDonusTarihi.Visible = false;
            lblDonus.Visible = false;
        }

        private void rbGidisDonus_CheckedChanged(object sender, EventArgs e)
        {
            dtpKalkisTarihi.Visible = true;
            dtpDonusTarihi.Visible = true;
            nudDonus.Visible = true;
            lblDonus.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKalkisID.Text == txtVarisID.Text  || txtKalkis.Text =="" || txtVaris.Text =="")
            {
                MessageBox.Show("Bambaleyoooo bmbaleyeeee");
            }
            else
            {
                Genel.EkstraBagajKilosuDonus = Convert.ToInt32(nudDonus.Value);
                Genel.BiletBagajKilosu = Convert.ToInt32(nudEkstra.Value);
                Genel.BiletTipi = cbBiletTipi.SelectedItem.ToString();
                Genel.BiletGidisTarihi = Convert.ToDateTime(txtKalkisTarihi.Text);
                Genel.BiletInisYeri = txtVaris.Text;
                Genel.BiletKalkisID = Convert.ToInt32(txtKalkisID.Text);
                Genel.BiletKalkisYeri = txtKalkis.Text;
                Genel.BiletKisiSayisi = Convert.ToInt32(nudKisi.Value);
                Genel.BiletVarisID = Convert.ToInt32(txtVarisID.Text);
                if (rbGidisDonus.Checked == true)
                {

                    Genel.BiletTekYonMu = false;
                    UcusSorgulama frm = new UcusSorgulama();
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();
                    Genel.BiletDonusTarihi = Convert.ToDateTime(txtVarisTarihi.Text);
                    Genel.BiletVarisIDDonus = Convert.ToInt32(txtKalkisID.Text);
                    Genel.BiletKalkisIDDonus = Convert.ToInt32(txtVarisID.Text);
                    Genel.BiletKalkisYeriDonus = txtVaris.Text;
                    Genel.BiletInisYeriDonus = txtKalkis.Text;
                    UcusSorgulamaDonus frm1 = new UcusSorgulamaDonus();
                    frm1.StartPosition = FormStartPosition.CenterScreen;
                    frm1.WindowState = FormWindowState.Maximized;
                    frm1.ShowDialog();
                }
                else
                {
                    Genel.BiletTekYonMu = true;
                    UcusSorgulama frm = new UcusSorgulama();
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();

                }

            }
        }

        private void dtpKalkisTarihi_ValueChanged(object sender, EventArgs e)
        {
            txtKalkisTarihi.Text = dtpKalkisTarihi.Value.ToShortDateString();
            dtpDonusTarihi.Value = dtpKalkisTarihi.Value;

        }

        private void dtpDonusTarihi_ValueChanged(object sender, EventArgs e)
        {
            txtVarisTarihi.Text = dtpDonusTarihi.Value.ToShortDateString();
        }

        private void cbSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOtelSehirler.Text = cbSehirler.SelectedItem.ToString();
        }

        private void btnOtelAra_Click(object sender, EventArgs e)
        {
            Genel.UlkeAdiOtel = txtOtelSehirler.Text;
            Genel.GirisTarihi = dtpGiris.Value.ToString();
            Genel.CikisTarihi = dtpCikis.Value.ToString();
            Genel.OdaTipi = cbOdaTipi.SelectedItem.ToString();
            Oteller frm = new Oteller();
            frm.Show();

        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            RezervasyonSorgulama frm = new RezervasyonSorgulama();
            frm.Show();
        }
        private void cbOdaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Oda o = new Oda();
            //o.OdaTipleriniGetir(cbOdaTipi);
        }

        private void tpOtel_Click(object sender, EventArgs e)
        {

        }
    }
}
