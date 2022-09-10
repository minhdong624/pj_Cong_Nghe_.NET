using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDotNet
{
    public partial class DangNhap : Form
    {
        Login lg = new Login();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else Application.Exit();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnDN_Click(sender, e);
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (!lg.chk_Login(txtUser.Text.Trim(), txtPass.Text.Trim()))
            {
                MessageBox.Show("Đăng nhập thất bại!");
                return;
            }
            else
            {
                DoAnDotNet.TrangChu tc = new DoAnDotNet.TrangChu();
                tc.Show();
                this.Hide();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
            this.Hide();
        }
    }
}
