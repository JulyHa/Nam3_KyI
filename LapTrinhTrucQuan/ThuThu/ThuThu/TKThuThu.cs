using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimKiemThuThu
{
    public partial class TKThuThu : Form
    {
        TimKiemThuThu_BUS timKiemThuThu_BUS = new TimKiemThuThu_BUS();
        public TKThuThu()
        {
            InitializeComponent();
        }

        
        private void TKThuThu_Load(object sender, EventArgs e)
        {
            dgvThuThu.DataSource = timKiemThuThu_BUS.GetListThuThu();
            dgvThuThu.Columns[0].HeaderText = "Mã thủ thư";
            dgvThuThu.Columns[1].HeaderText = "Tên thủ thư";
            dgvThuThu.Columns[2].HeaderText = "Địa chỉ";
            dgvThuThu.Columns[3].HeaderText = "Điện thoại cố định";
            dgvThuThu.Columns[4].HeaderText = "Điện thoại di động";
            dgvThuThu.Columns[5].HeaderText = "Quê";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTKThuThu.Text !="")
            {
                if (rdoTenTT.Checked == true) 
                {
                    dgvThuThu.DataSource = timKiemThuThu_BUS.TimKiem1(txtTKThuThu.Text, "TenThuThu");
                }
                if (rdoMaTT.Checked == true)
                {
                    dgvThuThu.DataSource = timKiemThuThu_BUS.TimKiem1(txtTKThuThu.Text, "MaThuThu");
                }
                if (rdoQue.Checked == true)
                {
                    dgvThuThu.DataSource = timKiemThuThu_BUS.TimKiem1(txtTKThuThu.Text, "TenQue");
                }
                if (rdoTT_Nhan_SachTra.Checked == true)
                {
                    dgvThuThu.DataSource = timKiemThuThu_BUS.TimKiem2(txtTKThuThu.Text, "MaThuThu");
                    dgvThuThu.Columns[2].HeaderText = "Hồ sơ trả";
                    dgvThuThu.Columns[3].HeaderText = "Ngày trả";
                }

            }
            else
            {
                if (rdoTenTT.Checked == true)
                {
                    dgvThuThu.DataSource = timKiemThuThu_BUS.GetListThuThu();
                    dgvThuThu.Columns[2].HeaderText = "Địa chỉ";
                    dgvThuThu.Columns[3].HeaderText = "Điện thoại cố định";
                    dgvThuThu.Columns[4].HeaderText = "Điện thoại di động";
                    dgvThuThu.Columns[5].HeaderText = "Quê";
                }
                if (rdoMaTT.Checked == true)
                {
                    dgvThuThu.DataSource = timKiemThuThu_BUS.GetListThuThu();
                    dgvThuThu.Columns[2].HeaderText = "Địa chỉ";
                    dgvThuThu.Columns[3].HeaderText = "Điện thoại cố định";
                    dgvThuThu.Columns[4].HeaderText = "Điện thoại di động";
                    dgvThuThu.Columns[5].HeaderText = "Quê";
                }
                if (rdoQue.Checked == true)
                {
                    dgvThuThu.DataSource = timKiemThuThu_BUS.GetListThuThu();
                    dgvThuThu.Columns[2].HeaderText = "Địa chỉ";
                    dgvThuThu.Columns[3].HeaderText = "Điện thoại cố định";
                    dgvThuThu.Columns[4].HeaderText = "Điện thoại di động";
                    dgvThuThu.Columns[5].HeaderText = "Quê";
                }
                if (rdoTT_Nhan_SachTra.Checked == true)
                {
                    dgvThuThu.DataSource = timKiemThuThu_BUS.GetListThuThuNhanHSTra();
                    dgvThuThu.Columns[2].HeaderText = "Hồ sơ trả";
                    dgvThuThu.Columns[3].HeaderText = "Ngày trả";
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
