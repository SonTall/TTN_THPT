using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyTHPT.GUI.UC.LopHoc
{
    public partial class UCLopHoc : Form
    {
        public UCLopHoc()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }

        #region Func Form
        private void LockControl()
        {
            txtMaLopHoc.Enabled = false;
            txtTenLopHoc.Enabled = false;
            dtNgayBatDau.Enabled = false;
            dtNgayKetThuc.Enabled = false;
            txtMaGiaoVienChuNhiem.Enabled = false;
        }

        private void OpenControl()
        {
            txtMaLopHoc.Enabled = true;
            txtTenLopHoc.Enabled = true;
            dtNgayBatDau.Enabled = true;
            dtNgayKetThuc.Enabled = true;
            txtMaGiaoVienChuNhiem.Enabled = true;
        }

        private void ClearText()
        {
            txtMaLopHoc.Text = "";
            txtTenLopHoc.Text = "";
            dtNgayBatDau.Value = DateTime.Now;
            dtNgayKetThuc.Value = DateTime.Now;
            txtMaGiaoVienChuNhiem.Text = "";
        }

        #endregion

        private void UCLopHoc_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            pnlThongTin_LopHoc.Visible = false;
            dgvLopHoc.Height = this.Height;
        }

        private void DataGridViewColStyle()
        {
            dgvLopHoc.BorderStyle = BorderStyle.None;
            dgvLopHoc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvLopHoc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLopHoc.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvLopHoc.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvLopHoc.BackgroundColor = Color.White;

            dgvLopHoc.EnableHeadersVisualStyles = false;
            dgvLopHoc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLopHoc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvLopHoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        // phan search
        
        private void btnSearch_LopHoc_Click(object sender, EventArgs e)
        {
            if (cbOption_LopHoc.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cbOption_LopHoc.Text.Equals("Mã lớp học"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "Lop";
                string key = "malop";
                dgvLopHoc.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_LopHoc.Text.Trim() + "%'");
                LockControl();
            }
        }
//

        private void dgvLopHoc_MouseClick(object sender, MouseEventArgs e)
        {
            LockControl();
            pnlThongTin_LopHoc.Visible = true;
            dgvLopHoc.Height = 426;

            if (dgvLopHoc.Rows.Count > 0)
            {
                txtMaLopHoc.Text = dgvLopHoc.SelectedRows[0].Cells[0].Value.ToString();
                txtTenLopHoc.Text = dgvLopHoc.SelectedRows[0].Cells[1].Value.ToString();
                //dtNgayBatDau.Text = dgvLopHoc.SelectedRows[0].Cells[2].Value.ToString();
                //dtNgayKetThuc.Text = dgvLopHoc.SelectedRows[0].Cells[3].Value.ToString();
                txtMaGiaoVienChuNhiem.Text = dgvLopHoc.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnThem_LopHoc_Click(object sender, EventArgs e)
        {
            pnlThongTin_LopHoc.Visible = true;
            dgvLopHoc.Height = 426;
            ClearText();
            OpenControl();
        }

        private void btnSua_LopHoc_Click(object sender, EventArgs e)
        {
            OpenControl();
        }

        private void btnXoa_LopHoc_Click(object sender, EventArgs e)
        {
            ENTITY.LopHoc l = new ENTITY.LopHoc(txtMaLopHoc.Text.Trim(), txtTenLopHoc.Text.Trim(), dtNgayBatDau.Value, dtNgayKetThuc.Value, txtMaGiaoVienChuNhiem.Text.Trim());
            DATA.LopHoc_Controler lh = new DATA.LopHoc_Controler();
            lh.deleteLop(l);
            loadDataGirdView();
            LockControl();
        }

        private void btnBack_LopHoc_Click(object sender, EventArgs e)
        {
            pnlThongTin_LopHoc.Visible = false;
            dgvLopHoc.Height = this.Height;
        }

        private void btnClearText_LopHoc_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            dgvLopHoc.DataSource = sql.getDataTable("Lop");
        }

        private void btnLuu_LopHoc_Click(object sender, EventArgs e)
        {
            ENTITY.LopHoc l = new ENTITY.LopHoc(txtMaLopHoc.Text.Trim(), txtTenLopHoc.Text.Trim(), dtNgayBatDau.Value, dtNgayKetThuc.Value, txtMaGiaoVienChuNhiem.Text.Trim());
            DATA.LopHoc_Controler lh = new DATA.LopHoc_Controler();
            lh.insertLopHoc(l);
            loadDataGirdView();
            LockControl();
        }


    }
}
