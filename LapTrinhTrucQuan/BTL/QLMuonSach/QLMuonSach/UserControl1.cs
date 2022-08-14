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

namespace QLMuonSach
{
    public partial class UserControl1 : UserControl
    {
        private static string stringConnection = @"Data Source=DESKTOP-4ARR1L0\NGU;Initial Catalog=DataLTTQ;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
        public UserControl1()
        {
            InitializeComponent();
        }
        Modify modify;
        Muon phieuMuon;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void UserControl1_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllPMuon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhieuMuon = this.txtMaMuon.Text;
            string maDocGia = this.txtMaDG.Text;
            string maSach = this.txtMaSach.Text;
            DateTime ngayMuon = this.dtpNgayMuon.Value;
            DateTime ngayPhaiTra = this.dtpNgayTra.Value;
            phieuMuon = new Muon(maPhieuMuon, maDocGia, maSach, ngayMuon, ngayPhaiTra);
            if(modify.insert(phieuMuon))
            {
                dataGridView1.DataSource = modify.getAllPMuon();
            }
            else
            {
                MessageBox.Show("Lỗi" + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhieuMuon = this.txtMaMuon.Text;
            string maDocGia = this.txtMaDG.Text;
            string maSach = this.txtMaSach.Text;
            DateTime ngayMuon = this.dtpNgayMuon.Value;
            DateTime ngayPhaiTra = this.dtpNgayTra.Value;
            phieuMuon = new Muon(maPhieuMuon, maDocGia, maSach, ngayMuon, ngayPhaiTra);
            if (modify.update(phieuMuon))
            {
                dataGridView1.DataSource = modify.getAllPMuon();
            }
            else
            {
                MessageBox.Show("Lỗi" + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhieu = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if(modify.delele(phieuMuon))
            {
                dataGridView1.DataSource = modify.getAllPMuon();
            }
            else
            {
                MessageBox.Show("Lỗi" + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
