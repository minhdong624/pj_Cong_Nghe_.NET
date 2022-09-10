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
    public partial class PhuKienDienThoai : Form
    {
        PhuKien pk = new PhuKien();
        public PhuKienDienThoai()
        {
            InitializeComponent();
        }

        public void LoadDataGridview()
        {
            grvPK.DataSource = pk.StrDataSet.Tables["tblPhuKien"];
        }

        private void PhuKienDienThoai_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
            loadComboBox_Hang();
            cboHang.SelectedIndex = 0;
            loadComboBox_Loai();
            cboLoai.SelectedIndex = 0;
            dataBindings(pk.StrDataSet.Tables["tblPhuKien"]);
            txtSTT.Enabled = txtMaPK.Enabled = txtTenPK.Enabled = txtGia.Enabled = false;
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
        }

        private void loadComboBox_Hang()
        {
            cboHang.Items.Add("Tất cả");
            string sql = "SELECT DISTINCT Hang FROM  tblPhuKien";
            SqlDataReader rdr = pk.getDataReader(sql);
            while (rdr.Read())
            {
                cboHang.Items.Add(rdr["Hang"].ToString());
            }
            rdr.Close();
        }

        private void loadComboBox_Loai()
        {
            cboLoai.Items.Add("Tất cả");
            string sql = "SELECT DISTINCT Loai FROM  tblPhuKien";
            SqlDataReader rdr = pk.getDataReader(sql);
            while (rdr.Read())
            {
                cboLoai.Items.Add(rdr["Loai"].ToString());
            }
            rdr.Close();
        }

        private void cboHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                if (cboHang.SelectedIndex == 0 && cboLoai.SelectedIndex == 0)
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien", "tblPhuKien");
                else if (cboHang.SelectedIndex == 0)
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Loai = '" + cboLoai.Text + "'", "tblPhuKien");
                else if (cboLoai.SelectedIndex == 0)
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Hang = '" + cboHang.Text + "'", "tblPhuKien");
                else
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Hang = '" + cboHang.Text + "' AND Loai = '" + cboLoai.Text + "'", "tblPhuKien");
            }
            
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                if (cboHang.SelectedIndex == 0 && cboLoai.SelectedIndex == 0)
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien", "tblPhuKien");
                else if (cboHang.SelectedIndex == 0)
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Loai = '" + cboLoai.Text.Trim() + "'", "tblPhuKien");
                else if (cboLoai.SelectedIndex == 0)
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Hang = '" + cboHang.Text.Trim() + "'", "tblPhuKien");
                else
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Hang = '" + cboHang.Text.Trim() + "' AND Loai = '" + cboLoai.Text.Trim() + "'", "tblPhuKien");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaPK.Enabled = txtTenPK.Enabled = txtGia.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = txtSTT.Enabled = false;
            txtMaPK.Clear();
            txtTenPK.Clear();
            txtSTT.Clear();
            txtGia.Clear();
            txtMaPK.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa phụ kiện " + txtTenPK.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                return;
            try
            {
                string strMaPK = txtMaPK.Text.Trim();

                //Kiểm tra khóa ngoại
                int kq = pk.delete(strMaPK);
                if (kq == 0)
                {
                    MessageBox.Show(strMaPK + " chưa tồn tại!");
                    return;
                }
                else if (kq == 3)
                {
                    MessageBox.Show("Phụ kiện đã tồn tại trong hóa đơn!");
                }
                else if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    if (cboHang.SelectedIndex == 0 && cboLoai.SelectedIndex == 0)
                        grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien", "tblPhuKien");
                    else if (cboHang.SelectedIndex == 0)
                        grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Loai = '" + cboLoai.SelectedText.Trim() + "'", "tblPhuKien");
                    else if (cboLoai.SelectedIndex == 0)
                        grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Hang = '" + cboHang.SelectedText.Trim() + "'", "tblPhuKien");
                    else
                        grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Hang = '" + cboHang.SelectedText.Trim() + "' AND Loai = '" + cboLoai.SelectedText.Trim() + "'", "tblPhuKien");
                }
                else if (kq == 2)
                {
                    MessageBox.Show("Xóa thất bại!");
                }
                btnLuu.Enabled = false;
                txtMaPK.Enabled = txtTenPK.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaPK.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtTenPK.Enabled = txtGia.Enabled = true;
            txtTenPK.Focus();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtSTT.Clear();
            txtTenPK.Clear();
            txtMaPK.Clear();
            txtGia.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strMaPK = txtMaPK.Text.Trim();
            string strHang = cboHang.Text.Trim();
            string strLoai = cboLoai.Text.Trim();
            string strTenPK = txtTenPK.Text.Trim();
            string strGia = txtGia.Text.Trim();
            if (strMaPK == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblMaPK.Text);
                txtMaPK.Focus();
                return;
            }
            if (cboHang.SelectedIndex == 0)
            {
                MessageBox.Show("Bạn chưa chọn " + lblHang.Text);
                cboHang.Focus();
                return;
            }
            if (cboLoai.SelectedIndex == 0)
            {
                MessageBox.Show("Bạn chưa chọn " + lblLoai.Text);
                cboHang.Focus();
                return;
            }
            if (strTenPK == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblTenPK.Text);
                txtTenPK.Focus();
                return;
            }
            if (strGia == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblGia.Text);
                txtGia.Focus();
                return;
            }
            //Tiến hành kiểm tra và lưu dữ liệu
            int kq;
            try
            {
                //Kiểm tra lưu mới hay cập nhật
                if (txtMaPK.Enabled == true)
                {//Lưu mới
                    kq = pk.add(strMaPK, strHang, strTenPK, strLoai, strLoai);
                    //Kiểm tra tồn tại
                    if (kq == 0)
                    {
                        MessageBox.Show(strMaPK + " đã tồn tại!");
                        txtMaPK.Clear();
                        txtMaPK.Focus();
                        return;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Thêm thành công!");
                        txtMaPK.Enabled = txtTenPK.Enabled = txtGia.Enabled = false;
                        btnThem.Enabled = true;
                        cboHang.SelectedIndex = 0;
                        cboLoai.SelectedIndex = 0;
                        grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Ram, Rom, Weight, Screen, Pin, Wipkh, Height, Price FROM dbo.tblPhuKien", "tblPhuKien");
                    }
                    else if (kq == 2)
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
                else
                {//Lưu cập nhật
                    kq = pk.update(strMaPK, strHang, strTenPK, strLoai, strGia);
                    if (kq == 0)
                    {
                        MessageBox.Show(strMaPK + " chưa tồn tại!");
                        return;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        txtMaPK.Enabled = txtTenPK.Enabled = txtGia.Enabled = false;
                        btnThem.Enabled = true;
                    }
                    else if (kq == 2)
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                    txtMaPK.Enabled = true;
                }
                btnLuu.Enabled = false;
                //txtSTT.Enabled = txtMaPK.Enabled = txtTenPK.Enabled = txtHeight.Enabled = txtPin.Enabled = txtPrice.Enabled = txtRam.Enabled = txtRom.Enabled = txtScreen.Enabled = txtWeight.Enabled = txtWipkh.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lưu không thành công!");
            }
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            txtMaPK.Enabled = txtTenPK.Enabled = txtGia.Enabled = false;
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
            txtMaPK.DataBindings.Clear();
            txtTenPK.DataBindings.Clear();
            txtSTT.DataBindings.Clear();
            txtGia.DataBindings.Clear();
            txtMaPK.DataBindings.Add("Text", pTable, "MaPK", true,
            DataSourceUpdateMode.Never);
            txtTenPK.DataBindings.Add("Text", pTable, "TenPK", true,
            DataSourceUpdateMode.Never);
            txtSTT.DataBindings.Add("Text", pTable, "STT", true,
            DataSourceUpdateMode.Never);
            txtGia.DataBindings.Add("Text", pTable, "Gia", true,
            DataSourceUpdateMode.Never);
        }
    }
}
