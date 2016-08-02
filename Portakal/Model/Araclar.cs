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
    class Araclar
    {
        private int _plakaID;
        private int _havalimaniID;
        private int _firmaID;
        private int _modelID;
        private double _fiyat;
        private bool _kiradaMi;
        #region Properties
        public int PlakaID
        {
            get { return _plakaID; }
            set { _plakaID = value; }
        }

        public int HavalimaniID
        {
            get { return _havalimaniID; }
            set { _havalimaniID = value; }
        }

        public int FirmaID
        {
            get { return _firmaID; }
            set { _firmaID = value; }
        }

        public int ModelID
        {
            get { return _modelID; }
            set { _modelID = value; }
        }

        public double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }


        public bool KiradaMi
        {
            get { return _kiradaMi; }
            set { _kiradaMi = value; }
        }
        #endregion



        SqlConnection conn = new SqlConnection(Genel.connStr);

        public bool AracEkle(Araclar a)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Araclar (HavalimaniID,FirmaID,ModelID,Fiyat,KiradaMi) values(@HavalimaniID,@FirmaID,@ModelID,@Fiyat,@KiradaMi)", conn);
            comm.Parameters.Add("@HavalimaniID", SqlDbType.Int).Value = a._havalimaniID;
            comm.Parameters.Add("@FirmaID", SqlDbType.Int).Value = a._firmaID;
            comm.Parameters.Add("@ModelID", SqlDbType.Int).Value = a._modelID;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = a._fiyat;
            comm.Parameters.Add("@KiradaMi", SqlDbType.Bit).Value = a._kiradaMi;
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

        public DataTable AraclariGetir(string firma, string Vites,string yakit, string havalimani)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Resim,MarkaAd,m.ModelAd,HavalimaniAdi,FirmaAd, Klima,VitesTipi,YakitTipi,Fiyat, PlakaID from Model m inner join Markalar ma on m.MarkaID=ma.MarkaID inner join Araclar a on m.ModelID=a.ModelID inner join Havalimanlari h on a.HavalimaniID=h.HavalimaniID inner join Firmalar f on a.FirmaID=f.FirmaID inner join AracResim ar on m.ModelResmi=ar.ID where FirmaAd=@FirmaAd and VitesTipi like @VitesTipi+'%' and YakitTipi like @YakitTipi+'%' and HavalimaniAdi=@Ad and KiradaMi=0 and m.Silindi=0", conn);
            da.SelectCommand.Parameters.Add("@Ad", SqlDbType.VarChar).Value = havalimani;
            da.SelectCommand.Parameters.Add("@FirmaAd", SqlDbType.VarChar).Value = firma;
            da.SelectCommand.Parameters.Add("@YakitTipi", SqlDbType.VarChar).Value = yakit;
            da.SelectCommand.Parameters.Add("@VitesTipi", SqlDbType.VarChar).Value = Vites;

            try
            {
                da.Fill(dt);

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }



        public void AraclariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select PlakaID,MarkaAd,ModelAd,HavalimaniAdi,FirmaAd,Fiyat,KiradaMi,a.ModelID,a.HavalimaniID,a.FirmaID from Araclar a inner join Model m on a.ModelID=m.ModelID inner join Markalar ma on m.MarkaID=ma.MarkaID inner join Havalimanlari h on a.HavalimaniID=h.HavalimaniID inner join Firmalar f on a.FirmaID=f.FirmaID where a.Silindi=0", conn);
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
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());

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

        public bool AracGuncelleVarmi(int PlakaID, string Fiyat, int FirmaID, int HavalimaniID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Araclar where Fiyat=@Fiyat and HavalimaniID=@HavalimaniID and FirmaID=@FirmaID and PlakaID=@ID and Silindi=0", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = PlakaID;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = Fiyat;
            comm.Parameters.Add("@HavalimaniID", SqlDbType.Int).Value = HavalimaniID;
            comm.Parameters.Add("@FirmaID", SqlDbType.Int).Value = FirmaID;

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

        public bool AracGuncelle(Araclar a)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Araclar set HavalimaniID=@HavalimaniID,FirmaID=@FirmaID,ModelID=@ModelID,Fiyat=@Fiyat where PlakaID=@PlakaID", conn);
            comm.Parameters.Add("@HavalimaniID", SqlDbType.Int).Value = a._havalimaniID;
            comm.Parameters.Add("@ModelID", SqlDbType.Int).Value = a._modelID;
            comm.Parameters.Add("@FirmaID", SqlDbType.Int).Value = a._firmaID;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = a._fiyat;
            comm.Parameters.Add("@PlakaID", SqlDbType.Int).Value = a.PlakaID;

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

        public bool AracSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Araclar set Silindi=1 where PlakaID=@ID", conn);
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
        DataTable dt = new DataTable();
        public DataTable AraclariGetir(string Havalimani)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Resim,MarkaAd,m.ModelAd,HavalimaniAdi,FirmaAd, Klima,VitesTipi,YakitTipi,Fiyat, PlakaID from Model m inner join Markalar ma on m.MarkaID=ma.MarkaID inner join Araclar a on m.ModelID=a.ModelID inner join Havalimanlari h on a.HavalimaniID=h.HavalimaniID inner join Firmalar f on a.FirmaID=f.FirmaID inner join AracResim ar on m.ModelResmi=ar.ID where HavalimaniAdi=@Ad and KiradaMi=0 and m.Silindi=0", conn);
            da.SelectCommand.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Havalimani;

            try
            {
                da.Fill(dt);

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;

        }

        public void AraclariGetirByPlakayaGore(string PlakaID, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select PlakaID,MarkaAd,ModelAd,HavalimaniAdi,FirmaAd,Fiyat,KiradaMi,a.ModelID,a.HavalimaniID,a.FirmaID from Araclar a inner join Model m on a.ModelID=m.ModelID inner join Markalar ma on m.MarkaID=ma.MarkaID inner join Havalimanlari h on a.HavalimaniID=h.HavalimaniID inner join Firmalar f on a.FirmaID=f.FirmaID where PlakaID like @ID+'%' and a.Silindi=0", conn);
            comm.Parameters.Add("@ID", SqlDbType.VarChar).Value = PlakaID;
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
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());

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

        public void AracKirala(int ID)
        {

            SqlCommand comm = new SqlCommand("update Araclar set KiradaMi=1 where PlakaID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public bool AracTeslimAl(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Araclar set KiradaMi=0 where PlakaID=@ID", conn);
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
    }
}
