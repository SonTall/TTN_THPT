using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyTHPT.GUI.UC.ThongKe
{
    public partial class UCThongKe : Form
    {

        public UCThongKe()
        {
            InitializeComponent();
            DataGridViewColStyle();
        }

        //Học sinh - Lớp Học
        //Giáo Viên - Chức Vụ
        //Danh sách môn học
        //Số lượng học sinh theo lớp
        //Số giáo viên theo chức vụ
        //Học lực của học sinh theo học kỳ
        //Sô tiết dạy của giáo viên trong 1 tuần

            // thong ke ae tu. them cot vao nhe', t k them truoc' duoc.
        private void UCThongKe_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
            dgvThongKe.AutoResizeColumns();
            dgvThongKe.AutoResizeRows();
        }

        private void DataGridViewColStyle()
        {
            dgvThongKe.BorderStyle = BorderStyle.None;
            dgvThongKe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvThongKe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvThongKe.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvThongKe.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvThongKe.BackgroundColor = Color.White;

            dgvThongKe.EnableHeadersVisualStyles = false;
            dgvThongKe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvThongKe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvThongKe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void AddColumn(string headerText, string name, int width, string dataPropertyName, DataGridViewAutoSizeColumnMode autoSizdeMode)
        {
            DataGridViewColumn newCol = new DataGridViewColumn();
            newCol.CellTemplate = new DataGridViewTextBoxCell();
            newCol.SortMode = DataGridViewColumnSortMode.Automatic;
            newCol.AutoSizeMode = autoSizdeMode;
            newCol.HeaderText = headerText;
            newCol.Name = name;
            newCol.Visible = true;
            newCol.Width = width;
            newCol.DataPropertyName = dataPropertyName;
            dgvThongKe.Columns.Add(newCol);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvThongKe.Height = 362;
            if (cbOption_ThongKe.Text.Equals("Học sinh - Lớp Học"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.TK("select a.mahocsinh,a.hoten,a.diachi,b.tenlop from HocSinh as a,Lop as b where a.malop = b.malop");
                dgvThongKe.AutoResizeColumns();
                dgvThongKe.AutoResizeRows();
            }

            if (cbOption_ThongKe.Text.Equals("Giáo Viên - Chức Vụ"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.TK("select a.magiaovien,a.tengiaovien,a.trinhdo,b.tenchucvu,a.sdt from GiaoVien as a, ChucVu as b where a.machucvu=b.machucvu");
            }

            if (cbOption_ThongKe.Text.Equals("Danh sách môn học"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.TK("select a.mamonhoc,a.tenmonhoc,b.malop,b.sotiet,b.thu,b.tiet from MonHoc as a,GiangDay as b where a.mamonhoc=b.mamonhoc");
            }

            if (cbOption_ThongKe.Text.Equals("Số lượng học sinh theo lớp"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.TK("select b.malop,b.tenlop,count(a.mahocsinh) as 'sohocsinh' from HocSinh as a,Lop as b where a.malop=b.malop group by b.malop, b.tenlop");
            }

            if (cbOption_ThongKe.Text.Equals("Số giáo viên theo chức vụ"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.TK("select b.machucvu,b.tenchucvu,count(a.magiaovien) as 'sogiaovien' from GiaoVien as a,ChucVu as b where a.machucvu=b.machucvu group by b.machucvu, b.tenchucvu");
            }

            if (cbOption_ThongKe.Text.Equals("Học lực của học sinh theo học kỳ"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.TK("select b.hocki,a.mahocsinh,a.hoten,b.mamonhoc,b.diemtrungbinh from HocSinh as a,BangDiem as b where a.mahocsinh=b.mahocsinh");
            }

            if (cbOption_ThongKe.Text.Equals("Sô tiết dạy của giáo viên trong 1 tuần"))
            {
                DATA.SqlConn sql = new DATA.SqlConn();
                dgvThongKe.DataSource = sql.TK("select a.magiaovien,a.tengiaovien,count(b.sotiet) as 'soluongtiet' from GiaoVien as a,GiangDay as b where a.magiaovien=b.magiaovien group by a.magiaovien, a.tengiaovien");
            }
        }

        private void loadDataGirdView()
        {
            DATA.SqlConn sql = new DATA.SqlConn();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
