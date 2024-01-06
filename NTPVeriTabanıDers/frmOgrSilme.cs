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
    public partial class frmOgrSilme : Form
    {
        public frmOgrSilme()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciSil(new Ogrenci
                {
                    OgrenciId = int.Parse(txbTcK.Text.Trim())
                }) ;
                MessageBox.Show(sonuc == true ? "Silme Başarılı" : "Silme Başarısız");
            }
            catch (SqlException exception)
            {

                switch (exception.Number)
                {

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
