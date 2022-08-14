using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BTLTimGT
{
    public partial class Form1 : Form
    {

        SqlConnection conn;
        SqlCommand comm;
        string str = @"Data Source=DESKTOP-4ARR1L0\NGU;Initial Catalog=DataLTTQ;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable dt;

        void loaddata()
        {
            comm = conn.CreateCommand();
            comm.CommandText = "select *from DMGiaoTrinh";
            adapter.SelectCommand = comm;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // bắt đầu tìm
               
               if (radioButton1.Checked == true)
                {

                    var table = this.textBox1.Text;
                    string sqlSELECT = $"select * from DMGiaoTrinh where TenGT = N'{table}'";
                    SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
               if(radioButton2.Checked== true)
                {
                    var table = this.textBox1.Text;
                    string sql = $"select * from TacGia where TenTG = N'{table}'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;

                }
                if (radioButton3.Checked == true)
                {
                    var table = this.textBox1.Text;
                    string sql = $"select * from ChuyenNganh where TenChuyenNganh = N'{table}'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;

                }
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string sqlSELECT = "select *from ChuyenNganh";

            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string sqlSELECT = "select *from TacGia";

            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            string sqlSELECT = "select *from DMGiaoTrinh";

            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
