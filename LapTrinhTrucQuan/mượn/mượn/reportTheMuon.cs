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


namespace mượn
{
    public partial class reportTheMuon : Form
    {
        public reportTheMuon()
        {
            InitializeComponent();
        }
        TheMuon_DAO themuon_DAO = new TheMuon_DAO();
        private void reportTheMuon_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer2.LocalReport.ReportEmbeddedResource = "mượn.ReportTheMuon.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = themuon_DAO.loadTheMuon();
                reportViewer2.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer2.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer2.RefreshReport();
        }
    }
}
