using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portakal.Model
{
    class Otel
    {
        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();

        private string _OdaTipi;
        private string _GirisTarihi;
        private string _CikisTarihi;
        private int _SehirID;
        private string _SehirAd;
        private int _OtelID;
        private string _OtelAd;
        private int _StatuID;
        private string _StatuAd;
        private string _Telefon;
        private string _Adres;

        #region Properties

        public string OdaTipi
        {
            get
            {
                return _OdaTipi;
            }

            set
            {
                _OdaTipi = value;
            }
        }

        public string GirisTarihi
        {
            get
            {
                return _GirisTarihi;
            }

            set
            {
                _GirisTarihi = value;
            }
        }

        public string CikisTarihi
        {
            get
            {
                return _CikisTarihi;
            }

            set
            {
                _CikisTarihi = value;
            }
        }

        public string SehirAd
        {
            get
            {
                return SehirAd1;
            }

            set
            {
                SehirAd1 = value;
            }
        }

        public int SehirID
        {
            get
            {
                return _SehirID;
            }

            set
            {
                _SehirID = value;
            }
        }

        public string SehirAd1
        {
            get
            {
                return _SehirAd;
            }

            set
            {
                _SehirAd = value;
            }
        }

        public string OtelAd
        {
            get
            {
                return _OtelAd;
            }

            set
            {
                _OtelAd = value;
            }
        }
        public int StatuID
        {
            get
            {
                return _StatuID;
            }

            set
            {
                _StatuID = value;
            }
        }

        public string StatuAd
        {
            get
            {
                return _StatuAd;
            }

            set
            {
                _StatuAd = value;
            }
        }
        public string Telefon
        {
            get
            {
                return _Telefon;
            }

            set
            {
                _Telefon = value;
            }
        }
        public string Adres
        {
            get
            {
                return _Adres;
            }

            set
            {
                _Adres = value;
            }
        }
        public int OtelID
        {
            get
            {
                return _OtelID;
            }

            set
            {
                _OtelID = value;
            }
        }
        #endregion

        internal DataSet OtelleriListeleByOtelEkle()
        {
            ds.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select Foto,OtelID,OtelAd,StatuAd,OtelStatu.StatuID,Telefon,Adres,SehirAdi,Sehirler.SehirID from Sehirler inner join Otel on Sehirler.SehirID=Otel.SehirID inner join OtelStatu on Otel.StatuID=OtelStatu.StatuID where Otel.Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Oteller");
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }
        internal DataSet OtelleriFiltreleByOtelEkle(string OtelAd, string StatuAd, string SehirAd)
        {
            SqlDataAdapter da = new SqlDataAdapter("select OtelID,OtelAd,StatuAd,Otel.StatuID,Telefon,Adres,SehirAdi,Otel.SehirID from Sehirler inner join Otel on Sehirler.SehirID=Otel.SehirID inner join OtelStatu on Otel.StatuID=OtelStatu.StatuID where OtelAd like @OtelAd+'%' and  StatuAd like @StatuAd +'%' and SehirAdi like @SehirAd +'%' and Otel.Silindi=0 ", conn);
            da.SelectCommand.Parameters.Add("@OtelAd", SqlDbType.VarChar).Value = OtelAd;
            da.SelectCommand.Parameters.Add("@StatuAd", SqlDbType.VarChar).Value = StatuAd;
            da.SelectCommand.Parameters.Add("@SehirAd", SqlDbType.VarChar).Value = SehirAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Filtre");
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }
        public DataSet OtelleriGetir(Otel o)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Foto,Otel.OtelID,OtelAd,OtelStatu.StatuAd,OdaStatu.StatuAd,TipAd,Fiyat,TipID,OdaSayisi,OdaStatu.StatuID from OtelStatu inner join Otel on OtelStatu.StatuID=Otel.StatuID inner join OdaTipi on Otel.OtelID=OdaTipi.OtelID inner join OdaStatu on OdaTipi.StatuID=OdaStatu.StatuID where Otel.Silindi=0 and TipAd=@TipAdi and Otel.SehirID in (select SehirID from Sehirler where SehirAdi=@Sehir)", conn);
            da.SelectCommand.Parameters.Add("@Sehir", SqlDbType.VarChar).Value = o._SehirAd;
            da.SelectCommand.Parameters.Add("@TipAdi", SqlDbType.VarChar).Value = o._OdaTipi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Oteller");
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }
        public bool OtelEkle(Otel o, PictureBox pbFoto)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Otel (OtelAd,StatuID,Telefon,Adres,SehirID,Foto) values(@OtelAd,@StatuID,@Telefon,@Adres,@SehirID,@Foto)", conn);
            comm.Parameters.Add("@OtelAd", SqlDbType.VarChar).Value = _OtelAd;
            comm.Parameters.Add("@StatuID", SqlDbType.VarChar).Value = _StatuID;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = _Telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = _Adres;
            comm.Parameters.Add("@SehirID", SqlDbType.VarChar).Value = _SehirID;
            MemoryStream ms = new MemoryStream();
            pbFoto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] byteData = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(byteData, 0, Convert.ToInt32(ms.Length));
            SqlParameter parametre = new SqlParameter("@Foto", SqlDbType.Image, byteData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, byteData);
            comm.Parameters.Add(parametre);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public bool OtelKontrol(string SehirID, string OtelAd)
        {
            bool varmi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Otel where Silimdi=0 and SehirID=@SehirID and OtelAd=@OtelAd", conn);
            comm.Parameters.Add("@SehirID", SqlDbType.Int).Value = Convert.ToInt32(SehirID);
            comm.Parameters.Add("@OtelAd", SqlDbType.Int).Value = OtelAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int sayi = Convert.ToInt32(comm.ExecuteScalar());
                if (sayi > 0)
                {
                    varmi = true;
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return varmi;
        }

        public void StatuGetir(ComboBox cb)
        {
            SqlCommand comm = new SqlCommand("select * from OtelStatu where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Otel o = new Otel();
                        o._StatuID = Convert.ToInt32(dr["StatuID"]);
                        o._StatuAd = dr["StatuAd"].ToString();
                        cb.Items.Add(o);
                    }
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public bool OtelKontrolFromDegistir(string SehirID, string OtelAd)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select SehirID,OtelAd from Otel where SehirID!=@SehirID and OtelAd=@OtelAd ", conn);
            comm.Parameters.Add("@SehirID", SqlDbType.Int).Value = Convert.ToInt32(SehirID);
            comm.Parameters.Add("@OtelAd", SqlDbType.VarChar).Value = OtelAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteReader());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public bool OtelDegistir(Otel o, PictureBox pbFoto)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Otel set OtelAd=@OtelAd,StatuID=@StatuID,Telefon=@Telefon,Adres=@Adres,SehirID=@SehirID,Foto=@Foto where OtelID=@OtelID", conn);
            comm.Parameters.Add("@OtelAd", SqlDbType.VarChar).Value = o._OtelAd;
            comm.Parameters.Add("@StatuID", SqlDbType.Int).Value = o._StatuID;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = o._Telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = o._Adres;
            comm.Parameters.Add("@SehirID", SqlDbType.Int).Value = o._SehirID;
            comm.Parameters.Add("@OtelID", SqlDbType.Int).Value = o._OtelID;
            MemoryStream ms = new MemoryStream();
            pbFoto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] byteData = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(byteData, 0, Convert.ToInt32(ms.Length));
            SqlParameter parametre = new SqlParameter("@Foto", SqlDbType.Image, byteData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, byteData);
            comm.Parameters.Add(parametre);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int sayi = comm.ExecuteNonQuery();
                if (sayi > 0)
                {
                    sonuc = true;
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public bool OtelSil(string OtelID, string SehirID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Otel set Silindi=1 where OtelID=@OtelID and SehirID=@SehirID", conn);
            comm.Parameters.Add("@SehirID", SqlDbType.Int).Value = Convert.ToInt32(SehirID);
            comm.Parameters.Add("@OtelID", SqlDbType.Int).Value = Convert.ToInt32(OtelID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        internal void OzellikleriGetir(string StatuID, CheckBox cb)
        {
            SqlCommand comm = new SqlCommand("select OzellikAd from OdaStatu inner join OdaOzellik on OdaStatu.StatuID=OdaOzellik.StatuID where OdaOzellik.StatuID=@StatuID", conn);
            comm.Parameters.Add("@StatuID", SqlDbType.Int).Value = Convert.ToInt32(StatuID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cb.Text = dr[0].ToString();
                }
                dr.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void SonKalanOdaSayisi(int OdaID, System.Windows.Forms.Label lbl)
        {
            SqlCommand comm = new SqlCommand("select OdaSayisi from OdaTipi where TipID=@OdaID and Silindi=0 ", conn);
            comm.Parameters.Add("@OdaID", SqlDbType.VarChar).Value = OdaID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    lbl.Text = "Kalan Son " + dr[0].ToString() + " oda";
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }
        internal void OdaSayisiniGüncelle(int odaTipiID)
        {
            SqlCommand comm = new SqlCommand("update OdaTipi set OdaSayisi=OdaSayisi-1 where TipID=@TipID", conn);
            comm.Parameters.Add("@TipID", SqlDbType.Int).Value = odaTipiID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public override string ToString()
        {
            return _StatuAd;
        }


    }
}
