using Portakal.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portakal
{
    public partial class Oteller : Form
    {
        public Oteller()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();
        ArrayList Gunler = new ArrayList();
        private void Oteller_Load(object sender, EventArgs e)
        {
            int id = 0;
            Rezerv r = new Rezerv();
            int kontrol = r.RezervleriKontrolEt();
            if (kontrol > 0)
            {
                id = r.RezDurumuGuncelle();
                r.idBul(id, txtoid.Text, txttid.Text);
                r.odasayisiniguncelle(txtoid, txttid);
            }



            Otel o = new Otel();
            o.SehirAd = Genel.UlkeAdiOtel;
            o.GirisTarihi = Genel.GirisTarihi;
            o.CikisTarihi = Genel.CikisTarihi;
            o.OdaTipi = Genel.OdaTipi;
            ds = o.OtelleriGetir(o);
            dgvOteller.DataSource = ds.Tables["Oteller"];
            ((DataGridViewImageColumn)dgvOteller.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvOteller.Columns[1].Visible = false;
            dgvOteller.Columns[7].Visible = false;
            dgvOteller.Columns[8].Visible = false;
            dgvOteller.Columns[9].Visible = false;
            dgvOteller.Columns[2].Width = 120;
            dgvOteller.Columns[3].Width = 90;
            dgvOteller.Columns[4].Width = 90;
            dgvOteller.Columns[5].Width = 90;
            dgvOteller.Columns[2].HeaderText = "Oteller";
            dgvOteller.Columns[3].HeaderText = "Dereceler";
            dgvOteller.Columns[4].HeaderText = "Statu";
            dgvOteller.Columns[5].HeaderText = "Oda Tipi";

            dtpBaslangic.Value = Convert.ToDateTime(Genel.GirisTarihi);
            dtpBitis.Value = Convert.ToDateTime(Genel.CikisTarihi);
            TimeSpan ts = dtpBitis.Value - dtpBaslangic.Value;
            lblGece.Text = ts.TotalDays.ToString();
            lblGun.Text = (ts.TotalDays - 1).ToString();
            cbAdet.SelectedItem = "1";
            txtFiyat.Text = "0";


            for (DateTime i = Convert.ToDateTime(Genel.GirisTarihi); i <= Convert.ToDateTime(Genel.CikisTarihi); i = i.AddDays(1.0))
            {
                string gun = i.ToShortDateString();
                Gunler.Add(gun);
            }


        }
        private void dgvOteller_DoubleClick(object sender, EventArgs e)
        {

            Otel o = new Otel();
            txtOtelAdi.Text = dgvOteller.SelectedRows[0].Cells[2].Value.ToString();
            txtOdaTipi.Text = dgvOteller.SelectedRows[0].Cells[5].Value.ToString();
            TimeSpan ts = dtpBitis.Value - dtpBaslangic.Value;
            txtFiyat.Text = ((ts.TotalDays) * (Convert.ToInt32(dgvOteller.SelectedRows[0].Cells[6].Value))).ToString();
            o.SonKalanOdaSayisi(Convert.ToInt32(dgvOteller.SelectedRows[0].Cells[7].Value), lblSonKalanOda);

            bool sonuc = RezDurumuGuncelle(dgvOteller.SelectedRows[0].Cells[1].Value.ToString(), dgvOteller.SelectedRows[0].Cells[9].Value.ToString());
            if (sonuc)
            {
                int tipid = Convert.ToInt32(dgvOteller.SelectedRows[0].Cells[9].Value.ToString());
                int odasayisi = OdaSayisiniGüncelle(tipid);
                odasayisi -= 1;
                lblSonKalanOda.Text = "Kalan Son " + odasayisi.ToString() + " oda";
            }
        }
        internal bool RezDurumuGuncelle(string OtelID, string TipID)
        {
            bool varmi = false;
            SqlCommand comm = new SqlCommand("select VarisTarihi , AyrilisTarihi from RezDurum where OtelID=@OtelID and TipID=@TipID", conn);
            comm.Parameters.Add("@OtelID", SqlDbType.Int).Value = Convert.ToInt32(OtelID);
            comm.Parameters.Add("@TipID", SqlDbType.Int).Value = Convert.ToInt32(TipID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                ArrayList rgunler = new ArrayList();
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    for (DateTime i = Convert.ToDateTime(dr[0]); i <= Convert.ToDateTime(dr[1]); i = i.AddDays(1))
                    {
                        string gun = i.ToShortDateString();
                        rgunler.Add(gun);
                    }
                }
                dr.Close();
                foreach (string rgun in rgunler)
                {
                    foreach (string gun in Gunler)
                    {
                        if (rgun == gun)
                        {
                            varmi = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return varmi;
        }
        internal int OdaSayisiniGüncelle(int odaTipi)
        {
            int odasayisi = 0;
            foreach (DataGridViewRow item in dgvOteller.Rows)
            {
                if (odaTipi == Convert.ToInt32(item.Cells[7].Value))
                {
                    odasayisi = Convert.ToInt32(item.Cells[8].Value);
                }
            }
            return odasayisi;
        }
        private void cbAdet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genel.GirisTarihi = dtpBaslangic.Value.ToString();
            Genel.CikisTarihi = dtpBitis.Value.ToString();
            TimeSpan ts = dtpBitis.Value - dtpBaslangic.Value;
            txtFiyat.Clear();
            txtFiyat.Text = ((Convert.ToInt32(cbAdet.SelectedItem)) * ((ts.TotalDays) * (Convert.ToInt32(dgvOteller.SelectedRows[0].Cells[6].Value)))).ToString();
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            Genel.GirisTarihi = dtpBaslangic.Value.ToString();
            TimeSpan ts = dtpBitis.Value - dtpBaslangic.Value;
            lblGece.Text = ts.TotalDays.ToString();
            lblGun.Text = (ts.TotalDays - 1).ToString();
            txtFiyat.Text = ((ts.TotalDays) * (Convert.ToInt32(dgvOteller.SelectedRows[0].Cells[6].Value))).ToString();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            Genel.CikisTarihi = dtpBitis.Value.ToString();
            TimeSpan ts = dtpBitis.Value - dtpBaslangic.Value;
            lblGece.Text = ts.TotalDays.ToString();
            lblGun.Text = (ts.TotalDays - 1).ToString();
            txtFiyat.Text = ((ts.TotalDays) * (Convert.ToInt32(dgvOteller.SelectedRows[0].Cells[6].Value))).ToString();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            Genel.OtelID = Convert.ToInt32(dgvOteller.SelectedRows[0].Cells[1].Value);
            Genel.OtelAd = txtOtelAdi.Text;
            Genel.OdaTipiID = Convert.ToInt32(dgvOteller.SelectedRows[0].Cells[7].Value);
            Genel.OdaTipi = txtOdaTipi.Text;
            Genel.OdaAdet = cbAdet.SelectedItem.ToString();
            Genel.OdaFiyat = txtFiyat.Text;
            this.Hide();
            Rezervasyon frm = new Rezervasyon();
            frm.ShowDialog();
        }
    }
}
