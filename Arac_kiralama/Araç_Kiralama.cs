using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Arac_Kiralama
{
    internal class Araç_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=YUSUF-TURGUT\\SQLEXPRESS;Initial Catalog=ArabaDB;Integrated Security=True");
        DataTable tablo;
      //  SqlConnection baglanti = new SqlConnection("Data Source=YUSUF-TURGUT\\SQLEXPRESS;Initial Catalog=Araç_Kiralama;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public void ekle_sil_güncelle(SqlCommand komut,string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu; 
            komut.ExecuteNonQuery();
            baglanti.Close();


        }
        public DataTable listele(SqlDataAdapter adtr , string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close ();
            return tablo;
        }
      
      }

}
