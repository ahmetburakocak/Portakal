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
    public partial class KiralamaSatisSorgulama : Form
    {
        public KiralamaSatisSorgulama()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            txtBaslangic.Text = dtpBaslangic.Value.ToShortDateString();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            txtBitis.Text = dtpBitis.Value.ToShortDateString();
        }

        private void KiralamaSatisSorgulama_Load(object sender, EventArgs e)
        {
            txtBaslangic.Text = dtpBaslangic.Value.ToShortDateString();
            txtBitis.Text = dtpBitis.Value.ToShortDateString();
            double ToplamTutar = 0;
        }
    }
}
