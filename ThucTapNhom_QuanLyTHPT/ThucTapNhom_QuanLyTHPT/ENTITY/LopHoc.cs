using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    class LopHoc
    {
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
    }
}
