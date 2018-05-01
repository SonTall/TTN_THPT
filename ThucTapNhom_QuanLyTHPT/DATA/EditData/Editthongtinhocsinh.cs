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
    class Editthongtinhocsinh
    {
        public string MAHOCSINHCU { get; set; }
        /// <param name="HocSinh"></param>
        public void ExcuteProc(HocSinh hocsinh)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P8I38NF\\SQLEXPRESS;Initial Catalog=TTN_THPT;Integrated Security=True");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Editthongtinhocsinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MAHOCSINHCU", SqlDbType.Char, 10)).Value = this.MAHOCSINHCU;
                cmd.Parameters.Add(new SqlParameter("@MAHOCSINH", SqlDbType.Char, 10)).Value = hocsinh.MaHocSinh;
                cmd.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.Text, 50)).Value = hocsinh.HoTen;
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", SqlDbType.DateTime)).Value = hocsinh.NgaySinh;
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", SqlDbType.Text, 20)).Value = hocsinh.GioiTinh;
                cmd.Parameters.Add(new SqlParameter("@DANTOC", SqlDbType.Text, 50)).Value = hocsinh.DanToc;
                cmd.Parameters.Add(new SqlParameter("@TONGIAO", SqlDbType.Text, 50)).Value = hocsinh.TonGiao;
                cmd.Parameters.Add(new SqlParameter("@DIACHI", SqlDbType.Text, 50)).Value = hocsinh.DiaChi;
                cmd.Parameters.Add(new SqlParameter("@QUEQUAN", SqlDbType.Text, 100)).Value = hocsinh.QueQuan;
                cmd.Parameters.Add(new SqlParameter("@THONGTINPHUHUYNH", SqlDbType.Text, 100)).Value = hocsinh.ThongTinPhuHuynh;
                cmd.Parameters.Add(new SqlParameter("@SODTLIENHE", SqlDbType.Char, 12)).Value = hocsinh.SoDienThoaiLienHe;
                cmd.Parameters.Add(new SqlParameter("@MALOP", SqlDbType.Char, 10)).Value = hocsinh.MaLop;
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

