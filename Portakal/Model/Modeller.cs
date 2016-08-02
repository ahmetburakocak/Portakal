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
    class Modeller
    {
        private int _modelID;
        private int _markaID;
        private string _modelAd;
        private string _aciklama;
        private int _modelResmi;
        private int _sinifID;
        private string _klima;
        private string _vitesTipi;
        private string _yakitTipi;


        #region Properties
        public int SinifID
        {
            get { return _sinifID; }
            set { _sinifID = value; }
        }

        public string Klima
        {
            get { return _klima; }
            set { _klima = value; }
        }

        public string VitesTipi
        {
            get { return _vitesTipi; }
            set { _vitesTipi = value; }
        }


        public string YakitTipi
        {
            get { return _yakitTipi; }
            set { _yakitTipi = value; }
        }
        public int ModelID
        {
            get { return _modelID; }
            set { _modelID = value; }
        }

        public int MarkaID
        {
            get { return _markaID; }
            set { _markaID = value; }
        }

        public string ModelAd
        {
            get { return _modelAd; }
            set { _modelAd = value; }
        }

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }


        public int ModelResmi
        {
            get { return _modelResmi; }
            set { _modelResmi = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void ModelleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select SinifAd, MarkaAd, ModelAd, Klima, VitesTipi, YakitTipi,Model.Aciklama,Model.SinifID,Model.MarkaID,ModelID,ModelResmi from Model inner join AracSinifi a on Model.SinifID=a.SinifID inner join Markalar m on Model.MarkaID=m.MarkaID where Model.Silindi=0", conn);
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
                        liste.Items[i].SubItems.Add(dr[10].ToString());


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



        public bool ModelVarmi(int MarkaID, string ModelAd)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Model where MarkaID=@MarkaID and ModelAd=@ModelAd and Silindi=0", conn);
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = MarkaID;
            comm.Parameters.Add("@ModelAd", SqlDbType.VarChar).Value = ModelAd;
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

        public bool ModelEkle(Modeller m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Model (SinifID,MarkaID,ModelAd,Klima,VitesTipi,YakitTipi,Aciklama,ModelResmi) values (@SinifID,@MarkaID,@ModelAd,@Klima,@VitesTipi,@YakitTipi,@Aciklama,@ModelResmi)", conn);
            comm.Parameters.Add("@SinifID", SqlDbType.Int).Value = m._sinifID;
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = m._markaID;
            comm.Parameters.Add("@ModelAd", SqlDbType.VarChar).Value = m._modelAd;
            comm.Parameters.Add("@Klima", SqlDbType.VarChar).Value = m._klima;
            comm.Parameters.Add("@VitesTipi", SqlDbType.VarChar).Value = m._vitesTipi;
            comm.Parameters.Add("@YakitTipi", SqlDbType.VarChar).Value = m._yakitTipi;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = m._aciklama;
            comm.Parameters.Add("@ModelResmi", SqlDbType.Int).Value = m._modelResmi;
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

        public bool ModelGuncelleVarmi(string ModelAd, int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Model where ModelAd=@ModelAd and ModelID!=@ID and Silindi=0", conn);
            comm.Parameters.Add("@ModelAd", SqlDbType.VarChar).Value = ModelAd;
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

        public bool ModelGuncelle(Modeller m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Model set SinifID=@SinifID,MarkaID=@MarkaID,ModelAd=@ModelAd,Klima=@Klima,VitesTipi=@VitesTipi,YakitTipi=@YakitTipi, Aciklama=@Aciklama,ModelResmi=@ModelResmi where ModelID=@ModelID", conn);
            comm.Parameters.Add("@SinifID", SqlDbType.Int).Value = m._sinifID;
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = m._markaID;
            comm.Parameters.Add("@ModelAd", SqlDbType.VarChar).Value = m._modelAd;
            comm.Parameters.Add("@Klima", SqlDbType.VarChar).Value = m._klima;
            comm.Parameters.Add("@VitesTipi", SqlDbType.VarChar).Value = m._vitesTipi;
            comm.Parameters.Add("@YakitTipi", SqlDbType.VarChar).Value = m._yakitTipi;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = m._aciklama;
            comm.Parameters.Add("@ModelResmi", SqlDbType.Int).Value = m._modelResmi;
            comm.Parameters.Add("@ModelID", SqlDbType.Int).Value = m._modelID;

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

        public bool ModelSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Model set Silindi=1 where ModelID=@ID", conn);
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

        public void ModelleriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select ModelAd from Model where Silindi=0", conn);
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


        public int ModelIDGetir(string ModelAd)
        {
            SqlCommand comm = new SqlCommand("select ModelID from Model where Silindi=0 and ModelAd=@Ad", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = ModelAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int ID = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return ID;
        }

        public void MarkayaGoreModelGetir(ComboBox liste, int ID)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select ModelAd from Model where MarkaID=@ID and Silindi=0", conn);
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



        public void ModelleriGetir(ComboBox liste, int ID)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select ModelAd from Model m inner join Markalar ma  on m.MarkaID=ma.MarkaID where m.MarkaID=@ID and m.Silindi=0 ", conn);
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

        public int ResimIDGetir(string ModelAd)
        {
            SqlCommand comm = new SqlCommand("select ID from AracResim where ModelAd=@Ad", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = ModelAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int ID = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return ID;
        }

        public void ModelleriGetirByAdaGore(string Ad, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select SinifAd, MarkaAd, ModelAd, Klima, VitesTipi, YakitTipi,Model.Aciklama,Model.SinifID,Model.MarkaID,ModelID,ModelResmi from Model inner join AracSinifi a on Model.SinifID=a.SinifID inner join Markalar m on Model.MarkaID=m.MarkaID where ModelAd like  @Ad+'%' and Model.Silindi=0", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Ad;
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
                        liste.Items[i].SubItems.Add(dr[10].ToString());


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
