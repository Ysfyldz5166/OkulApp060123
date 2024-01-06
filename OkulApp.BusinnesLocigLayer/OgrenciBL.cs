using OkulApp.MODEL;
using System;
using System.Data;
using System.Data.SqlClient;
using OkulApp.DAL;
using System.Runtime.InteropServices;

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

        public Ogrenci OgrenciBul(string numara)
        {
            try
            {
                var helper = new Helper();
                SqlParameter[] parameters = { new SqlParameter("@Numara", numara) };

                var dr = helper.ExecuteReader("Select OgrenciId, Ad, Soyad, Numara From Ogrenci where Numara=@Numara", parameters);

                Ogrenci ogrenci = null;
                if (dr.Read())
                {
                    ogrenci = new Ogrenci();
                    ogrenci.Ad = dr["Ad"].ToString();
                    ogrenci.Soyad = dr["Soyad"].ToString();
                    ogrenci.Numara = dr["Numara"].ToString();
                    ogrenci.OgrenciId = Convert.ToInt32(dr["OgrenciId"]);
                }
                dr.Close();
                
                return ogrenci;
            }
            catch(Exception ex)
            {
                throw new Exception("Oluşan Hata: " + ex.Message, ex);
                
            }

        }

        public bool OgrenciSil(int id)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@Id", id) };
                var hlp = new Helper();

                return hlp.ExecuteNonQuery("DELETE FROM Ogrenci WHERE OgrenciId = @Id;", parameters) > 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Oluşan Hata: " + ex.Message, ex);
            }
        }

        public bool OgrenciGuncelle(Ogrenci ogrenci)
        {
            try
            {
                SqlParameter[] parameters = {
                new SqlParameter("@Ad", ogrenci.Ad),
                new SqlParameter("@Soyad", ogrenci.Soyad),
                new SqlParameter("@Numara", ogrenci.Numara),
                new SqlParameter("@OgrenciId",ogrenci.OgrenciId) };

                var hlp = new Helper();

                return hlp.ExecuteNonQuery("Update Ogrenci set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@OgrenciId", parameters) > 0;

            }
            catch ( Exception ex)
            {
                throw new Exception("Oluşan Hata: " + ex.Message, ex);
            }
        }
    }
}
