using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuonSach
{
    class Muon
    {
        private string _MaPhieuMuon;
        private string _MaDocGia;
        private string _MaSach;
        private DateTime _NgayMuon;
        private DateTime _NgayPhaiTra;

        public Muon()
        {
        }

        public Muon(string maPhieuMuon, string maDocGia, string maSach, DateTime ngayMuon, DateTime ngayPhaiTra)
        {
            MaPhieuMuon = maPhieuMuon;
            MaDocGia = maDocGia;
            MaSach = maSach;
            NgayMuon = ngayMuon;
            NgayPhaiTra = ngayPhaiTra;
        }

        public string MaPhieuMuon { get => _MaPhieuMuon; set => _MaPhieuMuon = value; }
        public string MaDocGia { get => _MaDocGia; set => _MaDocGia = value; }
        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public DateTime NgayMuon { get => _NgayMuon; set => _NgayMuon = value; }
        public DateTime NgayPhaiTra { get => _NgayPhaiTra; set => _NgayPhaiTra = value; }
    }
}
