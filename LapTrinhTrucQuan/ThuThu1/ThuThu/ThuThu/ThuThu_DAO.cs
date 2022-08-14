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
        public DataTable loadThuThu()
        {
            string sqlString = "select * from ThuThu";
            return GetData(sqlString);
        }
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

        public bool Insert(ThuThu_DTO _tt)
        {
            if (GetData("select * from ThuThu where MaThuThu = '" + _tt.MaTT + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into ThuThu values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                _tt.MaTT, _tt.TenTT, _tt.DiaChi, _tt.DienthoaiCD, _tt.DienthoaiDD, _tt.Que);

            Excute(sql);
            return true;
        }
        public void Update(ThuThu_DTO _tt)
        {
            string sql = string.Format("update ThuThu set TenThuThu = N'{0}', DiaChi = N'{1}', DienThoaiCD = N'{2}', DienThoaiDD = N'{3}', MaQue = '{4}' where MaThuThu = '{5}'",
                _tt.TenTT, _tt.DiaChi, _tt.DienthoaiCD, _tt.DienthoaiDD, _tt.Que, _tt.MaTT);
            Excute(sql); 
        }

        public void Delete(string id)
        {
            Excute("delete from ThuThu where MaThuThu = '" + id + "'");
        }


        public DataTable Search1(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from ThuThu where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
        public DataTable Search2(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from DSThuThu_Nhan_HSTra where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
    }
}
