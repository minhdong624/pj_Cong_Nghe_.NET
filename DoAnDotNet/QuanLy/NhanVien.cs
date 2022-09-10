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
    public partial class NhanVien : Form
    {
        nv nv = new nv();
        public NhanVien()
        {
            InitializeComponent();
        }
        public void LoadDataGridview()
        {
            grvNV.DataSource = nv.StrDataSet.Tables["tblNhanVien"];
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
            loadComboBox_NhanVien();
            cboChuyenMon.SelectedIndex = 0;
            dataBindings(nv.StrDataSet.Tables["tblNhanVien"]);
            txtSTT.Enabled = txtMaNV.Enabled = txtTenNV.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtLuong.Enabled = false;
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
        }

        private void loadComboBox_NhanVien()
        {
            cboChuyenMon.Items.Add("Tất cả");
            string sql = "SELECT DISTINCT ChuyenMon FROM  tblNhanVien";
            SqlDataReader rdr = nv.getDataReader(sql);
            while (rdr.Read())
            {
                cboChuyenMon.Items.Add(rdr["ChuyenMon"].ToString());
            }
            rdr.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaNV.Enabled = txtTenNV.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtLuong.Enabled = cboChuyenMon.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = txtSTT.Enabled = false;
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtLuong.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa nhân viên " + txtTenNV.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                return;
            try
            {
                string strMaNV = txtMaNV.Text.Trim();

                //Kiểm tra khóa ngoại
                int kq = nv.delete(strMaNV);
                if (kq == 0)
                {
                    MessageBox.Show(strMaNV + " chưa tồn tại!");
                    return;
                }
                else if (kq == 3)
                {
                    MessageBox.Show("Nhân viên đã tồn tại trong hóa đơn!");
                }
                else if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    if (cboChuyenMon.SelectedIndex == 0)
                    {
                        grvNV.DataSource = nv.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaNV) AS [STT],  MaNV, TenNV, SDT, DiaChi, Email, ChuyenMon, Luong FROM dbo.tblNhanVien", "tblNhanVien");
                    }
                    else
                        grvNV.DataSource = nv.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaNV) AS [STT],  MaNV, TenNV, SDT, DiaChi, Email, ChuyenMon, Luong FROM dbo.tblNhanVien WHERE ChuyenMon = '" + cboChuyenMon.Text.Trim() + "'", "tblNhanVien");
                }
                else if (kq == 2)
                {
                    MessageBox.Show("Xóa thất bại!");
                }
                btnLuu.Enabled = false;
                txtMaNV.Enabled = txtTenNV.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void cboChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                if (cboChuyenMon.SelectedIndex == 0)
                {
                    grvNV.DataSource = nv.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaNV) AS [STT],  MaNV, TenNV, SDT, DiaChi, Email, ChuyenMon, Luong FROM dbo.tblNhanVien", "tblNhanVien");
                }
                else
                    grvNV.DataSource = nv.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaNV) AS [STT],  MaNV, TenNV, SDT, DiaChi, Email, ChuyenMon, Luong FROM dbo.tblNhanVien WHERE ChuyenMon = '" + cboChuyenMon.Text + "'", "tblNhanVien");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtTenNV.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtLuong.Enabled = cboChuyenMon.Enabled = true;
            txtTenNV.Focus();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtSTT.Clear();
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtLuong.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strMaNV = txtMaNV.Text.Trim();
            string strChuyenMon = cboChuyenMon.Text.Trim();
            string strTenNV = txtTenNV.Text.Trim();
            string strSDT = txtSDT.Text.Trim();
            string strDiaChi = txtDiaChi.Text.Trim();
            string strEmail = txtEmail.Text.Trim();
            string strLuong = txtLuong.Text.Trim();
            if (strMaNV == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblMaNV.Text);
                txtMaNV.Focus();
                return;
            }
            if (cboChuyenMon.SelectedIndex == 0)
            {
                MessageBox.Show("Bạn chưa chọn " + lblChuyenMon.Text);
                cboChuyenMon.Focus();
                return;
            }
            if (strTenNV == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblTenNV.Text);
                txtTenNV.Focus();
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
            if (strLuong == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblLuong.Text);
                txtLuong.Focus();
                return;
            }
            //Tiến hành kiểm tra và lưu dữ liệu
            int kq;
            try
            {
                //Kiểm tra lưu mới hay cập nhật
                if (txtMaNV.Enabled == true)
                {//Lưu mới
                    kq = nv.add(strMaNV, strTenNV, strSDT, strDiaChi, strEmail, strChuyenMon, strLuong);
                    //Kiểm tra tồn tại
                    if (kq == 0)
                    {
                        MessageBox.Show(strMaNV + " đã tồn tại!");
                        txtMaNV.Clear();
                        txtMaNV.Focus();
                        return;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Thêm thành công!");
                        txtMaNV.Enabled = txtTenNV.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtLuong.Enabled = cboChuyenMon.Enabled = true;
                        btnThem.Enabled = true;
                        grvNV.DataSource = nv.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaNV) AS [STT],  MaNV, TenNV, SDT, DiaChi, Email, ChuyenMon, Luong FROM dbo.tblNhanVien", "tblNhanVien");
                    }
                    else if (kq == 2)
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
                else
                {//Lưu cập nhật
                    kq = nv.update(strMaNV, strTenNV, strSDT, strDiaChi, strEmail, strChuyenMon, strLuong);
                    if (kq == 0)
                    {
                        MessageBox.Show(strMaNV + " chưa tồn tại!");
                        return;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        txtMaNV.Enabled = txtTenNV.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtLuong.Enabled = cboChuyenMon.Enabled = true;
                        btnThem.Enabled = true;
                    }
                    else if (kq == 2)
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                    txtMaNV.Enabled = true;
                }
                btnLuu.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lưu không thành công!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                this.Close();
        }

        private void grvNV_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = btnSua.Enabled = true;
        }

        public void dataBindings(DataTable pTable)
        {
            txtSTT.Clear();
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtLuong.Clear();
            txtMaNV.DataBindings.Add("Text", pTable, "MaNV", true,
            DataSourceUpdateMode.Never);
            txtTenNV.DataBindings.Add("Text", pTable, "TenNV", true,
            DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Add("Text", pTable, "SDT", true,
            DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", pTable, "DiaChi", true,
            DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("Text", pTable, "Email", true,
            DataSourceUpdateMode.Never);
            txtLuong.DataBindings.Add("Text", pTable, "Luong", true,
            DataSourceUpdateMode.Never);
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = txtTenNV.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtLuong.Enabled  = false;
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }
    }
}
