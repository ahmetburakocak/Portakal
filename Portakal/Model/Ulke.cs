using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Portakal.Model
{
    class Ulke
    {

        private int _ulkeID;
        private string _ulkeAdi;
        private string _aciklama;
        private string _ulkeTelCode;

        #region Properties
        public string UlkeTelCode
        {
            get { return _ulkeTelCode; }
            set { _ulkeTelCode = value; }
        }



        public int UlkeID
        {
            get { return _ulkeID; }
            set { _ulkeID = value; }
        }


        public string UlkeAdi
        {
            get { return _ulkeAdi; }
            set { _ulkeAdi = value; }
        }


        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void UlkeleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from ulkeler where silindi=0", conn);
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
                        liste.Items[i].SubItems.Add(dr[3].ToString());
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

        public bool UlkeVarMi(string TelefonKodu, string UlkeAdi)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Ulkeler where ulkeAdi=@Adi and UlketelCod=@TelCode and silindi=0", conn);
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = UlkeAdi;
            comm.Parameters.Add("@TelCode", SqlDbType.VarChar).Value = TelefonKodu;
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

        public bool UlkeEkle(Ulke u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Ulkeler (UlkeAdi, UlkeTelCod, Aciklama) values (@Adi, @TelCod, @Aciklama)", conn);
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = u._ulkeAdi;
            comm.Parameters.Add("@TelCod", SqlDbType.VarChar).Value = u._ulkeTelCode;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = u._aciklama;
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

        public bool UlkeVarMiForGuncelle(string UlkeAdi, int UlkeID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Ulkeler where ulkeAdi=@Adi and UlkeID!=@Id and silindi=0", conn);
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = UlkeAdi;
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = UlkeID;
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

        public bool UlkeGuncelle(Ulke u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Ulkeler set UlkeAdi=@Adi, UlkeTelCod=@TelCod, aciklama=@Aciklama where ulkeID=@ulkeID", conn);
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = u._ulkeAdi;
            comm.Parameters.Add("@ulkeID", SqlDbType.Int).Value = u._ulkeID;
            comm.Parameters.Add("@TelCod", SqlDbType.VarChar).Value = u._ulkeTelCode;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = u._aciklama;
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

        public bool UlkeSil(int UlkeID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Ulkeler set Silindi=1 where ulkeID=@ulkeID", conn);
            comm.Parameters.Add("@ulkeID", SqlDbType.Int).Value = UlkeID;
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

        public void UlkeleriGetirBySorgulama(string UlkeAdi, string TelefonKodu, string Aciklama, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from ulkeler where silindi=0 and UlkeAdi like @UlkeAdi+'%' and Aciklama like @aciklama+'%' and UlkeTelCod like @Telcod +'%'", conn);
            comm.Parameters.Add("@UlkeAdi", SqlDbType.VarChar).Value = UlkeAdi;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = Aciklama;
            comm.Parameters.Add("@Telcod", SqlDbType.VarChar).Value = TelefonKodu;
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
                        liste.Items[i].SubItems.Add(dr[3].ToString());
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
    }
}
