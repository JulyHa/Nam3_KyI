using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TimKiemThuThu
{
    class TimKiemThuThu_BUS
    {
        TimKiemThuThu_DAO timKiemThuThu_DAO = new TimKiemThuThu_DAO();
        public DataTable GetListThuThu()
        {
            return timKiemThuThu_DAO.loadThuThu();
        }
        public DataTable GetListThuThuNhanHSTra()
        {
            return timKiemThuThu_DAO.loadThuThuNhanHSTra();
        }
        public DataTable TimKiem1(string _timkiem, string _loaitk)
        {
            return timKiemThuThu_DAO.Search1(_timkiem, _loaitk);
        }
        public DataTable TimKiem2(string _timkiem, string _loaitk)
        {
            return timKiemThuThu_DAO.Search2(_timkiem, _loaitk);
        }
    }
}
