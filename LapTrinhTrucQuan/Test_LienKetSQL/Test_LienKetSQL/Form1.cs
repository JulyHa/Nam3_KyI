using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace Test_LienKetSQL
{
    public partial class Form1 : Form
    {
        SqlConnection lk = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenCon()
        {
            lk = new SqlConnection(@"Data Source=DESKTOP-4ARR1L0\NGU;Initial Catalog=TEST_Sql;Integrated Security=True");
            if (lk.State == ConnectionState.Closed)
            {
                lk.Open();
            }
        }
        private void CloseCon()
        {
            if (lk.State == ConnectionState.Open)
            {
                lk.Close();
                lk.Dispose(); //giải phóng bộ nhớ
                lk = null;
            }
        }
        private Boolean Exe(string cmd)
        {
            OpenCon();
            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, lk);
                sc.ExecuteNonQuery();
                sc.Dispose();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }

            CloseCon();
            return check;
        }
        private DataTable Red(string cmd)
        {
            OpenCon();
            System.Data.DataTable check = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, lk);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(check);
                sc.Dispose();
            }
            catch (Exception)
            {
                check = null;
            }
            CloseCon();
            return check;
        }
        private void load()
        {
            DataTable dt = Red("Select * from Diem");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            dataGridView1.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không cho sửa dữ liệu trực tiếp
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Exe("UPDATE Diem SET MaMOn = N'" + btnMaMon.Text + "', TenMon =  N'" + btnTenMon.Text + "', SoTin= N'" + btnST.Text + "', DiemThi= N'" + btnDT.Text + "' Where MaMon = N'" + btnMaMon.Text + "'");
            //load();
            DataTable datatable = new DataTable();
            List<string> list = new List<string>();
            datatable = Red("Select * from Diem");
            foreach (DataRow item in datatable.Rows)
            {
                string x = item["MaMon"].ToString();
                list.Add(x);
            }
            foreach(string x in list)
            {
                MessageBox.Show(x);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if (rs == DialogResult.OK) this.Close();
        }
        bool check(ref String mess)
        {
            bool c = true; int n; float diem;
            if (btnMaMon.Text == "")
            {
                mess = "Chua nhap ma\n";
                c = false;
            }
            if (btnTenMon.Text == "")
            {
                mess += "Chua nhap Ten\n";
                c = false;
            }
            if (btnST.Text == "" || int.TryParse(btnST.Text, out n) == false || n < 0)
            {
                mess += "So tin phai la so > 0\n";
                c = false;
            }
            if (btnDT.Text == "" || float.TryParse(btnDT.Text, out diem) == false || diem < 0)
            {
                mess += "Diem thi phai > 0\n";
                c = false;
            }
            return c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String mess = "";
            if (check(ref mess) == false)
            {
                MessageBox.Show(mess);
                return;
            }
            Exe("INSERT INTO Diem (MaMon,TenMon, SoTin, DiemThi) VALUES ( N'" + btnMaMon.Text + "', N'" + btnTenMon.Text + "', N'" + btnST.Text + "', N'" + btnDT.Text + "')");
            load();
            btnMaMon.Text = "";
            btnTenMon.Text = "";
            btnST.Text = "";
            btnDT.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("Select * from Diem Where MaMon = N'" + btnMaMon.Text + "'");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            dataGridView1.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không cho sửa dữ liệu trực tiếp
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnMaMon.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            btnTenMon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            btnST.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            btnDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
        private void XuatExcel(DataGridView g, string s, string name)
        {
            app obj = new app();
            if (obj == null)
            {
                MessageBox.Show("Khong the su dung thu vien Excarl");
                return;
            }
            Workbook wb = obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i <= g.Columns.Count; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
                obj.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter; // căn chữ giữa
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            ////Lưu file excel xuống Ổ cứng
            obj.ActiveWorkbook.SaveCopyAs(s + name + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

            //đóng file để hoàn tất quá trình lưu trữ
            wb.Close(true, Type.Missing, Type.Missing);

            //thoát và thu hồi bộ nhớ cho COM
            obj.Quit();
            releaseObject(wb);
            releaseObject(obj);

            //Mở File excel sau khi Xuất thành công
            System.Diagnostics.Process.Start(s+name+ ".xlsx");

        }
        private void button4_Click(object sender, EventArgs e)
        {
            XuatExcel(dataGridView1, @"D:\", "fileexcel");
        }
    }
}
