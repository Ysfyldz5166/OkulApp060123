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
using OkulApp.BusinnesLocigLayer;

namespace NTPVeriTabanıDers
{
    public partial class frmOgrKayit : Form
    {
        public frmOgrKayit()
        {
            InitializeComponent();
        }
        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciKaydet(new Ogrenci
                {
                    Ad = txbAd.Text.Trim(),
                    Soyad = txbSoyad.Text.Trim(),
                    Numara = txtNumara.Text.Trim()
                });
                MessageBox.Show(sonuc==true?"Giriş başarılı":"Ekleme Başarısız");
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
            catch(Exception) 
            {
                MessageBox.Show("Bilinmeyen bir hata");
            }
        }

        private void OgrKayit_Click(object sender, EventArgs e)
        {
            frmOgretmenKyt ogretmenKyt= new frmOgretmenKyt();
            ogretmenKyt.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            frmOgrSilme frmOgrSilme= new frmOgrSilme();
            frmOgrSilme.ShowDialog();
        }
    }
}
