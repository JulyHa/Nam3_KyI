using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class User
    {
        private string taikhoan;
        private string matkhau;

        public User()
        {

        }
        public User(string taikhoan, string matkhau)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }
        public string TaiKhoan 
        {
            get 
            {
                return taikhoan;
            }
            set 
            {
                taikhoan = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return matkhau;
            }
            set
            {
                matkhau = value;
            }
        }


    }
}
