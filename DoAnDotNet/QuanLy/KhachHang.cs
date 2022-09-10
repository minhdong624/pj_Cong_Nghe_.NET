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

namespace DoAnDotNet.QuanLy
{
    public partial class KhachHang : Form
    {
        kh kh = new kh();
        public KhachHang()
        {
            InitializeComponent();
        }

        public void LoadDataGridview()
        {
            grvKH.DataSource = kh.StrDataSet.Tables["tblKhachHang"];
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
            dataBindings(kh.StrDataSet.Tables["tblKhachHang"]);
            txtSTT.Enabled = txtMaKH.Enabled = txtTenKH.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = false;
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaKH.Enabled = txtTenKH.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = txtSTT.Enabled = false;
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa nhân viên " + txtTenKH.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                return;
            try
            {
                string strMaKH = txtMaKH.Text.Trim();

                //Kiểm tra khóa ngoại
                int kq = kh.delete(strMaKH);
                if (kq == 0)
                {
                    MessageBox.Show(strMaKH + " chưa tồn tại!");
                    return;
                }
                else if (kq == 3)
                {
                    MessageBox.Show("Khách hàng đã tồn tại trong hóa đơn!");
                }
                else if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    grvKH.DataSource = kh.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaKH) AS [STT],  MaKH, TenKH, SDT, DiaChi, Email FROM dbo.tblKhachHang", "tblKhachHang");
                }
                else if (kq == 2)
                {
                    MessageBox.Show("Xóa thất bại!");
                }
                btnLuu.Enabled = false;
                txtMaKH.Enabled = txtTenKH.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtTenKH.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = true;
            txtTenKH.Focus();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtSTT.Clear();
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strMaKH = txtMaKH.Text.Trim();
            string strTenKH = txtTenKH.Text.Trim();
            string strSDT = txtSDT.Text.Trim();
            string strDiaChi = txtDiaChi.Text.Trim();
            string strEmail = txtEmail.Text.Trim();
            if (strMaKH == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblMaKH.Text);
                txtMaKH.Focus();
                return;
            }
            if (strTenKH == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblTenKH.Text);
                txtTenKH.Focus();
                return;
            }
            if (strSDT == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblSDT.Text);
                txtSDT.Focus();
                return;
            }
            if (strDiaChi == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblDiaChi.Text);
                txtDiaChi.Focus();
                return;
            }
            if (strEmail == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblEmail.Text);
                txtEmail.Focus();
                return;
            }
            //Tiến hành kiểm tra và lưu dữ liệu
            int kq;
            try
            {
                //Kiểm tra lưu mới hay cập nhật
                if (txtMaKH.Enabled == true)
                {//Lưu mới
                    kq = kh.add(strMaKH, strTenKH, strSDT, strDiaChi, strEmail);
                    //Kiểm tra tồn tại
                    if (kq == 0)
                    {
                        MessageBox.Show(strMaKH + " đã tồn tại!");
                        txtMaKH.Clear();
                        txtMaKH.Focus();
                        return;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Thêm thành công!");
                        txtMaKH.Enabled = txtTenKH.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = true;
                        btnThem.Enabled = true;
                        grvKH.DataSource = kh.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaKH) AS [STT],  MaKH, TenKH, SDT, DiaChi, Email FROM dbo.tblKhachHang", "tblKhachHang");
                    }
                    else if (kq == 2)
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
                else
                {//Lưu cập nhật
                    kq = kh.update(strMaKH, strTenKH, strSDT, strDiaChi, strEmail);
                    if (kq == 0)
                    {
                        MessageBox.Show(strMaKH + " chưa tồn tại!");
                        return;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        txtMaKH.Enabled = txtTenKH.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = true;
                        btnThem.Enabled = true;
                    }
                    else if (kq == 2)
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                    txtMaKH.Enabled = true;
                }
                btnLuu.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lưu không thành công!");
            }
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = txtTenKH.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = false;
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                this.Close();
        }

        private void grvKH_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = btnSua.Enabled = true;
        }

        public void dataBindings(DataTable pTable)
        {
            txtSTT.Clear();
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtMaKH.DataBindings.Add("Text", pTable, "MaKH", true,
            DataSourceUpdateMode.Never);
            txtTenKH.DataBindings.Add("Text", pTable, "TenKH", true,
            DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Add("Text", pTable, "SDT", true,
            DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", pTable, "DiaChi", true,
            DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("Text", pTable, "Email", true,
            DataSourceUpdateMode.Never);
        }

    }
}
