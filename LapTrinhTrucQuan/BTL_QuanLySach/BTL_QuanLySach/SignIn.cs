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
    public partial class SignIn : Form
    {
        User user = new User();
        public SignIn()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn login = new LogIn(user);
            this.Visible = false;
            login.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool checkLignIn()
        {
            int check = 0;
            int check_mk = 0;
            errTK.Clear(); errMK.Clear(); errLMK.Clear();
            //check tk
            if (TK.Text == "Tên tài khoản" || TK.Text =="")
            {
                check = 1; TK.ResetText(); TK.Focus();
                errTK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                errTK.SetError(TK, "Bạn không được để trống.");
            }
            else
            {
                if (TK.Text.Length < 6 || TK.Text.Length > 15)
                {
                    check = 1; TK.ResetText(); TK.Focus();
                    errTK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                    errTK.SetError(TK, "Tài khoản chỉ từ 6-15 kí tự.");
                }
                else
                {
                    TruyVanSQL lk = new TruyVanSQL();
                    DataTable dttable = lk.Red("Select TaiKhoan from Account where TaiKhoan = N'" + TK.Text + "'");
                    if (dttable.Rows.Count >= 1)
                    {
                        check = 1;
                        TK.ResetText(); TK.Focus();
                        errTK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                        errTK.SetError(TK, "Tài khoản đã tồn tại!");
                    }
                }
            }
            // check mk
            if (MK.Text == "" || MK.Text == "Mật khẩu" || MK.Text.Length < 6)
            {
                if (check != 1) { MK.ResetText(); MK.Focus(); }
                else
                {
                    MK.Text = "Mật khẩu";
                }
                check_mk = 1;
                errMK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                errMK.SetError(MK, "Mật khẩu không được để trống và độ dài không nhỏ hơn 6 ký tự");
            }
            if (MK.Text != LMK.Text || LMK.Text == "" || LMK.Text == "Lại mật khẩu")
            {
                check_mk = 1;
                errLMK.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                errLMK.SetError(LMK, "Mật khẩu không khớp!");
                if (check != 1) { MK.ResetText(); LMK.ResetText() ; MK.Focus(); }
                else
                {
                    MK.Text = "Mật khẩu"; LMK.Text = "Lại mật khẩu";
                }
            }
            return (check == 0 && check_mk == 0);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (checkLignIn() == true)
            {
                User user = new User(TK.Text, MK.Text);
                TruyVanSQL truyvan = new TruyVanSQL();
                truyvan.Exe("insert into Account values ('" + TK.Text + "','" + MK.Text + "')");
                MessageBox.Show("Bạn đã đăng ký tài khoản thành công!", "Chúc mừng", MessageBoxButtons.OK);
                this.Visible = false;
                LogIn lg = new LogIn(user);
                lg.Show();
            }
        }
        private void TK_MouseClick(object sender, MouseEventArgs e)
        {
            TK.ResetText();
        }

        private void MK_MouseClick(object sender, MouseEventArgs e)
        {
            MK.ResetText();
            MK.UseSystemPasswordChar = true;
            show_hide.Image = BTL_QuanLySach.Properties.Resources.icons8_hide_50px;
        }

        private void LMK_MouseClick(object sender, MouseEventArgs e)
        {
            LMK.ResetText();
            LMK.UseSystemPasswordChar = true;
            show_hide_LMK.Image = BTL_QuanLySach.Properties.Resources.icons8_hide_50px;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (LMK.UseSystemPasswordChar == false)
            {
                LMK.UseSystemPasswordChar = true;
                show_hide_LMK.Image = BTL_QuanLySach.Properties.Resources.icons8_hide_50px;
            }
            else
            {
                LMK.UseSystemPasswordChar = false;
                show_hide_LMK.Image = BTL_QuanLySach.Properties.Resources.icons8_eye_50px_2;
            }
        }

        private void show_hide_Click(object sender, EventArgs e)
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

        private void LMK_TextChanged(object sender, EventArgs e)
        {
            if (LMK.Text != "") errLMK.Clear();
        }
    }
}
