using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
namespace QuanLyThuVien.BUS
{
    class PhieuTra_BUS
    {
        PhieuTra_DAO ptDao = new PhieuTra_DAO();
        public DataTable GetList()
        {
            return ptDao.loadPhieuTra();
        }
        public bool CheckExist(string _table, string _str)
        {
            return ptDao.CheckExist(_table, _str);

        }
        public void Xoa(string _mp)
        {
            ptDao.Delete(_mp);
        }
        public bool Sua(PhieuTra _pt)
        {
            if (string.IsNullOrEmpty(_pt.MaPhieu))
                return false;
            ptDao.Update(_pt);
            return true;
        }
        public int Them(PhieuTra _pt)
        {
            if (string.IsNullOrEmpty(_pt.MaPhieu))
                return 0;
            if (!ptDao.Insert(_pt))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return ptDao.Search(_timkiem, _loaitk);
        }
    }
}
