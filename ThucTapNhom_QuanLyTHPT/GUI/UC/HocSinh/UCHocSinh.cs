using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyTHPT.GUI.UC.HocSinh
{
    public partial class UCHocSinh : Form
    {
        public UCHocSinh()
        {
            InitializeComponent();
            DataGridViewColStyle();

        }

        #region Func Form
        private void LockControl()
        {
            txtMaHocSinh.Enabled = false;
            txtHoTen.Enabled = false;
            rbNam.Enabled = false;
            rbNu.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtDanToc.Enabled = false;
            txtTonGiao.Enabled = false;
            txtDiaChi.Enabled = false;
            txtQueQuan.Enabled = false;
            txtThongTinPhuHuynh.Enabled = false;
            txtSdtLienHe.Enabled = false;
            txtMaLop.Enabled = false;
            btnClearText_HocSinh.Enabled = false;
            btnLuu_HocSinh.Enabled = false;
        }

        private void OpenControl()
        {
            txtMaHocSinh.Enabled = true;
            txtHoTen.Enabled = true;
            rbNam.Enabled = true;
            rbNu.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtDanToc.Enabled = true;
            txtTonGiao.Enabled = true;
            txtDiaChi.Enabled = true;
            txtQueQuan.Enabled = true;
            txtThongTinPhuHuynh.Enabled = true;
            txtSdtLienHe.Enabled = true;
            txtMaLop.Enabled = true;
            btnClearText_HocSinh.Enabled = true;
            btnLuu_HocSinh.Enabled = true;
        }

        private void ClearText()
        {
            txtMaHocSinh.Text = "";
            txtHoTen.Text = "";
            dtNgaySinh.Value = DateTime.Now;
            rbNam.Checked = false;
            rbNam.Checked = false;
            txtDanToc.Text = "";
            txtTonGiao.Text = "";
            txtDiaChi.Text = "";
            txtQueQuan.Text = "";
            txtThongTinPhuHuynh.Text = "";
            txtSdtLienHe.Text = "";
            txtMaLop.Text = "";
        }
        #endregion
        private void UCHocSinh_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            LockControl();
            pnlThongTin.Visible = false;
            dgvHocSinh.Height = this.Height;
            #region testdata
            //for (int i = 0; i < 30; i++)
            //{
            //    i = dgvHocSinh.Rows.Add();
            //    dgvHocSinh.Rows[i].Cells[0].Value = "haha";
            //    dgvHocSinh.Rows[i].Cells[1].Value = "haha";
            //    dgvHocSinh.Rows[i].Cells[2].Value = "haha";
            //    dgvHocSinh.Rows[i].Cells[3].Value = "haha";
            //    dgvHocSinh.Rows[i].Cells[4].Value = "haha";
            //    dgvHocSinh.Rows[i].Cells[5].Value = "haha";
            //    dgvHocSinh.Rows[i].Cells[6].Value = "haha";
            //    dgvHocSinh.Rows[i].Cells[7].Value = "haha";
            //    dgvHocSinh.Rows[i].Cells[8].Value = "haha";
            //    dgvHocSinh.Rows[i].Cells[9].Value = "haha";
            //    dgvHocSinh.Rows[i].Cells[10].Value = "huhu";
            //}
            
            #endregion
        }

        private void DataGridViewColStyle()
        {
            dgvHocSinh.BorderStyle = BorderStyle.None;
            dgvHocSinh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvHocSinh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHocSinh.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvHocSinh.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvHocSinh.BackgroundColor = Color.White;

            dgvHocSinh.EnableHeadersVisualStyles = false;
            dgvHocSinh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHocSinh.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvHocSinh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_HocSinh_Click(object sender, EventArgs e)
        {
            if (cbOption.Text.Equals("")) MessageBox.Show("Chọn tiêu chí cần sắp xếp", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cbOption.Text.Equals("Mã học sinh"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "HocSinh";
                string key = "mahocsinh";
                dgvHocSinh.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_HocSinh.Text.Trim() + "%'");
                LockControl();
            }
            
            if (cbOption.Text.Equals("Tên học sinh"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "HocSinh";
                string key = "hoten";
                dgvHocSinh.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_HocSinh.Text.Trim() + "%'");
                LockControl();
            }

            if (cbOption.Text.Equals("Mã lớp"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                string tb = "HocSinh";
                string key = "malop";
                dgvHocSinh.DataSource = sql.searchQuery("select * from " + tb + " where " + key + " Like '%" + txtSearch_HocSinh.Text.Trim() + "%'");
                LockControl();
            }
        }

        private void dgvHocSinh_MouseClick(object sender, MouseEventArgs e)
        {
            LockControl();
            pnlThongTin.Visible = true;
            dgvHocSinh.Height = 362;

            if (dgvHocSinh.Rows.Count > 0)
            {
                txtMaHocSinh.Text = dgvHocSinh.SelectedRows[0].Cells[0].Value.ToString();
                txtHoTen.Text = dgvHocSinh.SelectedRows[0].Cells[1].Value.ToString();
               // dtNgaySinh.Text = dgvHocSinh.SelectedRows[0].Cells[2].Value.ToString();
               // txtGioiTinh.Text = dgvHocSinh.SelectedRows[0].Cells[3].Value.ToString();
                txtDanToc.Text = dgvHocSinh.SelectedRows[0].Cells[4].Value.ToString();
                txtTonGiao.Text = dgvHocSinh.SelectedRows[0].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvHocSinh.SelectedRows[0].Cells[6].Value.ToString();
                txtQueQuan.Text = dgvHocSinh.SelectedRows[0].Cells[7].Value.ToString();
                txtThongTinPhuHuynh.Text = dgvHocSinh.SelectedRows[0].Cells[8].Value.ToString();
                txtSdtLienHe.Text = dgvHocSinh.SelectedRows[0].Cells[9].Value.ToString();
                txtMaLop.Text = dgvHocSinh.SelectedRows[0].Cells[10].Value.ToString();
            }
        }

        private void btnBack_HocSinh_Click(object sender, EventArgs e)
        {
            pnlThongTin.Visible = false;
            dgvHocSinh.Height = this.Height;
        }

        private void btnClearText_HocSinh_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnThem_HocSinh_Click_1(object sender, EventArgs e)
        {
            pnlThongTin.Visible = true;
            dgvHocSinh.Height = 362;
            ClearText();
            OpenControl();
        }

        private void btnSua_HocSinh_Click(object sender, EventArgs e)
        {
            OpenControl();
        }

        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
            dgvHocSinh.DataSource = sql.getDataTable("HocSinh");
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

        private void btnLuu_HocSinh_Click(object sender, EventArgs e)
        {
            ENTITY.HocSinh hs = new ENTITY.HocSinh(txtMaHocSinh.Text.Trim(), txtHoTen.Text.Trim(), checkGioiTinh(), dtNgaySinh.Value, txtDanToc.Text.Trim(), txtTonGiao.Text.Trim(), txtDiaChi.Text.Trim(), txtQueQuan.Text.Trim(), txtThongTinPhuHuynh.Text.Trim(), txtSdtLienHe.Text.Trim(), txtMaLop.Text.Trim());
            DATA.HocSinh_Controler h = new DATA.HocSinh_Controler();
            h.insertHocSinh(hs);
            loadDataGirdView();
            LockControl();
        }

        private void btnXoa_HocSinh_Click(object sender, EventArgs e)
        {
            ENTITY.HocSinh hs = new ENTITY.HocSinh(txtMaHocSinh.Text.Trim(), txtHoTen.Text.Trim(), checkGioiTinh(), dtNgaySinh.Value, txtDanToc.Text.Trim(), txtTonGiao.Text.Trim(), txtDiaChi.Text.Trim(), txtQueQuan.Text.Trim(), txtThongTinPhuHuynh.Text.Trim(), txtSdtLienHe.Text.Trim(), txtMaLop.Text.Trim());
            DATA.HocSinh_Controler h = new DATA.HocSinh_Controler();
            h.deleteHocSinh(hs);
            loadDataGirdView();
            LockControl();
        }
    }
}
