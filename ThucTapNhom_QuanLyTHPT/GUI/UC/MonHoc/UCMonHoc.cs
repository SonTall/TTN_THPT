using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyTHPT.GUI.UC.MonHoc
{
    public partial class UCMonHoc : Form
    {
        public UCMonHoc()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }

        #region Func Form
        private void LockControl()
        {
            txtMaMonHoc.Enabled = false;
            txtTenMonHoc.Enabled = false;
            btnClearText_MonHoc.Enabled = false;
            btnLuu_MonHoc.Enabled = false;
        }

        private void OpenControl()
        {
            txtMaMonHoc.Enabled = true;
            txtTenMonHoc.Enabled = true;
            btnClearText_MonHoc.Enabled = true;
            btnLuu_MonHoc.Enabled = true;
        }

        private void ClearText()
        {
            txtMaMonHoc.Text = "";
            txtTenMonHoc.Text = "";
        }

        #endregion

        private void UCMonHoc_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            pnlThongTin_MonHoc.Visible = false;
            dgvMonHoc.Height = this.Height;
        }

        private void DataGridViewColStyle()
        {
            dgvMonHoc.BorderStyle = BorderStyle.None;
            dgvMonHoc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvMonHoc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMonHoc.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvMonHoc.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMonHoc.BackgroundColor = Color.White;

            dgvMonHoc.EnableHeadersVisualStyles = false;
            dgvMonHoc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMonHoc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvMonHoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dgvMonHoc_MouseClick(object sender, MouseEventArgs e)
        {
            LockControl();
            pnlThongTin_MonHoc.Visible = true;
            dgvMonHoc.Height = 481;

            if (dgvMonHoc.Rows.Count > 0)
            {
                txtMaMonHoc.Text = dgvMonHoc.SelectedRows[0].Cells[0].Value.ToString();
                txtTenMonHoc.Text = dgvMonHoc.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnThem_MonHoc_Click(object sender, EventArgs e)
        {
            pnlThongTin_MonHoc.Visible = true;
            dgvMonHoc.Height = 481;
            ClearText();
            OpenControl();
        }

        private void btnSua_MonHoc_Click(object sender, EventArgs e)
        {
            OpenControl();
        }

        private void btnXoa_MonHoc_Click(object sender, EventArgs e)
        {
            ENTITY.MonHoc mh = new ENTITY.MonHoc(txtMaMonHoc.Text.Trim(), txtTenMonHoc.Text.Trim());
            DATA.MonHoc_Controler m = new DATA.MonHoc_Controler();
            m.deleteMonHoc(mh);
            loadDataGirdView();
            LockControl();
        }

        private void btnBack_MonHoc_Click(object sender, EventArgs e)
        {
            pnlThongTin_MonHoc.Visible = false;
            dgvMonHoc.Height = this.Height;
        }

        private void btnClearText_MonHoc_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            dgvMonHoc.DataSource = sql.getDataTable("MonHoc");
        }

        private void btnLuu_MonHoc_Click(object sender, EventArgs e)
        {
            ENTITY.MonHoc mh = new ENTITY.MonHoc(txtMaMonHoc.Text.Trim(), txtTenMonHoc.Text.Trim());
            DATA.MonHoc_Controler m = new DATA.MonHoc_Controler();
            m.insertMonHoc(mh);
            loadDataGirdView();
            LockControl();
        }

//phan search 
        private void btnSearch_MonHoc_Click(object sender, EventArgs e)
        {
            if (cbOption_MonHoc.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cbOption_MonHoc.Text.Equals("Mã môn học"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "MonHoc";
                string key = "mamonhoc";
                dgvMonHoc.DataSource = sql.searchQuery("select * from " + tb + " where " + key +" Like '%" + txtSearch_MonHoc.Text.Trim() + "%'");
                LockControl();
            }
        }

    }
}
