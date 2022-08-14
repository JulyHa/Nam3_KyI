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
using Microsoft.Reporting.WinForms;

namespace BaoCao_HSM
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }
        static string strConnect = @"Data Source=DESKTOP-4ARR1L0\NGU;Initial Catalog=DataLTTQ;Integrated Security=True";
        SqlConnection sqlConnect= new SqlConnection(strConnect);
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adap;

        ReportDataSource rds;

        private void getDS_HSM(string sql)
        {
            sqlConnect.Open();
            cmd = new SqlCommand(sql, sqlConnect);
            cmd.ExecuteNonQuery();

            ds = new DataSet();
            adap = new SqlDataAdapter(cmd);
            adap.Fill(ds);
            sqlConnect.Close();

            //rptHSM.ProcessingMode = ProcessingMode.Local;
            rptHSM.LocalReport.ReportPath = "baocao_HSM_TheMuon.rdlc";

            rds = new ReportDataSource();
            rds.Name = "dsHSM";
            rds.Value = ds.Tables[0];

            rptHSM.LocalReport.DataSources.Clear();
            rptHSM.LocalReport.DataSources.Add(rds);
            rptHSM.RefreshReport();
        }
        private DataTable getMaTT(string sql)
        {
            sqlConnect.Open();
            System.Data.DataTable check = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(sql, sqlConnect);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(check);
                sc.Dispose();
            }
            catch (Exception)
            {
                check = null;
            }
            sqlConnect.Close();
            return check;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lbMaThe.Enabled = false;
            txtMaThe.Enabled = false;
            btnTao.Enabled = false;

            string truyvan = "select MaHSM, MaThe, MaThuThu, MaGT, SoLuong, NgayMuon, NgayPhaiTra from DS_HSM";
            getDS_HSM(truyvan);

            DataTable d = getMaTT("select MaThe from TheMuon");
            int n = d.Rows.Count;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (!txtMaThe.Items.Contains(d.Rows[i]["MaThe"].ToString()))
                    {
                        txtMaThe.Items.Add(d.Rows[i]["MaThe"]);
                    }
                }
                txtMaThe.SelectedIndex = 0;
            }

        }


        private void cmbBaoCaoTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTao.Enabled = true;
            if (cmbBaoCaoTheo.SelectedIndex == 0)
            {
                lbMaThe.Enabled = true;
                txtMaThe.Enabled = true;
            }
            else
            {
                lbMaThe.Enabled = false;
                txtMaThe.Enabled = false;
            }

        }


        private void btnTao_Click(object sender, EventArgs e)
        {
            if (cmbBaoCaoTheo.Text != "")
            {
                if (cmbBaoCaoTheo.SelectedIndex == 0)
                {
                    if (txtMaThe.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã thẻ!");
                    }
                    else
                    {
                        string truyvan1 = "select MaHSM, MaThe, MaThuThu, MaGT, SoLuong, NgayMuon, NgayPhaiTra from DS_HSM where MaThe = N'" + txtMaThe.Text + "'";
                        getDS_HSM(truyvan1);

  
                    }
                }
                else
                {
                    string truyvan2 = "select MaHSM, MaThe, MaThuThu, MaGT, SoLuong, NgayMuon, NgayPhaiTra from DS_HSM where ChuaTra=N'Chưa'";
                    getDS_HSM(truyvan2);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tạo báo cáo theo gì!");
            }
            
        }
    }
}
