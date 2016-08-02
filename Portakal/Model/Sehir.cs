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
    class Sehir
    {
        private int _sehirID;
        private string _sehirAdi;
        private int _ulkeID;
        private string _aciklama;

        #region Properties

        public int SehirID
        {
            get { return _sehirID; }
            set { _sehirID = value; }
        }

        public string SehirAdi
        {
            get { return _sehirAdi; }
            set { _sehirAdi = value; }
        }

        public int UlkeID
        {
            get { return _ulkeID; }
            set { _ulkeID = value; }
        }

        

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void SehirleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select SehirID,SehirAdi,UlkeAdi, sehirler.aciklama, sehirler.ulkeID from sehirler inner join ulkeler on sehirler.ulkeID=ulkeler.ulkeID where sehirler.silindi=0", conn);
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

        public bool SehirVarMi(string SehirAdi, string UlkeAdi)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Sehirler inner join Ulkeler on ulkeler.ulkeID=sehirler.UlkeID where ulkeAdi=@UlkeAdi and SehirAdi=@SehirAdi and silindi=0", conn);
            comm.Parameters.Add("@UlkeAdi", SqlDbType.VarChar).Value = UlkeAdi;
            comm.Parameters.Add("@SehirAdi", SqlDbType.VarChar).Value = SehirAdi;
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

        public bool SehirEkle(Sehir s)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into sehirler (SehirAdi, UlkeID, Aciklama) values (@SehirAdi, @UlkeID, @Aciklama)", conn);
            comm.Parameters.Add("@SehirAdi", SqlDbType.VarChar).Value = s._sehirAdi;
            comm.Parameters.Add("@UlkeID", SqlDbType.VarChar).Value = s._ulkeID;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = s._aciklama;
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

        public bool SehirVarMiForGuncelle(string SehirAdi, int ID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Sehirler where SehirAdi=@SehirAdi and SehirID!=@Id and silindi=0", conn);
            comm.Parameters.Add("@SehirAdi", SqlDbType.VarChar).Value = SehirAdi;
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = ID;
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

        public bool SehirGuncelle(Sehir s)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Sehirler set UlkeID=@UlkeID, SehirAdi=@Sehiradi, aciklama=@Aciklama where sehirID=@sehirID", conn);
            comm.Parameters.Add("@UlkeID", SqlDbType.Int).Value = s._ulkeID;
            comm.Parameters.Add("@Sehiradi", SqlDbType.VarChar).Value = s._sehirAdi;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = s._aciklama;
            comm.Parameters.Add("@sehirID", SqlDbType.Int).Value = s._sehirID;
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

        public bool SehirSil(int SehirKodu)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Sehirler set Silindi=1 where SehirID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = SehirKodu;
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

        public void SehirleriGetirBySorgulama(string sehirAdi, string ulkeAdi, string aciklama, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select s.SehirID,s.SehirAdi,UlkeAdi,s.Aciklama from sehirler s inner join ulkeler u on u.ulkeID=s.UlkeID where s.silindi=0 and SehirAdi like @SehirAdi+'%' and s.Aciklama like @aciklama+'%' and UlkeAdi like @UlkeAdi +'%'", conn);
            comm.Parameters.Add("@UlkeAdi", SqlDbType.VarChar).Value = ulkeAdi;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = aciklama;
            comm.Parameters.Add("@SehirAdi", SqlDbType.VarChar).Value = sehirAdi;
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
        public void SehirleriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select SehirAdi from sehirler where silindi=0", conn);
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

        public int SehirIDGetir(string Ad)
        {
            SqlCommand comm = new SqlCommand("select SehirID from Sehirler where Silindi=0 and SehirAdi=@Ad", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Ad;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int ID = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return ID;
        }

        public void SehirleriGetirFromOtel(ComboBox cb)
        {
            cb.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Sehirler where Silindi=0", conn);
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
                        Sehir s = new Sehir();
                        s._sehirID = Convert.ToInt32(dr[0]);
                        s._sehirAdi = dr[1].ToString();
                        cb.Items.Add(s);
                        i++;
                    }
                    dr.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }
        public override string ToString()
        {
            return _sehirAdi;
        }
    }
}
