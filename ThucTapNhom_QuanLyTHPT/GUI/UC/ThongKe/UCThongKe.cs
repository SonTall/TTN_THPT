using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            DataGridViewColStyle();
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
            if(cbOption_ThongKe.Text.Equals("Học sinh - Lớp Học"))
            {
                //test func
                AddColumn("hocsinh", "colhocsonh", 150, "hocsinh", DataGridViewAutoSizeColumnMode.Fill);


                #region testdata
                for (int i = 0; i < 30; i++)
                {
                    dgvThongKe.Rows.Add();
                    dgvThongKe.Rows[i].Cells[0].Value = "haha";
                }
                #endregion


            }

            if (cbOption_ThongKe.Text.Equals("Giáo Viên - Chức Vụ"))
            {

            }

            if (cbOption_ThongKe.Text.Equals("Danh sách môn học"))
            {

            }

            if (cbOption_ThongKe.Text.Equals("Số lượng học sinh theo lớp"))
            {

            }

            if (cbOption_ThongKe.Text.Equals("Số giáo viên theo chức vụ"))
            {

            }

            if (cbOption_ThongKe.Text.Equals("Học lực của học sinh theo học kỳ"))
            {

            }

            if (cbOption_ThongKe.Text.Equals("Sô tiết dạy của giáo viên trong 1 tuần"))
            {

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lbThongKe.Text = "Để cho đẹp thôi =))";
        }
    }
}
