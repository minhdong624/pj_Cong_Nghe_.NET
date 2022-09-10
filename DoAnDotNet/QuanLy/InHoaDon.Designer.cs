namespace DoAnDotNet.QuanLy
{
    partial class InHoaDon
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
            this.lblMaHD = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.crvHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(37, 13);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(109, 20);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(423, 9);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(276, 37);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem Hóa Đơn";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // crvHD
            // 
            this.crvHD.ActiveViewIndex = -1;
            this.crvHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHD.Location = new System.Drawing.Point(28, 52);
            this.crvHD.Name = "crvHD";
            this.crvHD.Size = new System.Drawing.Size(743, 278);
            this.crvHD.TabIndex = 3;
            this.crvHD.Load += new System.EventHandler(this.frmMau_BaiTap01_Load);
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(153, 11);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(168, 28);
            this.cboMaHD.TabIndex = 4;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 342);
            this.Controls.Add(this.cboMaHD);
            this.Controls.Add(this.crvHD);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lblMaHD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InHoaDon";
            this.Text = "InHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Button btnXem;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHD;
        private System.Windows.Forms.ComboBox cboMaHD;
    }
}