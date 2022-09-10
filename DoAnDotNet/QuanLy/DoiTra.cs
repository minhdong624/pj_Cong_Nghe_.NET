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
    public partial class DoiTra : Form
    {
        QuanLy.DienThoai dt = new QuanLy.DienThoai();

        public DoiTra()
        {
            InitializeComponent();
        }

        private void loadComboBox_Hang()
        {
            cboHang.Items.Add("Chọn 1 hãng");
            string sql = "SELECT DISTINCT Hang FROM  tblDienThoai";
            SqlDataReader rdr = dt.getDataReader(sql);
            while (rdr.Read())
            {
                cboHang.Items.Add(rdr["Hang"].ToString());
            }
            rdr.Close();
        }

        private void loadComboBox_DienThoai()
        {
            string sql = "SELECT TenSP FROM  tblDienThoai WHERE Hang = '" + cboHang.Text.Trim() + "'";
            SqlDataReader rdr = dt.getDataReader(sql);
            while (rdr.Read())
            {
                cboDienThoai.Items.Add(rdr["TenSP"].ToString());
            }
            rdr.Close();
        }

        private void lblHang_Click(object sender, EventArgs e)
        {

        }

        private void rdoTra_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void DoiTra_Load(object sender, EventArgs e)
        {
            loadComboBox_Hang();
            cboHang.SelectedIndex = 0;
            txtGiaGoc.Enabled = false;
        }

        private void cboDienThoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Price FROM  tblDienThoai WHERE TenSP = '" + cboDienThoai.Text.Trim() + "'";
            SqlDataReader rdr = dt.getDataReader(sql);
            while (rdr.Read())
            {
                txtGiaGoc.Text = rdr["Price"].ToString();
            }
            rdr.Close();
        }

        private void cboHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHang.SelectedIndex != 0)
            {
                cboDienThoai.Items.Clear();
                loadComboBox_DienThoai();
            }
            else
            {
                cboDienThoai.Items.Clear();
                cboDienThoai.Text = "";
            }
                
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (rdoDoi.Checked)
            {
                if (rdo2Tuan.Checked)
                {
                    txtTinhTien.Text = "Số tiền khách hàng phải bù là: 0";
                }
                else if (rdo1Thang.Checked)
                {
                    txtTinhTien.Text = "Số tiền khách hàng phải bù là: " + (float.Parse(txtGiaGoc.Text.Trim()) * 0.2).ToString();
                }
                else if (rdo2Thang.Checked)
                {
                    txtTinhTien.Text = "Số tiền khách hàng phải bù là: " + (float.Parse(txtGiaGoc.Text.Trim()) * 0.5).ToString();
                }
                else
                    MessageBox.Show("Hãy chọn 1 thời gian");
            }
            else if (rdoTra.Checked)
            {
                if (rdo2Tuan.Checked)
                {
                    txtTinhTien.Text = "Số tiền phải trả cho khách hàng là: " + txtGiaGoc.Text.Trim();
                }
                else if (rdo1Thang.Checked)
                {
                    txtTinhTien.Text = "Số tiền phải trả cho khách hàng là: " + (float.Parse(txtGiaGoc.Text.Trim()) * 0.8).ToString();
                }
                else if (rdo2Thang.Checked)
                {
                    txtTinhTien.Text = "Số tiền phải trả cho khách hàng là: " + (float.Parse(txtGiaGoc.Text.Trim()) * 0.5).ToString();
                }
                else
                    MessageBox.Show("Hãy chọn 1 thời gian");
            }
            else
                MessageBox.Show("Hãy chọn đổi hoặc trả");
        }

        
    }
}
