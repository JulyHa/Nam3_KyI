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

namespace GiaoTrinh
{
    public partial class GUIGiaoTrinh : Form
    {
        GiaoTrinh_DTO giaoTrinh_DTO = new GiaoTrinh_DTO();
        GiaoTrinh_BUS giaoTrinh_BUS = new GiaoTrinh_BUS();
        public GUIGiaoTrinh()
        {
            InitializeComponent();
        }

        private void GUIGiaoTrinh_Load(object sender, EventArgs e)
        {
            restErr();
            resetText();
            btnThem.Cursor = Cursors.Hand;
            btnIn.Cursor = Cursors.Hand;
            btnSua.Cursor = Cursors.No;
            btnXoa.Cursor = Cursors.No;

            dgvGiaoTrinh.DataSource = giaoTrinh_BUS.GetListDMGiaoTrinh(); 
            dgvGiaoTrinh.Columns[0].HeaderText = "Mã giáo trình";dgvGiaoTrinh.Columns[0].Width = 80;
            dgvGiaoTrinh.Columns[1].HeaderText = "Tên giáo trình"; dgvGiaoTrinh.Columns[1].Width = 200;
            dgvGiaoTrinh.Columns[2].HeaderText = "Tác giả"; dgvGiaoTrinh.Columns[2].Width = 100;
            dgvGiaoTrinh.Columns[3].HeaderText = "Năm xuất bản"; dgvGiaoTrinh.Columns[3].Width = 50;
            dgvGiaoTrinh.Columns[4].HeaderText = "Lần tái bản"; dgvGiaoTrinh.Columns[4].Width = 50;
            dgvGiaoTrinh.Columns[5].HeaderText = "Chuyên ngành"; dgvGiaoTrinh.Columns[5].Width = 120;
            dgvGiaoTrinh.Columns[6].HeaderText = "Số trang"; dgvGiaoTrinh.Columns[6].Width = 50;
            dgvGiaoTrinh.Columns[7].HeaderText = "Số lượng giáo trình"; dgvGiaoTrinh.Columns[7].Width = 50;
            dgvGiaoTrinh.Columns[8].HeaderText = "Tóm tắt nội dung"; dgvGiaoTrinh.Columns[8].Width = 200;
        }
        void restErr()
        {
            errTenGT.Visible = false;
            errTenTG.Visible = false;
            errNXB.Visible = false;
            errLanTB.Visible = false;
            errCN.Visible = false;
            errST.Visible = false;
        }
        void resetText()
        {
            txtMaGT.Text = "Mã giáo trình";
            txtTenGT.Text = "Tên giáo trình";
            txtTacGia.Text = "Tên tác giả";
            txtNamXB.Text = "Năm xuất bản";
            txtLanTB.Text = "Lần tái bản";
            txtChuyenNganh.Text = "Tên chuyên ngành";
            txtSoTrang.Text = "Số trang";
            txtSoLuong.Text = "0";
            txtNoiDung.Text = "Nội dung";
        }
        bool checkTT()
        {
            bool check = true;
            //check tên giáo trình
            if (txtTenGT.Text == "" || txtTenGT.Text == "Tên giáo trình") { errTenGT.Visible = true; check = false; }
            //check tên tác giả
            if (txtTacGia.Text == "" || txtTacGia.Text == "Tên tác giả" || giaoTrinh_BUS.GetMaTG( txtTacGia.Text) == null ) {errTenTG.Visible = true; check = false; }
            //check năm xuất bản
            if (txtNamXB.Text == "" || txtNamXB.Text == "Năm xuất bản" || Int32.Parse(txtNamXB.Text) >= DateTime.Now.Year) { errNXB.Visible = true; check = false; }
            //check lần tái bản
            if (txtLanTB.Text == "" || txtLanTB.Text == "Lần tái bản") { errLanTB.Visible = true; check = false; }
            //check chuyên ngành
            if (txtChuyenNganh.Text == "" || txtChuyenNganh.Text == "Chuyên ngành" || giaoTrinh_BUS.ChuyenNganh(txtChuyenNganh.Text) == null) { errCN.Visible = true; check = false; }
            //check số trang
            if (txtSoTrang.Text == "" || txtSoTrang.Text == "Số trang") { errST.Visible = true; check = false; }

                return check;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            restErr();
            if (btnThem.Cursor == Cursors.No) return;
            if (checkTT() == false) return;
            while (true)
            {
                Random rdm = new Random();
                giaoTrinh_DTO.MaGT = "GT" + rdm.Next(0, 999).ToString();
                if (giaoTrinh_BUS.GetMaGT(giaoTrinh_DTO.MaGT) == null) break;
            }
            giaoTrinh_DTO.TenGT = txtTenGT.Text;
            giaoTrinh_DTO.TacGia =giaoTrinh_BUS.GetMaTG(txtTacGia.Text);
            giaoTrinh_DTO.NamXB = int.Parse(txtNamXB.Text);
            giaoTrinh_DTO.LanTB = int.Parse(txtLanTB.Text);
            giaoTrinh_DTO.ChuyenNganh = giaoTrinh_BUS.ChuyenNganh(txtChuyenNganh.Text);
            giaoTrinh_DTO.SoTrang = int.Parse(txtSoTrang.Text);
            giaoTrinh_DTO.NoiDung = txtNoiDung.Text;
            giaoTrinh_DTO.SoLuong = int.Parse(txtSoLuong.Text);

            giaoTrinh_BUS.Them(giaoTrinh_DTO);
            GUIGiaoTrinh_Load(sender, e);
            resetText();
            MessageBox.Show("Bạn đã thêm tài liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Cursor == Cursors.No) return;
            if (dgvGiaoTrinh.SelectedRows.Count > 0)
            {
                if (checkTT() == false) return;
                giaoTrinh_DTO.MaGT = txtMaGT.Text;
                giaoTrinh_DTO.TenGT = txtTenGT.Text;
                giaoTrinh_DTO.TacGia = giaoTrinh_BUS.GetMaTG(txtTacGia.Text);
                giaoTrinh_DTO.NamXB = int.Parse(txtNamXB.Text);
                giaoTrinh_DTO.LanTB = int.Parse(txtLanTB.Text);
                giaoTrinh_DTO.ChuyenNganh = giaoTrinh_BUS.ChuyenNganh(txtChuyenNganh.Text);
                giaoTrinh_DTO.SoTrang = int.Parse(txtSoTrang.Text);
                giaoTrinh_DTO.NoiDung = txtNoiDung.Text;
                giaoTrinh_DTO.SoLuong = int.Parse(txtSoLuong.Text);

                giaoTrinh_BUS.Sua(giaoTrinh_DTO);
                GUIGiaoTrinh_Load(sender, e);
                resetText();
                MessageBox.Show("Bạn đã sửa thành công!");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Cursor == Cursors.No) return;
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.No) return;
            giaoTrinh_BUS.Xoa(txtMaGT.Text);
            GUIGiaoTrinh_Load(sender, e);
            resetText();
            MessageBox.Show("Bạn đã xóa thành công!", "Thông báo");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InDSThuThu reportGiaoTrinh = new InDSThuThu("GiaoTrinh");
            reportGiaoTrinh.ShowDialog();
        }

        private void dgvGiaoTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Cursor = Cursors.Hand;
            btnXoa.Cursor = Cursors.Hand;
            btnThem.Cursor = Cursors.No;
            int i;
            i = dgvGiaoTrinh.CurrentRow.Index;
            txtMaGT.Text = dgvGiaoTrinh.Rows[i].Cells[0].Value.ToString().Trim();
            txtTenGT.Text = dgvGiaoTrinh.Rows[i].Cells[1].Value.ToString().Trim();
            txtTacGia.Text = dgvGiaoTrinh.Rows[i].Cells[2].Value.ToString().Trim();
            txtNamXB.Text = dgvGiaoTrinh.Rows[i].Cells[3].Value.ToString().Trim();
            txtLanTB.Text = dgvGiaoTrinh.Rows[i].Cells[4].Value.ToString().Trim();
            txtChuyenNganh.Text = dgvGiaoTrinh.Rows[i].Cells[5].Value.ToString().Trim();
            txtSoTrang.Text = dgvGiaoTrinh.Rows[i].Cells[6].Value.ToString().Trim();
            txtSoLuong.Text = dgvGiaoTrinh.Rows[i].Cells[7].Value.ToString().Trim();
            txtNoiDung.Text = dgvGiaoTrinh.Rows[i].Cells[8].Value.ToString().Trim();
        }

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            resetText();
            btnThem.Cursor = Cursors.No;
            if (cmbTKTheo.Text == "" && txtTimKiem.Text != "") { errTK.Visible = true; return; }
            
            if (cmbTKTheo.SelectedIndex == 0)
            {
                dgvGiaoTrinh.DataSource = giaoTrinh_BUS.TimKiem(txtTimKiem.Text, "TenGT");
            }
            if (cmbTKTheo.SelectedIndex == 1)
            {
                dgvGiaoTrinh.DataSource = giaoTrinh_BUS.TimKiem(txtTimKiem.Text, "TenTG");
            }
            if (cmbTKTheo.SelectedIndex == 2)
            {
                dgvGiaoTrinh.DataSource = giaoTrinh_BUS.TimKiem(txtTimKiem.Text, "TenChuyenNganh");
            }
        }

        private void txtTenGT_MouseClick(object sender, MouseEventArgs e)
        {
            txtTenGT.ResetText();
        }

        private void txtTacGia_MouseClick(object sender, MouseEventArgs e)
        {
            txtTacGia.ResetText();
        }

        private void txtNamXB_MouseClick(object sender, MouseEventArgs e)
        {
            txtNamXB.ResetText();
        }

        private void txtLanTB_MouseClick(object sender, MouseEventArgs e)
        {
            txtLanTB.ResetText();
        }

        private void txtChuyenNganh_MouseClick(object sender, MouseEventArgs e)
        {
            txtChuyenNganh.ResetText();
        }

        private void txtSoTrang_MouseClick(object sender, MouseEventArgs e)
        {
            txtSoTrang.ResetText();
        }

        private void txtNoiDung_MouseClick(object sender, MouseEventArgs e)
        {
            txtNoiDung.ResetText();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GUIGiaoTrinh_Load(sender, e);
        }
    }
}
