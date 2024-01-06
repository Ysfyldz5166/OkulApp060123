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
    }
}
