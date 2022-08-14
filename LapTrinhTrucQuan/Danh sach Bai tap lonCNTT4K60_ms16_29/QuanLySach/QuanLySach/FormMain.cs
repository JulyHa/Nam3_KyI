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
using ThuThu;

namespace QuanLySach.View
{
    public partial class FormMain : Form
    {
        User user = new User();
        public FormMain(User x)
        {
            InitializeComponent();
            user = x;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            xinchao.Text = user.TaiKhoan;
        }
        private Form currentFormChild;
        private void OpenChildFrom(Form childFrom)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childFrom);
            panel_main.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }
        private void TheMuon_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new frmThuThu());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void MuonTaiLieu_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new MuonTL());
        }

        private void TraTaiLieu_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new TraTL());
        }

        private void TaiLieu_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new TaiLieu());
        }

        private void ThuThu_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new frmThuThu());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login(user);
            lg.Show();
            this.Visible = false;


        }
    }
}
