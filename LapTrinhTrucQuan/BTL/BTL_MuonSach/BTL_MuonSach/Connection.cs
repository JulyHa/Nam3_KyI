using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTL_MuonSach
{
    class Connection
    {
        private static string stringConnection = @"Data Source=a-pc\SQLEXPRESS;Initial Catalog=QLGiaoTrinh;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
