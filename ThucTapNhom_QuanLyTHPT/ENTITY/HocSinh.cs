using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    public class HocSinh
    {
        public string MaHocSinh { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string DiaChi { get; set; }
        public string QueQuan { get; set; }
        public string ThongTinPhuHuynh { get; set; }
        public string SoDienThoaiLienHe { get; set; }
        public string MaLop { get; set; }

        public HocSinh(string maHocSinh, string hoTen, bool gioiTinh, 
            DateTime ngaySinh, string danToc, string tonGiao, 
            string diaChi, string queQuan, string thongTinPhuHuynh, string sdt, string maLop)
        {
            this.MaHocSinh = maHocSinh;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DanToc = danToc;
            this.TonGiao = tonGiao;
            this.DiaChi = diaChi;
            this.QueQuan = queQuan;
            this.ThongTinPhuHuynh = thongTinPhuHuynh;
            this.SoDienThoaiLienHe = sdt;
            this.MaLop = maLop;
        }
    }
}
