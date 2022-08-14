using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Lon_LTTQ
{
    class Modify
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public Modify()
        {
        }
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
        public DataTable getAll()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from ViewHSTra";
            dataTable = GetData(query);
            return dataTable;
        }
        public void XoaCTM(string s)
        {
            string sql = "delete HoSoTra where MaHSTra = N'" + s + "'";
            Excute(sql);
        }
        public string GetHST (string s)
        {
            string sql = "select MaHSTra from HoSoTra where MaHSM = N'" + s + "'";
            DataTable data =  GetData(sql);
            if (data.Rows.Count > 0) return data.Rows[0]["MaHSTra"].ToString().Trim();
            return null;
        }
        public string Get_HST(string s)
        {
            string sql = "select MaHSTra from HoSoTra where MaHSTra = N'" + s + "'";
            DataTable data = GetData(sql);
            if (data.Rows.Count > 0) return data.Rows[0]["MaHSTra"].ToString().Trim();
            return null;
        }
        public string GetMaHSM(string s)
        {
            string sql = "select MaHSM from HoSoMuon where MaHSM = N'" + s + "'";
            DataTable data = GetData(sql);
            if (data.Rows.Count > 0) return data.Rows[0]["MaHSM"].ToString().Trim();
            return null;
        }
        public string GetTT(string s)
        {
            string sql = "select MaThuThu from ThuThu where MaThuThu = N'" + s + "'";
            DataTable data = GetData(sql);
            if (data.Rows.Count > 0) return data.Rows[0]["MaThuThu"].ToString().Trim();
            return null;
        }
        public string GetGT(string s1, string s2)
        {
            string sql = "select MaGT from ChiTietHSMuon where MaHSM = N'" + s1 + "' and MaGT = N'"+s2+"' and ChuaTra = N'Chưa'";
            DataTable data = GetData(sql);
            if (data.Rows.Count == 0) return null;
            return data.Rows[0]["MaGT"].ToString().Trim();
        }
        public void ThemHST(string a, string b, string c, string d, string e, string f, string g)
        {
            string sql = "insert into ChiTietHSTra values(N'" + a + "', N'"+b+"', N'"+c+"', N'"+f+"')";
            Excute(sql);
            if(d=="") sql = "insert into HoSoTra values(N'" + a + "', N'" + e + "', N'" + DateTime.Now.ToString("yyyy-MM-dd") + "', N'0', N'', N'"+f+"')";
            else sql = "insert into HoSoTra values(N'" + a + "', N'" + e + "', N'" + DateTime.Now.ToString("yyyy-MM-dd") + "', N'"+d+"', N'"+ DateTime.Now.ToString("yyyy-MM-dd") + "', N'" + f + "')";
            Excute(sql);
        }
        public string getMaThe(string s)
        {
            string sql = "select MaThe from HoSoMuon where MaHSM = N'" + s + "'";
            DataTable d =  GetData(sql);
            if (d.Rows.Count > 0) return d.Rows[0]["MaThe"].ToString();
            return null;
        }
        public void khoathe(string s)
        {
            string x = getMaThe(s);
            string sql = "update TheMuon set KhoaThe = N'Khóa' where MaThe = N'"+x+"'";
            Excute(sql);
        }
    }
}