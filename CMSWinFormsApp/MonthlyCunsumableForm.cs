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
    public partial class MonthlyCunsumableForm : Form
    {
        public MonthlyCunsumableForm()
        {
            InitializeComponent();
        }

        private ReportViewer GetReportViewer1()
        {
            return reportViewer1;
        }

        private void MonthlyCunsumableForm_Load(object sender, EventArgs e, ReportViewer reportViewer1)
        {

            //write code for data
            DataTable dt = GetCunsumableData();
            ReportDataSource rds = new ReportDataSource("jobDetailsDataSet",dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private DataTable GetCunsumableData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=CHOPIN;Initial Catalog=CMSDB;Integrated Security=True"))
            {
                string sql = "SELECT FORMAT(JobDate, 'MM/yyyy') AS JobDate,SUM(Tires) AS Tires, SUM(Weights) AS Weights,SUM(OilChanged) AS OilChanged,SUM(OilFilter) AS OilFilter,SUM(GearOil) AS GearOil ,SUM(Point) as Point,SUM(Condenser) as Condenser,SUM(Plug) as Plug,SUM(FuelFilter) as FuelFilter,SUM(AirFilter) as AirFilter FROM tblJobDetails WHERE JobDate >= DATEFROMPARTS(YEAR(GETDATE()), 1, 1) AND  JobDate<DATEADD(YEAR, 1, DATEFROMPARTS(YEAR(GETDATE()), 1, 1)) GROUP BY FORMAT(JobDate, 'MM/yyyy') ORDER BY JobDate";
                //find sql.txt
                SqlDataAdapter da = new SqlDataAdapter(sql,conn);
                da.Fill(dt);
            }
            return dt;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void MonthlyCunsumableForm_Load(object sender, EventArgs e)
        {
            DataTable dt = GetCunsumableData();
            ReportDataSource rds = new ReportDataSource("jobDetailsDataSet",dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
