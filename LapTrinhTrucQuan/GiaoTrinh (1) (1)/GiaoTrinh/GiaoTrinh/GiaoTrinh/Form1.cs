using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoTrinh
{
    public partial class Form1 : Form
    {
        GiaoTrinh GiaoTrinh = new GiaoTrinh();
        GiaoTrinh_TSX GiaoTrinh_TSX = new GiaoTrinh_TSX();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTKTheo.Text != "" && txtTimKiem.Text != "")
            {
                if (cmbTKTheo.SelectedIndex == 0)
                {
                    dgvgiaotrinh.DataSource = GiaoTrinh_TSX.TimKiem1(txtTimKiem.Text, "MaGT");
                    dgvgiaotrinh.Visible = true;
                    dgvtacgia.Visible = false;
                }
                if (cmbTKTheo.SelectedIndex == 1)
                {
                    dgvgiaotrinh.DataSource = GiaoTrinh_TSX.TimKiem1(txtTimKiem.Text, "TenGT");
                    dgvgiaotrinh.Visible = true;
                   dgvtacgia.Visible = false;
                }
                if (cmbTKTheo.SelectedIndex == 2)
                {
                    dgvgiaotrinh.DataSource = GiaoTrinh_TSX.TimKiem1(txtTimKiem.Text, "NamXB");
                    dgvgiaotrinh.Visible = true;
                 //   dgvTKTheoHSTra.Visible = false;
                }
                if (cmbTKTheo.SelectedIndex == 3)
                {
                    dgvgiaotrinh.Visible = false;
                    dgvtacgia.Visible = true;
                    dgvtacgia.DataSource = GiaoTrinh_TSX.TimKiem2(txtTimKiem.Text, "MaTG");
                    dgvtacgia.Columns[0].HeaderText = "Mã tác giả";
                    dgvtacgia.Columns[1].HeaderText = "Tên tác giả";
                    dgvtacgia.Columns[2].HeaderText = "Mã khoa";
                    dgvtacgia.Columns[3].HeaderText = "Năm sinh";
                    dgvtacgia.Columns[4].HeaderText = "Trình độ";
                }

            }
            else if (cmbTKTheo.Text != "" && txtTimKiem.Text == "")
            {
                if (cmbTKTheo.SelectedIndex == 0)
                {
                    Form1_Load(sender, e);
                }
                if (cmbTKTheo.SelectedIndex == 1)
                {
                    Form1_Load(sender, e);
                }
                if (cmbTKTheo.SelectedIndex == 2)
                {
                    Form1_Load(sender, e);
                }
                if (cmbTKTheo.SelectedIndex == 3)
                {
                    dgvgiaotrinh.Visible = false;
                    dgvtacgia.Visible = true;
                    dgvtacgia.DataSource = GiaoTrinh_TSX.GetListTacGia();
                    dgvtacgia.Columns[0].HeaderText = "Mã tác giả";
                    dgvtacgia.Columns[1].HeaderText = "Tên tác giả";
                    dgvtacgia.Columns[2].HeaderText = "Mã khoa";
                    dgvtacgia.Columns[3].HeaderText = "Năm sinh";
                    dgvtacgia.Columns[4].HeaderText = "Trình độ";
                }
            }
            else if (cmbTKTheo.Text == "" && txtTimKiem.Text != "")
            {
                MessageBox.Show("Bạn chưa chọn tìm kiếm theo gì?");
            }
            else
            {
                Form1_Load(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenGT.Focus();

            dgvgiaotrinh.DataSource = GiaoTrinh_TSX.GetListDMGiaoTrinh();
            dgvgiaotrinh.Columns[0].HeaderText = "Mã giáo trình";
            dgvgiaotrinh.Columns[1].HeaderText = "Tên giáo trình";
            dgvgiaotrinh.Columns[2].HeaderText = "Tên tác giả";
            dgvgiaotrinh.Columns[3].HeaderText = "Năm xuất bản";
            dgvgiaotrinh.Columns[4].HeaderText = "Lần xuất bản";
            dgvgiaotrinh.Columns[5].HeaderText = "Mã chuyên ngành";
            dgvgiaotrinh.Columns[6].HeaderText = "Số trang";
            dgvgiaotrinh.Columns[7].HeaderText = "Nội dung";
            dgvgiaotrinh.Columns[8].HeaderText = "Số lượng";

           
            // Reset();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            reportGiaoTrinh reportGiaoTrinh = new reportGiaoTrinh();
            reportGiaoTrinh.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenGT.Text != "")
            {
                if (txtMaTG.Text != "")
                {
                    if (txtNamXB.Text != "")
                    {
                        if (txtLanXB.Text != "")
                        {
                            if (txtMaChuyNganh.Text != "")
                            {
                                if (txtSoTrang.Text !="")
                                {
                                    if (txtNoidung.Text != "")
                                    {
                                        if (txtSoLuong.Text != "")
                                        {
                                            Random rdm = new Random();
                                GiaoTrinh.MaGT1 = "TT" + rdm.Next(0, 999).ToString();
                                //thuThu_DTO.MaTT = txtMaTT.Text;
                                GiaoTrinh.TenGT1 = txtTenGT.Text;
                                GiaoTrinh.MaTG1 = txtMaTG.Text;
                                GiaoTrinh.NamXB1 = txtNamXB.Text;
                                GiaoTrinh.LanXB1 = txtLanXB.Text;
                                GiaoTrinh.MaChuyenNganh1 = txtMaChuyNganh.Text;
                                GiaoTrinh.SoTrang1 = txtSoTrang.Text;
                                GiaoTrinh.TomTatNoiDung1 = txtNoidung.Text;
                                GiaoTrinh.SoLuongGT1 = txtSoLuong.Text;

                                            int check = GiaoTrinh_TSX.Them(GiaoTrinh);
                                if (check == -1)
                                    MessageBox.Show("Mã tự tạo bị trùng!");

                                Form1_Load(sender, e);
                                MessageBox.Show("Thêm thành công!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Bạn chưa điền đủ Thông tin!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bạn chưa điền đủ Thông tin!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Bạn chưa điền đủ Thông tin!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bạn chưa điền đủ Thông tin!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa điền đủ Thông tin!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa điền đủ Thông tin!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đủ Thông tin!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đủ Thông tin!");
            }
        }

        private void txtMGT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvgiaotrinh.SelectedRows.Count > 0)
            {
                GiaoTrinh.MaGT1 = txtMaGT.Text;
                GiaoTrinh.TenGT1 = txtTenGT.Text;
                GiaoTrinh.MaTG1 = txtMaTG.Text;
                GiaoTrinh.NamXB1 = txtNamXB.Text;
                GiaoTrinh.LanXB1 = txtLanXB.Text;
                GiaoTrinh.MaChuyenNganh1 = txtMaChuyNganh.Text;
                GiaoTrinh.SoTrang1 = txtSoTrang.Text;
                GiaoTrinh.TomTatNoiDung1 = txtNoidung.Text;
                GiaoTrinh.SoLuongGT1 = txtSoLuong.Text;

                GiaoTrinh_TSX.Sua(GiaoTrinh);
                Form1_Load(sender, e);
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvgiaotrinh.SelectedRows.Count > 0)
            {
                if (txtMaGT.Text != "")
                {
                    GiaoTrinh_TSX.Xoa(txtMaGT.Text);
                    Form1_Load(sender, e);
                    MessageBox.Show("Xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để xóa!");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTKTheo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
