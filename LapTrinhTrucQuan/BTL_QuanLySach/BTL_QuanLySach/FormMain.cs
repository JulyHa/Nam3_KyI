using Bai_Tap_Lon_LTTQ;
using BTL_MuonSach;
using GiaoTrinh;
using mượn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuThu;

namespace BTL_QuanLySach
{
    public partial class FormMain : Form
    {
        User user = new User();
        public FormMain(User x)
        {
            InitializeComponent();
            user = x;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            TaiLieu.Checked = false;
            ThuThu.Checked = false;
            TheMuon.Checked = false;
            HoSoMuon.Checked = false;
            HoSoTra.Checked = false;
            pictureBox3.BringToFront();
            pictureBox3.BackColor = Color.Transparent;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tenUser.Text = user.TaiKhoan;
            
        }

        private void tenUser_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (DangXuat.Visible == false)
            {
                DangXuat.Visible = true;
                DoiMK.Visible = true;
                i = 30;
            }
            else
            {
                DangXuat.Visible = false;
                DoiMK.Visible = false;
                i = -30;
            }
            TaiLieu.Location = new Point(TaiLieu.Location.X, TaiLieu.Location.Y + i);
            ThuThu.Location = new Point(ThuThu.Location.X, ThuThu.Location.Y + i);
            TheMuon.Location = new Point(TheMuon.Location.X, TheMuon.Location.Y + i);
            HoSoMuon.Location = new Point(HoSoMuon.Location.X, HoSoMuon.Location.Y + i);
            HoSoTra.Location = new Point(HoSoTra.Location.X, HoSoTra.Location.Y + i);
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            user.MatKhau = "";
            this.Visible = false;
            LogIn log = new LogIn(user);
            log.Show();
        }
        private Form currentFormChild;
        private void OpenChildFrom(Form childFrom)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childFrom;
            childFrom.TopLevel = false;
            childFrom.Dock = DockStyle.Fill;
            pn_main.Controls.Add(childFrom);
            pn_main.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }
        private void TaiLieu_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new GUIGiaoTrinh());
            pictureBox3.BringToFront();
            pictureBox3.BackColor = Color.White;
        }

        private void TheMuon_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new GuiTheMuon());
            pictureBox3.BringToFront();
            pictureBox3.BackColor = Color.White;
        }

        private void HoSoMuon_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new GuiMuonSach());
            pictureBox3.BringToFront();
            pictureBox3.BackColor = Color.White;
        }

        private void HoSoTra_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new GuiTraGT());
            pictureBox3.BringToFront();
            pictureBox3.BackColor = Color.White;
        }

        private void ThuThu_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new GuiThuThu());
            pictureBox3.BringToFront();
            pictureBox3.BackColor = Color.White;
        }

        private void DoiMK_Click(object sender, EventArgs e)
        {
            RePassWord doipass = new RePassWord(user);
            doipass.ShowDialog();
        }
    }
}
