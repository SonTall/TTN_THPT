using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using ThucTapNhom_QuanLyTHPT.ENTITY;

namespace ThucTapNhom_QuanLyTHPT.DATA.EditData
{
    class EditthongtinMonHoc
    {
        public string MAMONHOCCU { get; set; }
        //Data Source=DESKTOP-P8I38NF\SQLEXPRESS;Initial Catalog=TTN_THPT;Integrated Security=True
        /// <summary>
        /// Thuc thi thu tuc sua thong tin chuc vu
        /// </summary>
        /// <param name="MonHoc"></param>

        public void ExcuteProc(MonHoc monhoc)

        {
            //SqlConnection conn = DBUtils.GetDBConnection();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P8I38NF\\SQLEXPRESS;Initial Catalog=TTN_THPT;Integrated Security=True");
            // conn.ConnectionString = "Server=DEVSERVER-WIN7\\SQLEXPRESS;Database=ThucTapNhom_QuanLyNhanSu;Integrated Security=true";
            //Trusted_Connection=true";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("EditthongtinMonHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MAMOHOCU", SqlDbType.Char, 10)).Value = this.MAMONHOCCU;
                cmd.Parameters.Add(new SqlParameter("@MAMONHOC", SqlDbType.Char, 10)).Value = monhoc.MaMonHoc;
                cmd.Parameters.Add(new SqlParameter("@TEMONHOC", SqlDbType.Text)).Value = monhoc.TenMonHoc;

                //excute proc
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}

