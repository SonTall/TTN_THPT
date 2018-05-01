using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    class LopHoc
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;

        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string MaGiaoVienChuNhiem { get; set; }
        public LopHoc(string maLop, string tenLop, DateTime ngayBatDau,
            DateTime ngayKetThuc, string maGiaoVienChuNhiem)
        {
            this.MaLop = maLop;
            this.TenLop = tenLop;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.MaGiaoVienChuNhiem = maGiaoVienChuNhiem;
        }

        public LopHoc(string text1, string text2, string text3, string text4, string text5)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
        }
    }
}
