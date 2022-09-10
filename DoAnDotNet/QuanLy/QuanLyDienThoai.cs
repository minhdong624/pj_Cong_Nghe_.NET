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
    public partial class QuanLyDienThoai : Form
    {
        DienThoai dt = new DienThoai();
        public QuanLyDienThoai()
        {
            InitializeComponent();
        }

        public void LoadDataGridview()
        {
            grvDT.DataSource = dt.StrDataSet.Tables["tblDienThoai"];
        }

        private void QuanLyDienThoai_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
            loadComboBox_Hang();
            cboHang.SelectedIndex = 0;
            dataBindings(dt.StrDataSet.Tables["tblDienThoai"]);
            txtSTT.Enabled = txtMaSP.Enabled = txtTenSP.Enabled = txtHeight.Enabled = txtPin.Enabled = txtPrice.Enabled = txtRam.Enabled = txtRom.Enabled = txtScreen.Enabled = txtWeight.Enabled = txtWidth.Enabled = false;
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
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

        private void cboHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                if (cboHang.SelectedIndex == 0)
                {
                    grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai", "tblDienThoai");
                }
                else
                    grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai WHERE Hang = '" + cboHang.Text.Trim() + "'", "tblDienThoai");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaSP.Enabled = txtTenSP.Enabled = txtHeight.Enabled = txtPin.Enabled = txtPrice.Enabled = txtRam.Enabled = txtRom.Enabled = txtScreen.Enabled = txtWeight.Enabled = txtWidth.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = txtSTT.Enabled = false;
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtHeight.Clear();
            txtPin.Clear();
            txtPrice.Clear();
            txtRam.Clear();
            txtRom.Clear();
            txtScreen.Clear();
            txtSTT.Clear();
            txtWeight.Clear();
            txtWidth.Clear();
            txtMaSP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa điện thoại " + txtTenSP.Text.Trim() + " không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                return;
            try
            {
                string strMaSP = txtMaSP.Text.Trim();

                //Kiểm tra khóa ngoại
                int kq = dt.delete(strMaSP);
                if (kq == 0)
                {
                    MessageBox.Show(strMaSP + " chưa tồn tại!");
                    return;
                }
                else if (kq == 3)
                {
                    MessageBox.Show("Điện thoại đã tồn tại trong hóa đơn!");
                }
                else if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    if (cboHang.SelectedIndex == 0)
                    {
                        grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai", "tblDienThoai");
                    }
                    else
                        grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai WHERE Hang = '" + cboHang.Text.Trim() + "'", "tblDienThoai");
                }
                else if (kq == 2)
                {
                    MessageBox.Show("Xóa thất bại!");
                }
                btnLuu.Enabled = false;
                txtMaSP.Enabled = txtTenSP.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaSP.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtTenSP.Enabled = txtHeight.Enabled = txtPin.Enabled = txtPrice.Enabled = txtRam.Enabled = txtRom.Enabled = txtScreen.Enabled = txtWeight.Enabled = txtWidth.Enabled = true;
            txtTenSP.Focus();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtSTT.Clear();
            txtTenSP.Clear();
            txtWeight.Clear();
            txtWidth.Clear();
            txtHeight.Clear();
            txtMaSP.Clear();
            txtPin.Clear();
            txtPrice.Clear();
            txtRam.Clear();
            txtRom.Clear();
            txtScreen.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strMaSP = txtMaSP.Text.Trim();
            string strHang = cboHang.Text.Trim();
            string strTenSP = txtTenSP.Text.Trim();
            string strRam = txtRam.Text.Trim();
            string strRom = txtRom.Text.Trim();
            string strWeight = txtWeight.Text.Trim();
            string strScreen = txtScreen.Text.Trim();
            string strPin = txtPin.Text.Trim();
            string strWidth = txtWidth.Text.Trim();
            string strHeight = txtHeight.Text.Trim();
            string strPrice = txtPrice.Text.Trim();
            if (strMaSP == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblMaSP.Text);
                txtMaSP.Focus();
                return;
            }
            if (cboHang.SelectedIndex == 0)
            {
                MessageBox.Show("Bạn chưa chọn " + lblHang.Text);
                cboHang.Focus();
                return;
            }
            if (strTenSP == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblTenSP.Text);
                txtTenSP.Focus();
                return;
            }
            if (strRam == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblRam.Text);
                txtRam.Focus();
                return;
            }
            if (strRom == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblRom.Text);
                txtRom.Focus();
                return;
            }
            if (strWeight == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblWeight.Text);
                txtWeight.Focus();
                return;
            }
            if (strScreen == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblScreen.Text);
                txtScreen.Focus();
                return;
            }
            if (strPin == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblPin.Text);
                txtPin.Focus();
                return;
            }
            if (strWidth == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblWidth.Text);
                txtWidth.Focus();
                return;
            }
            if (strHeight == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblHeight.Text);
                txtHeight.Focus();
                return;
            }
            if (strPrice == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập " + lblPrice.Text);
                txtPrice.Focus();
                return;
            }
            //Tiến hành kiểm tra và lưu dữ liệu
            int kq;
            try
            {
                //Kiểm tra lưu mới hay cập nhật
                if (txtMaSP.Enabled == true)
                {//Lưu mới
                    kq = dt.add(strMaSP, strHang, strTenSP, strRam, strRom, strWeight, strScreen, strPin, strWidth, strHeight, strPrice);
                    //Kiểm tra tồn tại
                    if (kq == 0)
                    {
                        MessageBox.Show(strMaSP + " đã tồn tại!");
                        txtMaSP.Clear();
                        txtMaSP.Focus();
                        return;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Thêm thành công!");
                        txtMaSP.Enabled = txtTenSP.Enabled = txtHeight.Enabled = txtPin.Enabled = txtPrice.Enabled = txtRam.Enabled = txtRom.Enabled = txtScreen.Enabled = txtWeight.Enabled = txtWidth.Enabled = false;
                        btnThem.Enabled = true;
                        grvDT.DataSource = dt.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai", "tblDienThoai");
                    }
                    else if (kq == 2)
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
                else
                {//Lưu cập nhật
                    kq = dt.update(strMaSP, strHang, strTenSP, strRam, strRom, strWeight, strScreen, strPin, strWidth, strHeight, strPrice);
                    if (kq == 0)
                    {
                        MessageBox.Show(strMaSP + " chưa tồn tại!");
                        return;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        txtMaSP.Enabled = txtTenSP.Enabled = txtHeight.Enabled = txtPin.Enabled = txtPrice.Enabled = txtRam.Enabled = txtRom.Enabled = txtScreen.Enabled = txtWeight.Enabled = txtWidth.Enabled = false;
                        btnThem.Enabled = true;
                    }
                    else if (kq == 2)
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                    txtMaSP.Enabled = true;
                }
                btnLuu.Enabled = false;
                //txtSTT.Enabled = txtMaSP.Enabled = txtTenSP.Enabled = txtHeight.Enabled = txtPin.Enabled = txtPrice.Enabled = txtRam.Enabled = txtRom.Enabled = txtScreen.Enabled = txtWeight.Enabled = txtWidth.Enabled = false;
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

        private void grvDT_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = btnSua.Enabled = true;
        }

        public void dataBindings(DataTable pTable)
        {
            txtMaSP.DataBindings.Clear(); 
            txtTenSP.DataBindings.Clear();
            txtHeight.DataBindings.Clear();
            txtPin.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtRam.DataBindings.Clear();
            txtRom.DataBindings.Clear();
            txtScreen.DataBindings.Clear();
            txtSTT.DataBindings.Clear();
            txtWeight.DataBindings.Clear();
            txtWidth.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", pTable, "MaSP", true,
            DataSourceUpdateMode.Never);
            txtTenSP.DataBindings.Add("Text", pTable, "TenSP", true,
            DataSourceUpdateMode.Never);
            txtHeight.DataBindings.Add("Text", pTable, "Height", true,
            DataSourceUpdateMode.Never);
            txtPin.DataBindings.Add("Text", pTable, "Pin", true,
            DataSourceUpdateMode.Never);
            txtPrice.DataBindings.Add("Text", pTable, "Price", true,
            DataSourceUpdateMode.Never);
            txtRam.DataBindings.Add("Text", pTable, "Ram", true,
            DataSourceUpdateMode.Never);
            txtRom.DataBindings.Add("Text", pTable, "Rom", true,
            DataSourceUpdateMode.Never);
            txtScreen.DataBindings.Add("Text", pTable, "Screen", true,
            DataSourceUpdateMode.Never);
            txtSTT.DataBindings.Add("Text", pTable, "STT", true,
            DataSourceUpdateMode.Never);
            txtWeight.DataBindings.Add("Text", pTable, "Weight", true,
            DataSourceUpdateMode.Never);
            txtWidth.DataBindings.Add("Text", pTable, "Width", true,
            DataSourceUpdateMode.Never);
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            txtSTT.Enabled = txtMaSP.Enabled = txtTenSP.Enabled = txtHeight.Enabled = txtPin.Enabled = txtPrice.Enabled = txtRam.Enabled = txtRom.Enabled = txtScreen.Enabled = txtWeight.Enabled = txtWidth.Enabled = false;
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        
    }
}
