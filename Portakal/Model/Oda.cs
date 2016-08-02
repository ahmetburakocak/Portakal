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
    class Oda
    {
        private int _otelID;
        private string _tipAd;
        private int _odasayisi;
        private int _statuID;
        private string _statuAd;
        private decimal _fiyat;
        private string _aciklama;

        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();

        #region Properties
        public int OtelID
        {
            get
            {
                return _otelID;
            }

            set
            {
                _otelID = value;
            }
        }

        public string TipAd
        {
            get
            {
                return _tipAd;
            }

            set
            {
                _tipAd = value;
            }
        }
        public int Odasayisi
        {
            get
            {
                return _odasayisi;
            }

            set
            {
                _odasayisi = value;
            }
        }

        public int StatuID
        {
            get
            {
                return _statuID;
            }

            set
            {
                _statuID = value;
            }
        }

        public string StatuAd
        {
            get
            {
                return _statuAd;
            }

            set
            {
                _statuAd = value;
            }
        }

        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return _aciklama;
            }

            set
            {
                _aciklama = value;
            }
        }
        #endregion

        internal DataSet SehirleriGetir(ComboBox cb)
        {
            SqlCommand comm = new SqlCommand("select SehirAdi from Sehirler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }
        internal string SehirIDGetir(string SehirAd)
        {
            string sonuc = null;
            SqlCommand comm = new SqlCommand("select SehirID from Sehirler where SehirAdi=@SehirAd", conn);
            comm.Parameters.Add("@SehirAd", SqlDbType.VarChar).Value = SehirAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = comm.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        internal void OtelGetir(ComboBox cbOtel, int SehirID)
        {
            SqlCommand comm = new SqlCommand("select OtelAd from Otel where Silindi=0 and SehirID=@SehirID", conn);
            comm.Parameters.Add("@SehirID", SqlDbType.Int).Value = SehirID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cbOtel.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }
        internal string OtelIDGetir(string OtelAd)
        {
            string sonuc = null;
            SqlCommand comm = new SqlCommand("select OtelID from Otel where OtelAd=@OtelAd and Silindi=0", conn);
            comm.Parameters.Add("@OtelAd", SqlDbType.VarChar).Value = OtelAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = comm.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return sonuc;
        }
        public bool StatuKontrol(string StatuAd)
        {
            bool varmi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from OdaStatu where StatuAd=@StatuAd", conn);
            comm.Parameters.Add("@StatuAd", SqlDbType.VarChar).Value = StatuAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (Sayisi > 0)
            {
                varmi = true;
            }
            conn.Close();
            return varmi;
        }
        internal int OdaStatuEkle(string StatuAd)
        {
            int kayıtno = 0;
            SqlCommand comm = new SqlCommand("insert into OdaStatu (StatuAd) values(@StatuAd); select Scope_Identity()", conn);
            comm.Parameters.Add("StatuAd", SqlDbType.VarChar).Value = StatuAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                kayıtno = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return kayıtno;
        }
        internal void OdaTipleriniGetir(ComboBox cb)
        {
            SqlCommand comm = new SqlCommand("select TipAd from OdaTipi where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }
        public bool OdaTipiKontrol(string OtelID, string OdaTipi)
        {
            bool varmi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from OdaTipi where OtelID=@OtelID and TipAd=@OdaTipi", conn);
            comm.Parameters.Add("@OdaTipi", SqlDbType.VarChar).Value = OdaTipi;
            comm.Parameters.Add("OtelID", SqlDbType.Int).Value = Convert.ToInt32(OtelID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (Sayisi > 0)
            {
                varmi = true;
            }
            conn.Close();
            return varmi;
        }
        internal bool OdaTipiEkle(string TipAd, string odasayisi, string OtelID, int statuId, string fiyat, string aciklama)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into OdaTipi (TipAd,OdaSayisi,OtelID,StatuID,Fiyat,Aciklama) values(@TipAd,@OdaSayisi,@OtelID,@StatuID,@Fiyat,@Aciklama)", conn);
            comm.Parameters.Add("@TipAd", SqlDbType.VarChar).Value = TipAd;
            comm.Parameters.Add("@OdaSayisi", SqlDbType.Int).Value = Convert.ToInt32(odasayisi);
            comm.Parameters.Add("@OtelID", SqlDbType.Int).Value = Convert.ToInt32(OtelID);
            comm.Parameters.Add("@StatuID", SqlDbType.Int).Value = Convert.ToInt32(statuId);
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = Convert.ToDecimal(fiyat);
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = aciklama;
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
        internal bool OzellikEkle(ListBox liste, int statuid)
        {
            bool sonuc = false;
            for (int i = 0; i < liste.Items.Count; i++)
            {
                string ozellikad = liste.Items[i].ToString();
                SqlCommand comm = new SqlCommand("insert into OdaOzellik (OzellikAd,StatuID) values(@OzellikAd,@StatuID)", conn);
                comm.Parameters.Add("@StatuID", SqlDbType.Int).Value = Convert.ToInt32(statuid);
                comm.Parameters.Add("@OzellikAd", SqlDbType.VarChar).Value = ozellikad;
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
            }
            conn.Close();
            return sonuc;
        }
    }
}
