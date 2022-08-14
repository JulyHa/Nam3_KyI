using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DAO;
using System.Data;

namespace QuanLyThuVien.BUS
{
    class SachDangMuon_BUS
    {
        SachDangMuon_DAO sachdangmuonDao = new SachDangMuon_DAO();
        public DataTable GetList(string _tdn)
        {
            return sachdangmuonDao.loadSach(_tdn);
        }
        public DataTable TimKiem(string _ts, string _tdn)
        {
            return sachdangmuonDao.Search(_ts, _tdn);
        }
    }
}
