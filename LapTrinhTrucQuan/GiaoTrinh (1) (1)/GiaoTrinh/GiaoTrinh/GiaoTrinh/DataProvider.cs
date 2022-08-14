using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GiaoTrinh
{
    class DataProvider
    {
        static string stringConnection = @"Data Source=DESKTOP-DI63AJQ\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        SqlConnection connect = new SqlConnection(stringConnection);

        public DataTable GetData(string sql)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connect);
            sqlDataAdapter.Fill(dataTable);
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
