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
    class Musteriler
    {
        private int _musteriNo;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _cepTelefon;
        private string _adres;
        private int _sehirID;
        private string _aciklama;
        private string _kimlikNo;
        private string _evTelefon;
        #region Properties
        public string MusteriAd
        {
            get { return _musteriAd; }
            set { _musteriAd = value; }
        }

        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }
        }
        public string MusteriSoyad
        {
            get { return _musteriSoyad; }
            set { _musteriSoyad = value; }
        }

        public string EvTelefon
        {
            get { return _evTelefon; }
            set { _evTelefon = value; }
        }

        public string CepTelefon
        {
            get { return _cepTelefon; }
            set { _cepTelefon = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public int SehirID
        {
            get { return _sehirID; }
            set { _sehirID = value; }
        }

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }


        public string KimlikNo
        {
            get { return _kimlikNo; }
            set { _kimlikNo = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        public bool MusteriVarMi(string KimlikNo)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count (*) from Musteriler where TcKimlikNo=@KimlikNo and Silindi=0", conn);
            comm.Parameters.Add("@KimlikNo", SqlDbType.VarChar).Value = KimlikNo;
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

        public int MusteriIDGetir(string KimlikNo)
        {
            SqlCommand comm = new SqlCommand("select MusteriID from Musteriler where Silindi=0 and TcKimlikNo=@KimlikNo", conn);
            comm.Parameters.Add("@KimlikNo", SqlDbType.VarChar).Value = KimlikNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int ID = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return ID;
        }

        public bool MusteriEkle(Musteriler m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Musteriler (MusteriAdi, MusteriSoyadi, EvTelefonu, CepTelefonu, Adres, SehirID, Aciklama, TcKimlikNo) values (@MusteriAdi, @MusteriSoyadi, @EvTelefonu, @CepTelefonu, @Adres,@SehirID, @Aciklama,@KimlikNo)", conn);
            comm.Parameters.Add("@MusteriAdi", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@MusteriSoyadi", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@EvTelefonu", SqlDbType.VarChar).Value = m._evTelefon;
            comm.Parameters.Add("@CepTelefonu", SqlDbType.VarChar).Value = m._cepTelefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = m._aciklama;
            comm.Parameters.Add("@KimlikNo", SqlDbType.VarChar).Value = m._kimlikNo;
            comm.Parameters.Add("@SehirID", SqlDbType.Int).Value = m._sehirID;
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

        public void MusterileriGetir(int MusteriNo)
        {
            SqlCommand comm = new SqlCommand("select MusteriAdi,MusteriSoyadi,EvTelefonu,CepTelefonu,Adres from Musteriler where MusteriID=@MusteriNo and Silindi=0", conn);
            comm.Parameters.Add("MusteriNo", SqlDbType.Int).Value = MusteriNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        Sozlesme s = new Sozlesme();
                        s.txtAd.Text = dr[0].ToString();
                        s.txtSoyad.Text = dr[1].ToString();
                        s.txtEvTelefonu.Text = dr[2].ToString();
                        s.txtCepTelefonu.Text = dr[3].ToString();
                        s.txtAdres.Text = dr[4].ToString();
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

        public void MusterileriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriID, MusteriAdi, MusteriSoyadi, EvTelefonu, CepTelefonu, Adres, m.SehirID, s.sehirAdi, m.aciklama, TCKimlikNo from Musteriler m inner join sehirler s on s.sehirID=m.sehirID where m.Silindi =0", conn);
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

        public void MusteriSorgulamaByTCNOyaGore(string TCNO, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriID, MusteriAdi, MusteriSoyadi, EvTelefonu, CepTelefonu, Adres, m.SehirID, s.sehirAdi, m.aciklama, TCKimlikNo from Musteriler m inner join sehirler s on s.sehirID=m.sehirID where m.Silindi =0 and tcKimlikNo like @tcno+'%'", conn);
            comm.Parameters.Add("tcno", SqlDbType.VarChar).Value = TCNO;
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

        public bool MusteriSil(int MusteriID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update musteriler set silindi=0 where musteriID=@ID", conn);
            comm.Parameters.Add("@ID", SqlDbType.Int).Value = MusteriID;
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
