using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace mượn
{
    class TheMuon_DAO : DataProvider
    {
        public DataTable loadTheMuon()
        {
            string sqlString = "select * from ViewTheMuon";
            return GetData(sqlString);
        }

        public bool Insert(TheMuon_DTO _gt)
        {
            if (GetData("select * from TheMuon where MaThe = '" + _gt.MaThe + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into TheMuon values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')",
                _gt.MaThe, _gt.Ten, _gt.GioiTinh, _gt.MaLop, _gt.MaKhoa, _gt.KhoaThe, _gt.SoLuongMuon);

            Excute(sql);
            return true;
        }
        public void Update(TheMuon_DTO _gt)
        {
            string sql = string.Format("update TheMuon set MaThe = N'{0}', HoTen = N'{1}', GioiTinh = N'{2}', MaLop = N'{3}', MaKhoa = N'{4}', KhoaThe = N'{5}' , SoLuongMuon = N'{6}' where MaThe = N'{7}'",
                _gt.MaThe, _gt.Ten, _gt.GioiTinh, _gt.MaLop, _gt.MaKhoa, _gt.KhoaThe, _gt.SoLuongMuon, _gt.MaThe);
            Excute(sql);
        }

        public void Delete(string id)
        {
            Excute("delete from TheMuon where MaThe = '" + id + "'");
        }
        public DataTable getKhoa()
        {
            string sql = "select TenKhoa from Khoa";
            return GetData(sql);
        }
        public string getMaKhoa(string s)
        {
            string sql = "select MaKhoa from Khoa where TenKhoa = N'"+s+"'";
            DataTable data =  GetData(sql);
            if (data.Rows.Count > 0) return data.Rows[0]["MaKhoa"].ToString();
            return null;
        }
        public DataTable getLop(string s)
        {
            string ma = getMaKhoa(s);
            string sql = "select TenLop from Lop where MaKhoa = N'"+ma+"' order by TenLop asc";
            return GetData(sql);
        }
        public string getMaLop(string s)
        {
            string sql = "select MaLop from Lop where TenLop = N'" + s + "'";
            DataTable data = GetData(sql);
            if (data.Rows.Count > 0) return data.Rows[0]["MaLop"].ToString();
            return null;
        }
        public DataTable timkiem(string s)
        {
            string sql = "select * from ViewTheMuon where HoTen like N'%" + s + "%'";
            return  GetData(sql);
        }
        public string GetMaThe(string s)
        {
            string sql = "select MaThe from TheMuon where MaThe = N'" + s + "'";
            DataTable d = GetData(sql);
            if (d.Rows.Count > 0) return d.Rows[0]["MaThe"].ToString();
            return null;
        }
    }
}
