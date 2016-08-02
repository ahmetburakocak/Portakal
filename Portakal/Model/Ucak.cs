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
    class Ucak
    {
        #region prop
        private int _ucakID;

        public int UcakID
        {
            get { return _ucakID; }
            set { _ucakID = value; }
        }
        private int _modelID;

        public int ModelID
        {
            get { return _modelID; }
            set { _modelID = value; }
        }
        private int _havayollariID;

        public int HavayollariID
        {
            get { return _havayollariID; }
            set { _havayollariID = value; }
        }
        private string _ucakAdi;

        public string UcakAdi
        {
            get { return _ucakAdi; }
            set { _ucakAdi = value; }
        }
        private string _aciklama;

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void UcaklariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UcakID, UcakAdi, HavayoluAdi, Ucaklar.HavayollariID, ModelAdi, Ucaklar.ModelID, Ucaklar.Aciklama from Ucaklar inner join Havayollari on Ucaklar.HavayollariID=Havayollari.HavayoluID inner join Modeller on Modeller.ModelID=Ucaklar.ModelID where ucaklar.Silindi =0", conn);
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
                        liste.Items[i].SubItems.Add(dr[6].ToString());
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

        public bool UcakVarMi(string UcakAdi)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Ucaklar where UcakAdi=@UcakAdi and silindi=0", conn);
            comm.Parameters.Add("@UcakAdi", SqlDbType.VarChar).Value = UcakAdi;
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

        public bool UcakEkle(Ucak u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Ucaklar (UcakAdi, HavayollariID, ModelID, Aciklama) values (@UcakAdi, @HavayollariID, @ModelID, @Acikalama)", conn);
            comm.Parameters.Add("@UcakAdi", SqlDbType.VarChar).Value = u._ucakAdi;
            comm.Parameters.Add("@HavayollariID", SqlDbType.Int).Value = u._havayollariID;
            comm.Parameters.Add("@ModelID", SqlDbType.Int).Value = u._modelID;
            comm.Parameters.Add("@Acikalama", SqlDbType.VarChar).Value = u._aciklama;
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

        public bool UcakVarMi(int Kodu, string UcakAdi)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Ucaklar where UcakAdi=@UcakAdi and UcakID!=@Id and silindi=0", conn);
            comm.Parameters.Add("@havalimaniAdi", SqlDbType.VarChar).Value = UcakAdi;
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = Kodu;
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

        public bool UcakGuncelle(Ucak u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Ucaklar set UcakAdi=@UcakAdi, HavayollariID=@HavayollariID, aciklama=@Aciklama, ModelID=@ModelID where UcakID=@UcakID", conn);
            comm.Parameters.Add("@UcakAdi", SqlDbType.VarChar).Value = u._ucakAdi;
            comm.Parameters.Add("@HavayollariID", SqlDbType.Int).Value = u._havayollariID;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = u._aciklama;
            comm.Parameters.Add("@ModelID", SqlDbType.Int).Value = u._modelID;
            comm.Parameters.Add("@UcakID", SqlDbType.Int).Value = u._ucakID;
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

        public bool UcakSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Ucaklar set Silindi=1 where ucakID=@ID", conn);
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

        public DataSet UcaklariGetir()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select u.UcakID, u.UcakAdi,u.HavayollariID, h.Kisaltmasi, h.HavayoluAdi, u.ModelID, m.ModelAdi, m.EkoKoltukAdeti, m.BusinessKoltukAdeti, m.FirstKoltukAdeti from ucaklar u inner join Modeller m on U.ModelID=M.ModelID inner join Havayollari h on u.HavayollariID=h.HavayoluID where u.Silindi = 0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Ucaklar");
            }
            catch (SqlException ex)
            {
                string s = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }

        public string IsimBul(string kisaltma)
        {
            List<string> adlar = new List<string>();
            SqlCommand comm = new SqlCommand("Select UcakAdi from Ucaklar", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        adlar.Add(dr[0].ToString());
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            string s = "";
            bool deger = true;
            while (deger)
            {
                Random rnd = new Random();
                int a = rnd.Next(1000, 9999);
                s = kisaltma + a.ToString();
                foreach (string item in adlar)
                {
                    if (item == s)
                    {
                        deger = true;
                        break;
                    }
                    else
                    {
                        deger = false;
                        break;
                    }
                }
            }

            return s;

        }
    }
}
