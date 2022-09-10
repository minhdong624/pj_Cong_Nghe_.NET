using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ThuVien;


namespace DoAnDotNet
{
    class Register : DBConnect
    {
        SqlDataAdapter ada_Register = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];
        public Register()
        {
            string sql = "SELECT * FROM dbo.tblDangNhap";
            ada_Register = getDataAdapter(sql, "tblDangNhap");
            primaryKey[0] = StrDataSet.Tables["tblDangNhap"].Columns["User"];
            StrDataSet.Tables["tblDangNhap"].PrimaryKey = primaryKey;
        }

        public int add(string pUser, string pPass)
        {
            try
            {
                DataRow existRow = StrDataSet.Tables["tblDangNhap"].Rows.Find(pUser);
                if (existRow != null)
                {
                    return 0; //Trùng khóa chính
                }
                //Lưu
                DataRow newRow = StrDataSet.Tables["tblDangNhap"].NewRow();
                newRow["User"] = pUser;
                newRow["Password"] = pPass;
                StrDataSet.Tables["tblDangNhap"].Rows.Add(newRow);
                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_Register);
                ada_Register.Update(StrDataSet, "tblDangNhap");
                return 1; //Thêm thành công
            }
            catch
            {
                return 2; //Thêm thất bại
            }
        }
    }
}
