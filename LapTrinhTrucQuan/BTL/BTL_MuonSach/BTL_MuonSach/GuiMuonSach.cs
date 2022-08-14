using BaoCao_HSM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_MuonSach
{
    public partial class GuiMuonSach : Form
    {
        Modify modify = new Modify();
        public GuiMuonSach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GuiMuonSach_Load(sender, e);
        }

        private void GuiMuonSach_Load(object sender, EventArgs e)
        {
            dgvPhieuMuon.Visible = true;
            panel2.Visible = true;
            panel4.Visible = true;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            btnSua.Cursor = Cursors.No;
            btnXoa.Cursor = Cursors.No;
            btnThem.Cursor = Cursors.Hand;
            label2.Text = "Phiếu mượn";
            txtMaThe.Enabled = true;
            txtMaThe.ReadOnly = false;

            cmbLoai.Text = "Tất cả";
            txtMaHSM.Text = "Mã hồ sơ mượn";
            txtMaThe.Text = "Mã thẻ";
            txtMaTT.Text = "Mã thủ thư";
            txtMaGT.Text = "Mã GT";
            txtSoLuong.Text = "Số lượng";
            dtpNgayMuon.Text = DateTime.Now.ToString();
            dtpNgayTra.Text = DateTime.Now.ToString();
            resetErr();

            dgvPhieuMuon.DataSource = modify.getAllPhieuMuon("");
            dgvPhieuMuon.Columns[0].HeaderText = "Mã hồ sơ mượn"; dgvPhieuMuon.Columns[0].Width = 100;
            dgvPhieuMuon.Columns[1].HeaderText = "Mã thẻ"; dgvPhieuMuon.Columns[1].Width = 100;
            dgvPhieuMuon.Columns[2].HeaderText = "Mã thủ thư"; dgvPhieuMuon.Columns[2].Width = 100;
            dgvPhieuMuon.Columns[3].HeaderText = "Mã giáo trình"; dgvPhieuMuon.Columns[3].Width = 100;
            dgvPhieuMuon.Columns[4].HeaderText = "Số lượng"; dgvPhieuMuon.Columns[4].Width = 100;
            dgvPhieuMuon.Columns[5].HeaderText = "Ngày mượn"; dgvPhieuMuon.Columns[5].Width = 100;
            dgvPhieuMuon.Columns[6].HeaderText = "Ngày phải trả"; dgvPhieuMuon.Columns[6].Width = 100;
            dgvPhieuMuon.Columns[7].HeaderText = "Chưa trả"; dgvPhieuMuon.Columns[7].Width = 100;
        }
        void resetErr()
        {
            errMT.Visible = false;
            errTT.Visible = false;
            errGT.Visible = false;
            errSL.Visible = false;
            errNM.Visible = false;
            errNT.Visible = false;
        }
        bool check()
        {
            bool ok = true;
            //Int32.Parse(soLuong) > 0 && Int32.Parse(soLuong) <= 3 &&
            if (txtMaThe.Text == "" || txtMaThe.Text == "Mã thẻ" || modify.MaThe(txtMaThe.Text) == null)
            {
                ok = false;
                errMT.Visible = true;
            }
            if (txtMaTT.Text == "" || txtMaTT.Text=="Mã thủ thư" || modify.MaTT(txtMaTT.Text) == null)
            {
                ok = false;
                errTT.Visible = true;
            }
            if (txtMaGT.Text == "" || txtMaGT.Text == "Mã giáo trình" || modify.MaGT(txtMaGT.Text) == null) 
            {
                ok = false;
                errGT.Visible = true;
            }
            if(txtSoLuong.Text == "" || txtSoLuong.Text =="Số lượng" || Int32.Parse(txtSoLuong.Text) == 0)
            {
                ok = false;
                errSL.Visible = true;
            }
            return ok;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Cursor == Cursors.No) return;
            string ngayMuon = dtpNgayMuon.Text;
            string ngayTra = dtpNgayMuon.Text;
            if (check() == false) return;
            if (modify.tinhtrangthe(txtMaThe.Text) == true )
            {
                MessageBox.Show("Mã thẻ "+txtMaThe.Text+" đã bị khóa!\nMã thẻ "+txtMaThe.Text+" không thể mượn giáo trình!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string x = "";
            while (true)
            {
                Random rdm = new Random();
                x = "HSM" + rdm.Next(0, 999).ToString();
                if (modify.MaHSM(x) == null) break;
            }
            Muon PhieuMuon = new Muon(x, txtMaThe.Text, txtMaTT.Text, txtMaGT.Text, Int32.Parse( txtSoLuong.Text),ngayMuon, ngayTra );
            modify.insert(PhieuMuon);
            GuiMuonSach_Load(sender, e);
            MessageBox.Show("Bạn đã mượn thành công!", "Chúc mừng");
        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Cursor = Cursors.Hand;
            btnXoa.Cursor = Cursors.Hand;
            btnThem.Cursor = Cursors.No;
            label2.Text = "Thông tin";
            txtMaThe.Enabled = false;
            txtMaThe.ReadOnly = true;

            int i;
            i = dgvPhieuMuon.CurrentRow.Index;
            txtMaHSM.Text = dgvPhieuMuon.Rows[i].Cells[0].Value.ToString().Trim();
            txtMaThe.Text = dgvPhieuMuon.Rows[i].Cells[1].Value.ToString().Trim();
            txtMaTT.Text = dgvPhieuMuon.Rows[i].Cells[2].Value.ToString().Trim();
            txtMaGT.Text = dgvPhieuMuon.Rows[i].Cells[3].Value.ToString().Trim();
            txtSoLuong.Text = dgvPhieuMuon.Rows[i].Cells[4].Value.ToString().Trim();
            dtpNgayMuon.Text = dgvPhieuMuon.Rows[i].Cells[5].Value.ToString().Trim();
            dtpNgayTra.Text = dgvPhieuMuon.Rows[i].Cells[6].Value.ToString().Trim();
        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLoai.SelectedIndex == 0) dgvPhieuMuon.DataSource = modify.getAllPhieuMuon("");
            if(cmbLoai.SelectedIndex == 1) dgvPhieuMuon.DataSource = modify.getAllPhieuMuon("Chưa");
            if(cmbLoai.SelectedIndex == 2) dgvPhieuMuon.DataSource = modify.getAllPhieuMuon("Rồi");
        }

        private void txtMaThe_TextChanged(object sender, EventArgs e)
        {
            if (txtMaThe.Text.Length > 0) errMT.Visible = false;
        }

        private void txtMaTT_TextChanged(object sender, EventArgs e)
        {
            if (txtMaTT.Text.Length > 0) errTT.Visible = false;
        }

        private void txtMaGT_TextChanged(object sender, EventArgs e)
        {
            if (txtMaGT.Text.Length > 0) errGT.Visible = false;
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length > 0) errSL.Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa mã hồ sơ mượn "+txtMaHSM.Text+" hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(rs == DialogResult.Yes)
            {
                modify.delete(txtMaHSM.Text, txtMaGT.Text);
                GuiMuonSach_Load(sender, e);
                MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Cursor == Cursors.No) return;
            if (check() == false) return;
            string ngayMuon = dtpNgayMuon.Text;
            string ngayTra = dtpNgayMuon.Text;
            Muon PhieuMuon = new Muon(txtMaHSM.Text, txtMaThe.Text, txtMaTT.Text, txtMaGT.Text, Int32.Parse(txtSoLuong.Text), ngayMuon, ngayTra);
            modify.update(PhieuMuon);
            string tt = txtMaHSM.Text;
            GuiMuonSach_Load(sender, e);
            
            MessageBox.Show("Bạn đã sửa thành công thông tin của phiếu mươn " + tt + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            panel3.Controls.Add(childFrom);
            panel3.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            dgvPhieuMuon.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            OpenChildFrom(new BaoCao());
        }
    }
}
