using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_QuanLyTHPT.ENTITY
{
    class MonHoc
    {
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }

        public MonHoc(string maMonHoc, string tenMonHoc)
        {
            this.MaMonHoc = maMonHoc;
            this.TenMonHoc = tenMonHoc;
        }
    }
}
