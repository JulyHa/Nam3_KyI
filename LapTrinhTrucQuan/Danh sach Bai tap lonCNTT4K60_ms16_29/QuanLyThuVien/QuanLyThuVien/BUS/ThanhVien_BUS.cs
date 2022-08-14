using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
namespace QuanLyThuVien.BUS
{
    class ThanhVien_BUS
    {
        ThanhVien_DAO tvDao = new ThanhVien_DAO();
        public bool DangNhap(string _tk, string _mk)
        {
            if (tvDao.login(_tk, _mk) == true)
                return true;
            return false;
        }
        public int DangKy(ThanhVien _tv)
        {
            if (string.IsNullOrEmpty(_tv.TenDangNhap) || string.IsNullOrEmpty(_tv.MatKhau))
                return -1;
            if (tvDao.signup(_tv) == true)
                return 1;
            return 0;
        }
        public void sua(DocGia _dg)
        {
            tvDao.Update(_dg);
        }

    }
}
