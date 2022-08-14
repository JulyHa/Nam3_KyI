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
    public partial class frmThuThu : Form
    {
        ThuThu_DTO thuThu_DTO = new ThuThu_DTO();
        ThuThu_BUS thuThu_BUS = new ThuThu_BUS();
        public frmThuThu()
        {
            InitializeComponent();
        }

      

        private void frmThuThu_Load(object sender, EventArgs e)
        {
            txtTenTT.Focus();

            dgvThuThu.DataSource = thuThu_BUS.GetListThuThu();
            dgvThuThu.Columns[0].HeaderText = "Mã thủ thư";
            dgvThuThu.Columns[1].HeaderText = "Tên thủ thư";
            dgvThuThu.Columns[2].HeaderText = "Địa chỉ";
            dgvThuThu.Columns[3].HeaderText = "Điện thoại cố định";
            dgvThuThu.Columns[4].HeaderText = "Điện thoại di động";
            dgvThuThu.Columns[5].HeaderText = "Mã quê";

            Reset();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmThuThu_Load(sender, e);
            
        }
        private void cmbQue_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 63; i++)
            {
                if (i < 10)
                {
                    if (cmbQue.SelectedIndex == i) txtMaQue.Text = "Q0" + i.ToString();
                }
                else
                {
                    if (cmbQue.SelectedIndex == i) txtMaQue.Text = "Q" + i.ToString();
                }
            }
        }

        private void dgvThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThuThu.CurrentRow.Index;
            txtMaTT.Text = dgvThuThu.Rows[i].Cells[0].Value.ToString();
            txtTenTT.Text = dgvThuThu.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvThuThu.Rows[i].Cells[2].Value.ToString();
            txtDienThoaiCD.Text = dgvThuThu.Rows[i].Cells[3].Value.ToString();
            txtDienThoaiDD.Text = dgvThuThu.Rows[i].Cells[4].Value.ToString();
            txtMaQue.Text = dgvThuThu.Rows[i].Cells[5].Value.ToString();
           
        }
        private void Reset()
        {
            txtMaTT.Text = "Được tạo tự động!";
            txtTenTT.ResetText();  //giong txtTenTT.Text="";
            txtDiaChi.ResetText();
            txtDienThoaiCD.ResetText();
            txtDienThoaiDD.ResetText();
            cmbQue.ResetText();
            txtMaQue.ResetText();
            //cmbTKTheo.ResetText();
            txtTimKiem.ResetText();
            dgvThuThu.Visible = true;
            dgvTKTheoHSTra.Visible = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenTT.Text != "")
            {
                if (txtDiaChi.Text != "")
                {
                    if (txtDienThoaiCD.Text != "")
                    {
                        if (txtDienThoaiDD.Text != "")
                        {
                            if (txtMaQue.Text != "")
                            {
                                Random rdm = new Random();
                                thuThu_DTO.MaTT = "TT" + rdm.Next(0, 999).ToString();
                                //thuThu_DTO.MaTT = txtMaTT.Text;
                                thuThu_DTO.TenTT = txtTenTT.Text;
                                thuThu_DTO.DiaChi = txtDiaChi.Text;
                                thuThu_DTO.DienthoaiCD = txtDienThoaiCD.Text;
                                thuThu_DTO.DienthoaiDD = txtDienThoaiDD.Text;
                                thuThu_DTO.Que = txtMaQue.Text;

                                int check = thuThu_BUS.Them(thuThu_DTO);
                                if (check == -1)
                                    MessageBox.Show("Mã tự tạo bị trùng!");

                                frmThuThu_Load(sender, e);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvThuThu.SelectedRows.Count > 0)
            {
                thuThu_DTO.MaTT = txtMaTT.Text;
                thuThu_DTO.TenTT = txtTenTT.Text;
                thuThu_DTO.DiaChi = txtDiaChi.Text;
                thuThu_DTO.DienthoaiCD = txtDienThoaiCD.Text;
                thuThu_DTO.DienthoaiDD = txtDienThoaiDD.Text;
                thuThu_DTO.Que = txtMaQue.Text;

                thuThu_BUS.Sua(thuThu_DTO);
                frmThuThu_Load(sender, e);
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThuThu.SelectedRows.Count > 0)
            {
                if (txtMaTT.Text != "")
                {
                    thuThu_BUS.Xoa(txtMaTT.Text);
                    frmThuThu_Load(sender, e);
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
            if (cmbTKTheo.Text!="" && txtTimKiem.Text != "")
            {
                if (cmbTKTheo.SelectedIndex == 0)
                {
                    dgvThuThu.DataSource = thuThu_BUS.TimKiem1(txtTimKiem.Text, "MaThuThu");
                    dgvThuThu.Visible = true;
                    dgvTKTheoHSTra.Visible = false;
                }
                if (cmbTKTheo.SelectedIndex == 1)
                {
                    dgvThuThu.DataSource = thuThu_BUS.TimKiem1(txtTimKiem.Text, "TenThuThu");
                    dgvThuThu.Visible = true;
                    dgvTKTheoHSTra.Visible = false;
                }
                if (cmbTKTheo.SelectedIndex == 2)
                {
                    dgvThuThu.DataSource = thuThu_BUS.TimKiem1(txtTimKiem.Text, "MaQue");
                    dgvThuThu.Visible = true;
                    dgvTKTheoHSTra.Visible = false;
                }
                if (cmbTKTheo.SelectedIndex == 3)
                {
                    dgvThuThu.Visible = false;
                    dgvTKTheoHSTra.Visible = true;
                    dgvTKTheoHSTra.DataSource = thuThu_BUS.TimKiem2(txtTimKiem.Text, "MaThuThu");
                    dgvTKTheoHSTra.Columns[0].HeaderText = "Mã thủ thư";
                    dgvTKTheoHSTra.Columns[1].HeaderText = "Tên thủ thư";
                    dgvTKTheoHSTra.Columns[2].HeaderText = "Hồ sơ trả";
                    dgvTKTheoHSTra.Columns[3].HeaderText = "Ngày trả";
                }

            }
            else if(cmbTKTheo.Text != "" && txtTimKiem.Text == "")
            {
                if (cmbTKTheo.SelectedIndex == 0)
                {
                    frmThuThu_Load(sender, e);
                }
                if (cmbTKTheo.SelectedIndex == 1)
                {
                    frmThuThu_Load(sender, e);
                }
                if (cmbTKTheo.SelectedIndex ==2)
                {
                    frmThuThu_Load(sender, e);
                }
                if (cmbTKTheo.SelectedIndex == 3)
                {
                    dgvThuThu.Visible = false;
                    dgvTKTheoHSTra.Visible = true;
                    dgvTKTheoHSTra.DataSource = thuThu_BUS.GetListThuThuNhanHSTra();
                    dgvTKTheoHSTra.Columns[0].HeaderText = "Mã thủ thư";
                    dgvTKTheoHSTra.Columns[1].HeaderText = "Tên thủ thư";
                    dgvTKTheoHSTra.Columns[2].HeaderText = "Hồ sơ trả";
                    dgvTKTheoHSTra.Columns[3].HeaderText = "Ngày trả";
                }
            }
            else if(cmbTKTheo.Text == "" && txtTimKiem.Text != "")
            {
                MessageBox.Show("Bạn chưa chọn tìm kiếm theo gì?");
            }
            else
            {
                frmThuThu_Load(sender, e);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InDSThuThu inDSThuThu = new InDSThuThu();
            inDSThuThu.ShowDialog();
        }


    }
}
