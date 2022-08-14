using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TimKiemThuThu
{
    class TimKiemThuThu_DAO : DataProvider
    {
        public DataTable loadThuThu()
        {
            string sqlString = "select * from DSThuThu";
            return GetData(sqlString);
        }
        public DataTable loadThuThuNhanHSTra()
        {
            string sqlString = "select * from DSThuThu_Nhan_HSTra";
            return GetData(sqlString);
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
