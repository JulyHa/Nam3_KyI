using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GiaoTrinh
{
    class GiaoTrinh_DAO : DataProvider
    {
        public DataTable loadDMGiaoTrinh()
        {
            string sqlString = "select * from DMGiaoTrinh";
            return GetData(sqlString);
        }

        public bool Insert(GiaoTrinh_DTO _gt)
        {
            if (GetData("select * from DMGiaoTrinh where MaGT = '" + _gt.MaGT + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into DMGiaoTrinh values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')",
                _gt.MaGT, _gt.TenGT, _gt.TacGia, _gt.NamXB, _gt.LanTB, _gt.ChuyenNganh, _gt.SoTrang, _gt.NoiDung, _gt.SoLuong);

            Excute(sql);
            return true;
        }
        public void Update(GiaoTrinh_DTO _gt)
        {
            string sql = string.Format("update DMGiaoTrinh set TenGT = N'{0}', TacGia = N'{1}', NamXB = N'{2}', LanTB = N'{3}', ChuyenNganh = N'{4}', SoTrang = N'{5}', TomTatNoiDung = N'{6}', SoLuongGT = N'{7}' where MaGT = N'{8}'",
                _gt.TenGT, _gt.TacGia, _gt.NamXB, _gt.LanTB, _gt.ChuyenNganh, _gt.SoTrang, _gt.NoiDung, _gt.SoLuong, _gt.MaGT);
            Excute(sql);
        }

        public void Delete(string id)
        {
            Excute("delete from DMGiaoTrinh where MaGT = '" + id + "'");
        }


        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from DMGiaoTrinh where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }

    }
}
