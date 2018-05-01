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
    class EditthongtinGiaoVien
    {
        public string MAGIAOVIENCU { get; set; }

        public void ExcuteProc(GiaoVien giaovien)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P8I38NF\\SQLEXPRESS;Initial Catalog=TTN_THPT;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("EditthongtinGiaoVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MAGVCU", SqlDbType.Char, 10)).Value = this.MAGIAOVIENCU;
                cmd.Parameters.Add(new SqlParameter("@MAGV", SqlDbType.Char, 10)).Value = giaovien.MaGiaoVien;
                cmd.Parameters.Add(new SqlParameter("@TENGV", SqlDbType.Text, 50)).Value = giaovien.TenGiaoVien;
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", SqlDbType.Date)).Value = giaovien.NgaySinh;
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", SqlDbType.Text, 10)).Value = giaovien.GioiTinh;
                cmd.Parameters.Add(new SqlParameter("@DIACHI", SqlDbType.Text, 50)).Value = giaovien.DiaChi;
                cmd.Parameters.Add(new SqlParameter("@QUEQUAN", SqlDbType.Text, 50)).Value = giaovien.QueQuan;
                cmd.Parameters.Add(new SqlParameter("@SDT", SqlDbType.Text, 12)).Value = giaovien.SoDienThoai;
                cmd.Parameters.Add(new SqlParameter("@TRINHDO", SqlDbType.Text, 50)).Value = giaovien.TrinhDo;
                cmd.Parameters.Add(new SqlParameter("@LUONGCOBAN", SqlDbType.Text, 50)).Value = giaovien.LuongCoBan;
                cmd.Parameters.Add(new SqlParameter("@MACHUCVU", SqlDbType.Text, 10)).Value = giaovien.MaChucVu;
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
