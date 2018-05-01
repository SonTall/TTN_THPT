using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    class GiaoVien
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;
        private string text7;
        private string text8;
        private string text9;
        private int bottom1;
        private int bottom2;

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

        public GiaoVien(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, int bottom1, int bottom2)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
            this.text7 = text7;
            this.text8 = text8;
            this.text9 = text9;
            this.bottom1 = bottom1;
            this.bottom2 = bottom2;
        }
    }
}
