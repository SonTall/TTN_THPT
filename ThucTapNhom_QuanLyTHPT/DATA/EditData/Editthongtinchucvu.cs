using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using ThucTapNhom_QuanLyTHPT.ENTITY;
namespace ThucTapNhom_QuanLyTHPT.DATA.EditData
{
    class Editthongtinchucvu
    {
        public string MACHUCVUCU { get; set; }

        public void ExcuteProc(ChucVu chucvu)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P8I38NF\\SQLEXPRESS;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Editthongtinchucvu", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add(new SqlParameter("@MACHUCVU", SqlDbType.Char, 10)).Value = this.MACHUCVUCU;
                cmd.Parameters.Add(new SqlParameter("@MACHUCVU", SqlDbType.Char, 10)).Value = chucvu.MaChucVu;
                cmd.Parameters.Add(new SqlParameter("@TENCHUCVU", SqlDbType.Text, 50)).Value = chucvu.TenChucVu;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
