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
    class OtelRaporlama
    {
        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();
        internal DataSet otelleriGetir()
        {
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
        internal DataSet otelleriFiltrele(string OtelAd, string StatuAd, string SehirAd)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Foto,OtelID,OtelAd,StatuAd,Otel.StatuID,Telefon,Adres,SehirAdi,Otel.SehirID from Sehirler inner join Otel on Sehirler.SehirID=Otel.SehirID inner join OtelStatu on Otel.StatuID=OtelStatu.StatuID where OtelAd like @OtelAd+'%' and  StatuAd like @StatuAd +'%' and SehirAdi like @SehirAd +'%' and Otel.Silindi=0 ", conn);
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
        internal DataSet SatisRaporlariniGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Rezervasyon.OtelID,Convert(date,RezTarihi,104) as RezervasyonTarihi ,TipAd,Rezervasyon.MusteriID,MusteriAdi+' '+MusteriSoyadi as Musteri ,Musteriler.TCKimlikNo,ToplamFiyat as Fiyat,Rezervasyon.TipID from Musteriler inner join Rezervasyon on Musteriler.MusteriID=Rezervasyon.MusteriID inner join OdaTipi on Rezervasyon.TipID=OdaTipi.TipID inner join Otel on OdaTipi.OtelID=Otel.OtelID where Rezervasyon.OtelID=@OtelID", conn);
            da.SelectCommand.Parameters.Add("@OtelID", SqlDbType.Int).Value = Genel.OtelID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Raporlar");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }
        internal DataSet SatislariFiltrele(DateTimePicker dtpFirst, DateTimePicker dtpLast)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Rezervasyon.OtelID,Convert(date,RezTarihi,104) as RezervasyonTarihi ,TipAd,Rezervasyon.MusteriID,MusteriAdi+' '+MusteriSoyadi as Musteri ,Musteriler.TCKimlikNo,ToplamFiyat as Fiyat,Rezervasyon.TipID from Musteriler inner join Rezervasyon on Musteriler.MusteriID=Rezervasyon.MusteriID inner join OdaTipi on Rezervasyon.TipID=OdaTipi.TipID inner join Otel on OdaTipi.OtelID=Otel.OtelID where Rezervasyon.OtelID=@OtelID and Convert(date,RezTarihi,104) between Convert(date,@FirstDate,104) and Convert(date,@LastDate,104)", conn);
            da.SelectCommand.Parameters.Add("@OtelID", SqlDbType.Int).Value = Genel.OtelID;
            da.SelectCommand.Parameters.Add("@FirstDate", SqlDbType.DateTime).Value = dtpFirst.Value;
            da.SelectCommand.Parameters.Add("@LastDate", SqlDbType.DateTime).Value = dtpLast.Value;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Satislar");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }


    }
}
