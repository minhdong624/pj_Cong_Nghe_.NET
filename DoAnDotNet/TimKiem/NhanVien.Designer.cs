namespace DoAnDotNet.TimKiem
{
    partial class NhanVien
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
            this.lblTKNV = new System.Windows.Forms.Label();
            this.lblTNV = new System.Windows.Forms.Label();
            this.grvNV = new System.Windows.Forms.DataGridView();
            this.btnThoát = new System.Windows.Forms.Button();
            this.lblMNV = new System.Windows.Forms.Label();
            this.txtTNV = new System.Windows.Forms.TextBox();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTKNV
            // 
            this.lblTKNV.AutoSize = true;
            this.lblTKNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKNV.Location = new System.Drawing.Point(404, 20);
            this.lblTKNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTKNV.Name = "lblTKNV";
            this.lblTKNV.Size = new System.Drawing.Size(219, 26);
            this.lblTKNV.TabIndex = 14;
            this.lblTKNV.Text = "Tìm kiếm nhân viên";
            // 
            // lblTNV
            // 
            this.lblTNV.AutoSize = true;
            this.lblTNV.Location = new System.Drawing.Point(666, 89);
            this.lblTNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTNV.Name = "lblTNV";
            this.lblTNV.Size = new System.Drawing.Size(44, 13);
            this.lblTNV.TabIndex = 13;
            this.lblTNV.Text = "Tên NV";
            // 
            // grvNV
            // 
            this.grvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvNV.Location = new System.Drawing.Point(49, 162);
            this.grvNV.Margin = new System.Windows.Forms.Padding(2);
            this.grvNV.Name = "grvNV";
            this.grvNV.RowTemplate.Height = 24;
            this.grvNV.Size = new System.Drawing.Size(990, 395);
            this.grvNV.TabIndex = 11;
            // 
            // btnThoát
            // 
            this.btnThoát.Location = new System.Drawing.Point(565, 111);
            this.btnThoát.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(94, 37);
            this.btnThoát.TabIndex = 10;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.UseVisualStyleBackColor = true;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // lblMNV
            // 
            this.lblMNV.AutoSize = true;
            this.lblMNV.Location = new System.Drawing.Point(176, 88);
            this.lblMNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMNV.Name = "lblMNV";
            this.lblMNV.Size = new System.Drawing.Size(40, 13);
            this.lblMNV.TabIndex = 9;
            this.lblMNV.Text = "Mã NV";
            // 
            // txtTNV
            // 
            this.txtTNV.Location = new System.Drawing.Point(730, 87);
            this.txtTNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTNV.Name = "txtTNV";
            this.txtTNV.Size = new System.Drawing.Size(76, 20);
            this.txtTNV.TabIndex = 15;
            // 
            // txtMNV
            // 
            this.txtMNV.Location = new System.Drawing.Point(214, 85);
            this.txtMNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(76, 20);
            this.txtMNV.TabIndex = 12;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(327, 111);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 37);
            this.btnTim.TabIndex = 16;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTNV);
            this.Controls.Add(this.lblTKNV);
            this.Controls.Add(this.lblTNV);
            this.Controls.Add(this.txtMNV);
            this.Controls.Add(this.grvNV);
            this.Controls.Add(this.btnThoát);
            this.Controls.Add(this.lblMNV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTKNV;
        private System.Windows.Forms.Label lblTNV;
        private System.Windows.Forms.DataGridView grvNV;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.Label lblMNV;
        private System.Windows.Forms.TextBox txtTNV;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.Button btnTim;
    }
}