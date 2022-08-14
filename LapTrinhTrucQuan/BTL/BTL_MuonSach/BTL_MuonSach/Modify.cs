using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BTL_MuonSach
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
        public DataTable getAllPhieuMuon(string s)
        {
            DataTable dataTable = new DataTable();
            string query = "select * from ViewHSM where ChuaTra like N'%"+s+"%'";
            dataTable = GetData(query);
            return dataTable;
        }
        
        public bool tinhtrangthe(string s)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "select KhoaThe, SoLuongMuon from TheMuon where MaThe = N'" + s + "'";
            DataTable data =  GetData(query);
            string x = data.Rows[0]["KhoaThe"].ToString();
            int y =Int32.Parse( data.Rows[0]["SoLuongMuon"].ToString());
            if(x == "Không" && y <3) return false;
            return true;
        }
        public string MaHSM(string s)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "select MaHSM from HoSoMuon where MaHSM = N'" + s + "'";
            DataTable data = GetData(query);
            if(data.Rows.Count >0) data.Rows[0]["MaHSM"].ToString();
            return null;
        }
        public string MaThe(string s)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "select MaThe from TheMuon where MaThe = N'" + s + "'";
            DataTable data = GetData(query);
            if (data.Rows.Count > 0) return data.Rows[0]["MaThe"].ToString();
            return null;
        }
        public string MaTT(string s)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "select MaThuThu from ThuThu where MaThuThu = N'" + s + "'";
            DataTable data = GetData(query);
            if (data.Rows.Count > 0) return data.Rows[0]["MaThuThu"].ToString();
            return null;
        }
        public string MaGT(string s)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "select MaGT from DMGiaoTrinh where MaGT = N'" + s + "'";
            DataTable data = GetData(query);
            if (data.Rows.Count > 0) return data.Rows[0]["MaGT"].ToString();
            return null;
        }
        public bool insert(Muon x)
        {
            string sql = string.Format("Insert Into HoSoMuon values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                x.MaHSM, x.MaThe, x.MaThuThu, x.NgayMuon, x.NgayPhaiTra, x.TinhTrangMuon);
            Excute(sql);
            sql = string.Format("Insert Into ChiTietHSMuon values(N'{0}',N'{1}',N'{2}',N'{3}')",
                x.MaHSM, x.MaGT, "Chưa", x.SoLuong);
            Excute(sql);
            
            //update the muon
            DataTable data = GetData("select SoLuongMuon from TheMuon where MaThe = N'"+ x.MaThe + "'");
            int sl = Int32.Parse(data.Rows[0]["SoLuongMuon"].ToString());
            sl+= x.SoLuong;
            sql = string.Format("update TheMuon set SoLuongMuon = N'" + sl.ToString() + "' where MaThe = N'" + x.MaThe + "'");
            Excute(sql);

            //updata dl gt
            data = GetData("select SoLuongGT from DMGiaoTrinh where MaGT = N'" + x.MaGT + "'");
            sl = Int32.Parse(data.Rows[0]["SoLuongGT"].ToString());
            sl -= x.SoLuong;
            sql = string.Format("update DMGiaoTrinh set SoLuongGT = N'" + sl.ToString() + "' where MaGT = N'" + x.MaGT + "'");
            Excute(sql);

            return true;
        }

        public bool update(Muon x)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = string.Format("Update HoSoMuon set MaThe=N'{0}', MaThuThu = N'{1}', NgayMuon=N'{2}', NgayPhaiTra = N'{3}' where MaHSM = N'{4}'", x.MaThe, x.MaThuThu, x.NgayMuon, x.NgayPhaiTra, x.MaHSM);
            Excute(query);
            query = string.Format("update ChiTietHSMuon set MaGT = N'{0}', SoLuong = N'{1}' where MaHSM = N'{2}'", x.MaGT, x.SoLuong, x.MaHSM);
            Excute(query);

            //update the muon
            DataTable data = GetData("select SoLuongMuon from TheMuon where MaThe = N'" + x.MaThe + "'");
            int sl = Int32.Parse(data.Rows[0]["SoLuongMuon"].ToString());
            sl += x.SoLuong;
            query = string.Format("update TheMuon set SoLuongMuon = N'" + sl.ToString() + "' where MaThe = N'" + x.MaThe + "'");
            Excute(query);

            //updata dl gt
            data = GetData("select SoLuongGT from DMGiaoTrinh where MaGT = N'" + x.MaGT + "'");
            sl = Int32.Parse(data.Rows[0]["SoLuongGT"].ToString());
            sl -= x.SoLuong;
            query = string.Format("update DMGiaoTrinh set SoLuongGT = N'" + sl.ToString() + "' where MaGT = N'" + x.MaGT + "'");
            Excute(query);

            return true;
        }

        public bool delete(string maHSM, string maGT)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "delete ChiTietHSMuon where MaHSM=N'"+maHSM+"' and MaGT = N'"+maGT+"' ";
            Excute(query);
            return true;
        }
       

    }
}
