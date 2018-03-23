using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapNhom_QuanLyTHPT.GUI.UC.BangDiem;
using ThucTapNhom_QuanLyTHPT.GUI.UC.ChucVu;
using ThucTapNhom_QuanLyTHPT.GUI.UC.GiangDay;
using ThucTapNhom_QuanLyTHPT.GUI.UC.GiaoVien;
using ThucTapNhom_QuanLyTHPT.GUI.UC.HocSinh;
using ThucTapNhom_QuanLyTHPT.GUI.UC.Home;
using ThucTapNhom_QuanLyTHPT.GUI.UC.LopHoc;
using ThucTapNhom_QuanLyTHPT.GUI.UC.MonHoc;
using ThucTapNhom_QuanLyTHPT.GUI.UC.ThongKe;

namespace ThucTapNhom_QuanLyTHPT
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCHome uCHome = new UCHome();
            uCHome.TopLevel = false;
            uCHome.Width = pnlBody.Width;
            uCHome.Height = pnlBody.Height;
            uCHome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlBody.Controls.Add(uCHome);
            uCHome.Show();
        }
        private void ClearRenderbody()
        {
            while (pnlBody.Controls.Count > 0) pnlBody.Controls[pnlBody.Controls.Count - 1].Dispose();
            //foreach (Control ctrl in RenderBody.Controls) ctrl.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCHocSinh uCHocSinh = new UCHocSinh();
            uCHocSinh.TopLevel = false;
            uCHocSinh.Width = pnlBody.Width;
            uCHocSinh.Height = pnlBody.Height;
            uCHocSinh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlBody.Controls.Add(uCHocSinh);
            uCHocSinh.Show();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCGiaoVien uCGiaoVien = new UCGiaoVien();
            uCGiaoVien.TopLevel = false;
            uCGiaoVien.Width = pnlBody.Width;
            uCGiaoVien.Height = pnlBody.Height;
            uCGiaoVien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlBody.Controls.Add(uCGiaoVien);
            uCGiaoVien.Show();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCChucVu uCChucVu = new UCChucVu();
            uCChucVu.TopLevel = false;
            uCChucVu.Width = pnlBody.Width;
            uCChucVu.Height = pnlBody.Height;
            uCChucVu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlBody.Controls.Add(uCChucVu);
            uCChucVu.Show();
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCLopHoc uCLopHoc = new UCLopHoc();
            uCLopHoc.TopLevel = false;
            uCLopHoc.Width = pnlBody.Width;
            uCLopHoc.Height = pnlBody.Height;
            uCLopHoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlBody.Controls.Add(uCLopHoc);
            uCLopHoc.Show();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCMonHoc uCMonHoc = new UCMonHoc();
            uCMonHoc.TopLevel = false;
            uCMonHoc.Width = pnlBody.Width;
            uCMonHoc.Height = pnlBody.Height;
            uCMonHoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlBody.Controls.Add(uCMonHoc);
            uCMonHoc.Show();
        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCBangDiem uCBangDiem = new UCBangDiem();
            uCBangDiem.TopLevel = false;
            uCBangDiem.Width = pnlBody.Width;
            uCBangDiem.Height = pnlBody.Height;
            uCBangDiem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlBody.Controls.Add(uCBangDiem);
            uCBangDiem.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCHome uCHome = new UCHome();
            uCHome.TopLevel = false;
            uCHome.Width = pnlBody.Width;
            uCHome.Height = pnlBody.Height;
            uCHome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlBody.Controls.Add(uCHome);
            uCHome.Show();
        }

        private void btnGiangDay_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCGiangDay uCGiangDay = new UCGiangDay();
            uCGiangDay.TopLevel = false;
            uCGiangDay.Width = pnlBody.Width;
            uCGiangDay.Height = pnlBody.Height;
            uCGiangDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlBody.Controls.Add(uCGiangDay);
            uCGiangDay.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ClearRenderbody();
            UCThongKe uCThongKe = new UCThongKe();
            uCThongKe.TopLevel = false;
            uCThongKe.Width = pnlBody.Width;
            uCThongKe.Height = pnlBody.Height;
            uCThongKe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            pnlBody.Controls.Add(uCThongKe);
            uCThongKe.Show();
        }
    }
}
