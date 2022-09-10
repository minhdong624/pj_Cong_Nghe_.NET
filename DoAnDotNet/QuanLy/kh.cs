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
    class kh : DBConnect
    {
        SqlDataAdapter ada_KhachHang = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];

        public kh()
        {
            string sql = "SELECT ROW_NUMBER() OVER (ORDER BY MaKH) AS [STT],  MaKH, TenKH, SDT, DiaChi, Email FROM dbo.tblKhachHang";
            ada_KhachHang = getDataAdapter(sql, "tblKhachHang");
            primaryKey[0] = StrDataSet.Tables["tblKhachHang"].Columns["MaKH"];
            StrDataSet.Tables["tblKhachHang"].PrimaryKey = primaryKey;
        }

        public int add(string pMaKH, string pTenKH, string pSDT, string pDiaChi, string pEmail)
        {//0: Bị trùng khóa chính, 1: Thêm thành công, 2: Thêm thất bại
            try
            {
                DataRow existRow = StrDataSet.Tables["tblKhachHang"].Rows.Find(pMaKH);
                if (existRow != null)
                {
                    return 0; //Trùng khóa chính
                }
                //Lưu
                DataRow newRow = StrDataSet.Tables["tblKhachHang"].NewRow();
                newRow["MaKH"] = pMaKH;
                newRow["TenKH"] = pTenKH;
                newRow["SDT"] = pSDT;
                newRow["DiaChi"] = pDiaChi;
                newRow["Email"] = pEmail;
                StrDataSet.Tables["tblKhachHang"].Rows.Add(newRow);
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_KhachHang);
                ada_KhachHang.Update(StrDataSet, "tblKhachHang");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
        public int update(string pMaKH, string pTenKH, string pSDT, string pDiaChi, string pEmail)
        {//0: Không tồn tại, 1: Cập nhật thành công, 2: Cập nhật thất bại
            try
            {
                DataRow updateRow = StrDataSet.Tables["tblKhachHang"].Rows.Find(pMaKH);
                if (updateRow == null)
                {
                    return 0; //không tồn tại KhachHang này
                }
                //Lưu
                updateRow["TenKH"] = pTenKH;
                updateRow["SDT"] = pSDT;
                updateRow["DiaChi"] = pDiaChi;
                updateRow["Email"] = pEmail;
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_KhachHang);
                ada_KhachHang.Update(StrDataSet, "tblKhachHang");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
        public int delete(string pMaKH)
        {//0: Không tồn tại, 1: Xóa thành công, 2: Xóa thất bại, 3: Có ràng buộc khóa ngoại
            try
            {
                DataRow deleteRow = StrDataSet.Tables["tblKhachHang"].Rows.Find(pMaKH);
                if (deleteRow == null)
                {
                    return 0; //không tồn tại KhachHang này
                }
                string strSQL = "SELECT count(*) FROM tblHoaDon WHERE MaKH='" + pMaKH + "'";
                if (checkExist(strSQL))
                {
                    return 3; //Có ràng buộc khóa ngoại
                }
                //Lưu cập nhật
                deleteRow.Delete();
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_KhachHang);
                ada_KhachHang.Update(StrDataSet, "tblKhachHang");
                return 1; //Xóa thành công
            }
            catch
            {
                return 2; //Xóa thất bại
            }
        }
    }
}
