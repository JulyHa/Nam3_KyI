using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_MuonSach
{
    class Muon
    {
        private string _MaHSM;
        private string _MaThe;
        private string _MaThuThu;
        private string _MaGT;
        private int _SoLuong;
        private string _NgayMuon;
        private string _NgayPhaiTra;
        private bool _TinhTrangMuon;    // true la muon . false la da tra

        public Muon()
        {
        }

        public Muon(string maHSM, string maThe, string maThuThu, string maGT, int sl, string ngayMuon, string ngayPhaiTra)
        {
            _MaHSM = maHSM;
            _MaThe = maThe;
            _MaThuThu = maThuThu;
            _MaGT = maGT;
            _SoLuong = sl;
            _NgayMuon = ngayMuon;
            _NgayPhaiTra = ngayPhaiTra;
            _TinhTrangMuon = true;
        }
        public string MaHSM { get => _MaHSM; set => _MaHSM = value; }
        public string MaThe { get => _MaThe; set => _MaThe = value; }
        public string MaThuThu { get => _MaThuThu; set => _MaThuThu = value; }
        public string MaGT { get => _MaGT; set => _MaGT = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public string NgayMuon { get => _NgayMuon; set => _NgayMuon = value; }
        public string NgayPhaiTra { get => _NgayPhaiTra; set => _NgayPhaiTra = value; }
        public bool TinhTrangMuon { get => _TinhTrangMuon; set => _TinhTrangMuon = value; }
    }
}
