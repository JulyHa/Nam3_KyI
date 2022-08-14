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
    class DocGia_BUS
    {
        DocGia_DAO dgDao = new DocGia_DAO();
        public DataTable GetList()
        {
            return dgDao.loadDocGia();
        }
        public void Xoa(string mDG)
        {
            dgDao.Delete(mDG);
        }
        public bool Sua(DocGia dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return false;
            dgDao.Update(dg);
            return true;
        }
        public int Them(DocGia dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return 0;
            if (!dgDao.Insert(dg))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return dgDao.Search(_timkiem);
        }
        
    }
}
