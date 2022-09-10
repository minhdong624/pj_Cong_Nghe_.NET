using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ThuVien;

namespace DoAnDotNet.QuanLy
{
    class nv : DBConnect
    {
        SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];

        public nv()
        {
            string sql = "SELECT ROW_NUMBER() OVER (ORDER BY MaNV) AS [STT],  MaNV, TenNV, SDT, DiaChi, Email, ChuyenMon, Luong FROM dbo.tblNhanVien";
            ada_NhanVien = getDataAdapter(sql, "tblNhanVien");
            primaryKey[0] = StrDataSet.Tables["tblNhanVien"].Columns["MaNV"];
            StrDataSet.Tables["tblNhanVien"].PrimaryKey = primaryKey;
        }

        public int add(string pMaNV, string pTenNV, string pSDT, string pDiaChi, string pEmail, string pChuyenMon, string pLuong)
        {//0: Bị trùng khóa chính, 1: Thêm thành công, 2: Thêm thất bại
            try
            {
                DataRow existRow = StrDataSet.Tables["tblNhanVien"].Rows.Find(pMaNV);
                if (existRow != null)
                {
                    return 0; //Trùng khóa chính
                }
                //Lưu
                DataRow newRow = StrDataSet.Tables["tblNhanVien"].NewRow();
                newRow["MaNV"] = pMaNV;
                newRow["TenNV"] = pTenNV;
                newRow["SDT"] = pSDT;
                newRow["DiaChi"] = pDiaChi;
                newRow["Email"] = pEmail;
                newRow["ChuyenMon"] = pChuyenMon;
                newRow["Luong"] = pLuong;
                StrDataSet.Tables["tblNhanVien"].Rows.Add(newRow);
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(StrDataSet, "tblNhanVien");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
        public int update(string pMaNV, string pTenNV, string pSDT, string pDiaChi, string pEmail, string pChuyenMon, string pLuong)
        {//0: Không tồn tại, 1: Cập nhật thành công, 2: Cập nhật thất bại
            try
            {
                DataRow updateRow = StrDataSet.Tables["tblNhanVien"].Rows.Find(pMaNV);
                if (updateRow == null)
                {
                    return 0; //không tồn tại NhanVien này
                }
                //Lưu
                updateRow["TenNV"] = pTenNV;
                updateRow["SDT"] = pSDT;
                updateRow["DiaChi"] = pDiaChi;
                updateRow["Email"] = pEmail;
                updateRow["ChuyenMon"] = pChuyenMon;
                updateRow["Luong"] = pLuong;
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(StrDataSet, "tblNhanVien");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
        public int delete(string pMaNV)
        {//0: Không tồn tại, 1: Xóa thành công, 2: Xóa thất bại, 3: Có ràng buộc khóa ngoại
            try
            {
                DataRow deleteRow = StrDataSet.Tables["tblNhanVien"].Rows.Find(pMaNV);
                if (deleteRow == null)
                {
                    return 0; //không tồn tại NhanVien này
                }
                string strSQL = "SELECT count(*) FROM tblHoaDon WHERE MaNV='" + pMaNV + "'";
                if (checkExist(strSQL))
                {
                    return 3; //Có ràng buộc khóa ngoại
                }
                //Lưu cập nhật
                deleteRow.Delete();
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(StrDataSet, "tblNhanVien");
                return 1; //Xóa thành công
            }
            catch
            {
                return 2; //Xóa thất bại
            }
        }
    }
}
