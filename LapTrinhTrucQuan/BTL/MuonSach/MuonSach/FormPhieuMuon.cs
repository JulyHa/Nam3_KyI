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

namespace MuonSach
{
    public partial class FormPhieuMuon : Form
    {
        private static string stringConnection = @"Data Source=a-pc\SQLEXPRESS;Initial Catalog=QLGiaoTrinh;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
        public FormPhieuMuon()
        {
            InitializeComponent();
        }
              
        Modify modify;
        Muon PhieuMuon;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPhieuMuon_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dgvPhieuMuon.DataSource = modify.getAllPMuon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMuon = this.txtMaMuon.Text;
            string maDG = this.txtMaDG.Text;
            string maS = this.txtMaSach.Text;
            DateTime ngayMuon = this.dtpNgayMuon.Value;
            DateTime ngayTra = this.dtpNgayTra.Value;
            string tinhTrangSach = this.txtTinhTrangSach.Text;
            PhieuMuon = new Muon(maMuon, maDG, maS, ngayMuon, ngayTra, tinhTrangSach);
            if (modify.delele(PhieuMuon))
            {
                dgvPhieuMuon.DataSource = modify.getAllPMuon();
            }
            else
            {
                MessageBox.Show("Lỗi" + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhieu = this.txtMaMuon.Text;
            int Soluong = Int32.Parse(txtSoLuongMuon.Text);
            
            string maMuon = this.txtMaMuon.Text;
            string maDG = this.txtMaDG.Text;
            string maS = this.txtMaSach.Text;
            DateTime ngayMuon = this.dtpNgayMuon.Value;
            DateTime ngayTra = this.dtpNgayTra.Value;
            string tinhTrangSach = this.txtTinhTrangSach.Text;
            PhieuMuon = new Muon(maMuon, maDG, maS, ngayMuon, ngayTra, tinhTrangSach);

            if (Soluong > 0 && Soluong < 3 && radioButton1.Checked && maPhieu != "" && maS != "")
            {
                dgvPhieuMuon.DataSource = modify.getAllPMuon();
            }
            else
            {
                MessageBox.Show("Bạn không thể mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (modify.insert(PhieuMuon))
            {
                dgvPhieuMuon.DataSource = modify.getAllPMuon();
            }
            else
            {
                MessageBox.Show("Lỗi" + "Không thêm được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMuon = this.txtMaMuon.Text;
            string maDG = this.txtMaDG.Text;
            string maS = this.txtMaSach.Text;
            DateTime ngayMuon = this.dtpNgayMuon.Value;
            DateTime ngayTra = this.dtpNgayTra.Value;
            string tinhTrangSach = this.txtTinhTrangSach.Text;
            PhieuMuon = new Muon(maMuon, maDG, maS, ngayMuon, ngayTra, tinhTrangSach);
            if (modify.update(PhieuMuon))
            {
                dgvPhieuMuon.DataSource = modify.getAllPMuon();
            }
            else
            {
                MessageBox.Show("Lỗi" + "Không thêm được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPhieuMuon_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLGiaoTrinhDataSet1.PhieuMuon' table. You can move, or remove it, as needed.
            this.phieuMuonTableAdapter1.Fill(this.qLGiaoTrinhDataSet1.PhieuMuon);
            // TODO: This line of code loads data into the 'qLGiaoTrinhDataSet.PhieuMuon' table. You can move, or remove it, as needed.
            this.phieuMuonTableAdapter.Fill(this.qLGiaoTrinhDataSet.PhieuMuon);

        }
    }
}
