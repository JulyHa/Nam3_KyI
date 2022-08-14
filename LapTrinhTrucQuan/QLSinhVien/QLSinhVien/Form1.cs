using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace QLSinhVien
{
    public partial class Form1 : Form
    {
        LkData lk = new LkData();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }
        public DataTable load()
        {
            DataTable dt = lk.Red("Select * from SV");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            dataGridView1.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //không cho sửa dữ liệu trực tiếp

            return dt;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMSV.Text = "";
            txtMSV.Focus();            
            txtHoTen.Text = "";
            txtKhoa.Text = "";
            txtLop.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                this.Close();
            }
        }     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Value =(DateTime)dataGridView1.CurrentRow.Cells[2].Value;
            txtKhoa.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtLop.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtMSV.ReadOnly = true;
            lk.Exe("UPDATE SV SET HoTen =  N'" + txtHoTen.Text + "',NS = N'"+dtpNgaySinh.Text+"' ,Khoa= N'" + txtKhoa.Text + "', Lop= N'" + txtLop.Text + "', DiaChi= N'" + txtDiaChi.Text + "' Where MaSV = N'" + txtMSV.Text + "'");
            load();
            txtMSV.ReadOnly = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lk.Exe("DELETE from SV Where MaSV = N'" + txtMSV.Text + "'" );
            load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            lk.Exe("INSERT INTO SV VaLues (N'" + txtMSV.Text + "', N'" + txtHoTen.Text + "',N'" + dtpNgaySinh.Text + "',N'" + txtKhoa.Text + "',N'" + txtLop.Text + "', N'" + txtDiaChi.Text + "') ");
            load();
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
                MessageBox.Show("Không thể sử dụng thư viện Excarl");
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
            //System.Diagnostics.Process.Start(s + name + ".xlsx");

        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            XuatExcel(dataGridView1, @"D:\", "fileexcel");
            FormBaoCao fbc = new FormBaoCao();
            fbc.ShowDialog();
        }
    }
}
