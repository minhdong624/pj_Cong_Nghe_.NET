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
    class DienThoai : DBConnect
    {
        SqlDataAdapter ada_DienThoai = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];

        public DienThoai()
        {
            string sql = "SELECT ROW_NUMBER() OVER (ORDER BY MaSP) AS [STT],  MaSP, Hang, TenSP, Ram, Rom, Weight, Screen, Pin, Width, Height, Price FROM dbo.tblDienThoai";
            ada_DienThoai = getDataAdapter(sql, "tblDienThoai");
            primaryKey[0] = StrDataSet.Tables["tblDienThoai"].Columns["MaSP"];
            StrDataSet.Tables["tblDienThoai"].PrimaryKey = primaryKey;
        }

        public int add(string pMaSP, string pHang, string pTenSP, string pRam, string pRom, string pWeight, string pScreen, string pPin, string pWidth, string pHeight, string pPrice)
        {//0: Bị trùng khóa chính, 1: Thêm thành công, 2: Thêm thất bại
            try
            {
                DataRow existRow = StrDataSet.Tables["tblDienThoai"].Rows.Find(pMaSP);
                if (existRow != null)
                {
                    return 0; //Trùng khóa chính
                }
                //Lưu
                DataRow newRow = StrDataSet.Tables["tblDienThoai"].NewRow();
                newRow["MaSP"] = pMaSP;
                newRow["Hang"] = pHang;
                newRow["TenSP"] = pTenSP;
                newRow["Ram"] = pRam;
                newRow["Rom"] = pRom;
                newRow["Weight"] = pWeight;
                newRow["Screen"] = pScreen;
                newRow["Pin"] = pPin;
                newRow["Width"] = pWidth;
                newRow["Height"] = pHeight;
                newRow["Price"] = pPrice;
                StrDataSet.Tables["tblDienThoai"].Rows.Add(newRow);
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_DienThoai);
                ada_DienThoai.Update(StrDataSet, "tblDienThoai");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
        public int update(string pMaSP, string pHang, string pTenSP, string pRam, string pRom, string pWeight, string pScreen, string pPin, string pWidth, string pHeight, string pPrice)
        {//0: Không tồn tại, 1: Cập nhật thành công, 2: Cập nhật thất bại
            try
            {
                DataRow updateRow = StrDataSet.Tables["tblDienThoai"].Rows.Find(pMaSP);
                if (updateRow == null)
                {
                    return 0; //không tồn tại DienThoai này
                }
                //Lưu
                updateRow["Hang"] = pHang;
                updateRow["TenSP"] = pTenSP;
                updateRow["Ram"] = pRam;
                updateRow["Rom"] = pRom;
                updateRow["Weight"] = pWeight;
                updateRow["Screen"] = pScreen;
                updateRow["Pin"] = pPin;
                updateRow["Width"] = pWidth;
                updateRow["Height"] = pHeight;
                updateRow["Price"] = pPrice;
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_DienThoai);
                ada_DienThoai.Update(StrDataSet, "tblDienThoai");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
        public int delete(string pMaSP)
        {//0: Không tồn tại, 1: Xóa thành công, 2: Xóa thất bại, 3: Có ràng buộc khóa ngoại
            try
            {
                DataRow deleteRow = StrDataSet.Tables["tblDienThoai"].Rows.Find(pMaSP);
                if (deleteRow == null)
                {
                    return 0; //không tồn tại DienThoai này
                }
                string strSQL = "SELECT count(*) FROM tblHoaDon WHERE MaSP='" + pMaSP + "'";
                if (checkExist(strSQL))
                {
                    return 3; //Có ràng buộc khóa ngoại
                }
                //Lưu cập nhật
                deleteRow.Delete();
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_DienThoai);
                ada_DienThoai.Update(StrDataSet, "tblDienThoai");
                return 1; //Xóa thành công
            }
            catch
            {
                return 2; //Xóa thất bại
            }
        }
    }
}
