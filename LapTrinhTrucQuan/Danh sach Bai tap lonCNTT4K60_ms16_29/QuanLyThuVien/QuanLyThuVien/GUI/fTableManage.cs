using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using QuanLyThuVien.DAO;
namespace QuanLyThuVien
{
    public partial class fTableManage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private fLogin fLg;
        private string tdn;
        public fTableManage(fLogin _flg, string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
            fLg = _flg;
            DataProvider _dt = new DataProvider();
            DataTable dt = _dt.GetData("select * from ACCOUNT where ACCOUNT.TenDangNhap = '" + tdn + "'");
            string gt = dt.Rows[0]["Quyen"].ToString();
            if (gt == "1")
            {
                ribbonTrangChu.Visible = false;
                ribbonThongKe.Visible = false;
                barBtnQLSach.Enabled = false;
                barBtnQLPM.Enabled = false;
                barBtnQLPT.Enabled = false;
            }
            else
            {
                bar_SachDangMuon.Enabled = false;
                bar_LichSu.Enabled = false;
            }
        }
        

        private void barBtnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLThanhVien frm = new ucFrmQLThanhVien();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

       
        private void barBtnQLSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLSach frm = new ucFrmQLSach();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLPhieuMuon frm = new ucFrmQLPhieuMuon();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLPhieuTra frm = new ucFrmQLPhieuTra();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtbDXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            fLg.Show();
        }

        private void fTableManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            fLg.Close();
        }

        private void barBtnTimKiemSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmTimKiemSach frm = new ucFrmTimKiemSach();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barbtnThanhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmThanhVien frm = new ucFrmThanhVien(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmDoiMatKhau frm = new ucFrmDoiMatKhau(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }
        private void bar_SachDangMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmSachDangMuon frm = new ucFrmSachDangMuon(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void bar_LichSu_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmSachDaTra frm = new ucFrmSachDaTra(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }
        private void barBtnDangMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmDangMuon frm = new ucFrmDangMuon();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtnDaMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmDaTra frm = new ucFrmDaTra();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void fTableManage_Load(object sender, EventArgs e)
        {

        }
    }
}
