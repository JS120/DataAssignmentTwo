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
    public partial class MainForm : Form
    {
        private Common common;
        public MainForm()
        {
            InitializeComponent();
            common = new Common();
        }

        private void customerOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForms form = new CustomerForms(common);
            form.MdiParent = this;
            form.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            common.Close();
        }

        private void videoOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoForms form = new VideoForms(common);
            form.MdiParent = this;
            form.Show();
        }

        private void videoRentOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentForms form = new RentForms(common);
            form.MdiParent = this;
            form.Show();
        }
    }
}
