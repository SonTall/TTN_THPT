using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyTHPT.GUI.UC.BangDiem
{
    public partial class UCBangDiem : Form
    {
        public UCBangDiem()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }

        #region Func Form
        private void LockControl()
        {
            txtMaHocSinh.Enabled = false;
            txtMaGiaoVien.Enabled = false;
            txtMaMonHoc.Enabled = false;
            txtNamHoc.Enabled = false;
            txtHocKy.Enabled = false;
            txtDiemTrungBinh.Enabled = false;
        }

        private void OpenControl()
        {
            txtMaHocSinh.Enabled = true;
            txtMaGiaoVien.Enabled = true;
            txtMaMonHoc.Enabled = true;
            txtNamHoc.Enabled = true;
            txtHocKy.Enabled = true;
            txtDiemTrungBinh.Enabled = true;
        }

        private void ClearText()
        {
            txtMaHocSinh.Text = "";
            txtMaGiaoVien.Text = "";
            txtMaMonHoc.Text = "";
            txtNamHoc.Text = "";
            txtHocKy.Text = "";
            txtDiemTrungBinh.Text = "";
        }

        #endregion

        private void UCBangDiem_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            pnlThongTin_BangDiem.Visible = false;
            dgvBangDiem.Height = this.Height;
        }

        private void DataGridViewColStyle()
        {
            dgvBangDiem.BorderStyle = BorderStyle.None;
            dgvBangDiem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvBangDiem.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBangDiem.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvBangDiem.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvBangDiem.BackgroundColor = Color.White;

            dgvBangDiem.EnableHeadersVisualStyles = false;
            dgvBangDiem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBangDiem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvBangDiem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSearch_BangDiem_Click(object sender, EventArgs e)
        {
            if (cbOption_BangDiem.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cbOption_BangDiem.Text.Equals("Mã học sinh"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "BangDiem";
                string key = "mahocsinh";
                dgvBangDiem.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_BangDiem.Text.Trim() + "%'");
                LockControl();
            }

            if (cbOption_BangDiem.Text.Equals("Mã giáo viên"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "BangDiem";
                string key = "magiaovien";
                dgvBangDiem.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_BangDiem.Text.Trim() + "%'");
                LockControl();
            }

            if (cbOption_BangDiem.Text.Equals("Mã môn học"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "BangDiem";
                string key = "mamonhoc";
                dgvBangDiem.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_BangDiem.Text.Trim() + "%'");
                LockControl();
            }
        }

        private void dgvLopHoc_MouseClick(object sender, MouseEventArgs e)
        {
            LockControl();
            pnlThongTin_BangDiem.Visible = true;
            dgvBangDiem.Height = 404;

            if (dgvBangDiem.Rows.Count > 0)
            {
                txtMaHocSinh.Text = dgvBangDiem.SelectedRows[0].Cells[0].Value.ToString();
                txtMaHocSinh.Text = dgvBangDiem.SelectedRows[0].Cells[1].Value.ToString();
                txtMaMonHoc.Text = dgvBangDiem.SelectedRows[0].Cells[1].Value.ToString();
                txtNamHoc.Text = dgvBangDiem.SelectedRows[0].Cells[1].Value.ToString();
                txtHocKy.Text = dgvBangDiem.SelectedRows[0].Cells[1].Value.ToString();
                txtDiemTrungBinh.Text = dgvBangDiem.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnThem_BangDiem_Click(object sender, EventArgs e)
        {
            pnlThongTin_BangDiem.Visible = true;
            dgvBangDiem.Height = 404;
            ClearText();
            OpenControl();
        }

        private void btnSua_BangDiem_Click(object sender, EventArgs e)
        {
            OpenControl();
        }

        private void btnXoa_BangDiem_Click(object sender, EventArgs e)
        {
            try
            {
                ENTITY.BangDiem bd = new ENTITY.BangDiem();
                bd.MaHocSinh = 
                bd.MaGiaoVien = txtMaGiaoVien.Text.Trim();
                bd.MaMonHoc = txtMaMonHoc.Text.Trim();
                DATA.BangDiem_Controler b = new DATA.BangDiem_Controler();
                b.deleteBangDiem(bd);
                loadDataGirdView();
                LockControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            loadDataGirdView();
            LockControl();
        }

        private void btnBack_BangDiem_Click(object sender, EventArgs e)
        {
            pnlThongTin_BangDiem.Visible = false;
            dgvBangDiem.Height = this.Height;
        }

        private void btnClearText_BangDiem_Click(object sender, EventArgs e)
        {
            ClearText();
        }


        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            dgvBangDiem.DataSource = sql.getDataTable("BangDiem");
        }
        private void btnLuu_BangDiem_Click(object sender, EventArgs e)
        {
            ENTITY.BangDiem bd = new ENTITY.BangDiem(txtMaHocSinh.Text.Trim(), txtMaGiaoVien.Text.Trim(), txtMaMonHoc.Text.Trim(), int.Parse(txtNamHoc.Text.Trim()), int.Parse(txtHocKy.Text.Trim()), float.Parse(txtDiemTrungBinh.Text.Trim()));
            DATA.BangDiem_Controler b = new DATA.BangDiem_Controler();
            b.insertBangDiem(bd);
            loadDataGirdView();
            LockControl();
        }
    }
}
