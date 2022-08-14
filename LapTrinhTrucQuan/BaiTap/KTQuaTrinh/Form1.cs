using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTQuaTrinh
{
    public partial class Form1 : Form
    {
        TruyVansql truyvan = new TruyVansql();
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void load()
        {
            DataTable dt = truyvan.Red("Select * from NhanVien");
            if (dt != null)
            {
                dataNV.DataSource = dt;
            }
            dataNV.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataNV.EditMode = DataGridViewEditMode.EditProgrammatically; //không cho sửa dữ liệu trực tiếp
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
            bhtn.ReadOnly = true;
            bhyt.ReadOnly = true;
            bhxh.ReadOnly = true;
            thuclinh.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                truyvan.Exe("Delete from NhanVien where MaNV = N'" + maNV.Text + "'");
                load();
            }
            
        }
        void tinh()
        {
            bhtn.Text = (int.Parse(hsl.Text) * 0.01).ToString();
            bhyt.Text = (int.Parse(hsl.Text) * 0.05).ToString();
            bhxh.Text = (int.Parse(hsl.Text) * 0.1).ToString();
            thuclinh.Text = (int.Parse(hsl.Text) - int.Parse(bhtn.Text) - int.Parse(bhyt.Text) - int.Parse(bhxh.Text)).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tinh();
            truyvan.Exe("UPDATE NhanVien SET TenNV = N'" + tenNV.Text + "', phong =  N'" + phong.Text + "', ngayHD= N'" + hopdong.Text + "', HSL= N'" + hsl.Text + "'," +
                "BHTN = N'"+bhtn.Text+"', BHYT = N'"+bhyt.Text+"', BHXH = N'"+bhxh.Text+"', ThucLinh = "+thuclinh.Text+" Where MaNV = N'" + maNV.Text + "'");
            load();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            truyvan.Exe("insert into NhanVien VALUES ('"+maNV.Text+"',N'" + tenNV.Text + "', '" + phong.Text + "', '" + hopdong.Text + "', '" + hsl.Text + "', " +
                "'" + bhtn.Text + "', '" + bhyt.Text + "', '" + bhxh.Text + "', '" + thuclinh.Text + "')");
            load();
        }

        private void hsl_TextChanged(object sender, EventArgs e)
        {
            tinh();
            //bhtn.Text = (int.Parse(hsl.Text) * 0.01).ToString(); float a = 0;
            //bhyt.Text = (int.Parse(hsl.Text) * 0.05).ToString(); float b = 0; 
            //bhxh.Text = (int.Parse(hsl.Text) * 0.1).ToString(); float c = 0;
            //thuclinh.Text = (int.Parse(hsl.Text) - (int.Parse(bhtn.Text)) - (int.Parse(bhyt.Text)) - (int.Parse(bhxh.Text))).ToString();
        }

        private void dataNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maNV.Text = dataNV.CurrentRow.Cells[0].Value.ToString().Trim();
            tenNV.Text = dataNV.CurrentRow.Cells[1].Value.ToString().Trim();
            phong.Text = dataNV.CurrentRow.Cells[2].Value.ToString().Trim();
            hopdong.Text = dataNV.CurrentRow.Cells[3].Value.ToString().Trim();
            hsl.Text = dataNV.CurrentRow.Cells[4].Value.ToString().Trim();
            bhtn.Text = dataNV.CurrentRow.Cells[5].Value.ToString().Trim();
           bhyt.Text = dataNV.CurrentRow.Cells[6].Value.ToString().Trim();
            bhxh.Text = dataNV.CurrentRow.Cells[7].Value.ToString().Trim();
            thuclinh.Text = dataNV.CurrentRow.Cells[8].Value.ToString().Trim();

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = truyvan.Red("Select * from NhanVien where tenNV = N'"+tenNV.Text+"'");
            if (dt != null)
            {
                dataNV.DataSource = dt;
            }
            dataNV.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataNV.EditMode = DataGridViewEditMode.EditProgrammatically; //không cho sửa dữ liệu trực tiếp
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            load();
        }
    }
}
