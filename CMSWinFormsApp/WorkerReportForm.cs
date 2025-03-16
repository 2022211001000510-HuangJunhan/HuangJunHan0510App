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
using Microsoft.Reporting.WinForms;

namespace CMSWinFormsApp
{
    public partial class WorkerReportForm : Form
    {
        public WorkerReportForm()
        {
            InitializeComponent();
        }

        private void WorkerReportForm_Load(object sender, EventArgs e)
        {
            DataTable dt = GetCunsumableData();
            ReportDataSource rds = new ReportDataSource("jobDetailsDataSet", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

        private DataTable GetCunsumableData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=CHOPIN;Initial Catalog=CMSDB;Integrated Security=True"))
            {
                string sql = "SELECT  w.Name AS WorkerName,w.WorkerID, YEAR(j.JobDate) AS JobYear,MONTH(j.JobDate) AS JobMonth,COUNT(*) AS JobCount FROM tblJobDetails JOIN tblWorker w ON j.WorkerID = w.WorkerID WHERE j.JobDate BETWEEN DATEFROMPARTS(YEAR(GETDATE()), 1, 1) AND GETDATE() GROUP BY w.Name,w.WorkerID,YEAR(j.JobDate), MONTH(j.JobDate) ORDER BY JobYear, JobMonth, w.Name";
                //find sql.txt
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
