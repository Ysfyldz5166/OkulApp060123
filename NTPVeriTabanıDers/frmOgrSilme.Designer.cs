namespace NTPVeriTabanıDers
{
    partial class frmOgrSilme
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
            this.btnSil = new System.Windows.Forms.Button();
            this.lblOgreneciId = new System.Windows.Forms.Label();
            this.txbTcK = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(227, 97);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblOgreneciId
            // 
            this.lblOgreneciId.AutoSize = true;
            this.lblOgreneciId.Location = new System.Drawing.Point(37, 43);
            this.lblOgreneciId.Name = "lblOgreneciId";
            this.lblOgreneciId.Size = new System.Drawing.Size(107, 16);
            this.lblOgreneciId.TabIndex = 12;
            this.lblOgreneciId.Text = "Öğrenci Id Giriniz";
            // 
            // txbTcK
            // 
            this.txbTcK.Location = new System.Drawing.Point(150, 40);
            this.txbTcK.Name = "txbTcK";
            this.txbTcK.Size = new System.Drawing.Size(139, 22);
            this.txbTcK.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txbTcK);
            this.groupBox1.Controls.Add(this.lblOgreneciId);
            this.groupBox1.Location = new System.Drawing.Point(255, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 211);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmOgrSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrSilme";
            this.Text = "OgrSilme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblOgreneciId;
        private System.Windows.Forms.TextBox txbTcK;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}