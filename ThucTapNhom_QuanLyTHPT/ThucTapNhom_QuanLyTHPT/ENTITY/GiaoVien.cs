using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    class GiaoVien
    {
        public string MaGiaoVien { get; set; }
        public string TenGiaoVien { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string QueQuan { get; set; }
        public string SoDienThoai { get; set; }
        public string TrinhDo { get; set; }
        public float LuongCoBan { get; set; }
        public string MaChucVu { get; set; }

        public GiaoVien(string maGiaoVien, string tenGiaoVien, bool gioiTinh,
            DateTime ngaySinh, string diaChi, string queQuan,
            string soDienThoai, string trinhDo, float luongCoBan, string maChucVu)
        {
            this.MaGiaoVien = maGiaoVien;
            this.TenGiaoVien = tenGiaoVien;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.QueQuan = queQuan;
            this.SoDienThoai = soDienThoai;
            this.TrinhDo = trinhDo;
            this.LuongCoBan = luongCoBan;
            this.MaChucVu = maChucVu;
        }
    }
}
