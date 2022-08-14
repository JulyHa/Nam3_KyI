using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLySach
{
    public partial class LogIn : Form
    {
        TruyVanSQL truyvan = new TruyVanSQL();
        User user = new User();
        public LogIn(User x)
        {
            InitializeComponent();
            user = x;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            SignIn signin = new SignIn();
            signin.Show();
        }
        private bool CheckTK()
        {
            bool tk = true; int mk = 0;
            if (TK.Text == "" || TK.Text == "Tài khoản")
            {
                TK.ResetText(); TK.Focus();
                tk = false;
                if (MK.Text == "" || MK.Text == "Mật khẩu") mk = 1;
            }
            else
            {
                DataTable dttable = truyvan.Red("select * from Account where TaiKhoan = N'" + TK.Text + "'");
                if (dttable.Rows.Count >= 1)
                {
                    User user = new User();
                    string y = dttable.Rows[0]["MatKhau"].ToString().Trim();
                    if (MK.Text.Trim() == y) return true;
                    else mk = 2;
                }
                else mk = 2;
            }
            if (tk == false)
            {
                TK.Focus();
                errTK.SetError(TK, "Bạn chưa nhập tài khoản");
            }
            if (mk == 1)
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (CheckTK() == true)
            {
                User user = new User(TK.Text, MK.Text);
                FormMain ql = new FormMain(user);
                ql.Show();
                this.Visible = false;
                user.TaiKhoan = TK.Text;
            }
        }

        private void MK_MouseClick(object sender, MouseEventArgs e)
        {
            MK.ResetText();
            MK.UseSystemPasswordChar = true;
            show_hide.Image = BTL_QuanLySach.Properties.Resources.icons8_hide_50px;
        }

        private void TK_MouseClick(object sender, MouseEventArgs e)
        {
            TK.ResetText();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MK.UseSystemPasswordChar == false)
            {
                MK.UseSystemPasswordChar = true;
                show_hide.Image = BTL_QuanLySach.Properties.Resources.icons8_hide_50px;
            }
            else 
            {
                MK.UseSystemPasswordChar = false;
                show_hide.Image = BTL_QuanLySach.Properties.Resources.icons8_eye_50px_2;
            }
        }

        private void TK_TextChanged(object sender, EventArgs e)
        {
            if (TK.Text != "") errTK.Clear();
        }

        private void MK_TextChanged(object sender, EventArgs e)
        {
            if (MK.Text != "") errMK.Clear();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            if(user.TaiKhoan != "")
            {
                TK.Text = user.TaiKhoan;
                MK.Text = user.MatKhau;
            }
            if (MK.Text != "Mật khẩu")
            {
                MK.UseSystemPasswordChar = true;
                show_hide.Image = BTL_QuanLySach.Properties.Resources.icons8_hide_50px;
            }
        }
    }
}
