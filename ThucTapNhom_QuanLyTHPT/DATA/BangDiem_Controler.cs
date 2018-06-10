using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTapNhom_QuanLyTHPT.ENTITY;

namespace ThucTapNhom_QuanLyTHPT.DATA
{
    class BangDiem_Controler : SqlConn
    {
        public void insertBangDiem(BangDiem bd)
        {
            openConn();
            string query = "insert into BangDiem(mahocsinh, magiaovien, mamonhoc, namhoc, hocki, diemtrungbinh) values (@mahocsinh, @magiaovien, @mamonhoc, @namhoc, @hocki, @diemtrungbinh)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("mahocsinh", bd.MaHocSinh);
            cmd.Parameters.AddWithValue("magiaovien", bd.MaGiaoVien);
            cmd.Parameters.AddWithValue("mamonhoc", bd.MaMonHoc);
            cmd.Parameters.AddWithValue("namhoc", bd.NamHoc);
            cmd.Parameters.AddWithValue("hocki", bd.HocKy);
            cmd.Parameters.AddWithValue("diemtrungbinh", bd.DiemTrungBinh);
            cmd.ExecuteNonQuery();
        }
        public void deleteBangDiem(BangDiem bd)
        {
            try
            {
                openConn();
                String query = "delete from BangDiem where mahocsinh= @mahocsinh and magiaovien = @magiaovien and mamonhoc = @mamonhoc";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@mahocsinh", bd.MaHocSinh);
                cmd.Parameters.AddWithValue("@magiaovien", bd.MaGiaoVien);
                cmd.Parameters.AddWithValue("@mamonhoc", bd.MaMonHoc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
