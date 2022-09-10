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
    public partial class KhachHang : Form
    {
        QuanLy.kh kh = new QuanLy.kh();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                this.Close();
        }

        public void LoadDataGridview()
        {
            grvKH.DataSource = kh.StrDataSet.Tables["tblKhachHang"];
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMKH.Text.Trim() == string.Empty && txtTKH.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Hãy nhập thông tin khách hàng");
                }
                else if (txtTKH.Text.Trim() == string.Empty)
                {
                    grvKH.DataSource = kh.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaKH) AS [STT],  MaKH, TenKH, SDT, DiaChi, Email FROM dbo.tblKhachHang WHERE MaKH = '" + txtMKH.Text.Trim() + "'", "tblKhachHang");
                }
                else if (txtMKH.Text.Trim() == string.Empty)
                {
                    grvKH.DataSource = kh.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaKH) AS [STT],  MaKH, TenKH, SDT, DiaChi, Email FROM dbo.tblKhachHang WHERE TenKH = '" +txtTKH.Text.Trim() + "'" , "tblKhachHang");
                }
                else
                    grvKH.DataSource = kh.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaKH) AS [STT],  MaKH, TenKH, SDT, DiaChi, Email FROM dbo.tblKhachHang WHERE MaKH = '" + txtMKH.Text.Trim() + "' AND TenKH = '" + txtTKH.Text.Trim() + "'", "tblKhachHang");
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

    }
}
