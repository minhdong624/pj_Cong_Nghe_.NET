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
    public partial class TrangChu : Form
    {
        public QuanLy.QuanLyDienThoai QuanLyDienThoai = null;
        public QuanLy.NhanVien NhanVien = null;
        public QuanLy.KhachHang KhachHang = null;
        public QuanLy.DoiTra DoiTra = null;
        public QuanLy.HoaDon HoaDon = null;
        public QuanLy.PhuKienDienThoai PhuKienDienThoai = null;
        public TimKiem.QuanLyDienThoai QuanLyDienThoai1 = null;
        public TimKiem.NhanVien NhanVien1 = null;
        public TimKiem.KhachHang KhachHang1 = null;
        public TimKiem.PhuKienDienThoai PhuKien1 = null;

        public TrangChu()
        {
            InitializeComponent();
        }

        public void show_frm_ql_From(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        public void show_frm_ql_From_else(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void QuanLyDienThoai_Click(object sender, EventArgs e)
        {
            if (QuanLyDienThoai == null)
            {
                QuanLyDienThoai = new QuanLy.QuanLyDienThoai();
                show_frm_ql_From(QuanLyDienThoai);
            }
            else
            {
                if (QuanLyDienThoai.IsDisposed)
                {
                    QuanLyDienThoai = null;
                    QuanLyDienThoai = new QuanLy.QuanLyDienThoai();
                    show_frm_ql_From(QuanLyDienThoai);
                }
                else
                {
                    show_frm_ql_From_else(QuanLyDienThoai);
                }
            }
        }

        private void MenuItemNV_Click(object sender, EventArgs e)
        {
            if (NhanVien == null)
            {
                NhanVien = new QuanLy.NhanVien();
                show_frm_ql_From(NhanVien);
            }
            else
            {
                if (NhanVien.IsDisposed)
                {
                    NhanVien = null;
                    NhanVien = new QuanLy.NhanVien();
                    show_frm_ql_From(NhanVien);
                }
                else
                {
                    show_frm_ql_From_else(NhanVien);
                }
            }
        }

        private void MenuItemKH_Click(object sender, EventArgs e)
        {
            if (KhachHang == null)
            {
                KhachHang = new QuanLy.KhachHang();
                show_frm_ql_From(KhachHang);
            }
            else
            {
                if (KhachHang.IsDisposed)
                {
                    KhachHang = null;
                    KhachHang = new QuanLy.KhachHang();
                    show_frm_ql_From(KhachHang);
                }
                else
                {
                    show_frm_ql_From_else(KhachHang);
                }
            }
        }

        private void MenuItemPhuKien_Click(object sender, EventArgs e)
        {
            if (PhuKienDienThoai == null)
            {
                PhuKienDienThoai = new QuanLy.PhuKienDienThoai();
                show_frm_ql_From(PhuKienDienThoai);
            }
            else
            {
                if (PhuKienDienThoai.IsDisposed)
                {
                    PhuKienDienThoai = null;
                    PhuKienDienThoai = new QuanLy.PhuKienDienThoai();
                    show_frm_ql_From(PhuKienDienThoai);
                }
                else
                {
                    show_frm_ql_From_else(PhuKienDienThoai);
                }
            }
        }

        private void MenuItemHoaDon_Click(object sender, EventArgs e)
        {
            if (HoaDon == null)
            {
                HoaDon = new QuanLy.HoaDon();
                show_frm_ql_From(HoaDon);
            }
            else
            {
                if (HoaDon.IsDisposed)
                {
                    HoaDon = null;
                    HoaDon = new QuanLy.HoaDon();
                    show_frm_ql_From(HoaDon);
                }
                else
                {
                    show_frm_ql_From_else(HoaDon);
                }
            }
        }

        private void MenuItemDoiTra_Click(object sender, EventArgs e)
        {
            if (DoiTra == null)
            {
                DoiTra = new QuanLy.DoiTra();
                show_frm_ql_From(DoiTra);
            }
            else
            {
                if (DoiTra.IsDisposed)
                {
                    DoiTra = null;
                    DoiTra = new QuanLy.DoiTra();
                    show_frm_ql_From(DoiTra);
                }
                else
                {
                    show_frm_ql_From_else(DoiTra);
                }
            }
        }

        private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QuanLyDienThoai1 == null)
            {
                QuanLyDienThoai1 = new TimKiem.QuanLyDienThoai();
                show_frm_ql_From(QuanLyDienThoai1);
            }
            else
            {
                if (QuanLyDienThoai1.IsDisposed)
                {
                    QuanLyDienThoai1 = null;
                    QuanLyDienThoai1 = new TimKiem.QuanLyDienThoai();
                    show_frm_ql_From(QuanLyDienThoai1);
                }
                else
                {
                    show_frm_ql_From_else(QuanLyDienThoai1);
                }
            }
        }

        private void phụKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhuKien1 == null)
            {
                PhuKien1 = new TimKiem.PhuKienDienThoai();
                show_frm_ql_From(PhuKien1);
            }
            else
            {
                if (PhuKien1.IsDisposed)
                {
                    PhuKien1 = null;
                    PhuKien1 = new TimKiem.PhuKienDienThoai();
                    show_frm_ql_From(PhuKien1);
                }
                else
                {
                    show_frm_ql_From_else(PhuKien1);
                }
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NhanVien1 == null)
            {
                NhanVien1 = new TimKiem.NhanVien();
                show_frm_ql_From(NhanVien1);
            }
            else
            {
                if (NhanVien1.IsDisposed)
                {
                    NhanVien1 = null;
                    NhanVien1 = new TimKiem.NhanVien();
                    show_frm_ql_From(NhanVien1);
                }
                else
                {
                    show_frm_ql_From_else(NhanVien1);
                }
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KhachHang1 == null)
            {
                KhachHang1 = new TimKiem.KhachHang();
                show_frm_ql_From(KhachHang1);
            }
            else
            {
                if (KhachHang1.IsDisposed)
                {
                    KhachHang1 = null;
                    KhachHang1 = new TimKiem.KhachHang();
                    show_frm_ql_From(KhachHang1);
                }
                else
                {
                    show_frm_ql_From_else(KhachHang1);
                }
            }
        }
    }
}
