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
    class Sozlesmeler
    {
        private int _sozlesmeID;
        private int _plakaID;
        private int _musteriNo;
        private string _kimlikNo;
        private string _ad;
        private string _soyad;
        private string _evTelefonu;
        private string _cepTelefonu;
        private string _adres;
        private string _alisNoktasi;
        private DateTime _alisTarihi;
        private string _birakisNoktasi;
        private DateTime _birakisTarihi;
        private double _toplamTutar;



        #region Properties
        public int SozlesmeID
        {
            get { return _sozlesmeID; }
            set { _sozlesmeID = value; }
        }
        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }
        }
        public int PlakaID
        {
            get { return _plakaID; }
            set { _plakaID = value; }
        }

        public string KimlikNo
        {
            get { return _kimlikNo; }
            set { _kimlikNo = value; }
        }

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public string EvTelefonu
        {
            get { return _evTelefonu; }
            set { _evTelefonu = value; }
        }

        public string CepTelefonu
        {
            get { return _cepTelefonu; }
            set { _cepTelefonu = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public string AlisNoktasi
        {
            get { return _alisNoktasi; }
            set { _alisNoktasi = value; }
        }

        public DateTime AlisTarihi
        {
            get { return _alisTarihi; }
            set { _alisTarihi = value; }
        }

        public string BirakisNoktasi
        {
            get { return _birakisNoktasi; }
            set { _birakisNoktasi = value; }
        }

        public DateTime BirakisTarihi
        {
            get { return _birakisTarihi; }
            set { _birakisTarihi = value; }
        }


        public double ToplamTutar
        {
            get { return _toplamTutar; }
            set { _toplamTutar = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        public void SozlesmeleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select PlakaID,KimlikNo,Ad,Soyad,EvTelefon,CepTelefon,Adres,AlisNoktasi,AlisTarihi,BirakisYeri,BirakisTarihi,ToplamTutar,SozlesmeID,MusteriNo from Sozlesmeler where Silindi=0", conn);
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
                        liste.Items[i].SubItems.Add(dr[11].ToString());
                        liste.Items[i].SubItems.Add(dr[12].ToString());
                        liste.Items[i].SubItems.Add(dr[13].ToString());


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
        public bool SozlesmeEkle(Sozlesmeler s)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Sozlesmeler (KimlikNo,PlakaID,MusteriNo,Ad,Soyad,EvTelefon,CepTelefon,Adres,AlisNoktasi,AlisTarihi,BirakisYeri,BirakisTarihi,ToplamTutar) values (@KimlikNo,@PlakaID,@MusteriNo,@MusteriAdi,@MusteriSoyadi,@EvTelefonu,@CepTelefonu,@Adres,@AlisNoktasi,@AlisTarihi,@BirakisNoktasi,@BirakisTarihi,@ToplamTutar)", conn);
            comm.Parameters.Add("@PlakaID", SqlDbType.Int).Value = s._plakaID;
            comm.Parameters.Add("@MusteriAdi", SqlDbType.VarChar).Value = s._ad;
            comm.Parameters.Add("@MusteriSoyadi", SqlDbType.VarChar).Value = s._soyad;
            comm.Parameters.Add("@EvTelefonu", SqlDbType.VarChar).Value = s._evTelefonu;
            comm.Parameters.Add("@CepTelefonu", SqlDbType.VarChar).Value = s._cepTelefonu;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = s._adres;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = s._musteriNo;
            comm.Parameters.Add("@KimlikNo", SqlDbType.VarChar).Value = s._kimlikNo;
            comm.Parameters.Add("@AlisNoktasi", SqlDbType.VarChar).Value = s._alisNoktasi;
            comm.Parameters.Add("@AlisTarihi", SqlDbType.DateTime).Value = s._alisTarihi;
            comm.Parameters.Add("@BirakisNoktasi", SqlDbType.VarChar).Value = s._birakisNoktasi;
            comm.Parameters.Add("@BirakisTarihi", SqlDbType.DateTime).Value = s._birakisTarihi;
            comm.Parameters.Add("@ToplamTutar", SqlDbType.Money).Value = s._toplamTutar;

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

        public bool SozlesmeVarMi(string KimlikNo, int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Sozlesmeler where KimlikNo=@KimlikNo and PlakaID=@ID and Silindi=0", conn);
            comm.Parameters.Add("@KimlikNo", SqlDbType.VarChar).Value = KimlikNo;
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

        public bool SozlesmeGuncelle(Sozlesmeler s)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Sozlesmeler set KimlikNo=@KimlikNo,PlakaID=@PlakaID,MusteriNo=@MusteriNo,Ad=@MusteriAdi,Soyad=@MusteriSoyadi,EvTelefon=@EvTelefonu,CepTelefon=@CepTelefonu,Adres=@Adres,AlisNoktasi=@AlisNoktasi,AlisTarihi=@AlisTarihi,BirakisYeri=@BirakisNoktasi,BirakisTarihi=@BirakisTarihi,ToplamTutar=@ToplamTutar where SozlesmeID=@SozlesmeID", conn);
            comm.Parameters.Add("SozlesmeID", SqlDbType.Int).Value = s._sozlesmeID;
            comm.Parameters.Add("@PlakaID", SqlDbType.Int).Value = s._plakaID;
            comm.Parameters.Add("@MusteriAdi", SqlDbType.VarChar).Value = s._ad;
            comm.Parameters.Add("@MusteriSoyadi", SqlDbType.VarChar).Value = s._soyad;
            comm.Parameters.Add("@EvTelefonu", SqlDbType.VarChar).Value = s._evTelefonu;
            comm.Parameters.Add("@CepTelefonu", SqlDbType.VarChar).Value = s._cepTelefonu;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = s._adres;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = s._musteriNo;
            comm.Parameters.Add("@KimlikNo", SqlDbType.VarChar).Value = s._kimlikNo;
            comm.Parameters.Add("@AlisNoktasi", SqlDbType.VarChar).Value = s._alisNoktasi;
            comm.Parameters.Add("@AlisTarihi", SqlDbType.DateTime).Value = s._alisTarihi;
            comm.Parameters.Add("@BirakisNoktasi", SqlDbType.VarChar).Value = s._birakisNoktasi;
            comm.Parameters.Add("@BirakisTarihi", SqlDbType.DateTime).Value = s._birakisTarihi;
            comm.Parameters.Add("@ToplamTutar", SqlDbType.Money).Value = s._toplamTutar;

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

        public bool SozlesmeKaldır(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Sozlesmeler set Silindi=1 where SozlesmeID=@ID", conn);
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
