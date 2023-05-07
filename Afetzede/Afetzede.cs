using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afetzede
{
    internal class Afetzede
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OQJ59QU;Initial Catalog=Afetzede;Integrated Security=True");
        DataTable tablo;

        public void ekle_sil_guncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
           
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close() ;
            return tablo;
        }
    }
}
