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
    class Editthongtinbangdiem
    {
        public string MAHOCSIHCU { get; set; }
        /// <param name="BangDiem"></param>
        public void ExcuteProc(BangDiem bangdiem)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P8I38NF\\SQLEXPRESS;Initial Catalog=TTN_THPT;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Editthongtinbangdiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MAHOCSINHCU", SqlDbType.Char, 10)).Value = this.MAHOCSIHCU;
                cmd.Parameters.Add(new SqlParameter("@MAHOCSINH", SqlDbType.Char, 10)).Value = bangdiem.MaHocSinh;
                cmd.Parameters.Add(new SqlParameter("@MAGIAOVIEN", SqlDbType.Char, 10)).Value = bangdiem.MaGiaoVien;
                cmd.Parameters.Add(new SqlParameter("@MAMONHOC", SqlDbType.Char, 10)).Value = bangdiem.MaMonHoc;
                cmd.Parameters.Add(new SqlParameter("@NAMHOC", SqlDbType.Char, 10)).Value = bangdiem.NamHoc;
                cmd.Parameters.Add(new SqlParameter("@HOCKY", SqlDbType.Int)).Value = bangdiem.HocKy;
                cmd.Parameters.Add(new SqlParameter("@DIEMTRUNGBINH", SqlDbType.Char, 10)).Value = bangdiem.DiemTrungBinh;
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


