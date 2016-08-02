using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portakal.Model
{
    class RezervasyonSorgu
    {
        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();
        internal DataSet rezervasyonlariGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select RezervasyonID,RezTarihi,GirisTarihi,CikisTarihi,Rezervasyon.MusteriID,MusteriAdi+' '+MusteriSoyadi as Musteri ,Musteriler.TCKimlikNo,Rezervasyon.OtelID,OtelAd,TipAd,ToplamFiyat,Rezervasyon.TipID from Musteriler inner join Rezervasyon on Musteriler.MusteriID=Rezervasyon.MusteriID inner join OdaTipi on Rezervasyon.TipID=OdaTipi.TipID inner join Otel on OdaTipi.OtelID=Otel.OtelID ", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Rezervasyonlar");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }

        internal DataSet rezervasyonlariFiltrele(string tcno, string otelad)
        {
            ds.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select RezervasyonID,RezTarihi,GirisTarihi,CikisTarihi,Rezervasyon.MusteriID,MusteriAdi+' '+MusteriSoyadi as Musteri ,Musteriler.TCKimlikNo,Rezervasyon.OtelID,OtelAd,TipAd,ToplamFiyat,Rezervasyon.TipID from Musteriler inner join Rezervasyon on Musteriler.MusteriID=Rezervasyon.MusteriID inner join OdaTipi on Rezervasyon.TipID=OdaTipi.TipID inner join Otel on OdaTipi.OtelID=Otel.OtelID where TCKimlikNo like @TcKimlikNo + '%' and OtelAd like @OtelAd+'%'", conn);
            da.SelectCommand.Parameters.Add("@TcKimlikNo", SqlDbType.VarChar).Value = tcno;
            da.SelectCommand.Parameters.Add("@OtelAd", SqlDbType.VarChar).Value = otelad;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Rezervasyonlar");
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
