using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace GiaoTrinh
{
    class GiaoTrinh_BUS
    {
        GiaoTrinh_DAO giaoTrinh_DAO = new GiaoTrinh_DAO();
        public DataTable GetListDMGiaoTrinh()
        {
            return giaoTrinh_DAO.loadDMGiaoTrinh();
        }

        public int Them(GiaoTrinh_DTO gt)
        {
            if (string.IsNullOrEmpty(gt.MaGT))
                return 0;
            if (!giaoTrinh_DAO.Insert(gt))
                return -1;
            return 1;
        }
        public bool Sua(GiaoTrinh_DTO gt)
        {
            if (string.IsNullOrEmpty(gt.MaGT))
                return false;
            giaoTrinh_DAO.Update(gt);
            return true;
        }
        public void Xoa(string id)
        {
            giaoTrinh_DAO.Delete(id);
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return giaoTrinh_DAO.Search(_timkiem, _loaitk);
        }

    }
}
