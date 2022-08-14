using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyThuVien.BUS
{
    class LichSuMuon_BUS
    {
        LichSuMuon_DAO lsmDao = new LichSuMuon_DAO();
        public DataTable GetList(string _tdn)
        {
            return lsmDao.loadSach(_tdn);
        }
        public DataTable TimKiem(string _ts, string _tdn)
        {
            return lsmDao.Search(_ts, _tdn);
        }
    }
}
