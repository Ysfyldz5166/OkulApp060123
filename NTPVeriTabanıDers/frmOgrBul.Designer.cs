namespace NTPVeriTabanıDers
{
    partial class frmOgrBul
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
            this.btnAra = new System.Windows.Forms.Button();
            this.lblOgrNum = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(124, 112);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 17;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblOgrNum
            // 
            this.lblOgrNum.AutoSize = true;
            this.lblOgrNum.Location = new System.Drawing.Point(88, 40);
            this.lblOgrNum.Name = "lblOgrNum";
            this.lblOgrNum.Size = new System.Drawing.Size(144, 16);
            this.lblOgrNum.TabIndex = 12;
            this.lblOgrNum.Text = "Öğrenci Numara Giriniz";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(91, 72);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(139, 22);
            this.txbNum.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.txbNum);
            this.groupBox1.Controls.Add(this.lblOgrNum);
            this.groupBox1.Location = new System.Drawing.Point(255, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 211);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrBul";
            this.Text = "OgrSilme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblOgrNum;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}