using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThucTapNhom_QuanLyTHPT.DATA
{
    class SqlConn
    {
        //public static SqlConnection GetDBConnection()
        //{
        //    string datasource = @"";
        //    string database = "";
        //    string username = "";
        //    string password = "";

        //    string connString = @"Data Source=DESKTOP-DPEU76K;Initial Catalog=ThucTapNhom_QuanLyTruongTHPT;Integrated Security=True";

        //    SqlConnection conn = new SqlConnection(connString);

        //    return conn;
        //}

        string connString = @"Data Source=.;Initial Catalog=ThucTapNhom_QuanLyTruongTHPT;Integrated Security=True";
        SqlConnection conn = null;

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public SqlConn()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connString);
            }
        }

        public void openConn()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connString);
            }
            conn.Open();
        }
        public void closeConn()
        {
            conn.Close();
        }

        public DataTable getDataTable(string table)
        {
            openConn();
            string query = "select * from " + table;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            cmd.Dispose();
            return dt;
        }


        public DataTable searchQuery(string x)
        {
            openConn();
            string query = x;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter db = new SqlDataAdapter(cmd);
            DataTable dc = new DataTable();
            db.Fill(dc);
            db.Dispose();
            cmd.Dispose();
            return dc;
        }

        public DataTable TK(string cl)
        {
            openConn();
            string query = cl;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dh = new SqlDataAdapter(cmd);
            DataTable dk = new DataTable();
            dh.Fill(dk);
            dh.Dispose();
            cmd.Dispose();
            return dk;
        }
    }
}
