using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portakal.Model
{
    class Ucus
    {

        #region propperties

        private int _ucusID;

        public int UcusID
        {
            get { return _ucusID; }
            set { _ucusID = value; }
        }
        private string _ucusAdi;

        public string UcusAdi
        {
            get { return _ucusAdi; }
            set { _ucusAdi = value; }
        }
        private int _ucakID;

        public int UcakID
        {
            get { return _ucakID; }
            set { _ucakID = value; }
        }
        private int _kalkisYeriID;

        public int KalkisYeriID
        {
            get { return _kalkisYeriID; }
            set { _kalkisYeriID = value; }
        }
        private int _inisYeriID;

        public int InisYeriID
        {
            get { return _inisYeriID; }
            set { _inisYeriID = value; }
        }
        private DateTime _ucusTarihi;

        public DateTime UcusTarihi
        {
            get { return _ucusTarihi; }
            set { _ucusTarihi = value; }
        }

        private int _firstClassBosKoltuk;

        public int FirstClassBosKoltuk
        {
            get { return _firstClassBosKoltuk; }
            set { _firstClassBosKoltuk = value; }
        }
        private int _businessClassBosKoltuk;

        public int BusinessClassBosKoltuk
        {
            get { return _businessClassBosKoltuk; }
            set { _businessClassBosKoltuk = value; }
        }
        private int _ekonomikBosKoltuk;

        public int EkonomikBosKoltuk
        {
            get { return _ekonomikBosKoltuk; }
            set { _ekonomikBosKoltuk = value; }
        }
        private double _ekonomikFiyat;

        public double EkonomikFiyat
        {
            get { return _ekonomikFiyat; }
            set { _ekonomikFiyat = value; }
        }
        private double _firstClassFiyat;

        public double FirstClassFiyat
        {
            get { return _firstClassFiyat; }
            set { _firstClassFiyat = value; }
        }
        private double _businessClassFiyat;

        public double BusinessClassFiyat
        {
            get { return _businessClassFiyat; }
            set { _businessClassFiyat = value; }
        }
        private double _ekstraBagajFiyat;

        public double EkstraBagajFiyat
        {
            get { return _ekstraBagajFiyat; }
            set { _ekstraBagajFiyat = value; }
        }

        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataTable dt = new DataTable();

        public DataTable UcuslariGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select u.UcusID, u.UcusAdi, u.UcakID, uc.UcakAdi, u.KalkisYeriID, Kalkisyeri=(select distinct havalimaniadi from Havalimanlari h where h.havalimaniID=u.KalkisYeriID), u.InisYeriID, InisYeri=(select distinct havalimaniadi from Havalimanlari h where h.havalimaniID=u.InisYeriID), u.EkonimikBosKoltuk, u.BusinessClassBosKoltuk, u.FirstClassBosKoltuk, u.EkonomikFiyat, u.BusinessClassFiyat, u.FirstClassFiyat, u.EkstraBagajFiyat, u.UcusTarihi from Ucuslar u inner join Ucaklar uc on uc.UcakID=u.UcakID where U.silindi=0", conn);
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

        public string UcusAdiGetir(string kisaltma)
        {
            List<string> adlar = new List<string>();
            SqlCommand comm = new SqlCommand("Select UcusAdi from Ucuslar", conn);
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
            string ucusAdi = "";
            bool deger = true;
            while (deger)
            {
                Random rnd = new Random();
                int a = rnd.Next(1000, 9999);
                ucusAdi = kisaltma + a.ToString() + "FL";
                foreach (string kayit in adlar)
                {
                    if (kayit == ucusAdi)
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
            return ucusAdi;
        }

        public bool UcusVarMi(DateTime YolculukTarihi, string UcakID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Ucuslar where UcakID = @UcakID and Convert(Varchar, UcusTarihi, 104) = Convert(Varchar, @UcusTarihi, 104) and silindi=0", conn);
            comm.Parameters.Add("@UcakID", SqlDbType.Int).Value = UcakID;
            comm.Parameters.Add("@UcusTarihi", SqlDbType.DateTime).Value = YolculukTarihi;
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

        public bool UcusEkle(Ucus u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Ucuslar (BusinessClassBosKoltuk, BusinessClassFiyat, EkonimikBosKoltuk, EkonomikFiyat, EkstraBagajFiyat, FirstClassBosKoltuk, FirstClassFiyat, InisYeriID, KalkisYeriID, UcakID, UcusAdi, UcusTarihi) values (@BusinessClassBosKoltuk, @BusinessClassFiyat, @EkonimikBosKoltuk, @EkonomikFiyat, @EkstraBagajFiyat, @FirstClassBosKoltuk, @FirstClassFiyat, @InisYeriID, @KalkisYeriID, @UcakID, @UcusAdi, @UcusTarihi)", conn);
            comm.Parameters.Add("@BusinessClassBosKoltuk", SqlDbType.Int).Value = u._businessClassBosKoltuk;
            comm.Parameters.Add("@BusinessClassFiyat", SqlDbType.Money).Value = u._businessClassFiyat;
            comm.Parameters.Add("@EkonimikBosKoltuk", SqlDbType.Int).Value = u._ekonomikBosKoltuk;
            comm.Parameters.Add("@EkonomikFiyat", SqlDbType.Money).Value = u._ekonomikFiyat;
            comm.Parameters.Add("@EkstraBagajFiyat", SqlDbType.Money).Value = u._ekstraBagajFiyat;
            comm.Parameters.Add("@FirstClassBosKoltuk", SqlDbType.Int).Value = u._firstClassBosKoltuk;
            comm.Parameters.Add("@FirstClassFiyat", SqlDbType.Money).Value = u._firstClassFiyat;
            comm.Parameters.Add("@InisYeriID", SqlDbType.Int).Value = u._inisYeriID;
            comm.Parameters.Add("@KalkisYeriID", SqlDbType.Int).Value = u._kalkisYeriID;
            comm.Parameters.Add("@UcakID", SqlDbType.Int).Value = u._ucakID;
            comm.Parameters.Add("@UcusAdi", SqlDbType.VarChar).Value = u._ucusAdi;
            comm.Parameters.Add("@UcusTarihi", SqlDbType.DateTime).Value = u._ucusTarihi;
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

        public bool UcusGuncelle(Ucus u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Ucuslar set BusinessClassBosKoltuk=@BusinessClassBosKoltuk, BusinessClassFiyat=@BusinessClassFiyat, EkonimikBosKoltuk=@EkonimikBosKoltuk, EkonomikFiyat=@EkonomikFiyat, EkstraBagajFiyat=@EkstraBagajFiyat, FirstClassBosKoltuk=@FirstClassBosKoltuk, FirstClassFiyat=@FirstClassFiyat, InisYeriID=@InisYeriID, KalkisYeriID=@KalkisYeriID, UcakID=@UcakID, UcusAdi=@UcusAdi, UcusTarihi= @UcusTarihi where UcusID=@UcusID", conn);
            comm.Parameters.Add("@BusinessClassBosKoltuk", SqlDbType.Int).Value = u._businessClassBosKoltuk;
            comm.Parameters.Add("@BusinessClassFiyat", SqlDbType.Money).Value = u._businessClassFiyat;
            comm.Parameters.Add("@EkonimikBosKoltuk", SqlDbType.Int).Value = u._ekonomikBosKoltuk;
            comm.Parameters.Add("@EkonomikFiyat", SqlDbType.Money).Value = u._ekonomikFiyat;
            comm.Parameters.Add("@EkstraBagajFiyat", SqlDbType.Money).Value = u._ekstraBagajFiyat;
            comm.Parameters.Add("@FirstClassBosKoltuk", SqlDbType.Int).Value = u._firstClassBosKoltuk;
            comm.Parameters.Add("@FirstClassFiyat", SqlDbType.Money).Value = u._firstClassFiyat;
            comm.Parameters.Add("@InisYeriID", SqlDbType.Int).Value = u._inisYeriID;
            comm.Parameters.Add("@KalkisYeriID", SqlDbType.Int).Value = u._kalkisYeriID;
            comm.Parameters.Add("@UcakID", SqlDbType.Int).Value = u._ucakID;
            comm.Parameters.Add("@UcusAdi", SqlDbType.VarChar).Value = u._ucusAdi;
            comm.Parameters.Add("@UcusTarihi", SqlDbType.DateTime).Value = u._ucusTarihi;
            comm.Parameters.Add("@UcusID", SqlDbType.Int).Value = u._ucusID;
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

        public bool UcusSil(int UcusID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update ucuslar set Silindi=1 where UcusID=@UcusID", conn);
            comm.Parameters.Add("@UcusID", SqlDbType.Int).Value = UcusID;
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



        public DataTable UcuslariGetirBySorgulama(int KalkisID, int VarisID, DateTime Tarih, int KisiSayisi, string BiletTipi, bool TekyYon)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            if (BiletTipi == "Ekonomi")
            {
                da = new SqlDataAdapter("select u.UcusID, u.UcusAdi, u.UcakID, uc.UcakAdi, ha.HavayoluAdi, u.KalkisYeriID, Kalkisyeri=(select distinct havalimaniadi from Havalimanlari h where h.havalimaniID=u.KalkisYeriID), u.InisYeriID, InisYeri=(select distinct havalimaniadi from Havalimanlari h where h.havalimaniID=u.InisYeriID), u.EkonimikBosKoltuk, u.EkonomikFiyat, u.EkstraBagajFiyat, u.UcusTarihi from Ucuslar u inner join Ucaklar uc on uc.UcakID=u.UcakID inner join  Havayollari ha on ha.HavayoluID = uc.HavayollariID where U.silindi=0 and u.KalkisYeriID=@KalkisYeri and u.InisYeriID=@InisYeri and Convert(Varchar, UcusTarihi, 104) = Convert(Varchar, @UcusTarihi, 104) and  u.EkonimikBosKoltuk>=@KisiSayisi", conn);
            }

            else if (BiletTipi == "FirstClass")
            {
                da = new SqlDataAdapter("select u.UcusID, u.UcusAdi, u.UcakID, uc.UcakAdi, ha.HavayoluAdi, u.KalkisYeriID, Kalkisyeri=(select distinct havalimaniadi from Havalimanlari h where h.havalimaniID=u.KalkisYeriID), u.InisYeriID, InisYeri=(select distinct havalimaniadi from Havalimanlari h where h.havalimaniID=u.InisYeriID), u.FirstClassBosKoltuk, u.FirstClassFiyat, u.EkstraBagajFiyat, u.UcusTarihi from Ucuslar u inner join Ucaklar uc on uc.UcakID=u.UcakID inner join  Havayollari ha on ha.HavayoluID = uc.HavayollariID where U.silindi=0 and u.KalkisYeriID=@KalkisYeri and u.InisYeriID=@InisYeri and u.InisYeriID=@InisYeri and Convert(Varchar, UcusTarihi, 104) = Convert(Varchar, @UcusTarihi, 104) and  u.FirstClassBosKoltuk>=@KisiSayisi", conn);
            }

            else
            {
                da = new SqlDataAdapter("select u.UcusID, u.UcusAdi, u.UcakID, uc.UcakAdi, ha.HavayoluAdi, u.KalkisYeriID, Kalkisyeri=(select distinct havalimaniadi from Havalimanlari h where h.havalimaniID=u.KalkisYeriID), u.InisYeriID, InisYeri=(select distinct havalimaniadi from Havalimanlari h where h.havalimaniID=u.InisYeriID), u.BusinessClassBosKoltuk, u.BusinessClassFiyat, u.EkstraBagajFiyat, u.UcusTarihi from Ucuslar u inner join Ucaklar uc on uc.UcakID=u.UcakID inner join  Havayollari ha on ha.HavayoluID = uc.HavayollariID where U.silindi=0 and u.KalkisYeriID=@KalkisYeri and u.InisYeriID=@InisYeri and u.InisYeriID=@InisYeri and Convert(Varchar, UcusTarihi, 104) = Convert(Varchar, @UcusTarihi, 104) and  u.BusinessClassBosKoltuk>=@KisiSayisi", conn);
            }
            da.SelectCommand.Parameters.Add("@KalkisYeri", SqlDbType.Int).Value = KalkisID;
            da.SelectCommand.Parameters.Add("@InisYeri", SqlDbType.Int).Value = VarisID;
            da.SelectCommand.Parameters.Add("@UcusTarihi", SqlDbType.DateTime).Value = Tarih;
            da.SelectCommand.Parameters.Add("@KisiSayisi", SqlDbType.Int).Value = KisiSayisi;
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



        public Ucus BilgiGetirFiyat(int p)
        {
            SqlCommand commm = new SqlCommand("select u.BusinessClassFiyat, u.EkstraBagajFiyat, u.EkonomikFiyat, u.FirstClassFiyat from Ucuslar u inner join Ucaklar uc on uc.UcakID=u.UcakID inner join  Havayollari ha on ha.HavayoluID = uc.HavayollariID where U.silindi=0 and ucusID=@UcusID", conn);
            Ucus u = new Ucus();
            commm.Parameters.Add("@UcusID", SqlDbType.Int).Value = p;
            SqlDataReader dr;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                dr = commm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        u._businessClassFiyat = Convert.ToDouble(dr[0]);
                        u._ekstraBagajFiyat = Convert.ToDouble(dr[1]);
                        u._ekonomikFiyat = Convert.ToDouble(dr[2]);
                        u._firstClassFiyat = Convert.ToDouble(dr[3]);
                    }
                } dr.Close();
            }
            catch (SqlException ex)
            {

                string s = ex.Message;
            }
            finally { conn.Close(); }
            return u;
        }
    }
}
