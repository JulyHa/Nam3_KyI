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
    public partial class ucFrmSachDangMuon : UserControl
    {
        SachDangMuon_BUS sdmBus = new SachDangMuon_BUS();
        private string tdn;
        public ucFrmSachDangMuon(string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
        }

        private void ucFrmSachDangMuon_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = sdmBus.GetList(tdn);
        }

        private void txtTimTenSach_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimTenSach.Text == "")
            {
                gridControl1.DataSource = sdmBus.GetList(tdn);

            }
            else
             gridControl1.DataSource = sdmBus.TimKiem(txtTimTenSach.Text ,tdn);
        }

       

        
    }
}
