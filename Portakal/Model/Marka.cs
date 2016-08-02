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
    class Marka
    {
        private int _markaID;
        private string _MarkaAd;
        private string _Aciklama;
        private int _sinifID;

        #region Properties
        public int SinifID
        {
            get { return _sinifID; }
            set { _sinifID = value; }
        }
        public int MarkaID
        {
            get { return _markaID; }
            set { _markaID = value; }
        }


        public string MarkaAd
        {
            get { return _MarkaAd; }
            set { _MarkaAd = value; }
        }


        public string Aciklama
        {
            get { return _Aciklama; }
            set { _Aciklama = value; }
        }
        #endregion
        SqlConnection conn = new SqlConnection(Genel.connStr);
        public void MarkalariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select SinifAd,MarkaAd,m.Aciklama,MarkaID,m.SinifID from Markalar m inner join AracSinifi a on m.SinifID=a.SinifID where m.Silindi=0", conn);
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
        public bool MarkaVarmi(string MarkaAd, int ID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Markalar where MarkaAd=@MarkaAd and SinifID=@SinifID and Silindi=0", conn);
            comm.Parameters.Add("@MarkaAd", SqlDbType.VarChar).Value = MarkaAd;
            comm.Parameters.Add("@SinifID", SqlDbType.Int).Value = ID;
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
        public bool MarkaEkle(Marka m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Markalar (SinifID,MarkaAd, Aciklama) values (@SinifID,@MarkaAd, @Aciklama)", conn);
            comm.Parameters.Add("@MarkaAd", SqlDbType.VarChar).Value = m._MarkaAd;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = m._Aciklama;
            comm.Parameters.Add("@SinifID", SqlDbType.Int).Value = m._sinifID;
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
        public bool MarkaGuncelleVarmi(string MarkaAd, int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Markalar where MarkaAd=@MarkaAd and MarkaID!=@Id and Silindi=0", conn);
            comm.Parameters.Add("@MarkaAd", SqlDbType.VarChar).Value = MarkaAd;
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
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
        public bool MarkaGuncelle(Marka m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Markalar set MarkaAd=@MarkaAd, Aciklama=@Aciklama,SinifID=@SinifID where MarkaID=@MarkaID", conn);
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = m._markaID;
            comm.Parameters.Add("@MarkaAd", SqlDbType.VarChar).Value = m._MarkaAd;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = m._Aciklama;
            comm.Parameters.Add("@SinifID", SqlDbType.Int).Value = m._sinifID;
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
        public bool MarkaSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Markalar set Silindi=1 where MarkaID=@ID", conn);
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
        public void MarkalariGetir(ComboBox liste, int SinifID)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MarkaAd from Markalar m inner join AracSinifi a on m.SinifID=a.SinifID where m.SinifID=@ID and m.Silindi=0 ", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = SinifID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
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

        public int MarkaIDGetir(string MarkaAd)
        {
            SqlCommand comm = new SqlCommand("select MarkaID from Markalar where Silindi=0 and MarkaAd=@MarkaAd", conn);
            comm.Parameters.Add("@MarkaAd", SqlDbType.VarChar).Value = MarkaAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int ID = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return ID;
        }
        public override string ToString()
        {
            return MarkaAd;
        }

        public void MarkalariGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MarkaAd from Markalar where Silindi=0 ", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
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
