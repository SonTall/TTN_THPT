using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyTHPT.GUI.UC.GiaoVien
{
    public partial class UCGiaoVien : Form
    {
        public UCGiaoVien()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }

        #region Func Form
        private void LockControl()
        {
            txtMaGiaoVien.Enabled = false;
            txtTenGiaoVien.Enabled = false;
            rbNam.Enabled = false;
            rbNu.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtQueQuan.Enabled = false;
            txtLuongCoBan.Enabled = false;
            txtTrinhDo.Enabled = false;
            txtSdt.Enabled = false;
            txtMaChucVu.Enabled = false;
            btnClearText_GiaoVien.Enabled = false;
            btnLuu_GiaoVien.Enabled = false;
        }

        private void OpenControl()
        {
            txtMaGiaoVien.Enabled = true;
            txtTenGiaoVien.Enabled = true;
            rbNam.Enabled = true;
            rbNu.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtQueQuan.Enabled = true;
            txtLuongCoBan.Enabled = true;
            txtTrinhDo.Enabled = true;
            txtSdt.Enabled = true;
            txtMaChucVu.Enabled = true;
            btnClearText_GiaoVien.Enabled = true;
            btnLuu_GiaoVien.Enabled = true;
        }

        private void ClearText()
        {
            txtMaGiaoVien.Text = "";
            txtTenGiaoVien.Text = "";
            dtNgaySinh.Value = DateTime.Now;
            rbNam.Checked = false;
            rbNam.Checked = false;
            txtDiaChi.Text = "";
            txtQueQuan.Text = "";
            txtLuongCoBan.Text = "";
            txtTrinhDo.Text = "";
            txtSdt.Text = "";
            txtMaChucVu.Text = "";
        }

        #endregion

        private void UCGiaoVien_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            pnlThongTin_GiaoVien.Visible = false;
            dgvGiaoVien.Height = this.Height;
        }

        private void DataGridViewColStyle()
        {
            dgvGiaoVien.BorderStyle = BorderStyle.None;
            dgvGiaoVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvGiaoVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGiaoVien.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvGiaoVien.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvGiaoVien.BackgroundColor = Color.White;

            dgvGiaoVien.EnableHeadersVisualStyles = false;
            dgvGiaoVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGiaoVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvGiaoVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSearch_GiaoVien_Click(object sender, EventArgs e)
        {
            if (cbOption_GiaoVien.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cbOption_GiaoVien.Text.Equals("Mã giáo viên"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "GiaoVien";
                string key = "magiaovien";
                dgvGiaoVien.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_GiaoVien.Text.Trim() + "%'");
                LockControl();
            }

            if (cbOption_GiaoVien.Text.Equals("Tên giáo viên"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "GiaoVien";
                string key = "tengiaovien";
                dgvGiaoVien.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_GiaoVien.Text.Trim() + "%'");
                LockControl();
            }

            if (cbOption_GiaoVien.Text.Equals("Mã chức vụ"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "GiaoVien";
                string key = "machucvu";
                dgvGiaoVien.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_GiaoVien.Text.Trim() + "%'");
                LockControl();
            }
        }

        private void dgvGiaoVien_MouseClick(object sender, MouseEventArgs e)
        {
            LockControl();
            pnlThongTin_GiaoVien.Visible = true;
            dgvGiaoVien.Height = 362;

            if (dgvGiaoVien.Rows.Count > 0)
            {
                txtMaGiaoVien.Text = dgvGiaoVien.SelectedRows[0].Cells[0].Value.ToString();
                txtTenGiaoVien.Text = dgvGiaoVien.SelectedRows[0].Cells[1].Value.ToString();
                // dtNgaySinh.Text = dgvGiaoVien.SelectedRows[0].Cells[2].Value.ToString();
                // txtGioiTinh.Text = dgvGiaoVien.SelectedRows[0].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvGiaoVien.SelectedRows[0].Cells[4].Value.ToString();
                txtQueQuan.Text = dgvGiaoVien.SelectedRows[0].Cells[5].Value.ToString();
                txtSdt.Text = dgvGiaoVien.SelectedRows[0].Cells[6].Value.ToString();
                txtTrinhDo.Text = dgvGiaoVien.SelectedRows[0].Cells[7].Value.ToString();
                txtLuongCoBan.Text = dgvGiaoVien.SelectedRows[0].Cells[8].Value.ToString();
                txtMaChucVu.Text = dgvGiaoVien.SelectedRows[0].Cells[9].Value.ToString();
            }
        }

        private void btnThem_GiaoVien_Click(object sender, EventArgs e)
        {
            pnlThongTin_GiaoVien.Visible = true;
            dgvGiaoVien.Height = 362;
            ClearText();
            OpenControl();
        }

        private void btnSua_GiaoVien_Click(object sender, EventArgs e)
        {
            OpenControl();
        }

        private void btnXoa_GiaoVien_Click(object sender, EventArgs e)
        {
            ENTITY.GiaoVien gv = new ENTITY.GiaoVien(txtMaGiaoVien.Text.Trim(), txtTenGiaoVien.Text.Trim(), checkGioiTinh(), dtNgaySinh.Value, txtDiaChi.Text.Trim(), txtQueQuan.Text.Trim(), txtSdt.Text.Trim(), txtTrinhDo.Text.Trim(), float.Parse(txtLuongCoBan.Text.Trim()), txtMaChucVu.Text.Trim());
            DATA.GiaoVien_Controler g = new DATA.GiaoVien_Controler();
            DATA.ChucVu_Controler c = new DATA.ChucVu_Controler();
            g.deleteGiaoVien(gv);
            loadDataGirdView();
            LockControl();
        }

        private void btnBack_GiaoVien_Click(object sender, EventArgs e)
        {
            pnlThongTin_GiaoVien.Visible = false;
            dgvGiaoVien.Height = this.Height;
        }

        private void btnClearText_GiaoVien_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            dgvGiaoVien.DataSource = sql.getDataTable("GiaoVien");
        }

        private bool checkGioiTinh()
        {
            bool gioitinh;
            if (rbNam.Checked==true)
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            return gioitinh;
        }

        private void btnLuu_GiaoVien_Click(object sender, EventArgs e)
        {
            ENTITY.GiaoVien gv = new ENTITY.GiaoVien(txtMaGiaoVien.Text.Trim(), txtTenGiaoVien.Text.Trim(), checkGioiTinh(), dtNgaySinh.Value, txtDiaChi.Text.Trim(), txtQueQuan.Text.Trim(), txtSdt.Text.Trim(), txtTrinhDo.Text.Trim(), float.Parse(txtLuongCoBan.Text.Trim()), txtMaChucVu.Text.Trim());
            DATA.GiaoVien_Controler g = new DATA.GiaoVien_Controler();
            g.insertGiaoVien(gv);
            loadDataGirdView();
            LockControl();
        }
    }
}
