namespace DoAnDotNet.TimKiem
{
    partial class QuanLyDienThoai
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
            this.btnRom = new System.Windows.Forms.Button();
            this.btnHang = new System.Windows.Forms.Button();
            this.lblTKDT = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.grvDT = new System.Windows.Forms.DataGridView();
            this.btnThoát = new System.Windows.Forms.Button();
            this.lblHang = new System.Windows.Forms.Label();
            this.cboHang = new System.Windows.Forms.ComboBox();
            this.lblRom = new System.Windows.Forms.Label();
            this.cboRam = new System.Windows.Forms.ComboBox();
            this.cboRom = new System.Windows.Forms.ComboBox();
            this.btnRam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvDT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRom
            // 
            this.btnRom.Location = new System.Drawing.Point(550, 84);
            this.btnRom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRom.Name = "btnRom";
            this.btnRom.Size = new System.Drawing.Size(56, 19);
            this.btnRom.TabIndex = 17;
            this.btnRom.Text = "Tìm";
            this.btnRom.UseVisualStyleBackColor = true;
            this.btnRom.Click += new System.EventHandler(this.btnRom_Click);
            // 
            // btnHang
            // 
            this.btnHang.Location = new System.Drawing.Point(86, 90);
            this.btnHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnHang.Name = "btnHang";
            this.btnHang.Size = new System.Drawing.Size(56, 19);
            this.btnHang.TabIndex = 16;
            this.btnHang.Text = "Tìm";
            this.btnHang.UseVisualStyleBackColor = true;
            this.btnHang.Click += new System.EventHandler(this.btnHang_Click);
            // 
            // lblTKDT
            // 
            this.lblTKDT.AutoSize = true;
            this.lblTKDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKDT.Location = new System.Drawing.Point(356, 7);
            this.lblTKDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTKDT.Name = "lblTKDT";
            this.lblTKDT.Size = new System.Drawing.Size(220, 26);
            this.lblTKDT.TabIndex = 14;
            this.lblTKDT.Text = "Tìm kiếm điện thoại";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(234, 62);
            this.lblRam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(29, 13);
            this.lblRam.TabIndex = 13;
            this.lblRam.Text = "Ram";
            // 
            // grvDT
            // 
            this.grvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDT.Location = new System.Drawing.Point(-8, 135);
            this.grvDT.Margin = new System.Windows.Forms.Padding(2);
            this.grvDT.Name = "grvDT";
            this.grvDT.RowTemplate.Height = 24;
            this.grvDT.Size = new System.Drawing.Size(990, 395);
            this.grvDT.TabIndex = 11;
            // 
            // btnThoát
            // 
            this.btnThoát.Location = new System.Drawing.Point(418, 102);
            this.btnThoát.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(56, 19);
            this.btnThoát.TabIndex = 10;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.UseVisualStyleBackColor = true;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Location = new System.Drawing.Point(52, 62);
            this.lblHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(33, 13);
            this.lblHang.TabIndex = 9;
            this.lblHang.Text = "Hãng";
            // 
            // cboHang
            // 
            this.cboHang.FormattingEnabled = true;
            this.cboHang.Location = new System.Drawing.Point(103, 59);
            this.cboHang.Margin = new System.Windows.Forms.Padding(2);
            this.cboHang.Name = "cboHang";
            this.cboHang.Size = new System.Drawing.Size(92, 21);
            this.cboHang.TabIndex = 18;
            // 
            // lblRom
            // 
            this.lblRom.AutoSize = true;
            this.lblRom.Location = new System.Drawing.Point(513, 62);
            this.lblRom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRom.Name = "lblRom";
            this.lblRom.Size = new System.Drawing.Size(29, 13);
            this.lblRom.TabIndex = 19;
            this.lblRom.Text = "Rom";
            // 
            // cboRam
            // 
            this.cboRam.FormattingEnabled = true;
            this.cboRam.Location = new System.Drawing.Point(292, 59);
            this.cboRam.Margin = new System.Windows.Forms.Padding(2);
            this.cboRam.Name = "cboRam";
            this.cboRam.Size = new System.Drawing.Size(92, 21);
            this.cboRam.TabIndex = 20;
            // 
            // cboRom
            // 
            this.cboRom.FormattingEnabled = true;
            this.cboRom.Location = new System.Drawing.Point(581, 59);
            this.cboRom.Margin = new System.Windows.Forms.Padding(2);
            this.cboRom.Name = "cboRom";
            this.cboRom.Size = new System.Drawing.Size(92, 21);
            this.cboRom.TabIndex = 21;
            // 
            // btnRam
            // 
            this.btnRam.Location = new System.Drawing.Point(272, 90);
            this.btnRam.Margin = new System.Windows.Forms.Padding(2);
            this.btnRam.Name = "btnRam";
            this.btnRam.Size = new System.Drawing.Size(56, 19);
            this.btnRam.TabIndex = 22;
            this.btnRam.Text = "Tìm";
            this.btnRam.UseVisualStyleBackColor = true;
            this.btnRam.Click += new System.EventHandler(this.btnRam_Click);
            // 
            // QuanLyDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 557);
            this.Controls.Add(this.btnRam);
            this.Controls.Add(this.cboRom);
            this.Controls.Add(this.cboRam);
            this.Controls.Add(this.lblRom);
            this.Controls.Add(this.cboHang);
            this.Controls.Add(this.btnRom);
            this.Controls.Add(this.btnHang);
            this.Controls.Add(this.lblTKDT);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.grvDT);
            this.Controls.Add(this.btnThoát);
            this.Controls.Add(this.lblHang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyDienThoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDienThoai";
            this.Load += new System.EventHandler(this.QuanLyDienThoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRom;
        private System.Windows.Forms.Button btnHang;
        private System.Windows.Forms.Label lblTKDT;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.DataGridView grvDT;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.ComboBox cboHang;
        private System.Windows.Forms.Label lblRom;
        private System.Windows.Forms.ComboBox cboRam;
        private System.Windows.Forms.ComboBox cboRom;
        private System.Windows.Forms.Button btnRam;
    }
}