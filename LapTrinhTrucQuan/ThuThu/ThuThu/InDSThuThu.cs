using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuThu
{
    public partial class InDSThuThu : Form
    {
        string kieu;
        public InDSThuThu(string s )
        {
            InitializeComponent();
            kieu = s;
        }
        ThuThu_DAO thuThu_DAO = new ThuThu_DAO();
        DataProvider data = new DataProvider();

        private void InDSThuThu_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    reportViewer2.LocalReport.ReportEmbeddedResource = "ThuThu.mauInDSThuThu.rdlc";
            //    ReportDataSource reportDataSource = new ReportDataSource();
            //    reportDataSource.Name = "DataSet1";
            //    reportDataSource.Value = thuThu_DAO.loadDSThuThu();
            //    reportViewer2.LocalReport.DataSources.Add(reportDataSource);
            //    this.reportViewer2.RefreshReport();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //this.reportViewer2.RefreshReport();
            if (kieu == "ThuThu") InThuThu();
            if (kieu == "GiaoTrinh") InGiaoTrinh();
        }
        void TT_DS(string s, string sql) {

            try
            {
                reportViewer2.LocalReport.ReportEmbeddedResource = s;
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = data.GetData(sql);
                reportViewer2.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer2.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InThuThu()
        {
            TT_DS("ThuThu.mauInDSThuThu.rdlc", "select * from DSThuThu");
        }
        public void InGiaoTrinh()
        {
            TT_DS("ThuThu.InDSGT.rdlc", "select * from viewGT");
        }
    }
}
