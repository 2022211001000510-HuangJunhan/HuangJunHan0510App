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
    public partial class CustomerForm : Form
    {
        private SqlConnection con;
        SqlDataAdapter adapter;
        DataSet customerDataSet;
        BindingSource bindingSource;

  

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMake_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.Position += 1;
            }
            UpdatePosition();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=CHOPIN;Initial Catalog=CMSDB;Integrated Security=True");
            adapter = new SqlDataAdapter("Select * from tblCustomer",con);
            customerDataSet = new DataSet();
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(customerDataSet,"tblCustomer");

            bindingSource = new BindingSource();
            bindingSource.DataSource = customerDataSet;
            bindingSource.DataMember = "tblCustomer";

            txtCarNo.DataBindings.Add("Text", bindingSource, "CarNo");
            txtName.DataBindings.Add("Text",bindingSource, "Name");
            txtAddress.DataBindings.Add("Text", bindingSource, "address");
            txtMake.DataBindings.Add("Text", bindingSource, "make");

            UpdatePosition();
            
            errCustForm.SetError(txtCarNo, "");
            errCustForm.SetError(txtAddress, "");
            errCustForm.SetError(txtName, "");
            errCustForm.SetError(txtMake, "");
        }

        private void UpdatePosition()
        {
            lblPosition.Text = $"{bindingSource.Position + 1} of {bindingSource.Count}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { 
            bindingSource.EndEdit();
            adapter.Update(customerDataSet, "tblCustomer");
            MessageBox.Show("Record Saved Successfully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            bool flag = true;
            if (txtCarNo.Text == "")
            {
                errCustForm.SetError(txtCarNo, "Please specify a valid Car Number.");
                flag = false;
            }
            else
                errCustForm.SetError(txtCarNo, "");
            if (txtAddress.Text == "")
            {
                errCustForm.SetError(txtAddress, "Please specify a valid Name.");
                flag = false;
            }
            else
                errCustForm.SetError(txtAddress, "");
            if(txtName.Text == "")
            {
                errCustForm.SetError(txtName, "Please specify a valid Address.");
                flag = false;
            }
            else
                errCustForm.SetError(txtName, "");
            if (txtMake.Text == "")
            {
                errCustForm.SetError(txtMake, "Please specify a valid Makes.");
                flag = false;
            }
            else
                errCustForm.SetError(txtMake, "");
            if ((false == false))
                return;
            else
            {
                //database code - later
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void textCarNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(bindingSource.Position > 0)
            {
                bindingSource.Position -= 1;
            }
            UpdatePosition();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataRow newRow = customerDataSet.Tables["tblCustomer"].NewRow();
            newRow["CarNo"] = "";
            newRow["name"] = "";
            newRow["address"] = "";
            newRow["make"] = "";

            customerDataSet.Tables["tblCustomer"].Rows.Add(newRow);

            bindingSource.Position=bindingSource.Count-1;
            txtCarNo.ReadOnly = false;
            txtName.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtMake.ReadOnly = false;

            UpdatePosition();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCarNo.ReadOnly=false;
            txtName.ReadOnly=false;
            txtAddress.ReadOnly=false;
            txtMake.ReadOnly=false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bindingSource.CancelEdit();
        }
    }
}
