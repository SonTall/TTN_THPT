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
    class EditLop
    {
        /// <param name="LopHoc"></param>
        public string MALOPCU { get; set; }
        public void ExcuteProc(LopHoc lop)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P8I38NF\\SQLEXPRESS;Initial Catalog=TTN_THPT;Integrated Security=True");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("EditLop", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MALOPCU", SqlDbType.Char, 10)).Value = this.MALOPCU;
                cmd.Parameters.Add(new SqlParameter("@MALOP", SqlDbType.Char, 10)).Value = lop.MaLop;
                cmd.Parameters.Add(new SqlParameter("@TENLOP", SqlDbType.Text)).Value = lop.TenLop;
                cmd.Parameters.Add(new SqlParameter("@NAMBATDAU", SqlDbType.Date)).Value = lop.NgayBatDau;
                cmd.Parameters.Add(new SqlParameter("@NAMKETTHUC", SqlDbType.Date)).Value = lop.NgayKetThuc;
                cmd.Parameters.Add(new SqlParameter("@MAGVCHUNHIEM", SqlDbType.Char)).Value = lop.MaGiaoVienChuNhiem;

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
