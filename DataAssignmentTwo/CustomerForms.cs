using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAssignmentTwo
{
    public partial class CustomerForms : Form
    {
        public Common common; 
        DataTable table;
        public CustomerForms()
        {
            InitializeComponent();
            
        }
        public CustomerForms(Common common)
        {
            InitializeComponent();
            this.common = common;
            btnDelete.Enabled = false;
            table = new DataTable();
            LoadDatabase();
        }

        private void LoadDatabase()
        {
            PopulateDataTableColumns();
            DataSet dataset = common.GetAllCustomer();
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                table.Rows.Add(row["customer_id"], row["name"],  row["address"], row["contact_no"]);
            }
            dgvCustomer.DataSource = table;
        }

        private void PopulateDataTableColumns()
        {
            table.Clear();
            try
            {
                table.Columns.Add("Customer ID");
                table.Columns.Add("Customer Name");
                table.Columns.Add("Address");
                table.Columns.Add("Contact No");
            }
            catch (Exception ex)
            {

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "";
            string name = textCustomerName.Text.Trim();
            string contact_no = textContactNo.Text.Trim();
            string address = textAddress.Text.Trim();
            if (Checks.checkEmpty(name) || Checks.checkEmpty(contact_no) || Checks.checkEmpty(address))
            {
                message = "Please Fill All Boxes";
            }
            else if (btnSave.Text.Contains("Add"))
            {
                if (common.AddCustomer(name, address, contact_no))
                {
                    message = "New Customer is Added";
                    LoadDatabase();
                }
                else
                {
                    message = "Customer Addition is Failed";
                }
            }
            else if (btnSave.Text.Contains("Update"))
            {
                string customer_id = textCustomerID.Text.Trim();
                if (Checks.checkNumber(customer_id))
                {
                    int cid = int.Parse(customer_id);
                    if (common.UpdateCustomer(cid, name, address, contact_no))
                    {
                        message = "Customer Record is Updated";
                        LoadDatabase();
                    }
                    else
                    {
                        message = " Customer Update is Failed";
                    }
                    textCustomerID.Text = textCustomerName.Text = textContactNo.Text = textAddress.Text = "";
                    btnSave.Text = "Add New Customer";
                    btnDelete.Enabled = false;
                }
                else
                {
                    message = "Invalid Customer ID";
                }

            }
            else
            {
                message = "Invalid Operations";
            }
            MessageBox.Show(message);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string customer_id = textCustomerID.Text.Trim();
            if (Checks.checkNumber(customer_id))
            {
                int cid = int.Parse(customer_id);
                DialogResult result = MessageBox.Show("Are You Sure To Delete The Record", "Video Renting System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string message = "";
                    if(common.DeleteCustomer(cid))
                    {
                        message = "Record is Removed";
                        LoadDatabase();
                    }
                    else
                    {
                        message = "Record does not Removed";
                    }
                    MessageBox.Show(message);
                }
                textCustomerID.Text = textCustomerName.Text = textContactNo.Text = textAddress.Text = "";
                btnSave.Text = "Add New Customer";
                btnDelete.Enabled = false;
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textCustomerID.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                textCustomerName.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                textAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                textContactNo.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnSave.Text = "Update Customer Details";
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                textCustomerID.Text = textCustomerName.Text = textAddress.Text = textContactNo.Text = "";
            }
        }

        private void CustomerForms_Load(object sender, EventArgs e)
        {

        }
    }
}
