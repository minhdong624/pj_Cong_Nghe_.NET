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
    class hoadoncl : DBConnect
    {
        SqlDataAdapter ada_HoaDon = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];

        public hoadoncl()
        {
            string sql = "SELECT ROW_NUMBER() OVER (ORDER BY MaHD) AS [STT],  MaHD, MaKH, MaNV, MaSP, SoSP, MaPK, SoPK, NgayLap, Tong FROM dbo.tblHoaDon";
            ada_HoaDon = getDataAdapter(sql, "tblHoaDon");
            primaryKey[0] = StrDataSet.Tables["tblHoaDon"].Columns["MaHD"];
            StrDataSet.Tables["tblHoaDon"].PrimaryKey = primaryKey;
        }

        public int add(string pMaHD, string pMaKH, string pMaNV, string pMaSP, string pSoSP, string pMaPK, string pSoPK, string pNgayLap, string pTong)
        {//0: Bị trùng khóa chính, 1: Thêm thành công, 2: Thêm thất bại
            try
            {
                DataRow existRow = StrDataSet.Tables["tblHoaDon"].Rows.Find(pMaHD);
                if (existRow != null)
                {
                    return 0; //Trùng khóa chính
                }
                //Lưu
                DataRow newRow = StrDataSet.Tables["tblHoaDon"].NewRow();
                newRow["MaHD"] = pMaHD;
                newRow["MaKH"] = pMaKH;
                newRow["MaNV"] = pMaNV;
                newRow["MaSP"] = pMaSP;
                newRow["SoSP"] = pSoSP;
                newRow["MaPK"] = pMaPK;
                newRow["SoPK"] = pSoPK;
                newRow["NgayLap"] = pNgayLap;
                newRow["Tong"] = pTong;
                StrDataSet.Tables["tblHoaDon"].Rows.Add(newRow);
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_HoaDon);
                ada_HoaDon.Update(StrDataSet, "tblHoaDon");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
        public int update(string pMaHD, string pMaKH, string pMaNV, string pMaSP, string pSoSP, string pMaPK, string pSoPK, string pNgayLap, string pTong)
        {//0: Không tồn tại, 1: Cập nhật thành công, 2: Cập nhật thất bại
            try
            {
                DataRow updateRow = StrDataSet.Tables["tblHoaDon"].Rows.Find(pMaHD);
                if (updateRow == null)
                {
                    return 0; //không tồn tại HoaDon này
                }
                //Lưu
                updateRow["MaKH"] = pMaKH;
                updateRow["MaNV"] = pMaNV;
                updateRow["MaSP"] = pMaSP;
                updateRow["SoSP"] = pSoSP;
                updateRow["MaPK"] = pMaPK;
                updateRow["SoPK"] = pSoPK;
                updateRow["NgayLap"] = pNgayLap;
                updateRow["Tong"] = pTong;
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_HoaDon);
                ada_HoaDon.Update(StrDataSet, "tblHoaDon");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
        public int delete(string pMaHD)
        {//0: Không tồn tại, 1: Xóa thành công, 2: Xóa thất bại, 3: Có ràng buộc khóa ngoại
            try
            {
                DataRow deleteRow = StrDataSet.Tables["tblHoaDon"].Rows.Find(pMaHD);
                if (deleteRow == null)
                {
                    return 0; //không tồn tại HoaDon này
                }
                //Lưu cập nhật
                deleteRow.Delete();
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_HoaDon);
                ada_HoaDon.Update(StrDataSet, "tblHoaDon");
                return 1; //Xóa thành công
            }
            catch
            {
                return 2; //Xóa thất bại
            }
        }
    }
}
