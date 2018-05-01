using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    public class HocSinh
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
        private string text10;

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

        public HocSinh(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, int bottom1, int bottom2, string text10)
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
            this.text10 = text10;
        }
    }
}
