namespace DataAssignmentTwo
{
    partial class VideoForms
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
            this.dgvVideo = new System.Windows.Forms.DataGridView();
            this.textVideoID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textVideoTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericMinute = new System.Windows.Forms.NumericUpDown();
            this.numericHour = new System.Windows.Forms.NumericUpDown();
            this.textRentalCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHour)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVideo
            // 
            this.dgvVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideo.Location = new System.Drawing.Point(12, 12);
            this.dgvVideo.Name = "dgvVideo";
            this.dgvVideo.RowHeadersWidth = 51;
            this.dgvVideo.RowTemplate.Height = 24;
            this.dgvVideo.Size = new System.Drawing.Size(1285, 427);
            this.dgvVideo.TabIndex = 1;
            this.dgvVideo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVideo_CellClick);
            // 
            // textVideoID
            // 
            this.textVideoID.Enabled = false;
            this.textVideoID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVideoID.Location = new System.Drawing.Point(148, 468);
            this.textVideoID.Name = "textVideoID";
            this.textVideoID.Size = new System.Drawing.Size(100, 39);
            this.textVideoID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Video ID:";
            // 
            // textVideoTitle
            // 
            this.textVideoTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVideoTitle.Location = new System.Drawing.Point(476, 468);
            this.textVideoTitle.Name = "textVideoTitle";
            this.textVideoTitle.Size = new System.Drawing.Size(444, 39);
            this.textVideoTitle.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Video Title:";
            // 
            // textGenre
            // 
            this.textGenre.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGenre.Location = new System.Drawing.Point(148, 554);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(200, 39);
            this.textGenre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minutes:";
            // 
            // numericMinute
            // 
            this.numericMinute.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMinute.Location = new System.Drawing.Point(800, 554);
            this.numericMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMinute.Name = "numericMinute";
            this.numericMinute.Size = new System.Drawing.Size(120, 39);
            this.numericMinute.TabIndex = 12;
            // 
            // numericHour
            // 
            this.numericHour.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHour.Location = new System.Drawing.Point(526, 555);
            this.numericHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericHour.Name = "numericHour";
            this.numericHour.Size = new System.Drawing.Size(120, 39);
            this.numericHour.TabIndex = 13;
            // 
            // textRentalCost
            // 
            this.textRentalCost.Enabled = false;
            this.textRentalCost.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRentalCost.Location = new System.Drawing.Point(182, 649);
            this.textRentalCost.Name = "textRentalCost";
            this.textRentalCost.Size = new System.Drawing.Size(200, 39);
            this.textRentalCost.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rental Cost:";
            // 
            // textYear
            // 
            this.textYear.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textYear.Location = new System.Drawing.Point(660, 652);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(260, 39);
            this.textYear.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 655);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Year Of Release:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(943, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(354, 126);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Add New Video";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(943, 629);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(354, 126);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete Video";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // VideoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 767);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textRentalCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericHour);
            this.Controls.Add(this.numericMinute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textVideoTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textVideoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVideo);
            this.MaximizeBox = false;
            this.Name = "VideoForms";
            this.Text = "VideoForms";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideo;
        private System.Windows.Forms.TextBox textVideoID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textVideoTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericMinute;
        private System.Windows.Forms.NumericUpDown numericHour;
        private System.Windows.Forms.TextBox textRentalCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}