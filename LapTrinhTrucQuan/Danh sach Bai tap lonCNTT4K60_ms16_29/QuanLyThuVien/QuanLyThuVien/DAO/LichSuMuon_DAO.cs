using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    class LichSuMuon_DAO: DataProvider
    {
        public DataTable loadSach(string _tdn)
        {
            string sqlString = string.Format("select * from PHIEUTRA, SACH, ACCOUNT where PHIEUTRA.MaDocGia = ACCOUNT.MaDocGia and SACH.MaSach = PHIEUTRA.MaSach and ACCOUNT.TenDangNhap = '{0}'", _tdn);
            return GetData(sqlString);
        }
        public DataTable Search(string _ts, string _tdn)
        {
            string sqlString = string.Format("select * from PHIEUTRA, SACH, ACCOUNT where PHIEUTRA.MaDocGia = ACCOUNT.MaDocGia and SACH.MaSach = PHIEUTRA.MaSach and ACCOUNT.TenDangNhap = '{0}' and SACH.TenSach like N'%{1}%'", _tdn, _ts);
            return GetData(sqlString);
        }
    }
}
