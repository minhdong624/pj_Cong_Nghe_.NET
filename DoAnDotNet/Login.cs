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
    class Login : DBConnect
    {
        SqlDataAdapter ada_Login = new SqlDataAdapter();
        DataColumn[] primaryKey = new DataColumn[1];
        public Login()
        {
            string sql = "SELECT * FROM dbo.tblDangNhap";
            ada_Login = getDataAdapter(sql, "tblDangNhap");
            primaryKey[0] = StrDataSet.Tables["tblDangNhap"].Columns["User"];
            StrDataSet.Tables["tblDangNhap"].PrimaryKey = primaryKey;
        }
        public bool chk_Login(string user, string pass)
        {
            DataRow dr_DN = StrDataSet.Tables["tblDangNhap"].Rows.Find(user);
            if (dr_DN == null)
                return false;
            else
            {
                if (!dr_DN["Password"].ToString().Trim().Equals(pass))
                    return false;
                else
                {
                    return true;
                }
            }
        }
    }
}
