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
    public partial class RentForms : Form
    {
        public Common common;
        private DataTable table;

        public RentForms()
        {
            InitializeComponent();
        }
        public RentForms(Common common)
        {
            InitializeComponent();
            this.common = common;
            table = new DataTable();
            BindComboDetails();
            LoadDatabase(true);
        }



        public void LoadDatabase(bool alldata)
        {
            PopulateDataTableColumns();
            DataSet dataset = common.GetAllRentedVideo();
            if (!alldata)
            {
                dataset = common.GetAllOutRentedVideo();
            }
            if (dataset.Tables.Count > 0)
            {
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    table.Rows.Add(row["rvid"], row["video_title"], row["rent_cost"], row["name"]
                        , row["address"], row["contact_no"], row["rented_date"], row["returned_date"]);
                }
            }
            dgvRent.DataSource = table;
        }

        private void PopulateDataTableColumns()
        {
            table.Clear();
            try
            {
                table.Columns.Add("RVID");
                table.Columns.Add("Video Title");
                table.Columns.Add("Rental Cost");
                table.Columns.Add("Customer Name");
                table.Columns.Add("Address");
                table.Columns.Add("Contact No");
                table.Columns.Add("Rented Date");
                table.Columns.Add("Returned Date");
            }
            catch (Exception ex)
            {

            }
        }

        private void BindComboDetails()
        {
            DataTable customer_table = common.ViewCustomerForCombo();
            cmbCustomer.ValueMember = "customer_id";
            cmbCustomer.DisplayMember = "name";
            cmbCustomer.DataSource = customer_table;
            DataTable video_table = common.ViewVideoForCombo();
            cmbVideo.ValueMember = "video_id";
            cmbVideo.DisplayMember = "video_title";
            cmbVideo.DataSource = video_table;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            string message = "";
            if(cmbCustomer.SelectedIndex == 0 || cmbVideo.SelectedIndex == 0)
            {
                message = "Please Select Any Value";
            }
            else
            {
                int customer_id = int.Parse(cmbCustomer.SelectedValue.ToString());
                int video_id = int.Parse(cmbVideo.SelectedValue.ToString());
                int rent_cost = common.GetVideoRentalCost(video_id);
                if(common.AddRentedVideo(video_id,customer_id,rent_cost,dtpRentedDate.Value))
                {
                    message = "Selected Video Rent By Selected Customer";
                    LoadDatabase(true);
                }
                else
                {
                    message = "There are some issue";
                }
            }
            MessageBox.Show(message);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string rvid = textRVID.Text.Trim();
            if(Checks.checkNumber(rvid))
            {
                if(common.ReturnVideo(int.Parse(rvid),DateTime.Now))
                {
                    MessageBox.Show("Video is Returned");
                    LoadDatabase(true);
                }
            }
        }

        private void dgvRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textRVID.Text = dgvRent.Rows[e.RowIndex].Cells[0].Value.ToString();                
            }
            catch (Exception ex)
            {
                textRVID.Text = "";
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadDatabase(true);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            LoadDatabase(false);
        }
    }
}
