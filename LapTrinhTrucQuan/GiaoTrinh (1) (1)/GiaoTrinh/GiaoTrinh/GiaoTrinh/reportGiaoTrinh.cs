using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GiaoTrinh
{
    public partial class reportGiaoTrinh : Form
    {
        public reportGiaoTrinh()
        {
            InitializeComponent();
        }
        GiaoTrinh_LUD giaoTrinh_LUD = new GiaoTrinh_LUD();
        private void reportGiaoTrinh_Load(object sender, EventArgs e)
        {

            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "DMGiaoTrinh.Report1.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = giaoTrinh_LUD.loadDMGiaoTrinh();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // this.reportViewer1.RefreshReport();
        }
           
    }
}
