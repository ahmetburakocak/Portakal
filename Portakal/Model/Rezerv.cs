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
    class Rezerv
    {
        private int _MusteriID;
        private string _MusteriTc;
        private string _MusteriAd;
        private string _MusteriSoyad;
        private string _EvTelefon;
        private string _CepTelefon;
        private string _Adres;
        private int _SehirID;
        private string _Sehir;
        private string _GirisTarihi;
        private string _CikisTarihi;
        private int _Adet;
        private decimal _Fiyat;
        private int _TipID;
        private int _OtelID;
        private int _RezervasyonID;

      

        #region Properties
        public string MusteriAd
        {
            get
            {
                return _MusteriAd;
            }

            set
            {
                _MusteriAd = value;
            }
        }
        public string MusteriSoyad
        {
            get
            {
                return _MusteriSoyad;
            }

            set
            {
                _MusteriSoyad = value;
            }
        }

        public string EvTelefon
        {
            get
            {
                return _EvTelefon;
            }

            set
            {
                _EvTelefon = value;
            }
        }

        public string CepTelefon
        {
            get
            {
                return _CepTelefon;
            }

            set
            {
                _CepTelefon = value;
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
        public string MusteriTc
        {
            get
            {
                return _MusteriTc;
            }

            set
            {
                _MusteriTc = value;
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

        public int Adet
        {
            get
            {
                return _Adet;
            }

            set
            {
                _Adet = value;
            }
        }

        public decimal Fiyat
        {
            get
            {
                return _Fiyat;
            }

            set
            {
                _Fiyat = value;
            }
        }
        public int TipID
        {
            get
            {
                return _TipID;
            }

            set
            {
                _TipID = value;
            }
        }

        public int MusteriID
        {
            get
            {
                return _MusteriID;
            }

            set
            {
                _MusteriID = value;
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

        public string Sehir
        {
            get
            {
                return _Sehir;
            }

            set
            {
                _Sehir = value;
            }
        }

        public int RezervasyonID
        {
            get
            {
                return _RezervasyonID;
            }

            set
            {
                _RezervasyonID = value;
            }
        }
        #endregion
        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();
        internal DataSet MusterileriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MusteriID,MusteriAdi,MusteriSoyadi,TCKimlikNo,CepTelefonu,EvTelefonu,Adres,SehirAdi,Sehirler.SehirID from Musteriler inner join Sehirler on Musteriler.SehirID=Sehirler.SehirID where Musteriler.Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Musteriler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }
        internal bool MusteriKontrol(Rezerv r)
        {
            bool varmi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Musteriler where TcKimlikNo=@MusteriTc", conn);
            comm.Parameters.Add("@MusteriTc", SqlDbType.VarChar).Value = r.MusteriTc;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int sayi = 0;
            try
            {
                sayi = Convert.ToInt32(comm.ExecuteScalar());
                if (sayi > 0)
                {
                    varmi = true;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return varmi;
        }
        internal int MusteriKaydet(Rezerv r)
        {
            int sonuc = 0;
            SqlCommand comm = new SqlCommand("insert into Musteriler(MusteriAdi,MusteriSoyadi,EvTelefonu,CepTelefonu,Adres,SehirID,TcKimlikNo) values (@MusteriAd,@MusteriSoyad,@EvTelefonu,@CepTelefonu,@Adres,@SehirID,@TcKimlikNo); Select SCOPE_IDENTITY()", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = _MusteriAd;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = _MusteriSoyad;
            comm.Parameters.Add("@EvTelefonu", SqlDbType.VarChar).Value = _EvTelefon;
            comm.Parameters.Add("@CepTelefonu", SqlDbType.VarChar).Value = _CepTelefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = _Adres;
            comm.Parameters.Add("@SehirID", SqlDbType.Int).Value = _SehirID;
            comm.Parameters.Add("@TcKimlikNo", SqlDbType.VarChar).Value = _MusteriTc;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return sonuc;
        }
        internal int rezervasyonKaydet(Rezerv r)
        {
            int sonuc = 0;
            SqlCommand comm = new SqlCommand("insert into Rezervasyon (GirisTarihi,CikisTarihi,MusteriID,OtelID,Adet,ToplamFiyat,TipID) values (@GirisTarihi,@CikisTarihi,@MusteriID,@OtelID,@Adet,@ToplamFiyat,@TipID); Select SCOPE_IDENTITY()", conn);
            comm.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(_GirisTarihi);
            comm.Parameters.Add("@CikisTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(_CikisTarihi);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = _MusteriID;
            comm.Parameters.Add("@OtelID", SqlDbType.Int).Value = _OtelID;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = _Adet;
            comm.Parameters.Add("@ToplamFiyat", SqlDbType.Money).Value = _Fiyat;
            comm.Parameters.Add("@TipID", SqlDbType.Int).Value = _TipID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        internal bool RezervDurumuDegistir(Rezerv r)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into RezDurum (TipID,VarisTarihi,AyrilisTarihi,RezerveMi,RezervasyonID) values(@TipID,@GirisTarihi,@CikisTarihi,@RezervMi,@RezervasyonID)", conn);
            comm.Parameters.Add("@RezervasyonID", SqlDbType.Int).Value = _RezervasyonID;
            comm.Parameters.Add("@TipID", SqlDbType.Int).Value = _TipID;
            comm.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(_GirisTarihi);
            comm.Parameters.Add("@CikisTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(_CikisTarihi);
            comm.Parameters.Add("@RezervMi", SqlDbType.Bit).Value = true;
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
        internal DataSet rezervasyonBilgileriGetir(int musteriID)
        {
            SqlDataAdapter da = new SqlDataAdapter("select RezervasyonID,RezTarihi,GirisTarihi,CikisTarihi,Rezervasyon.MusteriID,Rezervasyon.OtelID,OtelAd,TipAd,ToplamFiyat,Rezervasyon.TipID from Rezervasyon inner join OdaTipi on Rezervasyon.TipID=OdaTipi.TipID inner join Otel on OdaTipi.OtelID=Otel.OtelID where MusteriID=@MusteriID", conn);
            da.SelectCommand.Parameters.Add("@MusteriID", SqlDbType.Int).Value = musteriID;
            try
            {
                da.Fill(ds, "Rezervasyon");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }
        internal void SehileriGetir(ComboBox cbSehirler)
        {
            SqlCommand comm = new SqlCommand("select SehirID,SehirAdi from Sehirler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Rezerv r = new Rezerv();
                    r._SehirID = Convert.ToInt32(dr[0]);
                    r._Sehir = dr[1].ToString();
                    cbSehirler.Items.Add(r);
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }
        public override string ToString()
        {
            return _Sehir;
        }
        internal int RezervleriKontrolEt()
        {
            int sayi = 0;
            SqlCommand comm = new SqlCommand("select Count(*) from RezDurum where AyrilisTarihi=GetDate()", conn);
            if (conn.State == ConnectionState.Closed) conn.Close();
            try
            {
                sayi = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sayi;
        }
        internal int RezDurumuGuncelle()
        {
            int id = 0;
            SqlCommand comm = new SqlCommand("update RezDurum set RezerveMi='False' where AyrilisTarihi=GETDATE(); select scope_identity", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                id=Convert.ToInt32(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return id;
        }
        internal void idBul(int id,string OtelID,string tipID)
        {
            SqlCommand comm = new SqlCommand("select OtelID,TipID from RezDurumu where DurumID=@id", conn);
            comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    OtelID = dr[0].ToString();
                    tipID = dr[1].ToString();
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }
        internal void odasayisiniguncelle(TextBox txtoid, TextBox txttid)
        {
            SqlCommand comm = new SqlCommand("update OdaTipi set OdaSayisi=OdaSayisi+1 where OtelID=@OtelID and TipID=@TipID", conn);
            comm.Parameters.Add("@OtelID", SqlDbType.Int).Value = Convert.ToInt32(txtoid);
            comm.Parameters.Add("@TipID", SqlDbType.Int).Value = Convert.ToInt32(txttid);
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
    }
}
