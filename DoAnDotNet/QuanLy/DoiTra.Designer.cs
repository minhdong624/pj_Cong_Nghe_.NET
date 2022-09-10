namespace DoAnDotNet.QuanLy
{
    partial class DoiTra
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
            this.lblHang = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.txtGiaGoc = new System.Windows.Forms.TextBox();
            this.txtTinhTien = new System.Windows.Forms.TextBox();
            this.cboHang = new System.Windows.Forms.ComboBox();
            this.cboDienThoai = new System.Windows.Forms.ComboBox();
            this.rdoDoi = new System.Windows.Forms.RadioButton();
            this.rdoTra = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.rdo2Tuan = new System.Windows.Forms.RadioButton();
            this.rdo1Thang = new System.Windows.Forms.RadioButton();
            this.rdo2Thang = new System.Windows.Forms.RadioButton();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblDoiTra = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Location = new System.Drawing.Point(41, 62);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(33, 13);
            this.lblHang.TabIndex = 0;
            this.lblHang.Text = "Hãng";
            this.lblHang.Click += new System.EventHandler(this.lblHang_Click);
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(41, 95);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(59, 13);
            this.lblDienThoai.TabIndex = 1;
            this.lblDienThoai.Text = "Điện Thoại";
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGoc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGiaGoc.Location = new System.Drawing.Point(493, 59);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(75, 20);
            this.lblGiaGoc.TabIndex = 2;
            this.lblGiaGoc.Text = "Giá Gốc";
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaGoc.Location = new System.Drawing.Point(411, 95);
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.Size = new System.Drawing.Size(259, 29);
            this.txtGiaGoc.TabIndex = 5;
            // 
            // txtTinhTien
            // 
            this.txtTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTien.Location = new System.Drawing.Point(85, 351);
            this.txtTinhTien.Name = "txtTinhTien";
            this.txtTinhTien.Size = new System.Drawing.Size(569, 26);
            this.txtTinhTien.TabIndex = 6;
            // 
            // cboHang
            // 
            this.cboHang.FormattingEnabled = true;
            this.cboHang.Location = new System.Drawing.Point(106, 59);
            this.cboHang.Name = "cboHang";
            this.cboHang.Size = new System.Drawing.Size(221, 21);
            this.cboHang.TabIndex = 7;
            this.cboHang.SelectedIndexChanged += new System.EventHandler(this.cboHang_SelectedIndexChanged);
            // 
            // cboDienThoai
            // 
            this.cboDienThoai.FormattingEnabled = true;
            this.cboDienThoai.Location = new System.Drawing.Point(106, 95);
            this.cboDienThoai.Name = "cboDienThoai";
            this.cboDienThoai.Size = new System.Drawing.Size(268, 21);
            this.cboDienThoai.TabIndex = 8;
            this.cboDienThoai.SelectedIndexChanged += new System.EventHandler(this.cboDienThoai_SelectedIndexChanged);
            // 
            // rdoDoi
            // 
            this.rdoDoi.AutoSize = true;
            this.rdoDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDoi.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdoDoi.Location = new System.Drawing.Point(67, 19);
            this.rdoDoi.Name = "rdoDoi";
            this.rdoDoi.Size = new System.Drawing.Size(59, 28);
            this.rdoDoi.TabIndex = 9;
            this.rdoDoi.TabStop = true;
            this.rdoDoi.Text = "Đổi";
            this.rdoDoi.UseVisualStyleBackColor = true;
            // 
            // rdoTra
            // 
            this.rdoTra.AutoSize = true;
            this.rdoTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTra.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdoTra.Location = new System.Drawing.Point(411, 19);
            this.rdoTra.Name = "rdoTra";
            this.rdoTra.Size = new System.Drawing.Size(59, 28);
            this.rdoTra.TabIndex = 10;
            this.rdoTra.TabStop = true;
            this.rdoTra.Text = "Trả";
            this.rdoTra.UseVisualStyleBackColor = true;
            this.rdoTra.CheckedChanged += new System.EventHandler(this.rdoTra_CheckedChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTime.Location = new System.Drawing.Point(241, 211);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(255, 20);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Thời Gian Đổi Trả Sau Khi Mua";
            // 
            // rdo2Tuan
            // 
            this.rdo2Tuan.AutoSize = true;
            this.rdo2Tuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo2Tuan.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdo2Tuan.Location = new System.Drawing.Point(95, 256);
            this.rdo2Tuan.Name = "rdo2Tuan";
            this.rdo2Tuan.Size = new System.Drawing.Size(82, 24);
            this.rdo2Tuan.TabIndex = 12;
            this.rdo2Tuan.TabStop = true;
            this.rdo2Tuan.Text = "2 Tuần";
            this.rdo2Tuan.UseVisualStyleBackColor = true;
            // 
            // rdo1Thang
            // 
            this.rdo1Thang.AutoSize = true;
            this.rdo1Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo1Thang.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdo1Thang.Location = new System.Drawing.Point(323, 256);
            this.rdo1Thang.Name = "rdo1Thang";
            this.rdo1Thang.Size = new System.Drawing.Size(92, 24);
            this.rdo1Thang.TabIndex = 13;
            this.rdo1Thang.TabStop = true;
            this.rdo1Thang.Text = "1 Tháng";
            this.rdo1Thang.UseVisualStyleBackColor = true;
            // 
            // rdo2Thang
            // 
            this.rdo2Thang.AutoSize = true;
            this.rdo2Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo2Thang.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdo2Thang.Location = new System.Drawing.Point(541, 256);
            this.rdo2Thang.Name = "rdo2Thang";
            this.rdo2Thang.Size = new System.Drawing.Size(92, 24);
            this.rdo2Thang.TabIndex = 14;
            this.rdo2Thang.TabStop = true;
            this.rdo2Thang.Text = "2 Tháng";
            this.rdo2Thang.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.Crimson;
            this.btnTinhTien.Location = new System.Drawing.Point(183, 297);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(385, 48);
            this.btnTinhTien.TabIndex = 15;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblDoiTra
            // 
            this.lblDoiTra.AutoSize = true;
            this.lblDoiTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiTra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDoiTra.Location = new System.Drawing.Point(341, 22);
            this.lblDoiTra.Name = "lblDoiTra";
            this.lblDoiTra.Size = new System.Drawing.Size(83, 26);
            this.lblDoiTra.TabIndex = 16;
            this.lblDoiTra.Text = "Đổi trả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDoi);
            this.groupBox1.Controls.Add(this.rdoTra);
            this.groupBox1.Location = new System.Drawing.Point(106, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 65);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // DoiTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDoiTra);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.rdo2Thang);
            this.Controls.Add(this.rdo1Thang);
            this.Controls.Add(this.rdo2Tuan);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cboDienThoai);
            this.Controls.Add(this.cboHang);
            this.Controls.Add(this.txtTinhTien);
            this.Controls.Add(this.txtGiaGoc);
            this.Controls.Add(this.lblGiaGoc);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblHang);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DoiTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiTra";
            this.Load += new System.EventHandler(this.DoiTra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblGiaGoc;
        private System.Windows.Forms.TextBox txtGiaGoc;
        private System.Windows.Forms.TextBox txtTinhTien;
        private System.Windows.Forms.ComboBox cboHang;
        private System.Windows.Forms.ComboBox cboDienThoai;
        private System.Windows.Forms.RadioButton rdoDoi;
        private System.Windows.Forms.RadioButton rdoTra;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RadioButton rdo2Tuan;
        private System.Windows.Forms.RadioButton rdo1Thang;
        private System.Windows.Forms.RadioButton rdo2Thang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblDoiTra;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}