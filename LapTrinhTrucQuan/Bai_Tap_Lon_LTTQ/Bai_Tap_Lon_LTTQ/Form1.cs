using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Lon_LTTQ
{
    public partial class TraSach : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();

        public TraSach()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e) { }
        private void dtpNgaynopphat_ValueChanged(object sender, EventArgs e) { }

        private void TraSach_Load(object sender, EventArgs e)
        {
            dgvDSTra.DataSource = dtBase.DocBang("select * from HoSoTra");
            dgvDSTra.Columns[0].HeaderText = "Mã hồ sơ trả";
            dgvDSTra.Columns[1].HeaderText = "Mã hồ sơ mượn";
            dgvDSTra.Columns[2].HeaderText = "Ngày Trả";
            dgvDSTra.Columns[3].HeaderText = "Tổng tiền phạt";
            dgvDSTra.Columns[4].HeaderText = "Ngày nộp phạt";
            dgvDSTra.Columns[5].HeaderText = "Mã thủ thư";

            dgvDSTra.Columns[0].Width = 100;
            dgvDSTra.Columns[1].Width = 100;
            dgvDSTra.Columns[2].Width = 100;
            dgvDSTra.Columns[3].Width = 100;
            dgvDSTra.Columns[4].Width = 100;
            dgvDSTra.Columns[5].Width = 100;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHST.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hồ sơ trả", "Thông báo");
                txtMaHST.Focus();
            }
            else
            if (txtMaHSM.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hồ sơ mượn", "Thông báo");
                txtMaHSM.Focus();
            }
            else
            if (dtpNgayTra.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày trả sách", "Thông báo");
                dtpNgayTra.Focus();
            }
            else
            if (txtTongTienPhat.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số tiền phạt", "Thông báo");
                txtTongTienPhat.Focus();
            }
            else
            if (dtpNgayNopPhat.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày nộp phạt", "Thông báo");
                dtpNgayNopPhat.Focus();
            }
            if (txtMaTT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã thủ thư", "Thông báo");
                txtMaTT.Focus();
            }
            else
            {
                DataTable dtChatLieu = dtBase.DocBang("Select * from HoSoTra where" + " MaHsTra = '" + (txtMaHST.Text).Trim() + "'");
                if (dtChatLieu.Rows.Count > 0)
                {
                    MessageBox.Show("Mã hồ sơ này đã có vui lòng nhập mã khác");
                    txtMaHST.Focus();
                }
                else
                {
                    dtBase.CapNhatDuLieu("insert into HoSoTra values('" + txtMaHST.Text + "', '" + txtMaHSM.Text + "', '" +
                    dtpNgayTra.Text + "', " + txtTongTienPhat.Text + ", '" + dtpNgayNopPhat.Text + "', N'" + txtMaTT.Text + "')");
                    dgvDSTra.DataSource = dtBase.DocBang("select * from HosoTra");
                    ResetValue();
                }
            }
        }

        private void ResetValue()
        {
            txtMaHST.Text = "";
            txtMaHSM.Text = "";
            dtpNgayTra.Text = "";
            txtTongTienPhat.Text = "";
            dtpNgayNopPhat.Text = "";
            txtMaTT.Text = "";
        }

        private void dgvDSTra_Click(object sender, EventArgs e)
        {
            txtMaHST.Text = dgvDSTra.CurrentRow.Cells[0].Value.ToString();
            txtMaHSM.Text = dgvDSTra.CurrentRow.Cells[1].Value.ToString();
            dtpNgayTra.Text = dgvDSTra.CurrentRow.Cells[2].Value.ToString();
            txtTongTienPhat.Text = dgvDSTra.CurrentRow.Cells[3].Value.ToString();
            dtpNgayNopPhat.Text = dgvDSTra.CurrentRow.Cells[4].Value.ToString();
            txtMaTT.Text = dgvDSTra.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHST.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hồ sơ trả", "Thông báo");
                txtMaHST.Focus();
            }
            else
            if (txtMaHSM.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hồ sơ mượn", "Thông báo");
                txtMaHSM.Focus();
            }
            else
            if (dtpNgayTra.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày trả", "Thông báo");
                dtpNgayTra.Focus();
            }
            else
            if (txtTongTienPhat.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tiền phạt", "Thông báo");
                txtTongTienPhat.Focus();
            }
            else
            if (txtMaTT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã thủ thư", "Thông báo");
                txtMaTT.Focus();
            }
            if (dtpNgayTra.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày trả", "Thông báo");
                dtpNgayTra.Focus();
            }
            else
            {
                dtBase.CapNhatDuLieu("update HoSoTra set MaHSM = '" + txtMaHSM.Text + "', NgayTra = '" + dtpNgayTra.Text + "', TongTienPhat = " +
                txtTongTienPhat.Text + ",  NgayNopPhat = '" + dtpNgayNopPhat.Text + "', MaThuThu = '" + txtMaTT.Text + "' where MaHSTra = '" + txtMaHST.Text.Trim() + "'");
                dgvDSTra.DataSource = dtBase.DocBang("Select * from HoSoTra");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa độc giả có mã là: " + txtMaHST.Text + " không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dtBase.CapNhatDuLieu("delete HoSoTra where MaHSTra = '" + txtMaHST.Text + "'");
                dgvDSTra.DataSource = dtBase.DocBang("Select * from HoSoTra");
            }
        }
    }

    //private void btnTimKiem_Click(object sender, EventArgs e)
    //{
    //    dgvDSTra.DataSource = dtBase.DocBang("select * from HoSoTra where MaHSTra = '" + txtMaHST.Text.Trim() + "'");
    //}

    //private void btnXuatBaoCao_Click(object sender, EventArgs e)
    //{
    //    if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
    //    {
    //        this.Close();
    //    }
    //}
}
