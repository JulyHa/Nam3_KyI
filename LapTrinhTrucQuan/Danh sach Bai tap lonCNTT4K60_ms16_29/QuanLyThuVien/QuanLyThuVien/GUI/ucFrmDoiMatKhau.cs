using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DTO;
using QuanLyThuVien.BUS;
namespace QuanLyThuVien
{
    public partial class ucFrmDoiMatKhau : UserControl
    {
        MatKhau_BUS mkBus = new MatKhau_BUS();
        private string tdn;
        public ucFrmDoiMatKhau(string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
        }

        private void btn_CN_Click(object sender, EventArgs e)
        {
            lb_KhongKhop.Visible = false;
            lb_sai.Visible = false;
            lb_ThanhCong.Visible = false;
            if(txt_MKM.Text != txt_NL.Text)
            {
                lb_KhongKhop.Visible = true;
                return;
            }

            if (mkBus.CheckExist(tdn, txt_MKC.Text) == true)
            {
                ThanhVien _tv = new ThanhVien();
                _tv.TenDangNhap = tdn;
                _tv.MatKhau = txt_MKM.Text;

                mkBus.DoiMatKhau(_tv);
                lb_ThanhCong.Visible = true;
            }
            else
            {
                lb_sai.Visible = true;
            }
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}
