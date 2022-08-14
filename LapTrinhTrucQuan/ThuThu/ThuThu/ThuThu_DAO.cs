using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ThuThu
{
    class ThuThu_DAO : DataProvider
    {
        public DataTable loadDSThuThu()
        {
            string sqlString = "select * from DSThuThu";
            return GetData(sqlString);
        }
        public DataTable loadThuThuNhanHSTra()
        {
            string sqlString = "select * from DSThuThu_Nhan_HSTra";
            return GetData(sqlString);
        }
        public string GetMaQue(string s)
        {
            string x = string.Format("select MaQue from Que where TenQue = N'{0}'", s);
            DataTable data = GetData(x);
            x = data.Rows[0]["MaQue"].ToString().Trim();
            return x;
        }
        public string GetMaGT(string s)
        {
            string x = string.Format("select MaGT from DMGiaoTrinh where TenGT = N'{0}'", s);
            DataTable data = GetData(x);
            x = data.Rows[0]["MaGT"].ToString().Trim();
            return x;
        }
        public bool GetTenGT(string s)
        {
            string x = string.Format("select TenGT from DMGiaoTrinh where TenGT = N'{0}'", s);
            DataTable data = GetData(x);
            if (data.Rows.Count == 0) return false;
            return true;
        }
        public string GetMaHSTra(string s)
        {
            string k = string.Format("select MaHSTra from HoSoTra where MaThuThu = N'{0}'", s);
            DataTable data = GetData(k);
            k = data.Rows[0]["MaHSTra"].ToString().Trim();
            return k;
        }
        public bool Insert(ThuThu_DTO _tt)
        {
            //if (GetData("select * from ThuThu where MaThuThu = '" + _tt.MaTT + "'").Rows.Count > 0)
            //    return false;
            string sql = string.Format("Insert Into ThuThu values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                _tt.MaTT, _tt.TenTT, _tt.DiaChi, _tt.DienthoaiCD, _tt.DienthoaiDD, _tt.Maque);

            Excute(sql);
            return true;
        }
        public void Update(ThuThu_DTO _tt)
        {
            string sql = string.Format("update ThuThu set TenThuThu = N'{0}', DiaChi = N'{1}', DienThoaiCD = N'{2}', DienThoaiDD = N'{3}', MaQue = N'{4}' where MaThuThu = N'{5}'",
                _tt.TenTT, _tt.DiaChi, _tt.DienthoaiCD, _tt.DienthoaiDD, _tt.Maque, _tt.MaTT);
            Excute(sql); 
        }
        public void UpdateTenGT(ThuThu_DTO _tt, string x)
        {
            string k = GetMaHSTra(_tt.MaTT);
            string s = GetMaGT(x);
            string sql = string.Format("update ChiTietHSTra set  MaGT = N'{0}' where MaHSTra = N'{1}'", s, k);
            Excute(sql);
        }

        public void Delete(string id)
        {
            Excute("delete from ThuThu where MaThuThu = '" + id + "'");
        }


        public DataTable Search1(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from DSThuThu where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
        public DataTable Search2(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from DSThuThu_Nhan_HSTra where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
    }
}
