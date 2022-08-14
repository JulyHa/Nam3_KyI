using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.View
{
    public partial class Login : Form
    {
        User user = new User();
        TruyVanSQL truyvan = new TruyVanSQL();
        public static bool LoGin = false;
        public Login(User x)
        {
            InitializeComponent();
            user = x;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            if(user.TaiKhoan != "")
            {
                TK.Text = user.TaiKhoan;
                MK.Text = user.MatKhau;
            }
        }
        private bool CheckTK()
        {
            bool tk = true; int mk = 0; 
            if (TK.Text == "")
            {
                tk = false;
                if (MK.Text == "") mk = 1;
            }
            else 
            {
                DataTable dttable = truyvan.Red("select * from Account where TaiKhoan = N'" + TK.Text + "'");
                if(dttable.Rows.Count >= 1)
                {
                    User user = new User();
                    string y = dttable.Rows[0]["MatKhau"].ToString().Trim();
                    if(MK.Text.Trim() == y) return true;
                    else mk = 2;
                }
                else mk = 2;
            }
            if(tk == false)
            {
                TK.Focus();
                errTK.SetError(TK, "Bạn chưa nhập tài khoản");
            }
            if(mk == 1)
            {
                errMK.SetError(MK, "Bạn chưa nhập nhập mật khẩu");
            }
            else
            {
                MK.Text = ""; MK.Focus();
                
                errMK.SetError(MK, "Tài khoản hoặc mật khẩu không đúng!");
            }
            errMK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            return false;
        }
        private void DangNhap_Click(object sender, EventArgs e)
        {
            if(CheckTK() == true)
            {
                User user = new User(TK.Text, MK.Text);
                LoGin = true;
                FormMain ql = new FormMain(user);
                ql.Show();
                this.Visible = false;
                user.TaiKhoan = TK.Text;
            }
        }

        private void DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn sign = new SignIn();
            this.Visible = false;
            sign.Show();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes) Application.Exit();
        }
    }
}
