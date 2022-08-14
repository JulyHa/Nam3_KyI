using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
    class DaTra_BUS
    {
        DaTra_DAO dtDao = new DaTra_DAO();
        public DataTable GetList()
        {
            return dtDao.loadSach();
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return dtDao.Search(_timkiem, _loaitk);
        }
    }
}
