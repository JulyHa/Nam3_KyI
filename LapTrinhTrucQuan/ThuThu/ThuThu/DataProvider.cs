using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ThuThu
{
    class DataProvider
    {
        static string stringConnection = @"Data Source=DESKTOP-4ARR1L0\NGU;Initial Catalog=DataLTTQ;Integrated Security=True";
        SqlConnection connect = new SqlConnection(stringConnection);

        public DataTable GetData(string sql)
        {
            connect.Open();
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(sql, connect);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dataTable);
                sc.Dispose();
            }
            catch (Exception)
            {
                dataTable = null;
            }
            //DataTable dataTable = new DataTable();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connect);
            //sqlDataAdapter.Fill(dataTable);
            
            connect.Close();
            return dataTable;
        }
        public void Excute(string sql)
        {
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
