using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTapNhom_QuanLyTHPT.ENTITY;

namespace ThucTapNhom_QuanLyTHPT.DATA
{
    class GiaoVien_Controler : SqlConn
    {
        public void insertGiaoVien(GiaoVien gv)
        {
            openConn();
            string query = "insert into GiaoVien(magiaovien, tengiaovien, ngaysinh, gioitinh, diachi, quequan, sdt, trinhdo, luongcoban, machucvu) values (@magiaovien, @tengiaovien, @ngaysinh, @gioitinh, @diachi, @quequan, @sdt, @trinhdo, @luongcoban, @machucvu)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@magiaovien", gv.MaGiaoVien);
            cmd.Parameters.AddWithValue("@tengiaovien", gv.TenGiaoVien);
            cmd.Parameters.AddWithValue("@ngaysinh", gv.NgaySinh);
            cmd.Parameters.AddWithValue("@gioitinh", gv.GioiTinh);
            cmd.Parameters.AddWithValue("@diachi", gv.DiaChi);
            cmd.Parameters.AddWithValue("@quequan", gv.QueQuan);
            cmd.Parameters.AddWithValue("@sdt", gv.SoDienThoai);
            cmd.Parameters.AddWithValue("@trinhdo", gv.TrinhDo);
            cmd.Parameters.AddWithValue("@luongcoban", gv.LuongCoBan);
            cmd.Parameters.AddWithValue("@machucvu", gv.MaChucVu);
            cmd.ExecuteNonQuery();
        }
        public void deleteGiaoVien(GiaoVien gv)
        {
            try
            {
                openConn();
                String query = "delete from GiaoVien where magiaovien= @magiaovien";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@magiaovien", gv.MaGiaoVien);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            
            }
        }
    }
}
