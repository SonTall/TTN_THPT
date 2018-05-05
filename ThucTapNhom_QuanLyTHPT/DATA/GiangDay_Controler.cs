using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTapNhom_QuanLyTHPT.ENTITY;

namespace ThucTapNhom_QuanLyTHPT.DATA
{
    class GiangDay_Controler : SqlConn
    {
        public void insertGiangDay(GiangDay d)
        {
            openConn();
            string query = "insert into GiangDay(magiaovien, malop, mamonhoc, thu, tiet, sotiet) values (@magiaovien, @malop, @mamonhoc, @thu, @tiet, @sotiet)";
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@magiaovien", d.MaGiaoVien);
            cmd.Parameters.AddWithValue("@malop", d.MaLopHoc);
            cmd.Parameters.AddWithValue("@mamonhoc", d.MaMonHoc);
            cmd.Parameters.AddWithValue("@thu", d.Thu);
            cmd.Parameters.AddWithValue("@tiet", d.Tiet);
            cmd.Parameters.AddWithValue("@sotiet", d.SoTiet);
            cmd.ExecuteNonQuery();
        }
    }
}
