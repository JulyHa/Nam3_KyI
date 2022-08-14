using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
    class DangMuon_BUS
    {
        DangMuon_DAO dmDao = new DangMuon_DAO();
        public DataTable GetList()
        {
            return dmDao.loadSach();
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return dmDao.Search(_timkiem, _loaitk);
        }
    }
}
