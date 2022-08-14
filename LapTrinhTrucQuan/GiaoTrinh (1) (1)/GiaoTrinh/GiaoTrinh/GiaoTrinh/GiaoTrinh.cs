using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoTrinh
{
    class GiaoTrinh
    {
        private string MaGT;
        private string TenGT;
        private string MaTG;
        private string NamXB;
        private string LanXB;
        private string MaChuyenNganh;
        private string SoTrang;
        private string TomTatNoiDung;
        private string SoLuongGT;

        public GiaoTrinh()
        { }
        public GiaoTrinh(string maGT, string tenGT, string maTG, string namXB, string lanXB, string maChuyenNganh, string soTrang, string tomTatNoiDung, string soLuongGT)
        {
            MaGT = maGT;
            TenGT = tenGT;
            MaTG = maTG;
            NamXB = namXB;
            LanXB = lanXB;
            MaChuyenNganh = maChuyenNganh;
            SoTrang = soTrang;
            TomTatNoiDung = tomTatNoiDung;
            SoLuongGT = soLuongGT;
        }

        public string MaGT1 { get => MaGT; set => MaGT = value; }
        public string TenGT1 { get => TenGT; set => TenGT = value; }
        public string MaTG1 { get => MaTG; set => MaTG = value; }
        public string NamXB1 { get => NamXB; set => NamXB = value; }
        public string LanXB1 { get => LanXB; set => LanXB = value; }
        public string MaChuyenNganh1 { get => MaChuyenNganh; set => MaChuyenNganh = value; }
        public string SoTrang1 { get => SoTrang; set => SoTrang = value; }
        public string TomTatNoiDung1 { get => TomTatNoiDung; set => TomTatNoiDung = value; }
        public string SoLuongGT1 { get => SoLuongGT; set => SoLuongGT = value; }
    }
}
