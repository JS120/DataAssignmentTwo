namespace DataAssignmentTwo
{
    partial class RentForms
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
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbVideo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRentedDate = new System.Windows.Forms.DateTimePicker();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textRVID = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRent
            // 
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Location = new System.Drawing.Point(12, 12);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.RowHeadersWidth = 51;
            this.dgvRent.RowTemplate.Height = 24;
            this.dgvRent.Size = new System.Drawing.Size(1088, 618);
            this.dgvRent.TabIndex = 0;
            this.dgvRent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRent_CellClick);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(1122, 178);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(390, 39);
            this.cmbCustomer.TabIndex = 1;
            // 
            // cmbVideo
            // 
            this.cmbVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVideo.FormattingEnabled = true;
            this.cmbVideo.Location = new System.Drawing.Point(1122, 306);
            this.cmbVideo.Name = "cmbVideo";
            this.cmbVideo.Size = new System.Drawing.Size(390, 39);
            this.cmbVideo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1116, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1116, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Video :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1116, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rented Date:";
            // 
            // dtpRentedDate
            // 
            this.dtpRentedDate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRentedDate.Location = new System.Drawing.Point(1122, 427);
            this.dtpRentedDate.Name = "dtpRentedDate";
            this.dtpRentedDate.Size = new System.Drawing.Size(390, 39);
            this.dtpRentedDate.TabIndex = 7;
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(1122, 499);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(390, 93);
            this.btnIssue.TabIndex = 8;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1122, 637);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(390, 93);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1123, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "RVID:";
            // 
            // textRVID
            // 
            this.textRVID.Enabled = false;
            this.textRVID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRVID.Location = new System.Drawing.Point(1274, 54);
            this.textRVID.Name = "textRVID";
            this.textRVID.Size = new System.Drawing.Size(100, 39);
            this.textRVID.TabIndex = 11;
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(24, 659);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(390, 93);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "All Rented Video";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(499, 659);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(390, 93);
            this.btnOut.TabIndex = 13;
            this.btnOut.Text = "All Out Rented Video";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // RentForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 764);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.textRVID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.dtpRentedDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVideo);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.dgvRent);
            this.Name = "RentForms";
            this.Text = "RentForms";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRentedDate;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRVID;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnOut;
    }
}