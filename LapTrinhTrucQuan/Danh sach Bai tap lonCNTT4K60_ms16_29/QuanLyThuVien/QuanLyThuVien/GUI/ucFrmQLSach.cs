using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien
{
    public partial class ucFrmQLSach : UserControl
    {
        Sach_BUS sachBUS = new Sach_BUS();
        public ucFrmQLSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;
            Sach _s = new Sach();
            Random rdm = new Random();
            _s.MaSach = rdm.Next(0, 1000).ToString();
            _s.TenSach = txtTenSach.Text;
            _s.TacGia = txtTacGia.Text;
            _s.NhaXuatBan = txtNXB.Text;
            _s.TheLoai = txtTheLoai.Text;
            if (txtGiaSach.Text != "")
                _s.GiaSach = int.Parse(txtGiaSach.Text);
            _s.SoLuong = Convert.ToInt32(nb_SoLuong.Value);

            //kiem tra loi madocgia
            int check = sachBUS.Them(_s);
            if (check == 0)
                lb_MDG.Visible = true;
            else if (check == -1)
                lb_Trung.Visible = true;
            //load lai
            ucFrmQLSach_Load(sender, e);
            ResetGridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                sachBUS.Xoa(txtMaSach.Text);
                ResetGridview();
                ucFrmQLSach_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;
            Sach _s = new Sach();
            _s.MaSach = txtMaSach.Text;
            _s.TenSach = txtTenSach.Text;
            _s.TacGia = txtTacGia.Text;
            _s.NhaXuatBan = txtNXB.Text;
            _s.TheLoai = txtTheLoai.Text;
            if (txtGiaSach.Text != "")
                _s.GiaSach = int.Parse(txtGiaSach.Text);
            _s.SoLuong = Convert.ToInt32(nb_SoLuong.Value);

            if (!sachBUS.Sua(_s))
                lb_MDG.Visible = true;
            ucFrmQLSach_Load(sender, e);
            ResetGridview();
        }
        private void ResetGridview()
        {
            txtMaSach.ResetText();
            txtTenSach.ResetText();
            txtTheLoai.ResetText();
            txtTacGia.ResetText();
            txtGiaSach.ResetText();
            txtNXB.ResetText();
            nb_SoLuong.ResetText();
        }
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaSach.Text = gridView1.GetRowCellValue(e.RowHandle, "MaSach").ToString();
            txtTenSach.Text = gridView1.GetRowCellValue(e.RowHandle, "TenSach").ToString();
            txtTheLoai.Text = gridView1.GetRowCellValue(e.RowHandle, "TheLoai").ToString();
            txtTacGia.Text = gridView1.GetRowCellValue(e.RowHandle, "TacGia").ToString();
            txtGiaSach.Text = gridView1.GetRowCellValue(e.RowHandle, "GiaSach").ToString();
            txtNXB.Text = gridView1.GetRowCellValue(e.RowHandle, "NhaXuatBan").ToString();
            nb_SoLuong.Value = Int32.Parse(gridView1.GetRowCellValue(e.RowHandle, "SoLuong").ToString());
        }

        private void ucFrmQLSach_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = sachBUS.GetList();
        }

        private void txtTimSach_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimSach.Text == "")
            {
                gridControl1.DataSource = sachBUS.GetList();
            }
            else
                gridControl1.DataSource = sachBUS.TimKiem(txtTimSach.Text, "MaSach");
                
        }

     
    }
}
