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
    class UcakModel
    {
        #region prop
        private int _modelID;

        public int ModelID
        {
            get { return _modelID; }
            set { _modelID = value; }
        }
        private string _modelAdi;

        public string ModelAdi
        {
            get { return _modelAdi; }
            set { _modelAdi = value; }
        }
        private int _ekoKoltukAdeti;

        public int EkoKoltukAdeti
        {
            get { return _ekoKoltukAdeti; }
            set { _ekoKoltukAdeti = value; }
        }
        private int _firstKoltukAdeti;

        public int FirstKoltukAdeti
        {
            get { return _firstKoltukAdeti; }
            set { _firstKoltukAdeti = value; }
        }
        private int _businessKoltukAdeti;

        public int BusinessKoltukAdeti
        {
            get { return _businessKoltukAdeti; }
            set { _businessKoltukAdeti = value; }
        }
        private string _aciklama;

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void ModelleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Modeller where silindi=0", conn);
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

        public bool UcakModelVarMi(string ModelAdi)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count(*) from Modeller where ModelAdi=@ModelAdi and silindi=0", conn);
            comm.Parameters.Add("@ModelAdi", SqlDbType.VarChar).Value = ModelAdi;
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

        public bool UcakModelEkle(UcakModel u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into modeller (ModelAdi, EkoKoltukAdeti,BusinessKoltukAdeti,FirstKoltukAdeti, aciklama) values (@ModelAdi, @EkoKoltukAdeti, @BusinessKoltukAdeti, @FirstKoltukAdeti, @aciklama)", conn);
            comm.Parameters.Add("@ModelAdi", SqlDbType.VarChar).Value = u._modelAdi;
            comm.Parameters.Add("@EkoKoltukAdeti", SqlDbType.Int).Value = u._ekoKoltukAdeti;
            comm.Parameters.Add("@BusinessKoltukAdeti", SqlDbType.Int).Value = u._businessKoltukAdeti;
            comm.Parameters.Add("@FirstKoltukAdeti", SqlDbType.Int).Value = u._firstKoltukAdeti;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
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

        public bool UcakModelSil(int ModelNo)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update modeller set Silindi=1 where ModelID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ModelNo;
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

        public bool UcakModelVarMi(string ModelAdi, int ID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Modeller where ModelAdi=@ModelAdi and ModelID!=@Id and silindi=0", conn);
            comm.Parameters.Add("@ModelAdi", SqlDbType.VarChar).Value = ModelAdi;
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

        public bool UcakModelGuncelle(UcakModel u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Modeller set ModelAdi=@Adi, EkoKoltukAdeti=@Eko, BusinessKoltukAdeti=@Buss, FirstKoltukAdeti=@First, Aciklama=@Aciklama where ModelID=@ID", conn);
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = u._modelAdi;
            comm.Parameters.Add("@Eko", SqlDbType.Int).Value = u._ekoKoltukAdeti;
            comm.Parameters.Add("@Buss", SqlDbType.Int).Value = u._businessKoltukAdeti;
            comm.Parameters.Add("@First", SqlDbType.Int).Value = u._firstKoltukAdeti;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = u._aciklama;
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = u._modelID;
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

        DataTable dt = new DataTable();

        public DataTable ModelleriGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from Modeller where silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return dt;
        }
    }
}
