using OkulApp.DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BusinnesLocigLayer
{
    public class OgretmenBL
    {
        public bool OgretmenKaydet(OgretmenModel ogretmen)
        {
            var hlp = new Helper();
            var p = new SqlParameter[]
                {
                new SqlParameter("@Tc",ogretmen.TcNo),
                new SqlParameter("@Ad",ogretmen.Name),
                new SqlParameter("@Soyad",ogretmen.SurName),
                new SqlParameter("@TelNo",ogretmen.TelNo)
                };
            return hlp.ExecuteNonQuery("Insert into Ogretmen values(@Tc,@Ad,@Soyad,@TelNo)", p) > 0;
        }

        public OgretmenModel OgretmenBul(string TC)
        {
            try
            {
                var helper = new Helper();
                SqlParameter[] parameters = { new SqlParameter("@TcNo", TC) };

                var dr = helper.ExecuteReader("Select TcNo, Name, Surname, Telefon From Ogretmen where TcNo=@TcNo", parameters);

                OgretmenModel ogretmen = null;
                if (dr.Read())
                {
                    ogretmen = new OgretmenModel();
                    ogretmen.Name = dr["Name"].ToString();
                    ogretmen.SurName = dr["Surname"].ToString();
                    ogretmen.TelNo = dr["Telefon"].ToString();
                    ogretmen.TcNo = dr["TcNo"].ToString();
                }
                dr.Close();

                return ogretmen;
            }
            catch (Exception ex)
            {
                throw new Exception("Oluşan Hata: " + ex.Message, ex);

            }

        }

        public bool OgretmenSil(string tc)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@Tc", tc) };
                var hlp = new Helper();

                return hlp.ExecuteNonQuery("DELETE FROM Ogretmen WHERE TcNo = @Tc;", parameters) > 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Oluşan Hata: " + ex.Message, ex);
            }
        }

        public bool OgretmenGuncelle(OgretmenModel ogretmen)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Name",ogretmen.Name),
            new SqlParameter("@Surname", ogretmen.SurName),
            new SqlParameter("@Telefon",ogretmen.TelNo),
            new SqlParameter("@Tc",ogretmen.TcNo)};

                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Update Ogretmen set Name=@Name,Surname=@Surname,Telefon=@Telefon where Tc=@Tc", p) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("UYARI! Hata: " + ex.Message, ex);
            }
        }
    }
}
