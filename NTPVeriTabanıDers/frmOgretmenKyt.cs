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

namespace NTPVeriTabanıDers
{
    public partial class frmOgretmenKyt : Form
    {
        public frmOgretmenKyt()
        {
            InitializeComponent();
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
    }
}
