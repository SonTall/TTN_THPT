using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTapNhom_QuanLyTHPT.ENTITY;

namespace ThucTapNhom_QuanLyTHPT.DATA
{
    class HocSinh_Controler : SqlConn
    {
        public void insertHocSinh(HocSinh hs)
        {
            openConn();
            string query = "insert into HocSinh(mahocsinh, hoten, gioitinh, ngaysinh, dantoc, tongiao, diachi, quequan, thongtinphuhuynh, sdtlienhe, malop) values (@mahocsinh, @hoten, @gioitinh, @ngaysinh, @dantoc, @tongiao, @diachi, @quequan, @thongtinphuhuynh, @sdtlienhe, @malop)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@mahocsinh", hs.MaHocSinh);
            cmd.Parameters.AddWithValue("@hoten", hs.HoTen);
            cmd.Parameters.AddWithValue("@gioitinh", hs.GioiTinh);
            cmd.Parameters.AddWithValue("@ngaysinh", hs.NgaySinh);
            cmd.Parameters.AddWithValue("@dantoc", hs.DanToc);
            cmd.Parameters.AddWithValue("@tongiao", hs.TonGiao);
            cmd.Parameters.AddWithValue("@diachi", hs.DiaChi);
            cmd.Parameters.AddWithValue("@quequan", hs.QueQuan);
            cmd.Parameters.AddWithValue("@thongtinphuhuynh", hs.ThongTinPhuHuynh);
            cmd.Parameters.AddWithValue("@sdtlienhe", hs.SoDienThoaiLienHe);
            cmd.Parameters.AddWithValue("@malop", hs.MaLop);
            cmd.ExecuteNonQuery();
        }
        public void deleteHocSinh(HocSinh hs)
        {
            try
            {
                openConn();
                String query = "delete from HocSinh where mahocsinh= @mahocsinh";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@mahocsinh", hs.MaHocSinh);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
