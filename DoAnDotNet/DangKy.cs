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
    public partial class DangKy : Form
    {
        Register rg = new Register();
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Trim() == string.Empty)
                    MessageBox.Show("Hãy nhập tên User");
                else if (txtPass.Text.Trim() == string.Empty)
                    MessageBox.Show("Hãy nhập Pass");
                else if (txtCheckPass.Text.Trim() == string.Empty)
                    MessageBox.Show("Hãy nhập CheckPass");
                else if (txtPass.Text.Trim() != txtCheckPass.Text.Trim())
                    MessageBox.Show("Hãy nhập 2 password giống nhau");
                else
                {
                    if(rg.add(txtUser.Text.Trim(), txtPass.Text.Trim()) == 1)
                        MessageBox.Show("Đăng ký thành công");
                    else if(rg.add(txtUser.Text.Trim(), txtPass.Text.Trim()) == 0)
                        MessageBox.Show("Trùng tên User");
                    else
                        MessageBox.Show("Đăng ký không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Đăng ký không thành công");
            }

        }

       

        private void btnDN_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
