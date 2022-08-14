using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GiaoTrinh
{
    class GiaoTrinh_LUD : DataProvider
    {
        public DataTable loadDMGiaoTrinh()
        {
            string sqlString = "select * from DMGiaoTrinh";
            return GetData(sqlString);
        }
        public DataTable loadTacGia()
        {
            string sqlString = "select * from TacGia";
            return GetData(sqlString);
        }
        public bool Insert(GiaoTrinh _tt)
        {
            if (GetData("select * from DMGiaoTrinh where MaGT = '" + _tt.MaGT1 + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into DMGiaoTrinh values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}')",
                _tt.MaGT1, _tt.TenGT1, _tt.MaTG1, _tt.NamXB1, _tt.LanXB1, _tt.MaChuyenNganh1, _tt.SoTrang1, _tt.TomTatNoiDung1, _tt.SoLuongGT1);

            Excute(sql);
            return true;
        }
        public void Update(GiaoTrinh _tt)
        {
            string sql = string.Format("update DMGiaoTrinh set TenGT = N'{0}', MaTG = N'{1}', NamXB = N'{2}', LanXB = N'{3}', MaChuyenNganh = '{4}', SoTrang = '{5}', NoiDung = '{6}', SoLuong = '{7}' where MaGT = '{8}'",
                _tt.MaGT1, _tt.TenGT1, _tt.MaTG1, _tt.NamXB1, _tt.LanXB1, _tt.MaChuyenNganh1, _tt.SoTrang1, _tt.TomTatNoiDung1, _tt.SoLuongGT1);
            Excute(sql);
        }

        public void Delete(string id)
        {
            Excute("delete from DMGiaoTrinh where MaGT = '" + id + "'");
        }


        public DataTable Search1(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from DMGiaoTrinh where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
        public DataTable Search2(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from TacGia where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
    }
}
