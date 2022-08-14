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
    public partial class frmGiaoTrinh : Form
    {
        GiaoTrinh_DTO giaoTrinh_DTO = new GiaoTrinh_DTO();
        GiaoTrinh_BUS giaoTrinh_BUS = new GiaoTrinh_BUS();
        public frmGiaoTrinh()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtMaGT.Text = "Được tạo tự động!";
            txtTenGT.ResetText();  
            txtTacGia.ResetText();
            txtNamXB.ResetText();
            txtLanTB.ResetText();
            txtChuyenNganh.ResetText();
            txtSoTrang.ResetText();
            txtNoiDung.ResetText();
            txtSoLuong.ResetText();

            txtTimKiem.ResetText();

        }
        private void frmGiaoTrinh_Load(object sender, EventArgs e)
        {
            txtTenGT.Focus();

            dgvGiaoTrinh.DataSource = giaoTrinh_BUS.GetListDMGiaoTrinh();
            dgvGiaoTrinh.Columns[0].HeaderText = "Mã giáo trình";
            dgvGiaoTrinh.Columns[1].HeaderText = "Tên giáo trình";
            dgvGiaoTrinh.Columns[2].HeaderText = "Tác giả";
            dgvGiaoTrinh.Columns[3].HeaderText = "Năm xuất bản";
            dgvGiaoTrinh.Columns[4].HeaderText = "Lần tái bản";
            dgvGiaoTrinh.Columns[5].HeaderText = "Chuyên ngành";
            dgvGiaoTrinh.Columns[6].HeaderText = "Số trang";
            dgvGiaoTrinh.Columns[7].HeaderText = "Tóm tắt nội dung";
            dgvGiaoTrinh.Columns[8].HeaderText = "Số lượng giáo trình";

            Reset();
        }
        private void btnLamMoi_Click_2(object sender, EventArgs e)
        {
            frmGiaoTrinh_Load(sender, e);
        }
        private void dgvGiaoTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvGiaoTrinh.CurrentRow.Index;
            txtMaGT.Text = dgvGiaoTrinh.Rows[i].Cells[0].Value.ToString();
            txtTenGT.Text = dgvGiaoTrinh.Rows[i].Cells[1].Value.ToString();
            txtTacGia.Text = dgvGiaoTrinh.Rows[i].Cells[2].Value.ToString();
            txtNamXB.Text = dgvGiaoTrinh.Rows[i].Cells[3].Value.ToString();
            txtLanTB.Text = dgvGiaoTrinh.Rows[i].Cells[4].Value.ToString();
            txtChuyenNganh.Text = dgvGiaoTrinh.Rows[i].Cells[5].Value.ToString();
            txtSoTrang.Text = dgvGiaoTrinh.Rows[i].Cells[6].Value.ToString();
            txtNoiDung.Text = dgvGiaoTrinh.Rows[i].Cells[7].Value.ToString();
            txtSoLuong.Text = dgvGiaoTrinh.Rows[i].Cells[8].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenGT.Text != "")
            {
                if (txtTacGia.Text != "")
                {
                    if (txtNamXB.Text != "")
                    {
                        if (txtLanTB.Text != "")
                        {
                            if (txtChuyenNganh.Text != "")
                            {
                                if (txtSoTrang.Text !="")
                                {
                                    if (txtNoiDung.Text != "")
                                    {
                                        if (txtSoLuong.Text != "")
                                        {
                                            Random rdm = new Random();
                                            giaoTrinh_DTO.MaGT = "GT" + rdm.Next(0, 999).ToString();
                                            giaoTrinh_DTO.TenGT = txtTenGT.Text;
                                            giaoTrinh_DTO.TacGia = txtTacGia.Text;
                                            giaoTrinh_DTO.NamXB = int.Parse(txtNamXB.Text);
                                            giaoTrinh_DTO.LanTB = int.Parse(txtLanTB.Text);
                                            giaoTrinh_DTO.ChuyenNganh = txtChuyenNganh.Text;
                                            giaoTrinh_DTO.SoTrang = int.Parse(txtSoTrang.Text);
                                            giaoTrinh_DTO.NoiDung = txtNoiDung.Text;
                                            giaoTrinh_DTO.SoLuong = int.Parse(txtSoLuong.Text);

                                            int check = giaoTrinh_BUS.Them(giaoTrinh_DTO);
                                            if (check == -1)
                                                MessageBox.Show("Mã tự tạo bị trùng!");

                                            frmGiaoTrinh_Load(sender, e);
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


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGiaoTrinh.SelectedRows.Count > 0)
            {
                giaoTrinh_DTO.MaGT = txtMaGT.Text;
                giaoTrinh_DTO.TenGT = txtTenGT.Text;
                giaoTrinh_DTO.TacGia = txtTacGia.Text;
                giaoTrinh_DTO.NamXB = int.Parse(txtNamXB.Text);
                giaoTrinh_DTO.LanTB = int.Parse(txtLanTB.Text);
                giaoTrinh_DTO.ChuyenNganh = txtChuyenNganh.Text;
                giaoTrinh_DTO.SoTrang = int.Parse(txtSoTrang.Text);
                giaoTrinh_DTO.NoiDung = txtNoiDung.Text;
                giaoTrinh_DTO.SoLuong = int.Parse(txtSoLuong.Text);

                giaoTrinh_BUS.Sua(giaoTrinh_DTO);
                frmGiaoTrinh_Load(sender, e);
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiaoTrinh.SelectedRows.Count > 0)
            {
                if (txtMaGT.Text != "")
                {
                    giaoTrinh_BUS.Xoa(txtMaGT.Text);
                    frmGiaoTrinh_Load(sender, e);
                    MessageBox.Show("Xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để xóa!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (cmbTKTheo.Text != "" && txtTimKiem.Text != "")
            {
                if (cmbTKTheo.SelectedIndex == 0)
                {
                    dgvGiaoTrinh.DataSource = giaoTrinh_BUS.TimKiem(txtTimKiem.Text, "MaGT");
                }
                if (cmbTKTheo.SelectedIndex == 1)
                {
                    dgvGiaoTrinh.DataSource = giaoTrinh_BUS.TimKiem(txtTimKiem.Text, "TenGT");
                }
                if (cmbTKTheo.SelectedIndex == 2)
                {
                    dgvGiaoTrinh.DataSource = giaoTrinh_BUS.TimKiem(txtTimKiem.Text, "TacGia");
                }
                if (cmbTKTheo.SelectedIndex == 3)
                {
                    dgvGiaoTrinh.DataSource = giaoTrinh_BUS.TimKiem(txtTimKiem.Text, "ChuyenNganh");
                }

            }
            else if (cmbTKTheo.Text != "" && txtTimKiem.Text == "")
            {
                if (cmbTKTheo.SelectedIndex == 0)
                {
                    frmGiaoTrinh_Load(sender, e);
                }
                if (cmbTKTheo.SelectedIndex == 1)
                {
                    frmGiaoTrinh_Load(sender, e);
                }
                if (cmbTKTheo.SelectedIndex == 2)
                {
                    frmGiaoTrinh_Load(sender, e);
                }
                if (cmbTKTheo.SelectedIndex == 3)
                {
                    frmGiaoTrinh_Load(sender, e);
                }
            }
            else if (cmbTKTheo.Text == "" && txtTimKiem.Text != "")
            {
                MessageBox.Show("Bạn chưa chọn tìm kiếm theo gì?");
            }
            else
            {
                frmGiaoTrinh_Load(sender, e);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            reportGiaoTrinh reportGiaoTrinh = new reportGiaoTrinh();
            reportGiaoTrinh.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
