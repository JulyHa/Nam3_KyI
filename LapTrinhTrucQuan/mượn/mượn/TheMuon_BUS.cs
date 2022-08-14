using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace mượn
{
    class TheMuon_BUS
    {
        TheMuon_DAO themuon_DAO = new TheMuon_DAO();
        public DataTable GetListTheMuon()
        {
            return themuon_DAO.loadTheMuon();
        }

        public int Them(TheMuon_DTO gt)
        {
            if (string.IsNullOrEmpty(gt.MaThe))
                return 0;
            if (!themuon_DAO.Insert(gt))
                return -1;
            return 1;
        }
        public bool Sua(TheMuon_DTO gt)
        {
            if (string.IsNullOrEmpty(gt.MaThe))
                return false;
            themuon_DAO.Update(gt);
            return true;
        }
        public void Xoa(string id)
        {
            themuon_DAO.Delete(id);
        }
        public DataTable GetKhoa()
        {
            return themuon_DAO.getKhoa();
        }
        public DataTable getLop(string s)
        {
            return themuon_DAO.getLop(s);
        }
        public DataTable TimKiem(string s)
        {
            return themuon_DAO.timkiem(s);
        }
        public string GetMaThe(string s)
        {
            return themuon_DAO.GetMaThe(s);
        }
        public string GetMaKhoa(string s)
        {
            return themuon_DAO.getMaKhoa(s);
        }
        public string GetMaLop(string s)
        {
            return themuon_DAO.getMaLop(s);
        }
    }
}
