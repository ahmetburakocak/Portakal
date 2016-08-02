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
    class Havalimani
    {
        private int _havalimaniID;
        private string _havalimaniAdi;
        private string _kisaltmasi;
        private int _sehirID;
        private string _aciklama;
        #region Properties
        public int HavalimaniID
        {
            get { return _havalimaniID; }
            set { _havalimaniID = value; }
        }

        public string HavalimaniAdi
        {
            get { return _havalimaniAdi; }
            set { _havalimaniAdi = value; }
        }


        public string Kisaltmasi
        {
            get { return _kisaltmasi; }
            set { _kisaltmasi = value; }
        }


        public int SehirID
        {
            get { return _sehirID; }
            set { _sehirID = value; }
        }


        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        #endregion
        SqlConnection conn = new SqlConnection(Genel.connStr);
        public void HavaalanlariGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Havalimanlari where Silindi=0", conn);
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

        public int HavalimaniIDGetir(string HavalimaniAdi)
        {
            SqlCommand comm = new SqlCommand("select HavalimaniID from Havalimanlari where Silindi=0 and HavalimaniAdi=@Ad", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = HavalimaniAdi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int ID = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return ID;
        }

        public void HavalimanlariniGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select HavalimaniID,Kisaltmasi, HavalimaniAdi, SehirAdi, h.Aciklama, h.SehirID from Havalimanlari h inner join Sehirler s on s.SehirID=h.SehirID where h.Silindi =0", conn);
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
                        liste.Items[i].SubItems.Add(dr[5].ToString());
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

        public bool HavayoluVarMi(string HavalimaniAdi, int Kodu, string Kisaltma)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from havalimanlari where (havalimaniAdi=@havalimaniAdi or kisaltmasi=@kisaltma) and habalimaniID!=@Id and silindi=0", conn);
            comm.Parameters.Add("@havalimaniAdi", SqlDbType.VarChar).Value = HavalimaniAdi;
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = Kodu;
            comm.Parameters.Add("@Kisaltma", SqlDbType.VarChar).Value = Kisaltma;
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

        public bool HavalimaniGuncelle(Havalimani h)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update havalimanlari set havalimaniAdi=@havalimaniAdi, SehirID=@SehirID, aciklama=@Aciklama, Kisaltmasi=@kisaltma where havalimaniID=@havalimaniID", conn);
            comm.Parameters.Add("@havalimaniAdi", SqlDbType.VarChar).Value = h._havalimaniAdi;
            comm.Parameters.Add("@SehirID", SqlDbType.Int).Value = h._sehirID;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = h._aciklama;
            comm.Parameters.Add("@kisaltma", SqlDbType.VarChar).Value = h._kisaltmasi;
            comm.Parameters.Add("@havalimaniID", SqlDbType.Int).Value = h._havalimaniID;
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

        public bool HavalimaniSil(int Kodu)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update havalimanlari set Silindi=1 where havalimaniID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = Kodu;
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

        public bool HavalimaniVarMi(string HavalimaniAdi, string Kisaltmasi)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Havalimanlari where (HavalimaniAdi=@HavalimaniAdi or kisaltmasi=@kisaltma) and silindi=0", conn);
            comm.Parameters.Add("@HavalimaniAdi", SqlDbType.VarChar).Value = HavalimaniAdi;
            comm.Parameters.Add("@Kisaltma", SqlDbType.VarChar).Value = Kisaltmasi;
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

        internal bool HavalimaniEkle(Havalimani h)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into havalimanlari (HavalimaniAdi, SehirID, Aciklama, Kisaltmasi) values (@HavalimaniAdi, @SehirID, @Aciklama, @Kisaltmasi)", conn);
            comm.Parameters.Add("@HavalimaniAdi", SqlDbType.VarChar).Value = h._havalimaniAdi;
            comm.Parameters.Add("@SehirID", SqlDbType.Int).Value = h._sehirID;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = h._aciklama;
            comm.Parameters.Add("@Kisaltmasi", SqlDbType.VarChar).Value = h._kisaltmasi;
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

        public void HavalimanlariniGetir(string Ad, string kisaltma, string sehirAd, string aciklama, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select h.HavalimaniID, s.SehirAdi, h.HavalimaniAdi, h.Kisaltmasi, h.Aciklama from Havalimanlari h inner join Sehirler s on s.SehirID=h.SehirID where h.silindi=0 and h.kisaltmasi like '%'+@kisaltmasi+'%' and h.Aciklama like '%'+@aciklama+'%' and s.SehirAdi like '%'+@sehirAdi +'%' and h.havalimaniAdi like '%'+@havalimaniAdi+'%'", conn);
            comm.Parameters.Add("@havalimaniAdi", SqlDbType.VarChar).Value = Ad;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = aciklama;
            comm.Parameters.Add("@kisaltmasi", SqlDbType.VarChar).Value = kisaltma;
            comm.Parameters.Add("@sehirAdi", SqlDbType.VarChar).Value = sehirAd;
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
