using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
namespace QuanLyThuVien
{
    public partial class fLogin : Form
    {
        ThanhVien_BUS tvBus = new ThanhVien_BUS();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (tvBus.DangNhap(txt_TK.Text, txt_MK.Text) == true)
            {
                fTableManage f = new fTableManage(this, txt_TK.Text);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            btnDangKy.Visible = false;
            paneDangKy.Visible = true;
        }

        private void btn_DangKy2_Click(object sender, EventArgs e)
        {
            lb_TonTai.Visible = false;
            lb_Trung.Visible = false;
            lb_ChuaNhap.Visible = false;

            if (txt_NLMatKhau.Text == "")
            {
                lb_ChuaNhap.Visible = true;
                return;
            }
            if(txt_NLMatKhau.Text != txt_MatKhau.Text)
            {
                lb_Trung.Visible = true;
                return;
            }

            ThanhVien _tv = new ThanhVien();
            _tv.TenDangNhap = txt_TenDangNhap.Text;
            _tv.MatKhau = txt_MatKhau.Text;

            int check = tvBus.DangKy(_tv);
            if (check == 1)
            {
                txt_TK.Text = _tv.TenDangNhap;
                txt_MK.Text = _tv.MatKhau;
                MessageBox.Show("Đăng ký thành công");
                paneDangKy.Visible = false;
                btnDangKy.Visible = true;
            }
            else if (check == -1)
            {
                lb_ChuaNhap.Visible = true;
            }
            else
            {
                lb_TonTai.Visible = true;
            }
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            paneDangKy.Visible = false;
            btnDangKy.Visible = true;
        }

        

       
    }
}
