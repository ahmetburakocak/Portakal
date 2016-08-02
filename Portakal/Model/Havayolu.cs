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
    class Havayolu
    {
        private int _havayoluID;
        private string _havayoluAdi;
        private string _kisaltmasi;
        private int _fotografID;
        private string _aciklama;
        private int _ulkeID;

        #region Prop

        public int HavayoluID
        {
            get { return _havayoluID; }
            set { _havayoluID = value; }
        }


        public string HavayoluAdi
        {
            get { return _havayoluAdi; }
            set { _havayoluAdi = value; }
        }
        public string Kisaltmasi
        {
            get { return _kisaltmasi; }
            set { _kisaltmasi = value; }
        }

        public int UlkeID
        {
            get { return _ulkeID; }
            set { _ulkeID = value; }
        }

        public int FotografID
        {
            get { return _fotografID; }
            set { _fotografID = value; }
        }

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void HavayollariniGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select HavayoluID,Kisaltmasi, HavayoluAdi, UlkeAdi, havayollari.Aciklama, ulkeler.UlkeID from Havayollari inner join Ulkeler on Ulkeler.UlkeID=Havayollari.UlkeID where havayollari.silindi=0", conn);
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

        public bool HavayoluVarMi(string HavayoluAdi, string Kisaltma)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count(*) from Havayollari where (HavayoluAdi=@Adi or Kisaltmasi=@kisaltma) and silindi=0", conn);
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = HavayoluAdi;
            comm.Parameters.Add("@kisaltma", SqlDbType.VarChar).Value = Kisaltma;
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

        public bool HavayoluEkle(Havayolu h)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into havayollari (HavayoluAdi, UlkeID, FotografID, Aciklama, Kisaltmasi) values (@HavayoluAdi, @UlkeID, @FotografID, @Aciklama, @Kisaltmasi)", conn);
            comm.Parameters.Add("@HavayoluAdi", SqlDbType.VarChar).Value = h._havayoluAdi;
            comm.Parameters.Add("@UlkeID", SqlDbType.Int).Value = h._ulkeID;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = h._aciklama;
            comm.Parameters.Add("@FotografID", SqlDbType.Int).Value = h._fotografID;
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

        public bool HavayoluVarMi(string HavayoluAdi, int HavayoluID, string Kisaltma)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Havayollari where (HavayoluAdi=@havayoluAdi or kisaltmasi=@kisaltma) and havayoluID!=@Id and silindi=0", conn);
            comm.Parameters.Add("@havayoluAdi", SqlDbType.VarChar).Value = HavayoluAdi;
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = HavayoluID;
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

        public bool HavayoluGuncelle(Havayolu h)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update havayollari set HavayoluAdi=@HavayoluAdi, UlkeID=@UlkeID, aciklama=@Aciklama, Kisaltmasi=@kisaltma where havayoluId=@HavayoluID", conn);
            comm.Parameters.Add("@HavayoluAdi", SqlDbType.VarChar).Value = h._havayoluAdi;
            comm.Parameters.Add("@UlkeID", SqlDbType.Int).Value = h._ulkeID;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = h._aciklama;
            comm.Parameters.Add("@kisaltma", SqlDbType.VarChar).Value = h._kisaltmasi;
            comm.Parameters.Add("@HavayoluID", SqlDbType.Int).Value = h._havayoluID;
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

        public bool HavayoluSil(int HavayoluID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update havayollari set Silindi=1 where HavayoluID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = HavayoluID;
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

        public void HavayollariniGetirBySorgulama(string HavayoluAdi, string Kisaltmasi, string UlkeAdi, string aciklama, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("	select h.HavayoluID, h.HavayoluAdi, h.Kisaltmasi, u.UlkeAdi, h.Aciklama from Havayollari h inner join Ulkeler u on h.UlkeID=u.UlkeID where h.Silindi =0 and UlkeAdi like @ulkeAdi+'%' and HavayoluAdi like @havayoluAdi+'%' and Kisaltmasi like @kisaltmasi+'%' and h.Aciklama like @aciklama+'%'", conn);
            comm.Parameters.Add("@ulkeAdi", SqlDbType.VarChar).Value = UlkeAdi;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = Aciklama;
            comm.Parameters.Add("@havayoluAdi", SqlDbType.VarChar).Value = HavayoluAdi;
            comm.Parameters.Add("@kisaltmasi", SqlDbType.VarChar).Value = Kisaltmasi;
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

        public string HavayoluAdiGetir(int ID) 
        {
            string ad = "";
            SqlCommand comm = new SqlCommand("select havayoluAdi from Havayollari where HavayoluID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ad = dr[0].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); }
            return ad;
        }
    }
}
