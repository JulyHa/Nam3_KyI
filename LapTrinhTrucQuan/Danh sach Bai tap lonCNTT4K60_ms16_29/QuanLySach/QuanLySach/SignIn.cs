using QuanLySach.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
         private void SignIn_Load(object sender, EventArgs e)
         {
           
         }
        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login(new User());
            lg.Show();
            this.Visible = false;
        }
        private bool checkLignIn()
        {
            bool check = true;
            errTK.Clear(); errMK.Clear();errLMK.Clear();
            //check tk
            if (TK.Text == "")
            {
                check = false;
                errTK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                errTK.SetError(TK, "Bạn không được để trống.");
                TK.Focus();
            }
            else
            {
                if(TK.Text.Length < 6 || TK.Text.Length > 15)
                {
                    errTK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                    errTK.SetError(TK, "Tài khoản chỉ từ 6-15 kí tự.");
                    TK.Focus();
                }
                else
                {
                    TruyVanSQL lk = new TruyVanSQL();
                    DataTable dttable = lk.Red("Select TaiKhoan from Account where TaiKhoan = N'" + TK.Text + "'");
                    if (dttable.Rows.Count >= 1)
                    {
                        check = false;
                        TK.Text = ""; TK.Focus();
                        errTK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                        errTK.SetError(TK, "Tài khoản đã tồn tại!");
                    }
                }
            }
            // check mk
            if(MK.Text == "" || MK.Text.Length < 6)
            {
                check = false;
                MK.Text = ""; MK.Focus();
                errMK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                errMK.SetError(MK, "Mật khẩu không được để trống và độ dài không nhỏ hơn 6 ký tự");
            }
            if(MK.Text != LMK.Text || LMK.Text == "")
            {
                check = false;
                MK.Text = ""; MK.Focus();
                LMK.Text = "";
                errLMK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                errLMK.SetError(LMK, "Mật khẩu không khớp!");
            }
            if(checkDK.Checked == false)
            {
                MessageBox.Show("Bạn chưa chấp nhận điều khoản của chúng tôi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            return check;
        }
        private void DangKy_Click(object sender, EventArgs e)
        {
            if (checkLignIn() == true)
            {
                User user = new User(TK.Text, MK.Text);
                TruyVanSQL truyvan = new TruyVanSQL();
                truyvan.Exe("insert into Account values ('" + TK.Text + "','" + MK.Text + "')");
                MessageBox.Show("Bạn đã đăng ký tài khoản thành công!", "Chúc mừng", MessageBoxButtons.OK);
                this.Visible = false;
                Login lg = new Login(user);
                lg.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DieuKhoan dk = new DieuKhoan();
            dk.ShowDialog();
        }
    }
}
