using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace mượn
{
    class DataProvider
    {
        static string stringConnection = @"Data Source=DESKTOP-4ARR1L0\NGU;Initial Catalog=DataLTTQ;Integrated Security=True";
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
