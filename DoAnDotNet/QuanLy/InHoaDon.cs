using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
using System.Data.SqlClient;

namespace DoAnDotNet.QuanLy
{
    public partial class InHoaDon : Form
    {
        QuanLy.hoadoncl hd = new QuanLy.hoadoncl();
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            rptHoaDon rpt = new rptHoaDon();
            rpt.SetParameterValue("pMaHD", cboMaHD.SelectedItem);
            crvHD.ReportSource = rpt;
            rpt.SetDatabaseLogon(hd.StrUserName, hd.StrPassword, hd.StrServerName, hd.StrPassword);

            crvHD.Refresh();
            crvHD.DisplayToolbar = false;
            crvHD.DisplayStatusBar = false;
        }

        private void LoadMaHD_ComboBox()
        {
            string sql = "SELECT MaHD FROM tblHoaDon";
            SqlDataReader rdr = hd.getDataReader(sql);
            while (rdr.Read())
            {
                cboMaHD.Items.Add(rdr["MaHD"].ToString());
            }
            rdr.Close();
            cboMaHD.SelectedValue = null;
            cboMaHD.Text = "--Chọn một hóa đơn--";
        }

        private void frmMau_BaiTap01_Load(object sender, EventArgs e)
        {
            LoadMaHD_ComboBox();
        }
    }
}
