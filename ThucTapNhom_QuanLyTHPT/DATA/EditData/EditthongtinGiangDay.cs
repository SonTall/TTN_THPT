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
    class EditthongtinGiangDay
    {
        public string MAGVCU { get; set; }


        public void ExcuteProc(GiangDay giangday)

        {
            //SqlConnection conn = DBUtils.GetDBConnection();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P8I38NF\\SQLEXPRESS;Initial Catalog=TTN_THPT;Integrated Security=True");


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("EditthongtinGiangDay", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MAGVCU", SqlDbType.Char, 10)).Value = this.MAGVCU;
                cmd.Parameters.Add(new SqlParameter("@MAMONHOC", SqlDbType.Char, 10)).Value = giangday.MaMonHoc;
                cmd.Parameters.Add(new SqlParameter("@MALOPHOC", SqlDbType.Char)).Value = giangday.MaLopHoc;
                cmd.Parameters.Add(new SqlParameter("@THU", SqlDbType.Text)).Value = giangday.Thu;
                cmd.Parameters.Add(new SqlParameter("@TIET", SqlDbType.Int)).Value = giangday.Tiet;
                cmd.Parameters.Add(new SqlParameter("@SOTIET", SqlDbType.Int)).Value = giangday.SoTiet;

                //excute proc
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
