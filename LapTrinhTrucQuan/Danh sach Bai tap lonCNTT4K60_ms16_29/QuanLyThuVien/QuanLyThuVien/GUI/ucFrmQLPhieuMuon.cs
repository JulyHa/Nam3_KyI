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
    public partial class ucFrmQLPhieuMuon : UserControl
    {
        PhieuMuon_BUS pmBUS = new PhieuMuon_BUS();
        public ucFrmQLPhieuMuon()
        {
            InitializeComponent();
        }

        private void ucFrmQLPhieuMuon_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = pmBUS.GetList();
            lb_exist.Visible = false;
            lb_ChuaNhap.Visible = false;
            lb_Trung.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lb_exist.Visible = false;
            if (pmBUS.CheckExist("DOCGIA", txt_MDG.Text) == true && pmBUS.CheckExist("SACH", txt_MS.Text) == true)
            {

                PhieuMuon _pM = new PhieuMuon();

                Random rdm = new Random();
                _pM.MaPhieu = rdm.Next(0, 1000).ToString();

                _pM.MaDocGia = txt_MDG.Text;
                _pM.MaSach = txt_MS.Text;
                
                if (d_NM.Text == "")
                    _pM.NgayMuon = DateTime.Now;
                else
                    _pM.NgayMuon = d_NM.DateTime;
                if (d_NPT.Text == "")
                    _pM.NgayPhaiTra = DateTime.Now;
                else
                    _pM.NgayPhaiTra = d_NM.DateTime;

                int check = pmBUS.Them(_pM);
                if (check == -1)
                    lb_Trung.Visible = true;
                else
                    ucFrmQLPhieuMuon_Load(sender, e);
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
                if (pmBUS.CheckExist("DOCGIA", txt_MDG.Text) == true && pmBUS.CheckExist("SACH", txt_MS.Text) == true)
                {
                    PhieuMuon _pM = new PhieuMuon();
                    _pM.MaDocGia = txt_MDG.Text;
                    _pM.MaSach = txt_MS.Text;
                    _pM.MaPhieu = txt_MP.Text;

                    if (d_NM.Text == "")
                        _pM.NgayMuon = DateTime.Now;
                    else
                        _pM.NgayMuon = d_NM.DateTime;
                    if (d_NPT.Text == "")
                        _pM.NgayPhaiTra = DateTime.Now;
                    else
                        _pM.NgayPhaiTra = d_NM.DateTime;

                    pmBUS.Sua(_pM);
                    ucFrmQLPhieuMuon_Load(sender, e);
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
                pmBUS.Xoa(txt_MP.Text);
                ResetGridview();
                ucFrmQLPhieuMuon_Load(sender, e);
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txt_MP.Text = gridView1.GetRowCellValue(e.RowHandle, "MaPhieu").ToString();
            txt_MS.Text = gridView1.GetRowCellValue(e.RowHandle, "MaSach").ToString();
            txt_MDG.Text = gridView1.GetRowCellValue(e.RowHandle, "MaDocGia").ToString();

            d_NM.Text = gridView1.GetRowCellDisplayText(e.RowHandle, "NgayMuon");
            d_NPT.Text = gridView1.GetRowCellDisplayText(e.RowHandle, "NgayPhaiTra");
        }
        private void ResetGridview()
        {
            txt_MP.ResetText();
            txt_MS.ResetText();
            txt_MDG.ResetText();
            d_NM.ResetText();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                gridControl1.DataSource = pmBUS.GetList();

            }
            else
            {
                if (rdoBtnMaSach.Checked == true)
                    gridControl1.DataSource = pmBUS.TimKiem(txtTimKiem.Text, "MaSach");
                else if (rdoBtnMaDocGia.Checked == true)
                    gridControl1.DataSource = pmBUS.TimKiem(txtTimKiem.Text, "MaDocGia");
                else if (rdoBtnNgayMuon.Checked == true)
                    gridControl1.DataSource = pmBUS.TimKiem(txtTimKiem.Text, "NgayMuon");
            }
        }

     
      

        

    }
}
