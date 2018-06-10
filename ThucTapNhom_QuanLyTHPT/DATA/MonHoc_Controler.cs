using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTapNhom_QuanLyTHPT.ENTITY;




namespace ThucTapNhom_QuanLyTHPT.DATA
{
    class MonHoc_Controler : SqlConn
    {
        public void insertMonHoc(MonHoc mh)
        {
            openConn();
            string query = "insert into MonHoc(mamonhoc, tenmonhoc) values (@mamonhoc, @tenmonhoc)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@mamonhoc", mh.MaMonHoc);
            cmd.Parameters.AddWithValue("@tenmonhoc", mh.TenMonHoc);
            cmd.ExecuteNonQuery();
        }
        public void deleteMonHoc(MonHoc mh)
        {
            try
            {
                openConn();
                String query = "delete from MonHoc where mamonhoc= @mamonhoc";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@mamonhoc", mh.MaMonHoc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
