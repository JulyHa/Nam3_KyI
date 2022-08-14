using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuaChoTrang
{
    public partial class Form1 : Form
    {
        List<NhanVien> nv = new List<NhanVien>();
        LienKet lk = new LienKet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cv.Items.Add("Ke toan");
            cv.Items.Add("Thu Ngan");
            cv.Items.Add("Bao ve");
            them.Enabled = true;
            Xoa.Enabled = false;
            Sua.Enabled = false;
            load();

        }
        private void load()
        {
            MaNV.Text = ""; MaNV.Focus();
            TenNV.Text = "";
            sdt.Text = "";
            nam.Checked = false;
            nu.Checked= false;
            cv.Text = "";
            ml.Text = "";

            DataTable dt = lk.Red("Select * from NhanVien");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            dataGridView1.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không cho sửa dữ liệu trực tiếp
        }
        private void sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Ban co muon thoat", "Thong bao", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes) Application.Exit();
        }
        private bool check(ref string mess)
        {
            bool c = true;
            if(MaNV.Text == "")
            {
                mess += "Ban chua nhap ma nv\n";
                c = false;
            }
            if(TenNV.Text == "")
            {
                mess += "Ban chua nhap ten nv\n";
                c = false;
            }
            if(nam.Checked == false && nu.Checked == false)
            {
                mess += "Ban chua chon gt\n";
                c = false;
            }
            if(cv.Text == "")
            {
                mess += "Ban chua nhap cv\n";
                c = false;
            }
            if (ml.Text == "")
            {
                mess += "Ban chua nhap muc luong\n";
                c = false;
            }
            return c;

        }
        private void them_Click(object sender, EventArgs e)
        {
            string mess = "";
            if(check(ref mess) == false)
            {
                MessageBox.Show(mess, "Loi", MessageBoxButtons.OK);
                return;
            }
            DataTable dt= lk.Red("select manv from NhanVien where manv = '"+ MaNV.Text +"'");
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Da ton tai");
            }
            else
            {
                lk.Exe("insert into NhanVien values(N'" + MaNV.Text + "',N'" + TenNV.Text + "',N'" + sdt.Text + "',N'" + (nam.Checked == true ? "nam" : "nu") + "',N'" + cv.Text + "'," + Int32.Parse(ml.Text) + ")");
                load();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TenNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sdt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string gih = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (gih == "nam") nam.Checked = true;
            else nu.Checked = true;

            cv.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ml.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Xoa.Enabled = true;
            Sua.Enabled = true;
            them.Enabled = false;
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            lk.Exe("update NhanVien set manv = N'" + MaNV.Text + "',tennv = N'" + TenNV.Text + "',sdt = N'" + sdt.Text + "',gt = N'" + (nam.Checked == true ? "nam" : "nu") + "',cv = N'" + cv.Text + "',ml = " + Int32.Parse(ml.Text) +" where manv = N'"+MaNV.Text+"'" );
            Form1_Load(sender, e);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Ban co muon xoa", "thong bao", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                lk.Exe("delete from NhanVien where manv = N'" + MaNV.Text + "'");
                Form1_Load(sender, e);
            }
            
        }
    }
}
