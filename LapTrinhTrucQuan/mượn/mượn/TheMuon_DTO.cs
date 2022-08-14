using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mượn
{
    class TheMuon_DTO
    {
        private string _MaThe;
        private string _Ten;
        private string _GioiTinh;
        private string _MaLop;
        private string _MaKhoa;
        private string _KhoaThe;
        private int _SoLuongMuon;

        public TheMuon_DTO() { }
        public TheMuon_DTO(string maThe, string ten, string gioiTinh, string maLop, string maKhoa, string khoaThe, int soLuongMuon)
        {
            _MaThe = maThe;
            _Ten = ten;
            _GioiTinh = gioiTinh;
            _MaLop = maLop;
            _MaKhoa = maKhoa;
            _KhoaThe = khoaThe;
            _SoLuongMuon = soLuongMuon;
        }

        public string MaThe { get => _MaThe; set => _MaThe = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string MaLop { get => _MaLop; set => _MaLop = value; }
        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }
        public string KhoaThe { get => _KhoaThe; set => _KhoaThe = value; }
        public int SoLuongMuon { get => _SoLuongMuon; set => _SoLuongMuon = value; }
    }
}
