using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaChoTrang
{
    class NhanVien
    {
        private string manv, tennv, sdt, cv;
        string gt;
        int ml;
        public NhanVien() { }

        public NhanVien(string manv, string tennv, string sdt, string cv, string gt, int ml)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.sdt = sdt;
            this.cv = cv;
            this.gt = gt;
            this.ml = ml;
        }
        public string getMaNV()
        {
            return manv;
        }
    }
}
