using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTapNhom_QuanLyTHPT.ENTITY;

namespace ThucTapNhom_QuanLyTHPT.DATA
{
    class ChucVu_Controler : SqlConn
    {
        public void insertChucVu(ChucVu cv)
        {
            openConn();
            string query = "insert into ChucVu(machucvu, tenchucvu) values (@macv, @tencv)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@macv", cv.MaChucVu);
            cmd.Parameters.AddWithValue("@tencv", cv.TenChucVu);
            cmd.ExecuteNonQuery();
        }
        public void deleteChucVu(ChucVu cv)
        {
            try
            {
                openConn();
                String query = "delete from ChucVu where machucvu= @machucvu";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@machucvu", cv.MaChucVu);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
