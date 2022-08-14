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
    public partial class RePassWord : Form
    {
        User s = new User();
        public RePassWord(User x)
        {
            InitializeComponent();
            s = x;
        }

        private void RePassWord_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            bool OK = true;
            errOld.Clear();
            errPass.Clear();
            errRe.Clear();
            if (MKC.Text == "" || MKC.Text == "Mật khẩu cũ")
            {
                errOld.SetError(MKC, "Bạn chưa nhập mật khẩu cũ");
                OK = false;
            }
            if (s.MatKhau != MKC.Text)
            {
                errOld.SetError(MKC, "Mật khẩu không đúng");
                OK = false;
            }
            if (MKM.Text == "" || MKM.Text == "Mật khẩu mới")
            {
                errPass.SetError(MKM, "Bạn chưa nhập mật khẩu");
                OK = false;
            } 
            else if(MKM.Text.Length < 6)
            {
                errPass.SetError(MKM, "Mật khẩu không được ngắn hơn 6 ký tự");
                OK = false;
            }
            if (LMK.Text == "" || LMK.Text == "Lại mật khẩu mới")
            {
                errRe.SetError(LMK, "Bạn chưa nhập lại mật khẩu");
                OK = false;
            }
            else if(MKM.Text != LMK.Text)
            {
                errRe.SetError(LMK, "Mật khẩu không khớp");
                OK = false;
            }
            if (OK == false) return;
            string sql = "Update Account set MatKhau = '" + MKM.Text + "' where Taikhoan = N'" + s.TaiKhoan + "'";
            TruyVanSQL truyvan = new TruyVanSQL();
            truyvan.Exe(sql);
            MessageBox.Show("Bạn đã đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Visible = false;
        }

        private void MKC_TextChanged(object sender, EventArgs e)
        {
            if (MKC.Text.Length > 0) errOld.Clear();
        }

        private void MKM_TextChanged(object sender, EventArgs e)
        {
            if (MKM.Text.Length > 0) errPass.Clear();
        }

        private void LMK_TextChanged(object sender, EventArgs e)
        {
            if (LMK.Text.Length > 0) errRe.Clear();
        }

        private void MKC_MouseClick(object sender, MouseEventArgs e)
        {
            MKC.ResetText();
        }

        private void MKM_MouseClick(object sender, MouseEventArgs e)
        {
            MKM.ResetText();
            MKM.UseSystemPasswordChar = true;
            show_hide.Image = BTL_QuanLySach.Properties.Resources.icons8_hide_50px;
        }

        private void LMK_MouseClick(object sender, MouseEventArgs e)
        {
            LMK.ResetText();
            LMK.UseSystemPasswordChar = true;
            show_hide_LMK.Image = BTL_QuanLySach.Properties.Resources.icons8_hide_50px;
        }

        private void show_hide_Click(object sender, EventArgs e)
        {
            if (MKM.UseSystemPasswordChar == false)
            {
                MKM.UseSystemPasswordChar = true;
                show_hide.Image = BTL_QuanLySach.Properties.Resources.icons8_hide_50px;
            }
            else
            {
                MKM.UseSystemPasswordChar = false;
                show_hide.Image = BTL_QuanLySach.Properties.Resources.icons8_eye_50px_2;
            }
        }

        private void show_hide_LMK_Click(object sender, EventArgs e)
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
    }
}
