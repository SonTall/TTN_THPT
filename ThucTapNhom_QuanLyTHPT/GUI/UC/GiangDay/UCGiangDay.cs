using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyTHPT.GUI.UC.GiangDay
{
    public partial class UCGiangDay : Form
    {
        public UCGiangDay()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }

        #region Func Form
        private void LockControl()
        {
            txtMaGiaoVien.Enabled = false;
            txtMaLop.Enabled = false;
            txtMaMonHoc.Enabled = false;
            txtThu.Enabled = false;
            txtTiet.Enabled = false;
            txtSoTiet.Enabled = false;
        }

        private void OpenControl()
        {
            txtMaGiaoVien.Enabled = true;
            txtMaLop.Enabled = true;
            txtMaMonHoc.Enabled = true;
            txtThu.Enabled = true;
            txtTiet.Enabled = true;
            txtSoTiet.Enabled = true;
        }

        private void ClearText()
        {
            txtMaGiaoVien.Text = "";
            txtMaLop.Text = "";
            txtMaMonHoc.Text = "";
            txtThu.Text = "";
            txtTiet.Text = "";
            txtSoTiet.Text = "";
        }

        #endregion

        private void UCGiangDay_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            pnlThongTin_GiangDay.Visible = false;
            dgvGiangDay.Height = this.Height;
        }

        private void DataGridViewColStyle()
        {
            dgvGiangDay.BorderStyle = BorderStyle.None;
            dgvGiangDay.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvGiangDay.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGiangDay.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvGiangDay.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvGiangDay.BackgroundColor = Color.White;

            dgvGiangDay.EnableHeadersVisualStyles = false;
            dgvGiangDay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGiangDay.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvGiangDay.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSearch_GiangDay_Click(object sender, EventArgs e)
        {
            if (cbOption_GiangDay.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cbOption_GiangDay.Text.Equals("Mã giáo viên"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "GiangDay";
                string key = "magiaovien";
                dgvGiangDay.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_GiangDay.Text.Trim() + "%'");
                LockControl();
            }

            if (cbOption_GiangDay.Text.Equals("Mã lớp học"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "GiangDay";
                string key = "malop";
                dgvGiangDay.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_GiangDay.Text.Trim() + "%'");
                LockControl();
            }

            if (cbOption_GiangDay.Text.Equals("Mã môn học"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "GiangDay";
                string key = "mamonhoc";
                dgvGiangDay.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_GiangDay.Text.Trim() + "%'");
                LockControl();
            }
        }

        private void dgvLopHoc_MouseClick(object sender, MouseEventArgs e)
        {
            LockControl();
            pnlThongTin_GiangDay.Visible = true;
            dgvGiangDay.Height = 408;

            if (dgvGiangDay.Rows.Count > 0)
            {
                txtMaGiaoVien.Text = dgvGiangDay.SelectedRows[0].Cells[0].Value.ToString();
                txtMaLop.Text = dgvGiangDay.SelectedRows[0].Cells[1].Value.ToString();
                txtMaMonHoc.Text = dgvGiangDay.SelectedRows[0].Cells[2].Value.ToString();
                txtThu.Text = dgvGiangDay.SelectedRows[0].Cells[3].Value.ToString();
                txtTiet.Text = dgvGiangDay.SelectedRows[0].Cells[4].Value.ToString();
                txtSoTiet.Text = dgvGiangDay.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void btnThem_GiangDay_Click(object sender, EventArgs e)
        {
            pnlThongTin_GiangDay.Visible = true;
            dgvGiangDay.Height = 408;
            ClearText();
            OpenControl();
        }

        private void btnSua_GiangDay_Click(object sender, EventArgs e)
        {
            OpenControl();
        }

        private void btnXoa_GiangDay_Click(object sender, EventArgs e)
        {
            ENTITY.GiangDay gd = new ENTITY.GiangDay(txtMaGiaoVien.Text.Trim(), txtMaLop.Text.Trim(), txtMaMonHoc.Text.Trim(), txtThu.Text.Trim(), int.Parse(txtTiet.Text.Trim()), int.Parse(txtSoTiet.Text.Trim()));
            DATA.GiangDay_Controler g = new DATA.GiangDay_Controler();
            g.deleteGiangDay(gd);
            loadDataGirdView();
            LockControl();
        }

        private void btnBack_GiangDay_Click(object sender, EventArgs e)
        {
            pnlThongTin_GiangDay.Visible = false;
            dgvGiangDay.Height = this.Height;
        }

        private void btnClearText_GiangDay_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            dgvGiangDay.DataSource = sql.getDataTable("GiangDay");
        }

        private void btnLuu_GiangDay_Click(object sender, EventArgs e)
        {
            ENTITY.GiangDay gd = new ENTITY.GiangDay(txtMaGiaoVien.Text.Trim(), txtMaLop.Text.Trim(), txtMaMonHoc.Text.Trim(), txtThu.Text.Trim(), int.Parse(txtTiet.Text.Trim()), int.Parse(txtSoTiet.Text.Trim()));
            DATA.GiangDay_Controler g = new DATA.GiangDay_Controler();
            g.insertGiangDay(gd);
            loadDataGirdView();
            LockControl();
        }
    }
}
