using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    class GiangDay
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;

        public string MaGiaoVien { get; set; }
        public string MaLopHoc { get; set; }
        public string MaMonHoc { get; set; }
        public string Thu { get; set; }
        public int Tiet { get; set; }
        public int SoTiet { get; set; }

        public GiangDay(string maGiaoVien, string maLopHoc, string maMonHoc,
            string thu, int tiet, int soTiet)
        {
            this.MaGiaoVien = maGiaoVien;
            this.MaLopHoc = maLopHoc;
            this.MaMonHoc = maMonHoc;
            this.Thu = thu;
            this.Tiet = tiet;
            this.SoTiet = soTiet;
        }

        public GiangDay(string text1, string text2, string text3, string text4, string text5, string text6)
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
