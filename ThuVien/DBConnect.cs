using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ThuVien
{
    public class DBConnect
    {
        private SqlConnection _conn;

        private DataSet _strDataSet;

        public DataSet StrDataSet
        {
            get { return _strDataSet; }
            set { _strDataSet = value; }
        }

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }
        private string _strConnect;

        public string StrConnect
        {
            get { return _strConnect; }
            set { _strConnect = value; }
        }
        private string _strServerName;

        public string StrServerName
        {
            get { return _strServerName; }
            set { _strServerName = value; }
        }
        private string _strDBName;

        public string StrDBName
        {
            get { return _strDBName; }
            set { _strDBName = value; }
        }
        private string _strUserName;

        public string StrUserName
        {
            get { return _strUserName; }
            set { _strUserName = value; }
        }
        private string _strPassword;

        public string StrPassword
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }

        public DBConnect()
        {
            StrServerName = "DESKTOP-JG34C6B\\DONG";
            StrDBName = "QLCuaHangDienThoai";
            StrUserName = "sa";
            StrPassword = "sa123";
            StrConnect = "Data Source = " + StrServerName + "; Initial Catalog = " + StrDBName + "; User ID = " + StrUserName + "; Password = " + StrPassword;
            Conn = new SqlConnection(StrConnect);
            StrDataSet = new DataSet();
        }

        public DBConnect(string ServerName, string DBName, string UserName, string Password)
        {
            StrServerName = ServerName;
            StrDBName = DBName;
            StrUserName = UserName;
            StrPassword = Password;
            StrConnect = "Data Source = " + StrServerName + "; Initial Catalog = " + StrDBName + "; User ID = " + StrUserName + "; Password = " + StrPassword;
            Conn = new SqlConnection(StrConnect);
            StrDataSet = new DataSet();
        }

        public void openConnection()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
        }

        public void closeConnection()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
        }

        public void updateToDatabase(string sql)
        {
            //Phương thức giúp cập nhật (Thêm, xoa, sửa) cho Database.
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public int getCount(string sql)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = sql;
            int count = (int)cmd.ExecuteScalar();
            closeConnection();
            return count;
        }

        public bool checkExist(string sql)
        {
            return getCount(sql) > 0 ? true : false;
        }

        public SqlDataReader getDataReader(string sql)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = sql;
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public SqlDataAdapter getDataAdapter(string sql, string tableName)
        {
            openConnection();
            SqlDataAdapter ada = new SqlDataAdapter(sql, Conn);
            if (StrDataSet.Tables[tableName] != null)
                StrDataSet.Tables[tableName].Clear();
            ada.Fill(StrDataSet, tableName);
            closeConnection();
            return ada;
        }

        public DataTable getDataTable(string sql)
        {
            openConnection();
            SqlDataAdapter ada = new SqlDataAdapter(sql, Conn);
            if (StrDataSet.Tables[0] != null)
                StrDataSet.Tables[0].Clear();
            ada.Fill(StrDataSet);
            closeConnection();
            return StrDataSet.Tables[0];
        }

        public DataTable getDataTable(string sql, string tableName)
        {
            openConnection();
            SqlDataAdapter ada = new SqlDataAdapter(sql, Conn);
            if (StrDataSet.Tables[tableName] != null)
                StrDataSet.Tables[tableName].Clear();
            ada.Fill(StrDataSet, tableName);
            closeConnection();
            return StrDataSet.Tables[tableName];
        }
    }
}
