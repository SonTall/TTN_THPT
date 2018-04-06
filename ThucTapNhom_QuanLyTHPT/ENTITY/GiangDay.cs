using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    class GiangDay
    {
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
    }
}
