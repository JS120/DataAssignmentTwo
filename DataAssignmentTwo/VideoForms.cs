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
    public partial class VideoForms : Form
    {
        private Common common;
        private DataTable table;

        public VideoForms()
        {
            InitializeComponent();
        }
        public VideoForms(Common common)
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
            DataSet dataset = common.GetAllVideos();
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                table.Rows.Add(row["video_id"], row["video_title"], row["genre"], row["hours"], row["minutes"], row["rental_cost"],row["year_of_release"]);
            }
            dgvVideo.DataSource = table;
        }

        private void PopulateDataTableColumns()
        {
            table.Clear();
            try
            {
                table.Columns.Add("Video ID");
                table.Columns.Add("Video Title");
                table.Columns.Add("Genre");
                table.Columns.Add("Hours");
                table.Columns.Add("Minutes");             
                table.Columns.Add("Rental Cost");
                table.Columns.Add("Year of Release");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "";
            string video_title = textVideoTitle.Text.Trim();
            string genre = textGenre.Text.Trim();
            string year_of_release = textYear.Text.Trim();
            int hours = (int)numericHour.Value;
            int minutes = (int)numericMinute.Value;
            if (Checks.checkEmpty(video_title) || Checks.checkEmpty(genre) || Checks.checkEmpty(year_of_release))
            {
                message = "Please Fill All Boxes";
            }
            else if (!Checks.checkNumber(year_of_release))
            {
                message = "Please Enter Number in Year of Release";
            }
            else 
            {
                int year = int.Parse(year_of_release);
                int rental_cost = 5;
                if(year < DateTime.Now.Year - 5)
                {
                    rental_cost = 2;
                }
                if (btnSave.Text.Contains("Add"))
                {
                    if(common.AddVideo(video_title,year,genre,hours,minutes,rental_cost))
                    {
                        textRentalCost.Text = rental_cost.ToString();
                        message = "Video Details is Saved";
                        LoadDatabase();
                    }
                    else
                    {
                        message = "Video Details does not Saved";
                    }
                }
                else if (btnSave.Text.Contains("Update"))
                {
                    string videoid = textVideoID.Text.Trim();
                    if(Checks.checkNumber(videoid))
                    {
                        int vid = int.Parse(videoid);
                        if(common.UpdateVideo(vid,video_title,year,genre,hours,minutes,rental_cost))
                        {
                            message = "Record is Updated";
                            LoadDatabase();
                        }
                        else
                        {
                            message = "Record in not Updated";
                        }
                    }
                    textVideoID.Text = textVideoTitle.Text = textGenre.Text = textYear.Text = textRentalCost.Text = ""; ;
                    numericHour.Value = numericMinute.Value = 0;
                    btnSave.Text = "Add New Video";
                    btnDelete.Enabled = false;
                }
                else
                {
                    message = "Invalid Operation";
                }
            }
            MessageBox.Show(message);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string video_id = textVideoID.Text.Trim();
            if (Checks.checkNumber(video_id))
            {
                int vid = int.Parse(video_id);
                DialogResult result = MessageBox.Show("Are You Sure To Delete The Record", "Video Renting System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string message = "";
                    if (common.DeleteVideo(vid))
                    {
                        message = "Record is Removed";
                        LoadDatabase();
                    }
                    else
                    {
                        message = "Record does not Removed";
                    }
                }
                textVideoID.Text = textVideoTitle.Text = textGenre.Text = textYear.Text = textRentalCost.Text = ""; ;
                numericHour.Value = numericMinute.Value = 0;
                btnSave.Text = "Add New Video";
                btnDelete.Enabled = false;

            }
        }

        private void dgvVideo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textVideoID.Text = dgvVideo.Rows[e.RowIndex].Cells[0].Value.ToString();
                textVideoTitle.Text = dgvVideo.Rows[e.RowIndex].Cells[1].Value.ToString();
                textGenre.Text = dgvVideo.Rows[e.RowIndex].Cells[2].Value.ToString();
                numericHour.Value = int.Parse( dgvVideo.Rows[e.RowIndex].Cells[3].Value.ToString());
                numericMinute.Value = int.Parse(dgvVideo.Rows[e.RowIndex].Cells[4].Value.ToString());
                textRentalCost.Text = dgvVideo.Rows[e.RowIndex].Cells[5].Value.ToString();
                textYear.Text = dgvVideo.Rows[e.RowIndex].Cells[6].Value.ToString();
                btnSave.Text = "Update Video Details";
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                textVideoID.Text = textVideoTitle.Text = textGenre.Text = textYear.Text= textRentalCost.Text = ""; ;
                numericHour.Value = numericMinute.Value = 0;
            }
        }
    }
}
