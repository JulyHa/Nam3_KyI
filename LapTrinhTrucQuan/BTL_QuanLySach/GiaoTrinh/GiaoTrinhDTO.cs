using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoTrinh
{
    class GiaoTrinh_DTO
    {
        private string _maGT;
        private string _tenGT;
        private string _tacGia;
        private int _namXB;
        private int _lanTB;
        private string _chuyenNganh;
        private int _soTrang;
        private string _noiDung;
        private int _soLuong;

        public GiaoTrinh_DTO()
        {
        }

        public GiaoTrinh_DTO(string maGT, string tenGT, string tacGia, int namXB, int lanTB, string chuyenNganh, int soTrang, string noiDung, int soLuong)
        {
            MaGT = maGT;
            TenGT = tenGT;
            TacGia = tacGia;
            NamXB = namXB;
            LanTB = lanTB;
            ChuyenNganh = chuyenNganh;
            SoTrang = soTrang;
            NoiDung = noiDung;
            SoLuong = soLuong;
        }

        public string MaGT { get => _maGT; set => _maGT = value; }
        public string TenGT { get => _tenGT; set => _tenGT = value; }
        public string TacGia { get => _tacGia; set => _tacGia = value; }
        public int NamXB { get => _namXB; set => _namXB = value; }
        public int LanTB { get => _lanTB; set => _lanTB = value; }
        public string ChuyenNganh { get => _chuyenNganh; set => _chuyenNganh = value; }
        public int SoTrang { get => _soTrang; set => _soTrang = value; }
        public string NoiDung { get => _noiDung; set => _noiDung = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
    }
}
