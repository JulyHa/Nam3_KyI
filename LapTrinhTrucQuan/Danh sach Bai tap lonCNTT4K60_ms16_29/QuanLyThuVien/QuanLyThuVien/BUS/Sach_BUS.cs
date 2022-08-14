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
    class Sach_BUS
    {
        Sach_DAO sachDao = new Sach_DAO();
        public DataTable GetList()
        {
            return sachDao.loadSach();
        }
        public void Xoa(string mS)
        {
            sachDao.Delete(mS);
        }
        public bool Sua(Sach s)
        {
            if (string.IsNullOrEmpty(s.MaSach))
                return false;
            sachDao.Update(s);
            return true;
        }
        public int Them(Sach s)
        {
            if (string.IsNullOrEmpty(s.MaSach))
                return 0;
            if (!sachDao.Insert(s))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return sachDao.Search(_timkiem, _loaitk);
        }
    }
}
