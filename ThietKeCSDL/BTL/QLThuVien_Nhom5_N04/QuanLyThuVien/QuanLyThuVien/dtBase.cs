using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public class dtBase
    {
        string connectionString = @"Data Source=DESKTOP-4ARR1L0\NGU;Initial Catalog=BTL_QLThuVien;Integrated Security=True";
        SqlConnection conn;
        DataTable dt;
        SqlCommand cmd;
        public dtBase()
        {
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message);
            }
        }

        public DataTable SelectData(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: "+ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        
       
    }

    
}
