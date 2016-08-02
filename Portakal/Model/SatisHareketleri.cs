using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portakal.Model
{
    class SatisHareketleri
    {
        SqlConnection conn = new SqlConnection(Genel.connStr);
        #region porp
        private int _satisID;

        public int SatisID
        {
            get { return _satisID; }
            set { _satisID = value; }
        }
        private int _musteriID;

        public int MusteriID
        {
            get { return _musteriID; }
            set { _musteriID = value; }
        }
        private DateTime _tarih;

        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }
        private int _ucusID;

        public int UcusID
        {
            get { return _ucusID; }
            set { _ucusID = value; }
        }
        private int _adet;

        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }
        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private double _birimFiyat;

        public double BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        }
        private double _tutar;

        public double Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        }
        private string _tekilKod;

        public string TekilKod
        {
            get { return _tekilKod; }
            set { _tekilKod = value; }
        }

        private int _ekstraBagajKilosu;

        public int EkstraBagajKilosu
        {
            get { return _ekstraBagajKilosu; }
            set { _ekstraBagajKilosu = value; }
        }
        private double _ToplamTutar;

        public double ToplamTutar
        {
            get { return _ToplamTutar; }
            set { _ToplamTutar = value; }
        } 
        #endregion


        DataTable dt = new DataTable();

        public bool HareketEkle(SatisHareketleri sh)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into SatisHareketleri(MusteriID, UcusID, Adet, Status, BirimFiyat, Tutar, TekilKod, EkstraBagajKilosu, ToplamTutar) values (@MusteriID, @UcusID, @Adet, @Status, @BirimFiyat, @Tutar, @TekilKod, @EkstraBagajKilosu, @ToplamTutar)", conn);
            comm.Parameters.Add("MusteriID", SqlDbType.Int).Value = sh._musteriID;
            comm.Parameters.Add("UcusID", SqlDbType.Int).Value = sh._ucusID;
            comm.Parameters.Add("Adet", SqlDbType.Int).Value = sh._adet;
            comm.Parameters.Add("Status", SqlDbType.VarChar).Value = sh._status;
            comm.Parameters.Add("BirimFiyat", SqlDbType.Money).Value = sh._birimFiyat;
            comm.Parameters.Add("Tutar", SqlDbType.Money).Value = sh._tutar;
            comm.Parameters.Add("TekilKod", SqlDbType.VarChar).Value = sh._tekilKod;
            comm.Parameters.Add("EkstraBagajKilosu", SqlDbType.Int).Value = sh._ekstraBagajKilosu;
            comm.Parameters.Add("ToplamTutar", SqlDbType.Money).Value = sh._ToplamTutar;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string s = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public DataTable SatislariGetir(DateTime baslangic, DateTime bitis, string HavayoluAdi)
        {
            SqlDataAdapter da = new SqlDataAdapter("select sh.SatisID, h.HavayoluAdi, sh.MusteriID, m.MusteriAdi+' '+m.MusteriSoyadi, sh.Tarih, sh.Adet, sh.Status, sh.ToplamTutar, sh.TekilKod from satishareketleri sh inner join Musteriler m on m.MusteriID=sh.MusteriID inner join ucuslar uc on uc.UcusID=sh.UcusID inner join Ucaklar u on u.UcakID=uc.UcakID inner join Havayollari h on  u.HavayollariID=h.HavayoluID where Tarih<=@TarihBuyuk and @TarihKucuk<Tarih and sh.Silindi=0 and h.HavayoluAdi like @havayolu+'%'", conn);
            da.SelectCommand.Parameters.Add("@TarihBuyuk", SqlDbType.DateTime).Value = bitis;
            da.SelectCommand.Parameters.Add("@TarihKucuk", SqlDbType.DateTime).Value = baslangic;
            da.SelectCommand.Parameters.Add("@havayolu", SqlDbType.VarChar).Value = HavayoluAdi;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string s = ex.Message;
            }
            finally { conn.Close(); }
            return dt;
        }
        public void KoltukAzalt(string tipi, int sayi, int ID)
        {
            SqlCommand comm;
            if (tipi == "Ekonomi")
            {
                comm = new SqlCommand("update Ucuslar set EkonimikBosKoltuk=EkonimikBosKoltuk-@Miktar where UcusID=@ucusID", conn);
            }

            else if (tipi == "FirstClass")
            {
                comm = new SqlCommand("update Ucuslar set FirstClassBosKoltuk=FirstClassBosKoltuk-@Miktar where UcusID=@ucusID", conn);
            }

            else
            {
                comm = new SqlCommand("update Ucuslar set BusinessClassBosKoltuk=BusinessClassBosKoltuk-@Miktar where UcusID=@ucusID", conn);
            }
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = sayi;
            comm.Parameters.Add("@ucusID", SqlDbType.Int).Value = ID;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                string s = ex.Message;
            }
            finally { conn.Close(); }
        }
    }
}
