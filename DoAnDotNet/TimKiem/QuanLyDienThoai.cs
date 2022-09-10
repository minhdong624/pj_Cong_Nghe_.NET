using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DoAnDotNet.TimKiem
{
    public partial class QuanLyDienThoai : Form
    {
        QuanLy.DienThoai dt = new QuanLy.DienThoai();
        public QuanLyDienThoai()
        {
            InitializeComponent();
        }

        private void loadComboBox_Hang()
        {
            cboHang.Items.Add("Tất cả");
            string sql = "SELECT DISTINCT Hang FROM  tblDienThoai";
            SqlDataReader rdr = dt.getDataReader(sql);
            while (rdr.Read())
            {
                cboHang.Items.Add(rdr["Hang"].ToString());
            }
            rdr.Close();
        }

        private void loadComboBox_Ram()
        {
            cboRam.Items.Add("Tất cả");
            string sql = "SELECT DISTINCT Ram FROM  tblDienThoai";
            SqlDataReader rdr = dt.getDataReader(sql);
            while (rdr.Read())
            {
                cboRam.Items.Add(rdr["Ram"].ToString());
            }
            rdr.Close();
        }

        private void loadComboBox_Rom()
        {
            cboRom.Items.Add("Tất cả");
            string sql = "SELECT DISTINCT Rom FROM  tblDienThoai";
            SqlDataReader rdr = dt.getDataReader(sql);
            while (rdr.Read())
            {
                cboRom.Items.Add(rdr["Rom"].ToString());
            }
            rdr.Close();
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                this.Close();
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            if (cboHang.SelectedIndex == 0)
            {
                grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai", "tblDienThoai");
            }
            else
                grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai WHERE Hang = '" + cboHang.Text.Trim() + "'", "tblDienThoai");
        }

        private void btnRam_Click(object sender, EventArgs e)
        {
            if (cboRam.SelectedIndex == 0)
            {
                grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai", "tblDienThoai");
            }
            else
                grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai WHERE Ram = '" + cboRam.Text.Trim() + "'", "tblDienThoai");
        }

        private void btnRom_Click(object sender, EventArgs e)
        {
            if (cboRom.SelectedIndex == 0)
            {
                grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai", "tblDienThoai");
            }
            else
                grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai WHERE Rom = '" + cboRom.Text.Trim() + "'", "tblDienThoai");
        }

        private void QuanLyDienThoai_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
            loadComboBox_Hang();
            cboHang.SelectedIndex = 0;
            loadComboBox_Ram();
            cboRam.SelectedIndex = 0;
            loadComboBox_Rom();
            cboRom.SelectedIndex = 0;

        }

        public void LoadDataGridview()
        {
            grvDT.DataSource = dt.StrDataSet.Tables["tblDienThoai"];
        }


    }
}
