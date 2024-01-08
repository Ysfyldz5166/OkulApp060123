using OkulApp.BusinnesLocigLayer;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTPVeriTabanıDers
{
    public partial class frmOgretmenBul : Form
    {
        frmOgretmenKyt frmOgretmenKyt;
        public frmOgretmenBul(frmOgretmenKyt frmOgretmenKyt)
        {
            InitializeComponent();
            this.frmOgretmenKyt = frmOgretmenKyt;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                OgretmenBL ogrtmenBl = new OgretmenBL();
                OgretmenModel ogretmenModel = ogrtmenBl.OgretmenBul(txbOgretTc.Text.Trim());
                if (ogrtmenBl != null)
                {

                    frmOgretmenKyt.txbTcK.Text = ogretmenModel.TcNo;
                    frmOgretmenKyt.txbSoyad.Text = ogretmenModel.SurName;
                    frmOgretmenKyt.txbİsim.Text = ogretmenModel.Name;
                    frmOgretmenKyt.txbTelNo.Text = ogretmenModel.TelNo;

                    frmOgretmenKyt.btnSil.Enabled = true;
                    frmOgretmenKyt.btnGuncelle.Enabled = true;

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
        }
    }
}
