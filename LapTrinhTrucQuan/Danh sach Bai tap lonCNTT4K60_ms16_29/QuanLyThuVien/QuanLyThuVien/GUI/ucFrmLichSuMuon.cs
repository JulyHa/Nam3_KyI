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
    public partial class ucFrmSachDaTra : UserControl
    {
        LichSuMuon_BUS lsmBus = new LichSuMuon_BUS();
        private string tdn;
        public ucFrmSachDaTra(string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
        }

        private void ucFrmSachDaTra_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = lsmBus.GetList(tdn);
        }

        private void txtTimTenSach_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimTenSach.Text == "")
            {
                gridControl1.DataSource = lsmBus.GetList(tdn);

            }
            else
                gridControl1.DataSource = lsmBus.TimKiem(txtTimTenSach.Text, tdn);
        }

        

       
    }
}
