using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mượn
{
    public partial class Form1 : Form
    {
        TheMuon_BUS themuon_BUS = new TheMuon_BUS();
        TheMuon_DTO themuon_DTO = new TheMuon_DTO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtMaThe.Text = "Được tạo tự động!";
            txtTen.ResetText();
            txtGioiTinh.ResetText();
            txtMaLop.ResetText();
            txtMaKhoa.ResetText();
            txtKhoaThe.ResetText();
            txtSoLuongMuon.ResetText();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaThe.Focus();

            dataGridView1.DataSource = themuon_BUS.GetListTheMuon();
            dataGridView1.Columns[0].HeaderText = "Mã thẻ";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Mã lớp";
            dataGridView1.Columns[4].HeaderText = "Mã khoa";
            dataGridView1.Columns[5].HeaderText = "Khóa thẻ";
            dataGridView1.Columns[6].HeaderText = "Số lượng mượn";

            Reset();
        }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaThe.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtMaLop.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtMaKhoa.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtKhoaThe.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtSoLuongMuon.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
            {
                if (txtGioiTinh.Text != "")
                {
                    if (txtMaLop.Text != "")
                    {
                        if (txtMaKhoa.Text != "")
                        {
                            if (txtKhoaThe.Text != "")
                            {
                                if (txtSoLuongMuon.Text != "")
                                {

                                    Random rdm = new Random();
                                    themuon_DTO.MaThe = "GT" + rdm.Next(0, 999).ToString();
                                    themuon_DTO.Ten = txtTen.Text;
                                    themuon_DTO.GioiTinh = txtGioiTinh.Text;
                                    themuon_DTO.MaLop = txtMaLop.Text;
                                    themuon_DTO.MaKhoa = txtMaKhoa.Text;
                                    themuon_DTO.KhoaThe = txtKhoaThe.Text;
                                    themuon_DTO.SoLuongMuon = int.Parse(txtSoLuongMuon.Text);


                                    int check = themuon_BUS.Them(themuon_DTO);
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

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                themuon_DTO.MaThe = txtMaThe.Text;
                themuon_DTO.Ten = txtTen.Text;
                themuon_DTO.GioiTinh = txtGioiTinh.Text;
                themuon_DTO.MaLop = txtMaLop.Text;
                themuon_DTO.MaKhoa = txtMaKhoa.Text;
                themuon_DTO.KhoaThe = txtKhoaThe.Text;
                themuon_DTO.SoLuongMuon = int.Parse(txtSoLuongMuon.Text);

                themuon_BUS.Sua(themuon_DTO);
                Form1_Load(sender, e);
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để sửa!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (txtMaThe.Text != "")
                {
                    themuon_BUS.Xoa(txtMaThe.Text);
                    Form1_Load(sender, e);
                    MessageBox.Show("Xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để xóa!");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            reportTheMuon reportTheMuon = new reportTheMuon();
            reportTheMuon.ShowDialog();
        }

        private void txtMaThe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
