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
    class PhuKien : DBConnect
    {
        SqlDataAdapter ada_PhuKien = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];

        public PhuKien()
        {
            string sql = "SELECT ROW_NUMBER() OVER (ORDER BY MaPK) AS [STT],  MaPK, Hang, TenPK, Loai, Gia FROM dbo.tblPhuKien";
            ada_PhuKien = getDataAdapter(sql, "tblPhuKien");
            primaryKey[0] = StrDataSet.Tables["tblPhuKien"].Columns["MaPK"];
            StrDataSet.Tables["tblPhuKien"].PrimaryKey = primaryKey;
        }

        public int add(string pMaPK, string pHang, string pTenPK, string pLoai, string pGia)
        {//0: Bị trùng khóa chính, 1: Thêm thành công, 2: Thêm thất bại
            try
            {
                DataRow existRow = StrDataSet.Tables["tblPhuKien"].Rows.Find(pMaPK);
                if (existRow != null)
                {
                    return 0; //Trùng khóa chính
                }
                //Lưu
                DataRow newRow = StrDataSet.Tables["tblPhuKien"].NewRow();
                newRow["MaPK"] = pMaPK;
                newRow["Hang"] = pHang;
                newRow["TenPK"] = pTenPK;
                newRow["Loai"] = pLoai;
                newRow["Gia"] = pGia;
                StrDataSet.Tables["tblPhuKien"].Rows.Add(newRow);
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_PhuKien);
                ada_PhuKien.Update(StrDataSet, "tblPhuKien");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
        public int update(string pMaPK, string pHang, string pTenPK, string pLoai, string pGia)
        {//0: Không tồn tại, 1: Cập nhật thành công, 2: Cập nhật thất bại
            try
            {
                DataRow updateRow = StrDataSet.Tables["tblPhuKien"].Rows.Find(pMaPK);
                if (updateRow == null)
                {
                    return 0; //không tồn tại PhuKien này
                }
                //Lưu
                updateRow["Hang"] = pHang;
                updateRow["TenPK"] = pTenPK;
                updateRow["Loai"] = pLoai;
                updateRow["Gia"] = pGia;
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_PhuKien);
                ada_PhuKien.Update(StrDataSet, "tblPhuKien");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
        public int delete(string pMaPK)
        {//0: Không tồn tại, 1: Xóa thành công, 2: Xóa thất bại, 3: Có ràng buộc khóa ngoại
            try
            {
                DataRow deleteRow = StrDataSet.Tables["tblPhuKien"].Rows.Find(pMaPK);
                if (deleteRow == null)
                {
                    return 0; //không tồn tại PhuKien này
                }
                string strSQL = "SELECT count(*) FROM tblHoaDon WHERE MaPK='" + pMaPK + "'";
                if (checkExist(strSQL))
                {
                    return 3; //Có ràng buộc khóa ngoại
                }
                //Lưu cập nhật
                deleteRow.Delete();
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_PhuKien);
                ada_PhuKien.Update(StrDataSet, "tblPhuKien");
                return 1; //Xóa thành công
            }
            catch
            {
                return 2; //Xóa thất bại
            }
        }
    }
}
