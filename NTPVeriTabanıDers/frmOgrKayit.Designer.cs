namespace NTPVeriTabanıDers
{
    partial class frmOgrKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxOgrBilg = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txbSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txbAd = new System.Windows.Forms.TextBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.OgrKayit = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbxOgrBilg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOgrBilg
            // 
            this.gbxOgrBilg.Controls.Add(this.btnKaydet);
            this.gbxOgrBilg.Controls.Add(this.txbSoyad);
            this.gbxOgrBilg.Controls.Add(this.txtNumara);
            this.gbxOgrBilg.Controls.Add(this.txbAd);
            this.gbxOgrBilg.Controls.Add(this.lblNumara);
            this.gbxOgrBilg.Controls.Add(this.lblSoyad);
            this.gbxOgrBilg.Controls.Add(this.lblAd);
            this.gbxOgrBilg.Location = new System.Drawing.Point(278, 75);
            this.gbxOgrBilg.Name = "gbxOgrBilg";
            this.gbxOgrBilg.Size = new System.Drawing.Size(258, 166);
            this.gbxOgrBilg.TabIndex = 0;
            this.gbxOgrBilg.TabStop = false;
            this.gbxOgrBilg.Text = "Öğrenci Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(25, 137);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txbSoyad
            // 
            this.txbSoyad.Location = new System.Drawing.Point(98, 59);
            this.txbSoyad.MaxLength = 30;
            this.txbSoyad.Name = "txbSoyad";
            this.txbSoyad.Size = new System.Drawing.Size(119, 22);
            this.txbSoyad.TabIndex = 5;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(98, 98);
            this.txtNumara.MaxLength = 15;
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(119, 22);
            this.txtNumara.TabIndex = 4;
            // 
            // txbAd
            // 
            this.txbAd.Location = new System.Drawing.Point(98, 24);
            this.txbAd.MaxLength = 20;
            this.txbAd.Name = "txbAd";
            this.txbAd.Size = new System.Drawing.Size(119, 22);
            this.txbAd.TabIndex = 3;
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(6, 101);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(55, 16);
            this.lblNumara.TabIndex = 2;
            this.lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(6, 59);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(6, 25);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(569, 97);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(116, 35);
            this.btnBul.TabIndex = 6;
            this.btnBul.Text = "Öğrenci Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click_1);
            // 
            // OgrKayit
            // 
            this.OgrKayit.Location = new System.Drawing.Point(410, 278);
            this.OgrKayit.Name = "OgrKayit";
            this.OgrKayit.Size = new System.Drawing.Size(135, 48);
            this.OgrKayit.TabIndex = 1;
            this.OgrKayit.Text = "Öğretmen Kayıt Sayfası";
            this.OgrKayit.UseVisualStyleBackColor = true;
            this.OgrKayit.Click += new System.EventHandler(this.OgrKayit_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(569, 155);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(116, 37);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(569, 212);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(116, 43);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.OgrKayit);
            this.Controls.Add(this.gbxOgrBilg);
            this.Name = "frmOgrKayit";
            this.Text = "Öğrenci Kayıt işlemleri";
            this.gbxOgrBilg.ResumeLayout(false);
            this.gbxOgrBilg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOgrBilg;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button OgrKayit;
        private System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.TextBox txbSoyad;
        public System.Windows.Forms.TextBox txtNumara;
        public System.Windows.Forms.TextBox txbAd;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGuncelle;
    }
}

