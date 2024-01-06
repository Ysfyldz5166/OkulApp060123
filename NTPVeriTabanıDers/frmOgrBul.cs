using OkulApp.BusinnesLocigLayer;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTPVeriTabanıDers
{
    public partial class frmOgrBul : Form
    {
        frmOgrKayit OgrKayit;
        public frmOgrBul( frmOgrKayit ogrKayit)
        {
            InitializeComponent();
            this.OgrKayit = ogrKayit;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL ogrenciBL = new OgrenciBL();
                Ogrenci ogrenci = ogrenciBL.OgrenciBul(txbNum.Text.Trim());
                if (ogrenci != null)
                {

                    OgrKayit.txbAd.Text = ogrenci.Ad;
                    OgrKayit.txbSoyad.Text = ogrenci.Soyad;
                    OgrKayit.txtNumara.Text = ogrenci.Numara;
                    OgrKayit.Ogrenciid = ogrenci.OgrenciId;

                    OgrKayit.btnSil.Enabled = true;
                    OgrKayit.btnGuncelle.Enabled = true;

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunamadı!!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu: " + ex.Message);

            }


            #region ÖğrenciBulmaEskiHal
            //using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            //{
            //    using(SqlCommand cmd = new SqlCommand("Select OgrenciId, Ad, Soyad, Numara From Ogrenci where Numara=@Numara",cn)) 
            //    {
            //        SqlParameter[] parameter = { new SqlParameter("@Numara", txbNum.Text.Trim()) };
            //        cmd.Parameters.AddRange(parameter);
            //        cn.Open();

            //        SqlDataReader dr=cmd.ExecuteReader();
            //        Ogrenci ogrenci = null;
            //        if (dr.Read())
            //        {
            //            ogrenci = new Ogrenci();
            //            ogrenci.Ad = dr["Ad"].ToString();
            //            ogrenci.Soyad = dr["Soyad"].ToString();
            //            ogrenci.Numara = dr["Numara"].ToString();
            //            ogrenci.OgrenciId =Convert.ToInt32( dr["OgrenciId"]);

            //            OgrKayit.txbAd.Text = ogrenci.Ad;
            //            OgrKayit.txbSoyad.Text= ogrenci.Soyad;
            //            OgrKayit.txtNumara.Text= ogrenci.Numara;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Öğrenci bulunamadı");
            //        }
            //    }
            //} 
            #endregion

        }
    }
}
            //try
            //{
            //    var obl = new OgrenciBL();
            //    bool sonuc = obl.OgrenciSil(new Ogrenci
            //    {
            //        OgrenciId = int.Parse(txbTcK.Text.Trim())
            //    }) ;
            //    MessageBox.Show(sonuc == true ? "Silme Başarılı" : "Silme Başarısız");
            //}
            //catch (SqlException exception)
            //{

            //    switch (exception.Number)
            //    {

            //        default:
            //            MessageBox.Show("Veri Tabanı Hatası");
            //            break;
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Bilinmeyen bir hata");
            //}