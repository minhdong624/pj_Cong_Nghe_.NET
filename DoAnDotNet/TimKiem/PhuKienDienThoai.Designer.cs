namespace DoAnDotNet.TimKiem
{
    partial class PhuKienDienThoai
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
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.btnLoaiPK = new System.Windows.Forms.Button();
            this.lblTKPK = new System.Windows.Forms.Label();
            this.grvPK = new System.Windows.Forms.DataGridView();
            this.btnThoát = new System.Windows.Forms.Button();
            this.lblLoaiPK = new System.Windows.Forms.Label();
            this.rdo100 = new System.Windows.Forms.RadioButton();
            this.rdo500 = new System.Windows.Forms.RadioButton();
            this.rdo501 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvPK)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(146, 74);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(92, 21);
            this.cboLoai.TabIndex = 30;
            // 
            // btnLoaiPK
            // 
            this.btnLoaiPK.Location = new System.Drawing.Point(320, 118);
            this.btnLoaiPK.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoaiPK.Name = "btnLoaiPK";
            this.btnLoaiPK.Size = new System.Drawing.Size(56, 19);
            this.btnLoaiPK.TabIndex = 28;
            this.btnLoaiPK.Text = "Tìm";
            this.btnLoaiPK.UseVisualStyleBackColor = true;
            this.btnLoaiPK.Click += new System.EventHandler(this.btnLoaiPK_Click);
            // 
            // lblTKPK
            // 
            this.lblTKPK.AutoSize = true;
            this.lblTKPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKPK.Location = new System.Drawing.Point(374, 23);
            this.lblTKPK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTKPK.Name = "lblTKPK";
            this.lblTKPK.Size = new System.Drawing.Size(206, 26);
            this.lblTKPK.TabIndex = 27;
            this.lblTKPK.Text = "Tìm kiếm phụ kiện";
            // 
            // grvPK
            // 
            this.grvPK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPK.Location = new System.Drawing.Point(11, 150);
            this.grvPK.Margin = new System.Windows.Forms.Padding(2);
            this.grvPK.Name = "grvPK";
            this.grvPK.RowTemplate.Height = 24;
            this.grvPK.Size = new System.Drawing.Size(990, 395);
            this.grvPK.TabIndex = 25;
            // 
            // btnThoát
            // 
            this.btnThoát.Location = new System.Drawing.Point(436, 118);
            this.btnThoát.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(56, 19);
            this.btnThoát.TabIndex = 24;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.UseVisualStyleBackColor = true;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // lblLoaiPK
            // 
            this.lblLoaiPK.AutoSize = true;
            this.lblLoaiPK.Location = new System.Drawing.Point(71, 77);
            this.lblLoaiPK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiPK.Name = "lblLoaiPK";
            this.lblLoaiPK.Size = new System.Drawing.Size(71, 13);
            this.lblLoaiPK.TabIndex = 23;
            this.lblLoaiPK.Text = "Loai phụ kiện";
            // 
            // rdo100
            // 
            this.rdo100.AutoSize = true;
            this.rdo100.Location = new System.Drawing.Point(436, 73);
            this.rdo100.Name = "rdo100";
            this.rdo100.Size = new System.Drawing.Size(73, 17);
            this.rdo100.TabIndex = 31;
            this.rdo100.TabStop = true;
            this.rdo100.Text = "< 100.000";
            this.rdo100.UseVisualStyleBackColor = true;
            // 
            // rdo500
            // 
            this.rdo500.AutoSize = true;
            this.rdo500.Location = new System.Drawing.Point(544, 73);
            this.rdo500.Name = "rdo500";
            this.rdo500.Size = new System.Drawing.Size(128, 17);
            this.rdo500.TabIndex = 32;
            this.rdo500.TabStop = true;
            this.rdo500.Text = "100.000 đến 500.000";
            this.rdo500.UseVisualStyleBackColor = true;
            // 
            // rdo501
            // 
            this.rdo501.AutoSize = true;
            this.rdo501.Location = new System.Drawing.Point(695, 73);
            this.rdo501.Name = "rdo501";
            this.rdo501.Size = new System.Drawing.Size(73, 17);
            this.rdo501.TabIndex = 33;
            this.rdo501.TabStop = true;
            this.rdo501.Text = "> 500.000";
            this.rdo501.UseVisualStyleBackColor = true;
            // 
            // PhuKienDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 568);
            this.Controls.Add(this.rdo501);
            this.Controls.Add(this.rdo500);
            this.Controls.Add(this.rdo100);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.btnLoaiPK);
            this.Controls.Add(this.lblTKPK);
            this.Controls.Add(this.grvPK);
            this.Controls.Add(this.btnThoát);
            this.Controls.Add(this.lblLoaiPK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhuKienDienThoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhuKienDienThoai";
            this.Load += new System.EventHandler(this.PhuKienDienThoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvPK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Button btnLoaiPK;
        private System.Windows.Forms.Label lblTKPK;
        private System.Windows.Forms.DataGridView grvPK;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.Label lblLoaiPK;
        private System.Windows.Forms.RadioButton rdo100;
        private System.Windows.Forms.RadioButton rdo500;
        private System.Windows.Forms.RadioButton rdo501;
    }
}