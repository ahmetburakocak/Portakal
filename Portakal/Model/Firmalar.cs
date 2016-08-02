using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portakal.Model
{
    class Firmalar
    {
        private int _firmaID;
        private string _firmaAd;
        private string _aciklama;

        #region Properties
        public int FirmaID
        {
            get
            {
                return _firmaID;
            }

            set
            {
                _firmaID = value;
            }
        }

        public string FirmaAd
        {
            get
            {
                return _firmaAd;
            }

            set
            {
                _firmaAd = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return _aciklama;
            }

            set
            {
                _aciklama = value;
            }
        }


        #endregion
        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void FirmalarıGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select FirmaAd,Aciklama,FirmaID from Firmalar where Silindi=0", conn);
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


        public bool FirmaVarmi(string FirmaAD, string Aciklama)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Firmalar where FirmaAd=@FirmaAd and Aciklama!=@Aciklama and Silindi=0", conn);
            comm.Parameters.Add("@FirmaAd", SqlDbType.VarChar).Value = FirmaAD;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int sayi = 0;
            try
            {
                sayi = Convert.ToInt32(comm.ExecuteScalar());
                if (sayi > 0)
                {
                    sonuc = true;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return sonuc;
        }

        public bool FirmaEkle(Firmalar f)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Firmalar (FirmaAd, Aciklama) values (@Firmad, @Aciklama)", conn);
            comm.Parameters.Add("@Firma", SqlDbType.VarChar).Value = f._firmaAd;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = f._aciklama;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public bool FirmaGuncelleVarmi(string FirmaAD, int ID, string Aciklama)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Firmalar where FirmaAd=@FirmaAd and FirmaID!=@Id and Silindi=0", conn);
            comm.Parameters.Add("@FirmaAd", SqlDbType.VarChar).Value = FirmaAD;
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int sayi = 0;
            try
            {
                sayi = Convert.ToInt32(comm.ExecuteScalar());
                if (sayi > 0)
                {
                    Sonuc = true;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return Sonuc;
        }

        public bool FirmaGuncelle(Firmalar f)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Firmalar set FirmaAd=@FirmaAd, Aciklama=@Aciklama where FirmaID=@FirmaID", conn);
            comm.Parameters.Add("@FirmaID", SqlDbType.Int).Value = f._firmaID;
            comm.Parameters.Add("@FirmaAd", SqlDbType.VarChar).Value = f._firmaAd;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = f._aciklama;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public bool FirmaSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Firmalar set Silindi=1 where FirmaID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public void FirmalarıGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Firmalar where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    liste.Items.Add(dr[1].ToString());
                }
                dr.Close();
            }
            conn.Close();
        }




        public int FirmaIDGetir(string FirmaAd)
        {
            SqlCommand comm = new SqlCommand("select FirmaID from Firmalar where Silindi=0 and FirmaAd=@Ad", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = FirmaAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int ID = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return ID;
        }
    }
}
