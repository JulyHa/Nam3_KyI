using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB
{
    public partial class Form1 : Form
    {
        dataclb Dataclb = new dataclb();
        Dictionary<string, int> GV = new Dictionary<string, int>() { { "MANCHESTER", 10 }, { "PARISSG", 12 },{ "REALMADRIT", 10 }, { "BENFICA", 7 }, { "ACMILAN", 12 }, { "BARCELONA", 10 },
        { "B.MUNICH", 10 }, { "JUVENTUS", 11 }};
        public Form1()
        {
            InitializeComponent();
        }
        private void load()
        {
            DataTable dt = Dataclb.Red("Select * from CLB");
            if (dt != null)
            {
                dataCLB.DataSource = dt;
            }
            dataCLB.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataCLB.EditMode = DataGridViewEditMode.EditProgrammatically; //không cho sửa dữ liệu trực tiếp
        }
        private void reset()
        {
            Tenclb.ResetText();
            Tennuoc.ResetText();
            sl.ResetText();
            giave.ResetText();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult rs= MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes) Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
            Tenclb.Items.Add("MANCHESTER");
            Tenclb.Items.Add("PARISSG");
            Tenclb.Items.Add("REALMADRIT");
            Tenclb.Items.Add("BENFICA");
            Tenclb.Items.Add("ACMILAN");
            Tenclb.Items.Add("BARCELONA");
            Tenclb.Items.Add("B.MUNICH");
            Tenclb.Items.Add("JUVENTUS");
            giave.ReadOnly = true;
            button2.Enabled = false;
            button3.Enabled = false;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tenclb.Text = dataCLB.CurrentRow.Cells[0].Value.ToString().Trim();
            Tennuoc.Text = dataCLB.CurrentRow.Cells[1].Value.ToString().Trim();
            sl.Text = dataCLB.CurrentRow.Cells[2].Value.ToString().Trim();
            giave.Text = GV[Tenclb.Text].ToString().Trim();
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void Tenclb_SelectedIndexChanged(object sender, EventArgs e)
        {
            giave.Text = GV[Tenclb.Text].ToString();
        }

        private bool check() 
        {
            errtenclb.Clear();
            errtennuoc.Clear();
            errsl.Clear();
            bool c = true;
            if(Tenclb.Text == "")
            {
                errtenclb.SetError(Tenclb, "Bạn chưa chọn clb!");
                c = false;
            }
            if(Tennuoc.Text == "")
            {
                errtennuoc.SetError(Tennuoc, "Bạn không được để trống tên nước!");
                c = false;
            }
            if(sl.Value == 0)
            {
                errsl.SetError(sl, "Số lượng phải lớn hơn 0!");
                c = false;
            }
            return c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (check() == false) return;
            Dataclb.Exe("insert into CLB values (N'" + Tenclb.Text + "', N'" + Tennuoc.Text + "',N'" + sl.Text + "', N'" + giave.Text + "')");
            load();
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dataclb.Exe("UPDATE CLB SET TenCLB = N'" + Tenclb.Text + "', TenNuoc =  N'" + Tennuoc.Text + "', Soluong= N'" + sl.Text + "', GiaVe= N'" + giave.Text + "' Where TenCLB = N'" + Tenclb.Text + "'");
            load();
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dataclb.Exe("Delete from CLB where TenCLB = N'" + Tenclb.Text + "'");
            load();
            reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = Dataclb.Red("Select * from CLB where Tenclb = '"+Tenclb.Text+"'");
            if (dt != null)
            {
                dataCLB.DataSource = dt;
            }
            dataCLB.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataCLB.EditMode = DataGridViewEditMode.EditProgrammatically; //không cho sửa dữ liệu trực tiếp
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
