using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        dtBase db = new dtBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void rdoTT1_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Text = "DocGia";
            dgvData.DataSource = db.SelectData("exec ThemDG 'DG40',N'Nguyễn Thị Phương Anh', '2001-12-24', N'Nữ', N'Hà Nội', 'L02','K02'");
            //dgvData.DataSource = db.SelectData("select * from DocGia");
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            // rdoHam6.Checked = false;
            rdoHam7.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;
        }

        private void rdoTT2_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Text = "ThemTL";
            dgvData.DataSource = db.SelectData("exec ThemTL 'TL31', N'Đại học không phải là con đường duy nhất', 'TL04', 'TG01', 'NXB02', 2001, 2, 250, Null, N'Nước ngoài',100, 55000");
            //dgvData.DataSource = db.SelectData("select * from TaiLieu");
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            // rdoHam6.Checked = false;
            rdoHam7.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }

       /* private void rdoTT3_CheckedChanged_1(object sender, EventArgs e)
        {

            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            rdoHam6.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }*/

        private void rdoTT4_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Text = "XoaTL";
            dgvData.DataSource = db.SelectData("exec XoaTL N'TL31'");
            //dgvData.DataSource = db.SelectData("select * from TaiLieu");

            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            //   rdoHam6.Checked = false;
            rdoHam7.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }

        private void rdoTT5_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Text = "XoaDG";
            dgvData.DataSource = db.SelectData("exec XoaDG N'DG40'");
           // dgvData.DataSource = db.SelectData("select * from DocGia");

            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            //  rdoHam6.Checked = false;
            rdoHam7.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }

        private void rdo6_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Text = "SuaDG";
            dgvData.DataSource = db.SelectData("exec SuaDG 'DG40',N'Nguyễn Thị Phương Anh', '2001-12-24', N'Nữ', N'Đan Phượng - Hà Nội', 'L01','K01', null");

            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            //  rdoHam6.Checked = false;
            rdoHam7.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }

        private void rdoHam1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "TimTL";
            dgvData.DataSource = db.SelectData("select * from TimTL('TL01')");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
          //  rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }

        private void rdoHam2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "DS_TLMuonThang";
            dgvData.DataSource = db.SelectData("select * from DS_TLMuonThang(1)");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
          //  rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }

        private void rdoHam3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "HT_ThuThu";
            dgvData.DataSource = db.SelectData("select * from HT_ThuThu(N'Đỗ')");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
          //  rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }

        private void rdoHam4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "TongPhat";
            dgvData.DataSource = db.SelectData("select * from TongPhat(N'Yến')");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
          //  rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }

        private void rdoHam5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "TraSachTruoc";
            dgvData.DataSource = db.SelectData("select * from TraSachTruoc('2021-01-01')");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
          //  rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }

      /* private void rdoHam6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "DG_TongPhat";
            dgvData.DataSource = db.SelectData("print dbo.DG_TongPhat(N'DG28')");

            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
            //rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;

        }*/

        private void rdoView1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "DS_ThuThu";
            dgvData.DataSource = db.SelectData("select * from DS_ThuThu");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
            //rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            // rdoHam6.Checked = false;
            rdoHam7.Checked = false;
        }

        private void rdoView2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "DS_DocGiaBiPhat";
            dgvData.DataSource = db.SelectData("select * from DS_DocGiaBiPhat"); //gọi đến view DS_DocGiaBiPhat

            dgvData.Columns["MaDocGia"].HeaderText = "Mã độc giả";
            dgvData.Columns["TenDocGia"].HeaderText = "Tên độc giả";
            dgvData.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvData.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvData.Columns["NoiSinh"].HeaderText = "Nơi sinh";
            dgvData.Columns["TenLoai"].HeaderText = "Loại độc giả";
            dgvData.Columns["TenKhoa"].HeaderText = "Khoa";
            dgvData.Columns["MaPhat"].HeaderText = "Mã phạt";

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
           // rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            // rdoHam6.Checked = false;
            rdoHam7.Checked = false;
        }

        private void rdoView3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "DS_DocGiaChuaNopPhat";
            dgvData.DataSource = db.SelectData("select * from DS_DocGiaChuaNopPhat");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
           // rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            //   rdoHam6.Checked = false;
            rdoHam7.Checked = false;
        }

        private void rdoView4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "DS_TLMuonNhieuNhat";
            dgvData.DataSource = db.SelectData("select * from DS_TLMuonNhieuNhat");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
           // rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            // rdoHam6.Checked = false;
            rdoHam7.Checked = false;
        }

        private void rdoView5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "DS_TLPhoBien";
            dgvData.DataSource = db.SelectData("select * from DS_TLPhoBien");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
            //rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            //  rdoHam6.Checked = false;
            rdoHam7.Checked = false;
        }

        private void rdoView6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "SLPhieuMuonMoiThang";
            dgvData.DataSource = db.SelectData("select * from SLPhieuMuonMoiThang");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
            //rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            //  rdoHam6.Checked = false;
            rdoHam7.Checked = false;
        }

        private void rdoView7_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "DS_TLNuocNgoai";
            dgvData.DataSource = db.SelectData("select * from DS_TLNuocNgoai");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
            //rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            //  rdoHam6.Checked = false;
            rdoHam7.Checked = false;
        }

        private void rdoView8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "SLTGCuaMoiKhoa";
            dgvData.DataSource = db.SelectData("select * from SLTGCuaMoiKhoa");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
           // rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            //rdoHam6.Checked = false;
            rdoHam7.Checked = false;
        }

        private void rdoView9_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Tài liệu được cả giáo viên và sinh viên mượn";
            dgvData.DataSource = db.SelectData("select * from TLDuocMuon");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
           // rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            //  rdoHam6.Checked = false;
            rdoHam7.Checked = false;
        }

        private void rdoView10_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "TiengViet_NuocNgoai";
            dgvData.DataSource = db.SelectData("select * from TiengViet_NuocNgoai");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
           // rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            //rdoHam6.Checked = false;
            rdoHam7.Checked = false;
        }

        private void rdoDocGia_CheckedChanged(object sender, EventArgs e)
        {

            groupBox1.Text = "DocGia";
            dgvData.DataSource = db.SelectData("select * from DocGia");

            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            // rdoHam6.Checked = false;
            rdoHam7.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;
        }

        private void rdoTaiLieu_CheckedChanged(object sender, EventArgs e)
        {

            groupBox1.Text = "TaiLieu";
            dgvData.DataSource = db.SelectData("select * from TaiLieu");

            rdoHam1.Checked = false;
            rdoHam2.Checked = false;
            rdoHam3.Checked = false;
            rdoHam4.Checked = false;
            rdoHam5.Checked = false;
            // rdoHam6.Checked = false;
            rdoHam7.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "DS_Muon";
            dgvData.DataSource = db.SelectData("select * from DS_Muon(N'M02')");

            rdoDocGia.Checked = false;
            rdoTaiLieu.Checked = false;
            rdoTT1.Checked = false;
            rdoTT2.Checked = false;
            //rdoTT3.Checked = false;
            rdoTT4.Checked = false;
            rdoTT5.Checked = false;
            rdoTT6.Checked = false;
            rdoView1.Checked = false;
            rdoView2.Checked = false;
            rdoView3.Checked = false;
            rdoView4.Checked = false;
            rdoView5.Checked = false;
            rdoView6.Checked = false;
            rdoView7.Checked = false;
            rdoView8.Checked = false;
            rdoView9.Checked = false;
            rdoView10.Checked = false;
        }

        private void rdoHam6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
