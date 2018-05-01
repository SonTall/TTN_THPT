using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    class BangDiem
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;

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
        public BangDiem()
        { }

        public BangDiem(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
        }
    }
}
