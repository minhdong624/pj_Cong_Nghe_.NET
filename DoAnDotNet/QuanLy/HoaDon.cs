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
    public partial class HoaDon : Form
    {
        hoadoncl hd = new hoadoncl();
        public HoaDon()
        {
            InitializeComponent();
        }

        public void LoadDataGridview()
        {
            grvHD.DataSource = hd.StrDataSet.Tables["tblHoaDon"];
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
            loadComboBox_MaNV();
            cboMaNV.SelectedIndex = 0;
            dataBindings(hd.StrDataSet.Tables["tblHoaDon"]);
            txtSTT.Enabled = txtMaHD.Enabled = txtMaKH.Enabled = txtMaSP.Enabled = txtSoSP.Enabled = txtMaPK.Enabled = txtSoPK.Enabled = txtNgayLap.Enabled = txtTong.Enabled = false;
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
        }

        private void loadComboBox_MaNV()
        {
            cboMaNV.Items.Add("Tất cả");
            string sql = "SELECT DISTINCT MaNV FROM  tblHoaDon";
            SqlDataReader rdr = hd.getDataReader(sql);
            while (rdr.Read())
            {
                cboMaNV.Items.Add(rdr["MaNV"].ToString());
            }
            rdr.Close();
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled)
            {
                if (cboMaNV.SelectedIndex == 0)
                    grvHD.DataSource = hd.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaHD) AS [STT],  MaHD, MaKH, MaNV, MaSP, SoSP, MaPK, SoPK, NgayLap, Tong FROM dbo.tblHoaDon", "tblHoaDon");
                else
                    grvHD.DataSource = hd.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaHD) AS [STT],  MaHD, MaKH, MaNV, MaSP, SoSP, MaPK, SoPK, NgayLap, Tong FROM dbo.tblHoaDon WHERE MaNV = '" + cboMaNV.Text.Trim() + "'", "tblHoaDon");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaHD.Enabled = txtMaKH.Enabled = txtMaSP.Enabled = txtSoSP.Enabled = txtMaPK.Enabled = txtSoPK.Enabled = txtNgayLap.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            txtMaHD.Clear();
            txtMaKH.Clear();
            txtSTT.Clear();
            txtMaSP.Clear();
            txtSoSP.Clear();
            txtMaPK.Clear();
            txtSoPK.Clear();
            txtMaHD.Focus();
            txtTong.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa hóa đơn " + txtMaHD.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                return;
            try
            {
                string strMaHD = txtMaHD.Text.Trim();

                //Kiểm tra khóa ngoại
                int kq = hd.delete(strMaHD);
                if (kq == 0)
                {
                    MessageBox.Show(strMaHD + " chưa tồn tại!");
                    return;
                }
                //else if (kq == 3)
                //{
                //    MessageBox.Show("Khoa này đã có lớp học dồi!");
                //}
                else if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    if (cboMaNV.SelectedIndex == 0)
                        grvHD.DataSource = hd.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaHD) AS [STT],  MaHD, MaKH, MaNV, MaSP, SoSP, MaPK, SoPK, NgayLap, Tong FROM dbo.tblHoaDon", "tblHoaDon");
                    else
                        grvHD.DataSource = hd.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaHD) AS [STT],  MaHD, MaKH, MaNV, MaSP, SoSP, MaPK, SoPK, NgayLap, Tong FROM dbo.tblHoaDon WHERE MaNV = '" + cboMaNV + "'", "tblHoaDon");
                }
                else if (kq == 2)
                {
                    MessageBox.Show("Xóa thất bại!");
                }
                btnLuu.Enabled = false;
                txtMaHD.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtMaKH.Enabled = txtMaSP.Enabled = txtSoSP.Enabled = txtMaPK.Enabled = txtSoPK.Enabled = txtNgayLap.Enabled = true;
            txtMaKH.Focus();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            txtMaKH.Clear();
            txtSTT.Clear();
            txtMaSP.Clear();
            txtSoSP.Clear();
            txtMaPK.Clear();
            txtSoPK.Clear();
            txtNgayLap.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strMaHD = txtMaHD.Text.Trim();
            string strMaKH = txtMaKH.Text.Trim();
            string strMaNV = cboMaNV.Text.Trim();
            string strMaSP = txtMaSP.Text.Trim();
            string strSoSP = txtSoSP.Text.Trim();
            string strMaPK = txtMaPK.Text.Trim();
            string strSoPK = txtSoPK.Text.Trim();
            string strNgayLap = txtNgayLap.Text.Trim();
            string strTong = txtTong.Text.Trim();
            if (strMaHD == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblMaHD.Text);
                txtMaHD.Focus();
                return;
            }
            if (strMaKH == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblMaKH.Text);
                txtMaKH.Focus();
                return;
            }
            if (cboMaNV.SelectedIndex == 0)
            {
                MessageBox.Show("Bạn chưa chọn " + lblMaNV.Text);
                cboMaNV.Focus();
                return;
            }
            if (strMaSP == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblMaSP.Text);
                txtMaSP.Focus();
                return;
            }
            if (strSoSP == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblSoSP.Text);
                txtSoSP.Focus();
                return;
            }
            if (strMaPK == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblMaPK.Text);
                txtMaPK.Focus();
                return;
            }
            if (strSoPK == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblSoPK.Text);
                txtSoPK.Focus();
                return;
            }
            if (strNgayLap == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblNgayLap.Text);
                txtNgayLap.Focus();
                return;
            }
            if (DateTime.Parse(txtNgayLap.Text) > DateTime.Today)
            {
                MessageBox.Show("Bạn nhập sai ngày " );
                txtNgayLap.Focus();
                return;
            }
            //Tiến hành kiểm tra và lưu dữ liệu
            int kq;
            try
            {
                //Kiểm tra lưu mới hay cập nhật
                if (txtMaHD.Enabled == true)
                {//Lưu mới
                    kq = hd.add(strMaHD, strMaKH, strMaNV, strMaSP, strSoSP, strMaPK, strSoPK, strNgayLap, strTong);
                    //Kiểm tra tồn tại
                    if (kq == 0)
                    {
                        MessageBox.Show(strMaHD + " đã tồn tại!");
                        txtMaHD.Clear();
                        txtMaHD.Focus();
                        return;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Thêm thành công!");
                        txtMaHD.Enabled = txtMaKH.Enabled = txtMaSP.Enabled = txtSoSP.Enabled = txtMaPK.Enabled = txtSoPK.Enabled = txtNgayLap.Enabled = false;
                        btnThem.Enabled = true;
                        cboMaNV.SelectedIndex = 0;
                        grvHD.DataSource = hd.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaHD) AS [STT],  MaHD, MaKH, MaNV, MaSP, SoSP, MaPK, SoPK, NgayLap, Tong FROM dbo.tblHoaDon", "tblHoaDon");
                    }
                    else if (kq == 2)
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
                else
                {//Lưu cập nhật
                    kq = hd.update(strMaHD, strMaKH, strMaNV, strMaSP, strSoSP, strMaPK, strSoPK, strNgayLap, strTong);
                    if (kq == 0)
                    {
                        MessageBox.Show(strMaHD + " chưa tồn tại!");
                        return;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        txtMaHD.Enabled = txtMaKH.Enabled = txtMaSP.Enabled = txtSoSP.Enabled = txtMaPK.Enabled = txtSoPK.Enabled = txtNgayLap.Enabled = false;
                        btnThem.Enabled = true;
                    }
                    else if (kq == 2)
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                    txtMaHD.Enabled = true;
                }
                btnLuu.Enabled = false;
                //txtSTT.Enabled = txtMaHD.Enabled = txtMaSP.Enabled = txtHeight.Enabled = txtPin.Enabled = txtPrice.Enabled = txtRam.Enabled = txtRom.Enabled = txtScreen.Enabled = txtWeight.Enabled = txtWipkh.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lưu không thành công!");
            }


        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = txtMaKH.Enabled = txtMaSP.Enabled = txtSoSP.Enabled = txtMaPK.Enabled = txtSoPK.Enabled = txtNgayLap.Enabled = false;
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                this.Close();
        }

        private void grvHD_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = btnSua.Enabled = true;
        }

        public void dataBindings(DataTable pTable)
        {
            txtMaHD.Clear();
            txtMaKH.Clear();
            txtSTT.Clear();
            txtMaSP.Clear();
            txtSoSP.Clear();
            txtMaPK.Clear();
            txtSoPK.Clear();
            txtTong.Clear();
            txtMaHD.DataBindings.Add("Text", pTable, "MaHD", true,
            DataSourceUpdateMode.Never);
            txtMaKH.DataBindings.Add("Text", pTable, "MaKH", true,
            DataSourceUpdateMode.Never);
            txtMaSP.DataBindings.Add("Text", pTable, "MaSP", true,
            DataSourceUpdateMode.Never);
            txtSoSP.DataBindings.Add("Text", pTable, "SoSP", true,
            DataSourceUpdateMode.Never);
            txtMaPK.DataBindings.Add("Text", pTable, "MaPK", true,
            DataSourceUpdateMode.Never);
            txtSoPK.DataBindings.Add("Text", pTable, "SoPK", true,
            DataSourceUpdateMode.Never);
            txtTong.DataBindings.Add("Text", pTable, "Tong", true,
            DataSourceUpdateMode.Never);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                string strMaSP = txtMaSP.Text.Trim();
                string strSoSP = txtSoSP.Text.Trim();
                string strMaPK = txtMaPK.Text.Trim();
                string strSoPK = txtSoPK.Text.Trim();

                if (strMaSP == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập " + lblMaSP.Text);
                    txtMaSP.Focus();
                    return;
                }
                if (strSoSP == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập " + lblSoSP.Text);
                    txtSoSP.Focus();
                    return;
                }
                if (strMaPK == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập " + lblMaPK.Text);
                    txtMaPK.Focus();
                    return;
                }
                if (strSoPK == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập " + lblSoPK.Text);
                    txtSoPK.Focus();
                    return;
                }

                string giadt = "";
                string giapk = "";
                string sql = "SELECT Price FROM  tblDienThoai WHERE MaSP = '" + strMaSP + "'";
                SqlDataReader rdr = hd.getDataReader(sql);
                while (rdr.Read())
                {
                    giadt = rdr["Price"].ToString();
                }
                rdr.Close();

                string sql1 = "SELECT Gia FROM  tblPhuKien WHERE MaPK = '" + strMaPK + "'";
                SqlDataReader rdr1 = hd.getDataReader(sql1);
                while (rdr1.Read())
                {
                    giapk = rdr1["Gia"].ToString();
                }
                rdr1.Close();

                float tong = float.Parse(giadt) * float.Parse(strSoSP) + float.Parse(giapk) * float.Parse(strSoPK);

                txtTong.Text = tong.ToString();
            }
            catch
            {
                MessageBox.Show("Sai dữ liệu, vui lòng kiểm tra lại");
            }
        }

        public void show_frm_ql_From(Form frm)
        {
            frm.Show();
            frm.Focus();
        }

        public void show_frm_ql_From_else(Form frm)
        {
            frm.Show();
            frm.Focus();
        }

        public QuanLy.InHoaDon InHoaDon = new QuanLy.InHoaDon();

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (InHoaDon == null)
            {
                InHoaDon = new QuanLy.InHoaDon();
                show_frm_ql_From(InHoaDon);
            }
            else
            {
                if (InHoaDon.IsDisposed)
                {
                    InHoaDon = null;
                    InHoaDon = new QuanLy.InHoaDon();
                    show_frm_ql_From(InHoaDon);
                }
                else
                {
                    show_frm_ql_From_else(InHoaDon);
                }
            }
        }
    }
}
