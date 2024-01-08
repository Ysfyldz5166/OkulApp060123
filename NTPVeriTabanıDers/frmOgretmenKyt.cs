using OkulApp.BusinnesLocigLayer;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NTPVeriTabanıDers
{
    public partial class frmOgretmenKyt : Form
    {
        public frmOgretmenKyt()
        {
            InitializeComponent();
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var ogrtmBl = new OgretmenBL();
                bool sonuc = ogrtmBl.OgretmenKaydet(new OgretmenModel
                {
                    TcNo=txbTcK.Text.Trim(),
                    Name=txbİsim.Text.Trim(),
                    SurName=txbSoyad.Text.Trim(),
                    TelNo=txbTelNo.Text.Trim(),

                });
                MessageBox.Show(sonuc == true ? "Giriş başarılı" : "Ekleme Başarısız");
            }
            catch (SqlException exception)
            {

                switch (exception.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara bir daha girilemez");
                        break;
                    default:
                        MessageBox.Show("Veri Tabanı Hatası");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen bir hata");
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmOgretmenBul frmOgretmenBul = new frmOgretmenBul(this);
            frmOgretmenBul.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenSil(txbTcK.Text.Trim()) ? "Silme başarılı" : "Silme işlemi başarısız!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenGuncelle(new OgretmenModel { Name = txbİsim.Text.Trim(), SurName = txbSoyad.Text.Trim(), TcNo = txbTcK.Text.Trim(), TelNo = txbTelNo.Text.Trim() }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");

            }
            catch (Exception ex) { throw new Exception("UYARI! Hata: " + ex.Message); }
        }
    }
}
