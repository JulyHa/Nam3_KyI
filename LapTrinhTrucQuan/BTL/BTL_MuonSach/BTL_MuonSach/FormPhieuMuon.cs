using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_MuonSach
{
    public partial class FormPhieuMuon : Form
    {
        Modify modify = new Modify();
        public FormPhieuMuon()
        {
            InitializeComponent();
        }
        Muon PhieuMuon;
        private void FormPhieuMuon_Load(object sender, EventArgs e)
        {
            //dgvPhieuMuon.DataSource = modify.getAllPhieuMuon();
            dgvPhieuMuon.Columns[0].HeaderText = "Mã giáo trình"; dgvPhieuMuon.Columns[0].Width = 80;
            dgvPhieuMuon.Columns[0].HeaderText = "Mã giáo trình"; dgvPhieuMuon.Columns[0].Width = 80;
            dgvPhieuMuon.Columns[0].HeaderText = "Mã giáo trình"; dgvPhieuMuon.Columns[0].Width = 80;
            dgvPhieuMuon.Columns[0].HeaderText = "Mã giáo trình"; dgvPhieuMuon.Columns[0].Width = 80;
            dgvPhieuMuon.Columns[0].HeaderText = "Mã giáo trình"; dgvPhieuMuon.Columns[0].Width = 80;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHoSoMuon = this.txtMaHSM.Text;
            string maDG = this.txtMaDG.Text;
            string maGT = this.txtMaGT.Text;
            string soLuong = this.txtSoLuong.Text;
            DateTime ngayMuon = this.dtpNgayMuon.Value;
            DateTime ngayTra = this.dtpNgayTra.Value;
            string tinhTrangThe = this.cmbTinhTrangThe.Text;
            string tinhTrangMuon = this.cmbTinhTrangMuon.Text;
            //PhieuMuon = new Muon(maHoSoMuon, maDG, maGT, soLuong, ngayMuon, ngayTra, tinhTrangThe, tinhTrangMuon);
            
            if ( Int32.Parse(soLuong)>0 && Int32.Parse(soLuong)<=3 && cmbTinhTrangThe.Text == "Thẻ mở" && modify.insert(PhieuMuon))
            {
                //dgvPhieuMuon.DataSource = modify.getAllPhieuMuon();
            }
            else
            {
                MessageBox.Show("Lỗi! " + "Không thêm được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHoSoMuon = this.txtMaHSM.Text;
            string maDG = this.txtMaDG.Text;
            string maGT = this.txtMaGT.Text;
            string soLuong = this.txtSoLuong.Text;
            string ngayMuon = this.dtpNgayMuon.Text;
            string ngayTra = this.dtpNgayTra.Text;
            string tinhTrangThe = this.cmbTinhTrangThe.Text;
            string tinhTrangMuon = this.cmbTinhTrangMuon.Text;
            //PhieuMuon = new Muon(maHoSoMuon, maDG, maGT, soLuong, ngayMuon, ngayTra, tinhTrangThe, tinhTrangMuon);
            
            if (modify.update(PhieuMuon))
            {
                //dgvPhieuMuon.DataSource = modify.getAllPhieuMuon();
            }
            else
            {
                MessageBox.Show("Lỗi! " + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHSM = dgvPhieuMuon.SelectedRows[0].Cells[0].Value.ToString();

            if (modify.delete(maHSM, ""))
            {
                //dgvPhieuMuon.DataSource = modify.getAllPhieuMuon();
            }
            else
            {
                MessageBox.Show("Lỗi! " + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTinhTrangThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbTinhTrangThe.Items.Add("Thẻ mở");
            //cmbTinhTrangThe.Items.Add("Thẻ đóng");
        }

        private void cmbTinhTrangMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbTinhTrangMuon.Items.Add("Đã trả");
            //cmbTinhTrangMuon.Items.Add("Đang mượn");
            //cmbTinhTrangMuon.Items.Add("Chưa trả");
        }
    }
}
