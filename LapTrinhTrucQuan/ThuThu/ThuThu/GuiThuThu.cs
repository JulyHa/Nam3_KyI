using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuThu
{
    public partial class GuiThuThu : Form
    {
        //ThuThu_DTO thuThu_DTO = new ThuThu_DTO();
        ThuThu_BUS thuThu_BUS = new ThuThu_BUS();
        public GuiThuThu()
        {
            InitializeComponent();
        }
        private void GuiThuThu_Load(object sender, EventArgs e)
        {
            btnThem.Cursor = Cursors.Hand;
            btnSua.Cursor = Cursors.No;
            btnXoa.Cursor = Cursors.No;
            dgvThuThu.DataSource = thuThu_BUS.GetListThuThu();
            dgvThuThu.Columns[0].HeaderText = "Mã thủ thư";dgvThuThu.Columns[0].Width = 80;
            dgvThuThu.Columns[1].HeaderText = "Tên thủ thư"; dgvThuThu.Columns[1].Width = 200;
            dgvThuThu.Columns[2].HeaderText = "Địa chỉ"; dgvThuThu.Columns[2].Width = 100;
            dgvThuThu.Columns[3].HeaderText = "Điện thoại cố định"; dgvThuThu.Columns[3].Width = 100;
            dgvThuThu.Columns[4].HeaderText = "Điện thoại di động"; dgvThuThu.Columns[4].Width = 100;
            dgvThuThu.Columns[5].HeaderText = "Tên quê"; dgvThuThu.Columns[5].Width = 100;

            Reset();
        }
        private void Reset()
        {
            txtMaTT.Text = "Mã thủ thư";
            txtTenTT.Text = "Tên thủ thư";
            txtDiaChi.Text = "Địa chỉ";
            txtDienThoaiCD.Text = "SDT cố định";
            txtDienThoaiDD.Text = "SDT di động";
            cmbQue.Text = "Quê quán";
            txtTimKiem.ResetText();
            MaHS.Visible = false;
        }
        private void resetErr()
        {
            errTenTT.Visible = false;
            errDC.Visible = false;
            errDTCD.Visible = false;
            errDTDD.Visible = false;
            errQQ.Visible = false;
            errTK.Visible = false;
            errTenGT.Visible = false;

        }
        private bool check()
        {
            bool check = true;
            resetErr();
            //chech Ten Thu thu
            if (txtTenTT.Text == "" || txtTenTT.Text == "Tên thủ thư") { errTenTT.Visible = true; check = false; }
            // check Dia Chi
            if (txtDiaChi.Text == "" || txtDiaChi.Text == "Địa chỉ") { errDC.Visible = true; check = false; }
            // check DTCD
            if (txtDienThoaiCD.Text == "" || txtDienThoaiCD.Text == "SDT cố định" || txtDienThoaiCD.Text.Length != 10) { errDTCD.Visible = true; check = false; }
            // check DTDD
            if (txtDienThoaiDD.Text == "" || txtDienThoaiDD.Text == "SDT di động" || txtDienThoaiDD.Text.Length != 10) { errDTDD.Visible = true; check = false; }
            // check quê 
            if (cmbQue.Text == "" || cmbQue.Text == "Quê quán") { errQQ.Visible = true ; check = false; }

            return check;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Cursor == Cursors.No) return;
            if (check())
            {
                string x = "";
                while (true)
                {
                    Random rdm = new Random();
                    x = "TT" + rdm.Next(0, 999).ToString();
                    if (thuThu_BUS.TimKiem1("MaThuThu", x) == null) break;
                }
                ThuThu_DTO tt = new ThuThu_DTO(x, txtTenTT.Text, txtDiaChi.Text, txtDienThoaiCD.Text, txtDienThoaiDD.Text, cmbQue.Text);
                thuThu_BUS.Them(tt);
                GuiThuThu_Load(sender, e);
                MessageBox.Show("Bạn đã thêm thủ thư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDienThoaiCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Cursor == Cursors.No) return;
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.No) return;
            string s = txtTenTT.Text;
            thuThu_BUS.Xoa(txtMaTT.Text);
            GuiThuThu_Load(sender, e);
            MessageBox.Show("Bạn đã xóa thủ thư "+s+" thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InDSThuThu inDSThuThu = new InDSThuThu("ThuThu");
            inDSThuThu.ShowDialog();
        }

        private void txtTenTT_TextChanged(object sender, EventArgs e)
        {
            if (txtTenTT.Text.Length > 0 && txtTenTT.Text != "Tên thủ thư") errTenTT.Visible = false;
            
        }

        private void txtTenTT_MouseClick(object sender, MouseEventArgs e)
        {
            txtTenTT.ResetText();
        }

        private void txtDiaChi_MouseClick(object sender, MouseEventArgs e)
        {
            txtDiaChi.ResetText();
        }

        private void txtDienThoaiCD_MouseClick(object sender, MouseEventArgs e)
        {
            txtDienThoaiCD.ResetText();
        }

        private void txtDienThoaiDD_MouseClick(object sender, MouseEventArgs e)
        {
            txtDienThoaiDD.ResetText();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // check tìm kiếm
            if (cmbTKTheo.Text == "" && txtTimKiem.Text != "") { errTK.Visible = true; return; }

            if (cmbTKTheo.SelectedIndex == 0)
            {
                dgvThuThu.DataSource = thuThu_BUS.TimKiem1(txtTimKiem.Text, "MaThuThu");
            }
            if (cmbTKTheo.SelectedIndex == 1)
            {
                dgvThuThu.DataSource = thuThu_BUS.TimKiem1(txtTimKiem.Text, "TenThuThu");
            }
            if (cmbTKTheo.SelectedIndex == 2)
            {
                dgvThuThu.DataSource = thuThu_BUS.TimKiem1(txtTimKiem.Text, "TenQue");
            }
            if (cmbTKTheo.SelectedIndex == 3)
            {
                btnThem.Cursor = Cursors.No;
                dgvThuThu.DataSource = thuThu_BUS.TimKiem2(txtTimKiem.Text, "TenGT");
                dgvThuThu.Columns[6].HeaderText = "Tên sách trả";
            }
            Reset();
        }

        private void cmbQue_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbQue.Text.Length > 0 && cmbQue.Text != "Quê quán") errQQ.Visible = false;
        }

        private void dgvThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Cursor = Cursors.No;
            resetErr();
            btnSua.Cursor = Cursors.Hand;
            btnXoa.Cursor = Cursors.Hand;
            btnThem.Cursor = Cursors.No;
            txtTimKiem.ResetText();

            int i;
            i = dgvThuThu.CurrentRow.Index;
            txtMaTT.Text = dgvThuThu.Rows[i].Cells[0].Value.ToString().Trim();
            txtTenTT.Text = dgvThuThu.Rows[i].Cells[1].Value.ToString().Trim();
            txtDiaChi.Text = dgvThuThu.Rows[i].Cells[2].Value.ToString().Trim();
            txtDienThoaiCD.Text = dgvThuThu.Rows[i].Cells[3].Value.ToString().Trim();
            txtDienThoaiDD.Text = dgvThuThu.Rows[i].Cells[4].Value.ToString().Trim();
            cmbQue.Text = dgvThuThu.Rows[i].Cells[5].Value.ToString().Trim();
            if (cmbTKTheo.SelectedIndex == 3)
            {
                MaHS.Visible = true;
                MaHS.Text = dgvThuThu.Rows[i].Cells[6].Value.ToString().Trim();
            }
            else MaHS.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Cursor == Cursors.No) return;
            if (dgvThuThu.SelectedRows.Count > 0)
            {
                if (check() == false) return;
                ThuThu_DTO x = new ThuThu_DTO(txtMaTT.Text, txtTenTT.Text, txtDiaChi.Text, txtDienThoaiCD.Text, txtDienThoaiDD.Text, cmbQue.Text);
                if (cmbTKTheo.SelectedIndex == 3)
                {
                    if (MaHS.Text == "" || MaHS.Text == "Tên sách TT nhận trả" || thuThu_BUS.TenGT(MaHS.Text) == false)
                    {
                        errTenGT.Visible = true;
                        return;
                    }
                    thuThu_BUS.SuaTenGT(x, MaHS.Text);
                    
                }
                thuThu_BUS.Sua(x);
                GuiThuThu_Load(sender, e);
                MessageBox.Show("Bạn đã sửa thành công thủ thư có mã "+x.MaTT+"!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để sửa!");
            }
            txtTimKiem.ResetText();
            cmbTKTheo.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GuiThuThu_Load(sender, e);
        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Length > 0 && txtDiaChi.Text != "Địa chỉ") errDC.Visible = false;
        }
        private void txtDTCD_TextChanged(object sender, EventArgs e)
        {
            if (txtDienThoaiCD.Text.Length > 0 && txtDienThoaiCD.Text != "SDT cố định") errDTCD.Visible = false;
        }
        private void DTDD_TextChanged(object sender, EventArgs e)
        {
            if (txtDienThoaiDD.Text.Length > 0 && txtDienThoaiDD.Text != "SDT di động") errDTDD.Visible = false;
        }
    }
}
