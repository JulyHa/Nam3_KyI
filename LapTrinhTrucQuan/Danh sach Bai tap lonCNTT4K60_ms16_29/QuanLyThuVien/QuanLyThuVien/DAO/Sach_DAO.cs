using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.DAO
{
    class Sach_DAO : DataProvider
    {
        public DataTable loadSach()
        {
            string sqlString = @"select * from SACH";
            return GetData(sqlString);
        }
        public bool Insert(Sach _s)
        {
            if (GetData("select* from SACH where MaSach = '" + _s.MaSach + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into SACH values('{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}','{6}')",
                _s.MaSach, _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong);

            Excute(sql);
            return true;
        }
        public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = string.Format("update SACH set TenSach = N'{0}', TacGia = N'{1}', TheLoai = N'{2}', NhaXuatBan = N'{3}', GiaSach = '{4}', SoLuong = '{5}' where MaSach = '{6}'",
                _s.TenSach, _s.TacGia, _s.TheLoai, _s.NhaXuatBan, _s.GiaSach, _s.SoLuong, _s.MaSach);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select * from SACH where {0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }
    }
}
