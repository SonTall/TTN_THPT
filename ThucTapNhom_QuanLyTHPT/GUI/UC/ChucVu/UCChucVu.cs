using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyTHPT.GUI.UC.ChucVu
{
    public partial class UCChucVu : Form
    {
        public UCChucVu()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }

        #region Func Form
        private void LockControl()
        {
            txtMaChucVu.Enabled = false;
            txtTenChucVu.Enabled = false;
            btnClearText_ChucVu.Enabled = false;
            btnLuu_ChucVu.Enabled = false;
        }

        private void OpenControl()
        {
            txtMaChucVu.Enabled = true;
            txtTenChucVu.Enabled = true;
            btnClearText_ChucVu.Enabled = true;
            btnLuu_ChucVu.Enabled = true;
        }

        private void ClearText()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }

        #endregion

        private void UCChucVu_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            pnlThongTin_ChucVu.Visible = false;
            dgvChucVu.Height = this.Height;
        }
        private void DataGridViewColStyle()
        {
            dgvChucVu.BorderStyle = BorderStyle.None;
            dgvChucVu.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvChucVu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChucVu.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvChucVu.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvChucVu.BackgroundColor = Color.White;

            dgvChucVu.EnableHeadersVisualStyles = false;
            dgvChucVu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvChucVu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvChucVu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSearch_ChucVu_Click(object sender, EventArgs e)
        {
            if (cbOption_ChucVu.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cbOption_ChucVu.Text.Equals("Mã chức vụ"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "ChucVu";
                string key = "machucvu";
                dgvChucVu.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_ChucVu.Text.Trim() + "%'");
                LockControl();
            }
        }

        private void dgvChucVu_MouseClick(object sender, MouseEventArgs e)
        {
            LockControl();
            pnlThongTin_ChucVu.Visible = true;
            dgvChucVu.Height = 481;

            if (dgvChucVu.Rows.Count > 0)
            {
                txtMaChucVu.Text = dgvChucVu.SelectedRows[0].Cells[0].Value.ToString();
                txtTenChucVu.Text = dgvChucVu.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnThem_ChucVu_Click(object sender, EventArgs e)
        {
            pnlThongTin_ChucVu.Visible = true;
            dgvChucVu.Height = 481;
            ClearText();
            OpenControl();
        }

        private void btnSua_ChucVu_Click(object sender, EventArgs e)
        {
            OpenControl();
        }

        private void btnXoa_ChucVu_Click(object sender, EventArgs e)
        {
            ENTITY.ChucVu cv = new ENTITY.ChucVu(txtMaChucVu.Text.Trim(), txtTenChucVu.Text.Trim());
            DATA.ChucVu_Controler c = new DATA.ChucVu_Controler();
            c.deleteChucVu(cv);
            loadDataGirdView();
            LockControl();
        }

        private void btnBack_GiaoVien_Click(object sender, EventArgs e)
        {
            pnlThongTin_ChucVu.Visible = false;
            dgvChucVu.Height = this.Height;
        }

        private void btnClearText_GiaoVien_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            dgvChucVu.DataSource = sql.getDataTable("ChucVu");
        }

        private void btnLuu_GiaoVien_Click(object sender, EventArgs e)
        {
            ENTITY.ChucVu cv = new ENTITY.ChucVu(txtMaChucVu.Text.Trim(), txtTenChucVu.Text.Trim());
            DATA.ChucVu_Controler c = new DATA.ChucVu_Controler();
            c.insertChucVu(cv);
            loadDataGirdView();
            LockControl();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
