using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DataQLS
    {
        SqlConnection lk = null;
        private void OpenCon()
        {
           
            lk = new SqlConnection(@"Data Source=DESKTOP-4ARR1L0\NGU;Initial Catalog=TEST_Sql;Integrated Security=True");
            if (lk.State == ConnectionState.Closed)
            {
                lk.Open();
            }
        }
        private void CloseCon()
        {
            if (lk.State == ConnectionState.Open)
            {
                lk.Close();
                lk.Dispose(); //giải phóng bộ nhớ
                lk = null;
            }
        }
        private Boolean Exe(string cmd)
        {
            OpenCon();
            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, lk);
                sc.ExecuteNonQuery();
                sc.Dispose();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }

            CloseCon();
            return check;
        }
        private DataTable Red(string cmd)
        {
            OpenCon();
            System.Data.DataTable check = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, lk);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(check);
                sc.Dispose();
            }
            catch (Exception)
            {
                check = null;
            }
            CloseCon();
            return check;
        }
        private void load()
        {
            DataTable dt = Red("Select * from Diem");
            //if (dt != null)
            //{
            //    dataGridView1.DataSource = dt;
            //}
            //dataGridView1.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            //dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không cho sửa dữ liệu trực tiếp
        }
    }
}
