using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    class PhieuTra_DAO : DataProvider
    {
        public DataTable loadPhieuTra()
        {
            string sqlString = @"select PT.MaPhieu, PT.MaDocGia, DG.HoTen, PT.MaSach, S.TenSach, PT.NgayTra from DOCGIA DG, PHIEUTRA PT, SACH S where PT.MaDocGia = DG.MaDocGia and PT.MaSach = S.MaSach";
            return GetData(sqlString);
        }
        public bool CheckExist(string _table, string _str)
        {
            if (_table == "DOCGIA")
                if (GetData("select* from DOCGIA where MaDocGia = '" + _str + "'").Rows.Count > 0)
                    return true;
            if (_table == "SACH")
                if (GetData("select* from SACH where MaSach = '" + _str + "'").Rows.Count > 0)
                    return true;
            return false;
        }

        public bool Insert(PhieuTra _pt)
        {
            if (GetData("select* from PHIEUTRA where MaPhieu = '" + _pt.MaPhieu + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into PHIEUTRA values('{0}','{1}','{2}','{3}')",
                _pt.MaPhieu, _pt.MaDocGia, _pt.MaSach, _pt.NgayTra);

            Excute(sql);
            return true;
        }
        public void Delete(string _pm)
        {
            Excute("delete from PHIEUTRA where MaPhieu = '" + _pm + "'");
        }

        public void Update(PhieuTra _pt)
        {
            string sql = string.Format("update PHIEUTRA set MaDocGia = N'{0}', MaSach = N'{1}', NgayTra = '{2}' where MaPhieu = '{3}'",
                 _pt.MaDocGia, _pt.MaSach, _pt.NgayTra, _pt.MaPhieu);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select PT.MaPhieu, PT.MaDocGia, DG.HoTen, PT.MaSach, S.TenSach, PT.NgayTra from DOCGIA DG, PHIEUTRA PT, SACH S where PT.MaDocGia = DG.MaDocGia and PT.MaSach = S.MaSach and PT.{0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
    }
}
