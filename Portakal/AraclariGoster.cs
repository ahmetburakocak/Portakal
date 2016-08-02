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
    public partial class AraclariGoster : Form
    {
        public AraclariGoster()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        string Havalimani = Genel.HavalimaniAdi;
        private void AraclariGoster_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Araclar a = new Araclar();
            Firmalar f = new Firmalar();
            f.FirmalarıGetir(cbFirmalar);
            cbFirmalar.Items.Insert(0, "Tümü");
            cbFirmalar.SelectedIndex = 0;
            dt = a.AraclariGetir(Havalimani);
            dgvAraclar.DataSource = dt;
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            Sozlesme s = new Sozlesme();
            s.ShowDialog();
            this.Close();
        }

        private void dgvAraclar_DoubleClick(object sender, EventArgs e)
        {
            Genel.PlakaID = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells[9].Value);
            Genel.Fiyat = Convert.ToDouble(dgvAraclar.SelectedRows[0].Cells[8].Value);
        }

        private void cbFirmalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            AraclariGetir();
        }
        private void txtVites_TextChanged(object sender, EventArgs e)
        {
            AraclariGetir();
        }

        private void txtYakit_TextChanged(object sender, EventArgs e)
        {
            AraclariGetir();
        }

        private void AraclariGetir()
        {
            string Firma = "";   
            if (cbFirmalar.SelectedItem.ToString()!="")
            {
                Firma = cbFirmalar.SelectedItem.ToString();
            }
            Araclar a = new Araclar();
            dt = a.AraclariGetir(Firma, txtVites.Text, txtYakit.Text, Havalimani);
            dgvAraclar.DataSource = dt;

        }

        
    }
}
