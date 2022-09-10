namespace DoAnDotNet.TimKiem
{
    partial class KhachHang
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
            this.lblMKH = new System.Windows.Forms.Label();
            this.btnThoát = new System.Windows.Forms.Button();
            this.grvKH = new System.Windows.Forms.DataGridView();
            this.txtMKH = new System.Windows.Forms.TextBox();
            this.lblTKH = new System.Windows.Forms.Label();
            this.lblTKKH = new System.Windows.Forms.Label();
            this.txtTKH = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMKH
            // 
            this.lblMKH.AutoSize = true;
            this.lblMKH.Location = new System.Drawing.Point(136, 39);
            this.lblMKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMKH.Name = "lblMKH";
            this.lblMKH.Size = new System.Drawing.Size(40, 13);
            this.lblMKH.TabIndex = 0;
            this.lblMKH.Text = "Mã KH";
            // 
            // btnThoát
            // 
            this.btnThoát.Location = new System.Drawing.Point(516, 65);
            this.btnThoát.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(89, 35);
            this.btnThoát.TabIndex = 1;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.UseVisualStyleBackColor = true;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // grvKH
            // 
            this.grvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvKH.Location = new System.Drawing.Point(9, 114);
            this.grvKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grvKH.Name = "grvKH";
            this.grvKH.RowTemplate.Height = 24;
            this.grvKH.Size = new System.Drawing.Size(990, 395);
            this.grvKH.TabIndex = 2;
            // 
            // txtMKH
            // 
            this.txtMKH.Location = new System.Drawing.Point(175, 37);
            this.txtMKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(76, 20);
            this.txtMKH.TabIndex = 3;
            // 
            // lblTKH
            // 
            this.lblTKH.AutoSize = true;
            this.lblTKH.Location = new System.Drawing.Point(626, 41);
            this.lblTKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTKH.Name = "lblTKH";
            this.lblTKH.Size = new System.Drawing.Size(44, 13);
            this.lblTKH.TabIndex = 4;
            this.lblTKH.Text = "Tên KH";
            // 
            // lblTKKH
            // 
            this.lblTKKH.AutoSize = true;
            this.lblTKKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKKH.Location = new System.Drawing.Point(367, 7);
            this.lblTKKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTKKH.Name = "lblTKKH";
            this.lblTKKH.Size = new System.Drawing.Size(238, 26);
            this.lblTKKH.TabIndex = 5;
            this.lblTKKH.Text = "Tìm kiếm khách hàng";
            // 
            // txtTKH
            // 
            this.txtTKH.Location = new System.Drawing.Point(691, 38);
            this.txtTKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTKH.Name = "txtTKH";
            this.txtTKH.Size = new System.Drawing.Size(76, 20);
            this.txtTKH.TabIndex = 6;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(287, 65);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(89, 35);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 532);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTKH);
            this.Controls.Add(this.lblTKKH);
            this.Controls.Add(this.lblTKH);
            this.Controls.Add(this.txtMKH);
            this.Controls.Add(this.grvKH);
            this.Controls.Add(this.btnThoát);
            this.Controls.Add(this.lblMKH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMKH;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.DataGridView grvKH;
        private System.Windows.Forms.TextBox txtMKH;
        private System.Windows.Forms.Label lblTKH;
        private System.Windows.Forms.Label lblTKKH;
        private System.Windows.Forms.TextBox txtTKH;
        private System.Windows.Forms.Button btnTim;
    }
}