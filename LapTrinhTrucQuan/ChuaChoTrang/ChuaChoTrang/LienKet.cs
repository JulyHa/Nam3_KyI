using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaChoTrang
{
    class LienKet
    {
        SqlConnection lk = null;
        private void OpenCon()
        {
            lk = new SqlConnection(@"Data Source=DESKTOP-4ARR1L0\NGU;Initial Catalog=Trang;Integrated Security=True");
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
        public Boolean Exe(string cmd) // insert, update, delete
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
        public DataTable Red(string cmd) // select
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
    }
}
