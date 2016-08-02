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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            AcilisEkrani frm = new AcilisEkrani();
            FormAcikMi(frm);
        }

        private void FormAcikMi(Form AcilacakForm)
        {
            bool sonuc = false;
            for (int i = 0; i < MdiChildren.Count(); i++)
            {
                if (AcilacakForm.Name == this.MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus();
                    sonuc = true;
                }

            }
            if (sonuc == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose();
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            AcilisEkrani frm = new AcilisEkrani();
            FormAcikMi(frm);
        }

        private void ülkeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ulkeler frm = new Ulkeler();
            FormAcikMi(frm);
        }

        private void şehirEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sehirler frm = new Sehirler();
            FormAcikMi(frm);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void markaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracMarka frm = new AracMarka();
            FormAcikMi(frm);

        }

        private void modelEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AracModel frm = new AracModel();
            FormAcikMi(frm);
        }

        private void havayollarıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Havayollari frm = new Havayollari();
            FormAcikMi(frm);
        }

        private void modelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcakModelleri frm = new UcakModelleri();
            FormAcikMi(frm);
        }

        private void havalimanıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Havalimanlari frm = new Havalimanlari();
            FormAcikMi(frm);
        }

        private void uçakEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ucaklar frm = new Ucaklar();
            FormAcikMi(frm);
        }

        private void uçuşEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ucuslar frm = new Ucuslar();
            FormAcikMi(frm);
        }

        private void aracEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracEkle frm = new AracEkle();
            FormAcikMi(frm);
        }

        private void firmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmaEkle frm = new FirmaEkle();
            FormAcikMi(frm);
        }

        private void uçakBiletiSatışRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisSorgulama frm = new SatisSorgulama();
            FormAcikMi(frm);
        }

        private void teslimAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sozlesme s = new Sozlesme();
            FormAcikMi(s);
            s.btnTeslimAl.Enabled = true;
        }

        private void kiralamaSatışSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralamaSatisSorgulama frm = new KiralamaSatisSorgulama();
            FormAcikMi(frm);
            

        }

        private void otelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtelEkle o = new OtelEkle();
            FormAcikMi(o);
        }

        private void odaTipiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaTipiEkle o = new OdaTipiEkle();
            FormAcikMi(o);
        }

        private void otelSatışRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otelSatisRaporlama frm = new otelSatisRaporlama();
            FormAcikMi(frm);
        }
    }
}
