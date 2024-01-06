using OkulApp.MODEL;
using System;
using System.Data;
using System.Data.SqlClient;
using OkulApp.DAL;

namespace OkulApp.BusinnesLocigLayer
{
    public class OgrenciBL
    {
        public bool OgrenciKaydet(Ogrenci ogrenci)
        {
            var hlp = new Helper();
            var p = new SqlParameter[]
                {
                new SqlParameter("@Ad",ogrenci.Ad),
                new SqlParameter("@Soyad",ogrenci.Soyad),
                new SqlParameter("@Numara",ogrenci.Numara)
                };
            return hlp.ExecuteNonQuery("Insert into Ogrenci values(@Ad,@Soyad,@Numara)",p)>0;
        }
        public bool OgrenciSil(Ogrenci ogrenci)
        {
            var hlp=new Helper();
            var p = new SqlParameter[]
            {
                new SqlParameter("@Id",ogrenci.OgrenciId),
            };
            return hlp.ExecuteNonQuery("DELETE FROM Ogrenci WHERE OgrenciId = @Id;", p) > 0;
        }
    }
}
