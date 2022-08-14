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

namespace QuanLyThuVien
{
    public partial class ucFrmDangMuon : UserControl
    {
        DangMuon_BUS dmBus = new DangMuon_BUS();
        public ucFrmDangMuon()
        {
            InitializeComponent();
        }

        private void ucFrmDangMuon_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dmBus.GetList();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                gridControl1.DataSource = dmBus.GetList();

            }
            else
            {
                if (rdoBtnHoTen.Checked == true)
                    gridControl1.DataSource = dmBus.TimKiem(txtTimKiem.Text, "HoTen");
                else if (rdoBtnTenSach.Checked == true)
                    gridControl1.DataSource = dmBus.TimKiem(txtTimKiem.Text, "TenSach");
            }
        }
    }
}
