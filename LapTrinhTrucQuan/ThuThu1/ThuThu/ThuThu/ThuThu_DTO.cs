using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuThu
{
    class ThuThu_DTO
    {
        private string maTT;
        private string tenTT;
        private string diaChi;
        private string dienthoaiCD;
        private string dienthoaiDD;
        private string que;

        public ThuThu_DTO()
        {
        }

        public ThuThu_DTO(string maTT, string tenTT, string diaChi, string dienthoaiCD, string dienthoaiDD, string que)
        {
            this.maTT = maTT;
            this.tenTT = tenTT;
            this.diaChi = diaChi;
            this.dienthoaiCD = dienthoaiCD;
            this.dienthoaiDD = dienthoaiDD;
            this.que = que;
        }

        public string MaTT { get => maTT; set => maTT = value; }
        public string TenTT { get => tenTT; set => tenTT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienthoaiCD { get => dienthoaiCD; set => dienthoaiCD = value; }
        public string DienthoaiDD { get => dienthoaiDD; set => dienthoaiDD = value; }
        public string Que { get => que; set => que = value; }
    }
}
