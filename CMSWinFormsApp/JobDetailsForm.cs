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

namespace CMSWinFormsApp
{
    public partial class JobDetailsForm : Form
    {
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private DataSet jobDetailsDataSet;
        private BindingSource bindingSource;
 

        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtCarNo_Leave(object sender, EventArgs e)
        {
            if ((txtCarNo.Text == "") || (txtCarNo.Text == null)){
                MessageBox.Show("Please Specify a Valid Car Number");
                txtCarNo.Focus();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try { 
            if (txtCarNo.Text.Length < 6)
            {
                MessageBox.Show("Please Specify a Valid Car Number");
                txtCarNo.Focus();
                return;
            }
            if (Convert.ToInt32(txtWorkerId.Text) < 1)
            {
                MessageBox.Show("Please Specify a Valid Worker Id");
                txtWorkerId.Focus();
                return;
            }
            if (Convert.ToDateTime(dateTimePicker1.Text) > DateTime.Today)
            {
                MessageBox.Show("Please Specify a Valid Date");
                    dateTimePicker1.Focus();
                return;
                }

                //update record
                bindingSource.EndEdit();
                adapter.Update(jobDetailsDataSet, "tblJobDetails");
                MessageBox.Show("Record Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :"+ex.Message);
            }

            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//close
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void UpdatePositionLabel()
        {
            if(bindingSource.Count > 0) {
                textPosition.Text = $"{bindingSource.Position + 1}  of  {bindingSource.Count}";
            }
            else
            {
                textPosition.Text = "0 of 0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                bindingSource.MovePrevious();
                UpdatePositionLabel();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.MoveNext();
                UpdatePositionLabel();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource.MoveFirst();
            UpdatePositionLabel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource.MoveLast();
            UpdatePositionLabel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=CHOPIN;Initial Catalog=CMSDB;Integrated Security=True");
            adapter = new SqlDataAdapter("Select * from tblJobDetails", con);
            jobDetailsDataSet = new DataSet();
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(jobDetailsDataSet, "tblJobDetails");

            bindingSource = new BindingSource { DataSource = jobDetailsDataSet.Tables["tblJobDetails"] };
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txt && txt.Name.StartsWith("txt"))
                {
                    txt.DataBindings.Clear();
                    String columnName = txt.Name.Substring(3);
                    txt.DataBindings.Add("Text", bindingSource, columnName);
                }
            }
            UpdatePositionLabel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(bindingSource == null)
            {
                bindingSource = new BindingSource();
            }

            if(bindingSource.DataSource == null)
            {
                MessageBox.Show("Data source is empty.Load data first.");
                return;
            }
            bindingSource.DataSource = jobDetailsDataSet.Tables["tblJobDetails"];
            bindingSource.AddNew();
            UpdatePositionLabel();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(bindingSource.Count > 0)
            {
                bindingSource.RemoveCurrent();
                adapter.Update(jobDetailsDataSet, "tblJobDetails");
                MessageBox.Show("Record Deleted Successfully!");
                UpdatePositionLabel();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bindingSource.CancelEdit();
            UpdatePositionLabel() ;
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            jobDetailsDataSet.RejectChanges();
            UpdatePositionLabel();
        }
    }

    }
