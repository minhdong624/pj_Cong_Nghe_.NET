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
    public partial class PhuKienDienThoai : Form
    {
        QuanLy.PhuKien pk = new QuanLy.PhuKien();
        public PhuKienDienThoai()
        {
            InitializeComponent();
        }

        private void btnLoaiPK_Click(object sender, EventArgs e)
        {
            if (rdo100.Checked)
            {
                if (cboLoai.SelectedIndex == 0)
                {
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Gia < 100000", "tblPhuKien");
                }
                else
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Gia < 100000 AND Loai = '" + cboLoai.Text.Trim() + "'", "tblPhuKien");
            }
            else if (rdo500.Checked)
                if (cboLoai.SelectedIndex == 0)
                {
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Gia BETWEEN 100000 AND 500000", "tblPhuKien");
                }
                else
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Gia BETWEEN 100000 AND 500000 AND Loai = '" + cboLoai.Text.Trim() + "'", "tblPhuKien");
            else if (rdo501.Checked)
                if (cboLoai.SelectedIndex == 0)
                {
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Gia > 500000", "tblPhuKien");
                }
                else
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Gia > 500000 AND Loai = '" + cboLoai.Text.Trim() + "'", "tblPhuKien");
            else
                if (cboLoai.SelectedIndex == 0)
                {
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien", "tblPhuKien");
                }
                else
                    grvPK.DataSource = pk.getDataTable("SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien WHERE Loai = '" + cboLoai.Text.Trim() + "'", "tblPhuKien");
        }

        public void LoadDataGridview()
        {
            grvPK.DataSource = pk.StrDataSet.Tables["tblPhuKien"];
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

        private void PhuKienDienThoai_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
            loadComboBox_Loai();
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                this.Close();
        }

    }
}
