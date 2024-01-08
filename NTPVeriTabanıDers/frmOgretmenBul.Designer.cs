namespace NTPVeriTabanıDers
{
    partial class frmOgretmenBul
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
            this.grbOgrBul = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblOgretTc = new System.Windows.Forms.Label();
            this.txbOgretTc = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.grbOgrBul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOgrBul
            // 
            this.grbOgrBul.Controls.Add(this.btnAra);
            this.grbOgrBul.Controls.Add(this.txbOgretTc);
            this.grbOgrBul.Controls.Add(this.lblOgretTc);
            this.grbOgrBul.Location = new System.Drawing.Point(157, 67);
            this.grbOgrBul.Name = "grbOgrBul";
            this.grbOgrBul.Size = new System.Drawing.Size(363, 242);
            this.grbOgrBul.TabIndex = 0;
            this.grbOgrBul.TabStop = false;
            this.grbOgrBul.Text = "Öğretmen Bul";
            // 
            // lblOgretTc
            // 
            this.lblOgretTc.AutoSize = true;
            this.lblOgretTc.Location = new System.Drawing.Point(114, 74);
            this.lblOgretTc.Name = "lblOgretTc";
            this.lblOgretTc.Size = new System.Drawing.Size(147, 16);
            this.lblOgretTc.TabIndex = 0;
            this.lblOgretTc.Text = "Öğretmen TC No Giriniz";
            // 
            // txbOgretTc
            // 
            this.txbOgretTc.Location = new System.Drawing.Point(140, 108);
            this.txbOgretTc.Name = "txbOgretTc";
            this.txbOgretTc.Size = new System.Drawing.Size(100, 22);
            this.txbOgretTc.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(117, 147);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(141, 47);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmOgretmenBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbOgrBul);
            this.Name = "frmOgretmenBul";
            this.Text = "frmOgretmenBul";
            this.grbOgrBul.ResumeLayout(false);
            this.grbOgrBul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOgrBul;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txbOgretTc;
        private System.Windows.Forms.Label lblOgretTc;
    }
}