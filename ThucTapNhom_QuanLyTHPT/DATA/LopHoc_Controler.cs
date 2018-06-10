using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTapNhom_QuanLyTHPT.ENTITY;

namespace ThucTapNhom_QuanLyTHPT.DATA
{
    class LopHoc_Controler : SqlConn
    {
        public void insertLopHoc(LopHoc lh)
        {
            openConn();
            string query = "insert into Lop(malop, tenlop, ngaybatdau, ngayketthuc, magvchunhiem) values (@malop, @tenlop, @ngaybatdau, @ngayketthuc, @magvchunhiem)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@malop", lh.MaLop);
            cmd.Parameters.AddWithValue("@tenlop", lh.TenLop);
            cmd.Parameters.AddWithValue("@ngaybatdau", lh.NgayBatDau);
            cmd.Parameters.AddWithValue("@ngayketthuc", lh.NgayKetThuc);
            cmd.Parameters.AddWithValue("@magvchunhiem", lh.MaGiaoVienChuNhiem);
            cmd.ExecuteNonQuery();

        }
        public void deleteLop(LopHoc lh)
        {
            try
            {
                openConn();
                String query = "delete from Lop where malop= @malop";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@malop", lh.MaLop);
                cmd.ExecuteNonQuery();
            }
            catch (Exception msg)
            {

            }
        }
    }
}