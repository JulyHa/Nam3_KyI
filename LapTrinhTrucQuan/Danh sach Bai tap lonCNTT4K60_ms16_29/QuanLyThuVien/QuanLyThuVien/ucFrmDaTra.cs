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
    public partial class ucFrmDaTra : UserControl
    {
        DaTra_BUS dtBus = new DaTra_BUS();
        public ucFrmDaTra()
        {
            InitializeComponent();
        }

        private void ucFrmDaTra_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dtBus.GetList();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                gridControl1.DataSource = dtBus.GetList();

            }
            else
            {
                if (rdoBtnHoTen.Checked == true)
                    gridControl1.DataSource = dtBus.TimKiem(txtTimKiem.Text, "HoTen");
                else if (rdoBtnTenSach.Checked == true)
                    gridControl1.DataSource = dtBus.TimKiem(txtTimKiem.Text, "TenSach");
            }
        }
    }
}
