using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace GiaoTrinh
{
    class GiaoTrinh_TSX
    {
        GiaoTrinh_LUD GiaoTrinh_LUD = new GiaoTrinh_LUD();
        public DataTable GetListDMGiaoTrinh()
        {
            return GiaoTrinh_LUD.loadDMGiaoTrinh();
        }
        public DataTable GetListTacGia()
        {
            return GiaoTrinh_LUD.loadTacGia();
        }
        public int Them(GiaoTrinh tt)
        {
            /*if (string.IsNullOrEmpty(tt.MaTT))
                return 0;*/
            if (!GiaoTrinh_LUD.Insert(tt))
                return -1;
            return 1;
        }
        public bool Sua(GiaoTrinh tt)
        {
            if (string.IsNullOrEmpty(tt.MaGT1))
                return false;
            GiaoTrinh_LUD.Update(tt);
            return true;
        }
        public void Xoa(string id)
        {
            GiaoTrinh_LUD.Delete(id);
        }
        public DataTable TimKiem1(string _timkiem, string _loaitk)
        {
            return GiaoTrinh_LUD.Search1(_timkiem, _loaitk);
        }
        public DataTable TimKiem2(string _timkiem, string _loaitk)
        {
            return GiaoTrinh_LUD.Search2(_timkiem, _loaitk);
        }
    }
}
