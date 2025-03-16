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
    public partial class MonthlyCustomerForm : Form
    {
        public MonthlyCustomerForm()
        {
            InitializeComponent();
        }

        private void MonthlyCustomerForm_Load(object sender, EventArgs e)
        {
            //write code for data
            DataTable dt = GetCunsumableData();
            ReportDataSource rds = new ReportDataSource("CustomerJobDataSet", dt);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

        private DataTable GetCunsumableData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=CHOPIN;Initial Catalog=CMSDB;Integrated Security=True"))
            {
                string sql = "SELECT c.CarNo,c.Name,c.Address,c.Make,YEAR(j.JobDate) AS JobYear,MONTH(j.JobDate) AS JobMonth,COUNT(j.JobDate) AS JobCount FROM dbo.tblCustomer c LEFT JOIN dbo.tblJobDetails j ON c.CarNo = j.CarNo AND j.JobDate BETWEEN DATEFROMPARTS(YEAR(GETDATE()), 1, 1) AND GETDATE() GROUP BY c.CarNo, c.Name, c.Address, c.Make, YEAR(j.JobDate), MONTH(j.JobDate) ORDER BY JobYear DESC, JobMonth DESC, JobCount DESC";
                //find sql.txt
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
