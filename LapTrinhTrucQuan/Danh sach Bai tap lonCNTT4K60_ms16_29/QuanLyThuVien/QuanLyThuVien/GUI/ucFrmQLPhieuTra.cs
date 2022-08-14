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
    public partial class ucFrmQLPhieuTra : UserControl
    {
        PhieuTra_BUS ptBUS = new PhieuTra_BUS();
        public ucFrmQLPhieuTra()
        {
            InitializeComponent();
        }

        private void ucFrmQLPhieuTra_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ptBUS.GetList();
            lb_exist.Visible = false;
            lb_ChuaNhap.Visible = false;
            lb_Trung.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lb_exist.Visible = false;
            if (ptBUS.CheckExist("DOCGIA", txt_MDG.Text) == true && ptBUS.CheckExist("SACH", txt_MS.Text) == true)
            {
                PhieuTra _pt = new PhieuTra();
                _pt.MaDocGia = txt_MDG.Text;
                _pt.MaSach = txt_MS.Text;

                Random rdm = new Random();
                _pt.MaPhieu = rdm.Next(0, 1000).ToString();

                if (d_NT.Text == "")
                    _pt.NgayTra = DateTime.Now;
                else
                    _pt.NgayTra = d_NT.DateTime;

                int check = ptBUS.Them(_pt);
                if (check == -1)
                    lb_Trung.Visible = true;
                else
                    ucFrmQLPhieuTra_Load(sender, e);
            }
            else
            {
                lb_ChuaNhap.Visible = false;
                lb_exist.Visible = true;
                lb_Trung.Visible = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txt_MP.Text != "")
            {
                if (ptBUS.CheckExist("DOCGIA", txt_MDG.Text) == true && ptBUS.CheckExist("SACH", txt_MS.Text) == true)
                {
                    PhieuTra _pt = new PhieuTra();
                    _pt.MaDocGia = txt_MDG.Text;
                    _pt.MaSach = txt_MS.Text;
                    _pt.MaPhieu = txt_MP.Text;

                    if (d_NT.Text == "")
                        _pt.NgayTra = DateTime.Now;
                    else
                        _pt.NgayTra = d_NT.DateTime;

                    ptBUS.Sua(_pt);
                    ucFrmQLPhieuTra_Load(sender, e);
                }
                else
                {
                    lb_exist.Visible = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txt_MP.Text != "")
            {
                ptBUS.Xoa(txt_MP.Text);
                ResetGridview();
                ucFrmQLPhieuTra_Load(sender, e);
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txt_MP.Text = gridView1.GetRowCellValue(e.RowHandle, "MaPhieu").ToString();
            txt_MS.Text = gridView1.GetRowCellValue(e.RowHandle, "MaSach").ToString();
            txt_MDG.Text = gridView1.GetRowCellValue(e.RowHandle, "MaDocGia").ToString();

            d_NT.Text = gridView1.GetRowCellDisplayText(e.RowHandle, "NgayTra");
        }
        private void ResetGridview()
        {
            txt_MP.ResetText();
            txt_MS.ResetText();
            txt_MDG.ResetText();
            d_NT.ResetText();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                gridControl1.DataSource = ptBUS.GetList();

            }
            else
            {
                if (rdoBtnMaSach.Checked == true)
                    gridControl1.DataSource = ptBUS.TimKiem(txtTimKiem.Text, "MaSach");
                else if (rdoBtnMaDocGia.Checked == true)
                    gridControl1.DataSource = ptBUS.TimKiem(txtTimKiem.Text, "MaDocGia");
                else if (rdoBtnNgayTra.Checked == true)
                    gridControl1.DataSource = ptBUS.TimKiem(txtTimKiem.Text, "NgayTra");
               
            }
        }

      
    }
}
