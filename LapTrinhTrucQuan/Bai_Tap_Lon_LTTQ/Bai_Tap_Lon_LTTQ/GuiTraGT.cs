using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Lon_LTTQ
{
    public partial class GuiTraGT : Form
    {
        Modify modify = new Modify();
        public GuiTraGT()
        {
            InitializeComponent();
        }
        private void GuiTraGT_Load(object sender, EventArgs e)
        {
            btnThem.Cursor = Cursors.Hand;
            btnSua.Cursor = Cursors.No;
            btnXoa.Cursor = Cursors.No;
            panelSua.Visible = false;
            panelTra.Visible = true;

            dataTra.DataSource = modify.getAll();
            dataTra.Columns[0].HeaderText = "Mã hồ sơ trả"; dataTra.Columns[0].Width = 80;
            dataTra.Columns[1].HeaderText = "Mã hồ sơ mượn"; dataTra.Columns[1].Width = 100;
            dataTra.Columns[2].HeaderText = "Ngày trả"; dataTra.Columns[2].Width = 100;
            dataTra.Columns[3].HeaderText = "Ngày nộp phạt"; dataTra.Columns[3].Width = 100;
            dataTra.Columns[4].HeaderText = "Mã thủ thư"; dataTra.Columns[4].Width = 80;
            dataTra.Columns[5].HeaderText = "Tổng tiền phạt"; dataTra.Columns[5].Width = 100;
            dataTra.Columns[6].HeaderText = "Mã giáo trình"; dataTra.Columns[6].Width = 80;
            dataTra.Columns[7].HeaderText = "Vi phạm"; dataTra.Columns[7].Width = 100;
            dataTra.Columns[8].HeaderText = "Tiền phạt"; dataTra.Columns[8].Width = 100;
            resetpanlThem();
            resetpanlSua();
            resetErr();
        }
        void resetpanlThem()
        {
            txtTT_MaHSM.Text = "Mã hồ sơ mượn";
            txtTT_MaTT.Text = "Mã thủ thư";
            txtTT_GT.Text = "Mã giáo trình";
            txtTT_TP.Text = "Tiền phạt";
        }
        void resetpanlSua()
        {
            txtCT_HST.Text = "Mã hồ sơ trả";
            txtCT_HSM.Text = "Mã hồ sơ mượn";
            txtCT_NgayTra.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtCT_NgayNP.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtCT_MaTT.Text = "Mã thủ thư";
            txtCT_TongPhat.Text = "Tổng tiền phạt";
            txtCT_MaGT.Text = "Giáo trình";
            txtCT_TP.Text = "Tiền phạt";
        }
        void resetErr()
        {
            errTTHSM.Visible = false;
            errTTMaGT.Visible = false;
            errTTMaTT.Visible = false;
        }
        bool checkTTVao()
        {
            bool check = true;
            if(txtTT_MaHSM.Text == "" || txtTT_MaHSM.Text == "Mã hồ sơ mượn" || modify.GetMaHSM(txtTT_MaHSM.Text) == null)
            {
                errTTHSM.Visible = true;
                check = false;
            }
            else if (txtTT_GT.Text == "" || txtTT_GT.Text == "Mã giáo trình" || modify.GetGT(txtTT_MaHSM.Text, txtTT_GT.Text) == null)
            {
                errTTMaGT.Visible = true;
                check = false;
            }
            if (txtTT_MaTT.Text == "" || txtTT_MaTT.Text =="Mã thủ thư" || modify.GetTT(txtTT_MaTT.Text) == null)
            {
                errTTMaTT.Visible = true;
                check = false;
            }
            
            return check;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Cursor == Cursors.No) return;
            if (checkTTVao() == false) return;
            string x = "";
            while (true)
            {
                Random rdm = new Random();
                x = "HST"+ rdm.Next(0, 999).ToString();
                if (modify.Get_HST(x) == null) break;
            }
            string mavp="", map = "";
            if (txtTT_VP.Text == "Làm mất giáo trình") { mavp = "VP01"; map = "P01"; }
            if (txtTT_VP.Text == "Làm hỏng giáo trình") { mavp = "VP02"; map = "P02"; }
            if (txtTT_VP.Text == "Trả quá hạn") { mavp = "VP03"; map = "P03"; }
            modify.ThemHST(x, txtTT_GT.Text, mavp, txtTT_TP.Text, txtTT_MaHSM.Text, txtTT_MaTT.Text, map);

            if(txtTT_TP.Text != ""  && chuanop.Checked == true)
            {
                modify.khoathe(txtTT_MaHSM.Text);
            }
            GuiTraGT_Load(sender, e);
            MessageBox.Show("Bạn đã trả giáo trình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Cursor == Cursors.No) return;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Cursor == Cursors.No) return;
            if (MessageBox.Show("Bạn có muốn xóa chi tiết hồ sơ có mã mượn là: " + txtCT_HST.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                modify.XoaCTM(txtCT_HST.Text);
                GuiTraGT_Load(sender, e);
                MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelTra.Visible = false;
            panelSua.Visible = true;
            btnThem.Cursor = Cursors.No;
            btnXoa.Cursor = Cursors.Hand;
            int i;
            i = dataTra.CurrentRow.Index;
            txtCT_HST.Text = dataTra.Rows[i].Cells[0].Value.ToString().Trim();
            txtCT_HSM.Text = dataTra.Rows[i].Cells[1].Value.ToString().Trim();
            txtCT_NgayTra.Text = dataTra.Rows[i].Cells[2].Value.ToString().Trim();
            txtCT_NgayNP.Text = dataTra.Rows[i].Cells[3].Value.ToString().Trim();
            txtCT_MaTT.Text = dataTra.Rows[i].Cells[4].Value.ToString().Trim();
            txtCT_TongPhat.Text = dataTra.Rows[i].Cells[5].Value.ToString().Trim();
            txtCT_MaGT.Text = dataTra.Rows[i].Cells[6].Value.ToString().Trim();
            txtCT_VP.Text = dataTra.Rows[i].Cells[7].Value.ToString().Trim();
            txtCT_TP.Text = dataTra.Rows[i].Cells[8].Value.ToString().Trim();
        }

        private void txtCT_TongPhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTT_VP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTT_TP.Visible = true;
            if (txtTT_VP.Text == "Làm mất giáo trình") txtTT_TP.Text = "20000";
            if (txtTT_VP.Text == "Làm hỏng giáo trình") txtTT_TP.Text = "30000";
            if (txtTT_VP.Text == "Trả quá hạn") txtTT_TP.Text = "50000";
            if(txtTT_VP.Text != "")
            {
                danop.Visible = true;
                danop.Checked = true;
                chuanop.Visible = true;
            }
        }

        private void txtCT_VP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCT_VP.Text == "Làm mất giáo trình") txtCT_TP.Text = "20000";
            if (txtCT_VP.Text == "Làm hỏng giáo trình") txtCT_TP.Text = "30000";
            if (txtCT_VP.Text == "Trả quá hạn") txtCT_TP.Text = "50000";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GuiTraGT_Load(sender, e);
        }

        private void txtTT_MaHSM_TextChanged(object sender, EventArgs e)
        {
            if (txtTT_MaHSM.Text.Length > 0) errTTHSM.Visible = false;
        }

        private void txtTT_MaTT_TextChanged(object sender, EventArgs e)
        {
            if (txtTT_MaTT.Text.Length > 0) errTTMaTT.Visible = false;
        }

        private void txtTT_GT_TextChanged(object sender, EventArgs e)
        {
            if (txtTT_GT.Text.Length > 0) errTTMaGT.Visible = false;
        }

        private void txtTT_MaHSM_MouseClick(object sender, MouseEventArgs e)
        {
            txtTT_MaHSM.ResetText();
        }

        private void txtTT_MaTT_MouseClick(object sender, MouseEventArgs e)
        {
            txtTT_MaTT.ResetText();
        }

        private void txtTT_GT_MouseClick(object sender, MouseEventArgs e)
        {
            txtTT_GT.ResetText();
        }
    }
}
