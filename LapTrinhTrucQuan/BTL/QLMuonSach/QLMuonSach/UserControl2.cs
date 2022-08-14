using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuonSach
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        Modify modify;

        private void btnMuon_Click(object sender, EventArgs e)
        {
            string maPhieu = this.txtMaPM.Text;
            string maS = this.txtMaS.Text;
            int Soluong = Int32.Parse(txtSoLuongMuon.Text);
            if( Soluong > 0 && Soluong < 3 && radioButton1.Checked && maPhieu != "" && maS != "")
            {
                dataGridView1.DataSource = modify.getAllPMuon();
            }
            else
            {
                MessageBox.Show("Bạn không thể mượn!","Thông báo" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
