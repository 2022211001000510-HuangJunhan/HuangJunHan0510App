using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_Check(object sender, EventArgs e)
        {
            MonthlyCunsumableForm monthlyCunsumableForm = new MonthlyCunsumableForm();
            monthlyCunsumableForm.ShowDialog();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            MonthlyCustomerForm monthlyCustomerReportForm = new MonthlyCustomerForm();
            monthlyCustomerReportForm.ShowDialog();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            WorkerAlignBalanceReport f = new WorkerAlignBalanceReport();
            f.ShowDialog();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            WorkerReportForm f = new WorkerReportForm();
            f.ShowDialog();
        }
    }
}
