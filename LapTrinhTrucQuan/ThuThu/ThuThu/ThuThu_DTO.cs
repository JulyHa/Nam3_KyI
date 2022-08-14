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
        private string maque;

        public ThuThu_DTO()
        {
        }

        public ThuThu_DTO(string maTT, string tenTT, string diaChi, string dienthoaiCD, string dienthoaiDD, string que, string maque)
        {
            this.maTT = maTT.Trim();
            this.tenTT = tenTT.Trim();
            this.diaChi = diaChi.Trim();
            this.dienthoaiCD = dienthoaiCD.Trim();
            this.dienthoaiDD = dienthoaiDD.Trim();
            this.que = que.Trim();
            this.maque = maque.Trim();
        }
        public ThuThu_DTO(string maTT, string tenTT, string diaChi, string dienthoaiCD, string dienthoaiDD, string que)
        {
            ThuThu_BUS s = new ThuThu_BUS();
            this.maTT = maTT.Trim();
            this.tenTT = tenTT.Trim();
            this.diaChi = diaChi.Trim();
            this.dienthoaiCD = dienthoaiCD.Trim();
            this.dienthoaiDD = dienthoaiDD.Trim();
            this.que = que.Trim();
            this.maque = s.MaQue(this.que);

        }

        public string MaTT { get => maTT; set => maTT = value; }
        public string TenTT { get => tenTT; set => tenTT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienthoaiCD { get => dienthoaiCD; set => dienthoaiCD = value; }
        public string DienthoaiDD { get => dienthoaiDD; set => dienthoaiDD = value; }
        public string Que { get => que; set => que = value; }
        public string Maque { get => maque; set => maque = value; }
    }
}
