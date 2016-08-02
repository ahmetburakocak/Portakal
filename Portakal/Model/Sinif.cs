using Portakal.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portakal
{
    class Sinif
    {
        private int _sinifID;
        private string _sinifAd;
        private string _aciklama;
        #region Properties
        public int SinifID
        {
            get { return _sinifID; }
            set { _sinifID = value; }
        }


        public string SinifAd
        {
            get { return _sinifAd; }
            set { _sinifAd = value; }
        }


        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        #endregion
        SqlConnection conn = new SqlConnection(Genel.connStr);
        public void SiniflariGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from AracSinifi where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[1].ToString());
                    }
                    dr.Close();
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); }
        }

        public int SinifIDGetir(string Ad)
        {
            SqlCommand comm = new SqlCommand("select SinifID from AracSinifi where Silindi=0 and SinifAd=@SinifAd", conn);
            comm.Parameters.Add("@SinifAd", SqlDbType.VarChar).Value = Ad;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int ID = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return ID;
        }
        public override string ToString()
        {
            return SinifAd;
        }
        public void SinifaGoreArama(ListView liste, int ID)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select SinifAd,MarkaAd,m.Aciklama,MarkaID,m.SinifID from Markalar m inner join AracSinifi a on m.SinifID=a.SinifID where m.SinifID=@ID and m.Silindi=0", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        i++;

                    }
                    dr.Close();
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); }
        }
    }
}
