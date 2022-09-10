using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDotNet.TimKiem
{
    public partial class NhanVien : Form
    {
        QuanLy.nv nv = new QuanLy.nv();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMNV.Text.Trim() == string.Empty && txtTNV.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Hãy nhập thông tin nhân viên");
                }
                else if (txtTNV.Text.Trim() == string.Empty)
                {
                    grvNV.DataSource = nv.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaNV) AS [STT],  MaNV, TenNV, SDT, DiaChi, Email, ChuyenMon, Luong FROM dbo.tblNhanVien WHERE MaNV = '" + txtMNV.Text.Trim() + "'", "tblNhanVien");
                }
                else if (txtMNV.Text.Trim() == string.Empty)
                {
                    grvNV.DataSource = nv.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaNV) AS [STT],  MaNV, TenNV, SDT, DiaChi, Email, ChuyenMon, Luong FROM dbo.tblNhanVien WHERE TenNV = '" + txtTNV.Text.Trim() + "'", "tblNhanVien");
                }
                else
                    grvNV.DataSource = nv.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaNV) AS [STT],  MaNV, TenNV, SDT, DiaChi, Email, ChuyenMon, Luong FROM dbo.tblNhanVien WHERE TenNV = '" + txtTNV.Text.Trim() + "' AND MaNV = '" + txtMNV.Text.Trim() + "'", "tblNhanVien");
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }

        public void LoadDataGridview()
        {
            grvNV.DataSource = nv.StrDataSet.Tables["tblNhanVien"];
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
