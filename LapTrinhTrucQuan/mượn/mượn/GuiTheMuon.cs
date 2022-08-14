using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mượn
{
    public partial class GuiTheMuon : Form
    {
        TheMuon_BUS themuon_BUS = new TheMuon_BUS();
        TheMuon_DTO themuon_DTO = new TheMuon_DTO();
        public GuiTheMuon()
        {
            InitializeComponent();
        }

        private void GuiTheMuon_Load(object sender, EventArgs e)
        {
            btnthem.Cursor = Cursors.Hand;
            btnxoa.Cursor = Cursors.No;
            btnsua.Cursor = Cursors.No;
            label2.Text = "Thêm thẻ";
            resetTxt();
            resetErr();
            txtMaThe.Visible = false;
            txtKhoaThe.Visible = false;
            txtSoLuongMuon.Visible = false;

            label3.Location = new Point(3, 286);
            label4.Location = new Point(9, 362);
            txtMaKhoa.Location = new Point(66, 283);
            txtMaLop.Location = new Point(64, 359);
            txtTen.Location = new Point(11, 96);
            txtGioiTinh.Location = new Point(11, 191);
            errHT.Location = new Point(179, 104);
            errGT.Location = new Point(181, 200);

            dataGridView1.DataSource = themuon_BUS.GetListTheMuon();
            dataGridView1.Columns[0].HeaderText = "Mã thẻ";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Tên lớp";
            dataGridView1.Columns[4].HeaderText = "Tên khoa";
            dataGridView1.Columns[5].HeaderText = "Khóa thẻ";
            dataGridView1.Columns[6].HeaderText = "Số lượng mượn";

            getKHOA();
        }
        void getKHOA()
        {
            DataTable data = themuon_BUS.GetKhoa();
            int n = data.Rows.Count;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (!txtMaKhoa.Items.Contains(data.Rows[i]["TenKhoa"]))
                    {
                        txtMaKhoa.Items.Add(data.Rows[i]["TenKhoa"]);
                    }
                }
            }
            txtMaKhoa.Text = txtMaKhoa.Items[0].ToString();
        }
        void resetTxt()
        {
            txtMaThe.Text = "Mã thẻ";
            txtTen.Text = "Họ tên";
            txtGioiTinh.Text = "Giới tính";
            txtKhoaThe.Text = "Khóa thẻ";
            txtSoLuongMuon.Text = "Số lượng mượn";
        }
        void resetErr()
        {
            errHT.Visible = false;
            errGT.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GuiTheMuon_Load(sender, e);
            check = true;
            txtMaKhoa_SelectedIndexChanged(sender, e);
        }
        bool check = true;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = "Thông tin";
            btnxoa.Cursor = Cursors.Hand;
            btnsua.Cursor = Cursors.Hand;
            btnthem.Cursor = Cursors.No;
            check = false;
            txtMaThe.Visible = true;
            txtKhoaThe.Visible = true;
            txtSoLuongMuon.Visible = true;


            label3.Location = new Point(2, 245);
            label4.Location = new Point(10, 295);
            txtMaKhoa.Location = new Point(65, 242);
            txtMaLop.Location = new Point(65, 292);
            txtTen.Location = new Point(11, 117);
            txtGioiTinh.Location = new Point(11, 184);
            errHT.Location = new Point(179, 125);
            errGT.Location = new Point(181, 193);

            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaThe.Text = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
            txtTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
            txtGioiTinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
            txtMaLop.Text = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
            txtMaKhoa.Text = dataGridView1.Rows[i].Cells[4].Value.ToString().Trim();
            txtKhoaThe.Text = dataGridView1.Rows[i].Cells[5].Value.ToString().Trim();
            txtSoLuongMuon.Text = dataGridView1.Rows[i].Cells[6].Value.ToString().Trim();
        }

        private void txtMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == true) txtMaLop.ResetText();
            string s = txtMaKhoa.Text;
            DataTable data = themuon_BUS.getLop(s);
            int n = data.Rows.Count;
            txtMaLop.Items.Clear();
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (!txtMaLop.Items.Contains(data.Rows[i]["TenLop"]))
                    {
                        txtMaLop.Items.Add(data.Rows[i]["TenLop"]);
                    }
                }
            }
            if (check == true) txtMaLop.Text = txtMaLop.Items[0].ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            reportTheMuon reportTheMuon = new reportTheMuon();
            reportTheMuon.ShowDialog();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (btnxoa.Cursor == Cursors.No) return;
            string s = txtMaThe.Text;
            DialogResult rs = MessageBox.Show("Bạn có chắc sẽ xóa thẻ có mã " + s + " không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.No) return;
            themuon_BUS.Xoa(s);
            GuiTheMuon_Load(sender, e);
            MessageBox.Show("Bạn đã xóa thành công mã " + s + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnthem.Cursor = Cursors.Hand;
            btnxoa.Cursor = Cursors.No;
            btnsua.Cursor = Cursors.No;
            label2.Text = "Thêm thẻ";
            resetTxt();
            resetErr();

            dataGridView1.DataSource = themuon_BUS.TimKiem(txtTK.Text);
            dataGridView1.Columns[0].HeaderText = "Mã thẻ";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Tên lớp";
            dataGridView1.Columns[4].HeaderText = "Tên khoa";
            dataGridView1.Columns[5].HeaderText = "Khóa thẻ";
            dataGridView1.Columns[6].HeaderText = "Số lượng mượn";

            getKHOA();
        }

        private void txtTK_MouseClick(object sender, MouseEventArgs e)
        {
            txtTK.ResetText();
        }

        bool checkTT()
        {
            bool ok = true;
            if (txtTen.Text == "" || txtTen.Text == "Họ tên")
            {
                errHT.Visible = true;
                ok = false;
            }
            if (txtGioiTinh.Text == "" || txtGioiTinh.Text == "Giới tính")
            {
                errGT.Visible = true;
                ok = false;
            }
            return ok;
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btnsua.Cursor == Cursors.No || checkTT() == false) return;
            string makhoa = themuon_BUS.GetMaKhoa(txtMaKhoa.Text);
            string malop = themuon_BUS.GetMaLop(txtMaLop.Text);
            string s = txtMaThe.Text;
            TheMuon_DTO x = new TheMuon_DTO(s, txtTen.Text, txtGioiTinh.Text, malop, makhoa, txtKhoaThe.Text,Int32.Parse(txtSoLuongMuon.Text));
            themuon_BUS.Sua(x);
            GuiTheMuon_Load(sender, e);
            MessageBox.Show("Bạn đã sưa thẻ có mã "+s+" thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (btnthem.Cursor == Cursors.No || checkTT() == false) return;
            string s = "";
            while (true)
            {
                Random rdm = new Random();
                s = "T" + rdm.Next(0, 999).ToString();
                if (themuon_BUS.GetMaThe(s) == null) break;
            }
            string makhoa = themuon_BUS.GetMaKhoa(txtMaKhoa.Text);
            string malop = themuon_BUS.GetMaLop(txtMaLop.Text);
            TheMuon_DTO x = new TheMuon_DTO(s, txtTen.Text, txtGioiTinh.Text, malop, makhoa, "Không", 0);
            themuon_BUS.Them(x);
            GuiTheMuon_Load(sender, e);
            MessageBox.Show("Bạn đã thêm thẻ mới thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
