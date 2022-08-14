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

namespace QLSinhVien
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }
        Form1 lk = new Form1();
        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer2.LocalReport.ReportEmbeddedResource = "QLSinhVien.Report1.rdlc";
                ReportDataSource rpdt = new ReportDataSource();
                rpdt.Name = "DataSet1";
                rpdt.Value = lk.load();
                reportViewer2.LocalReport.DataSources.Add(rpdt);
                this.reportViewer2.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
