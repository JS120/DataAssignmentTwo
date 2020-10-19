namespace DataAssignmentTwo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoRentOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerOperationsToolStripMenuItem,
            this.videoOperationsToolStripMenuItem,
            this.videoRentOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerOperationsToolStripMenuItem
            // 
            this.customerOperationsToolStripMenuItem.Name = "customerOperationsToolStripMenuItem";
            this.customerOperationsToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.customerOperationsToolStripMenuItem.Text = "Customer Operations";
            this.customerOperationsToolStripMenuItem.Click += new System.EventHandler(this.customerOperationsToolStripMenuItem_Click);
            // 
            // videoOperationsToolStripMenuItem
            // 
            this.videoOperationsToolStripMenuItem.Name = "videoOperationsToolStripMenuItem";
            this.videoOperationsToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.videoOperationsToolStripMenuItem.Text = "Video Operations";
            this.videoOperationsToolStripMenuItem.Click += new System.EventHandler(this.videoOperationsToolStripMenuItem_Click);
            // 
            // videoRentOperationsToolStripMenuItem
            // 
            this.videoRentOperationsToolStripMenuItem.Name = "videoRentOperationsToolStripMenuItem";
            this.videoRentOperationsToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.videoRentOperationsToolStripMenuItem.Text = "Video Rent Operations";
            this.videoRentOperationsToolStripMenuItem.Click += new System.EventHandler(this.videoRentOperationsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 525);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Renting Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoRentOperationsToolStripMenuItem;
    }
}

