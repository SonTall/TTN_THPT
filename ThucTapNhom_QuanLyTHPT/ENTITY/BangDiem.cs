using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    class BangDiem
    {
        public string MaHocSinh { get; set; }
        public string MaGiaoVien { get; set; }
        public string MaMonHoc { get; set; }
        public int NamHoc { get; set; }
        public int HocKy { get; set; }
        public float DiemTrungBinh { get; set; }

        public BangDiem(string maHocSinh, string maGiaoVien, string maMonHoc,
            int namHoc, int hocKy, float diemTrungBinh)
        {
            this.MaHocSinh = maHocSinh;
            this.MaGiaoVien = maGiaoVien;
            this.MaMonHoc = maMonHoc;
            this.NamHoc = namHoc;
            this.HocKy = hocKy;
            this.DiemTrungBinh = diemTrungBinh;
        }
        public BangDiem() { }
    }
}
