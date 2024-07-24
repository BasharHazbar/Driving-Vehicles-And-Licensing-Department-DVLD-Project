namespace DVLD.Local_Driving_Licenses
{
    partial class frmLocalLicenseApplicationsManagement
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
            this.components = new System.ComponentModel.Container();
            this.tsmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsApplicationsManageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecordsCountValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.dgvLocalLicenseApplicationsList = new System.Windows.Forms.DataGridView();
            this.lbApplicationsManagement = new System.Windows.Forms.Label();
            this.pbAddNewLocalLicenseApplication = new System.Windows.Forms.PictureBox();
            this.cmsApplicationsManageMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApplicationsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewLocalLicenseApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // tsmShowLicense
            // 
            this.tsmShowLicense.Name = "tsmShowLicense";
            this.tsmShowLicense.Size = new System.Drawing.Size(292, 24);
            this.tsmShowLicense.Text = "Show License";
            this.tsmShowLicense.Click += new System.EventHandler(this.tsmShowLicense_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmIssueDrivingLicenseFirstTime
            // 
            this.tsmIssueDrivingLicenseFirstTime.Name = "tsmIssueDrivingLicenseFirstTime";
            this.tsmIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(292, 24);
            this.tsmIssueDrivingLicenseFirstTime.Text = "Issue Driving License [First Time]";
            this.tsmIssueDrivingLicenseFirstTime.Click += new System.EventHandler(this.tsmIssueDrivingLicenseFirstTime_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmStreetTest
            // 
            this.tsmStreetTest.Name = "tsmStreetTest";
            this.tsmStreetTest.Size = new System.Drawing.Size(236, 26);
            this.tsmStreetTest.Text = "Schedule Street Test";
            this.tsmStreetTest.Click += new System.EventHandler(this.tsmStreetTest_Click);
            // 
            // tsmWrittenTest
            // 
            this.tsmWrittenTest.Name = "tsmWrittenTest";
            this.tsmWrittenTest.Size = new System.Drawing.Size(236, 26);
            this.tsmWrittenTest.Text = "Schedule Writtrin Test";
            this.tsmWrittenTest.Click += new System.EventHandler(this.tsmWrittenTest_Click);
            // 
            // tsmVisionTest
            // 
            this.tsmVisionTest.Name = "tsmVisionTest";
            this.tsmVisionTest.Size = new System.Drawing.Size(236, 26);
            this.tsmVisionTest.Text = "Schedule Vision Test";
            this.tsmVisionTest.Click += new System.EventHandler(this.tsmVisionTest_Click);
            // 
            // tsmScheduleTest
            // 
            this.tsmScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVisionTest,
            this.tsmWrittenTest,
            this.tsmStreetTest});
            this.tsmScheduleTest.Name = "tsmScheduleTest";
            this.tsmScheduleTest.Size = new System.Drawing.Size(292, 24);
            this.tsmScheduleTest.Text = "Schedule Test";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmCancelApplication
            // 
            this.tsmCancelApplication.Name = "tsmCancelApplication";
            this.tsmCancelApplication.Size = new System.Drawing.Size(292, 24);
            this.tsmCancelApplication.Text = "Cancel Application";
            this.tsmCancelApplication.Click += new System.EventHandler(this.tsmCancelApplication_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmDeleteApplication
            // 
            this.tsmDeleteApplication.Name = "tsmDeleteApplication";
            this.tsmDeleteApplication.Size = new System.Drawing.Size(292, 24);
            this.tsmDeleteApplication.Text = "Delete Application";
            this.tsmDeleteApplication.Click += new System.EventHandler(this.tsmDeleteApplication_Click);
            // 
            // tsmEditApplication
            // 
            this.tsmEditApplication.Name = "tsmEditApplication";
            this.tsmEditApplication.Size = new System.Drawing.Size(292, 24);
            this.tsmEditApplication.Text = "Edit Application";
            this.tsmEditApplication.Click += new System.EventHandler(this.tsmEditApplication_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(289, 6);
            // 
            // tsmShowApplicationDetails
            // 
            this.tsmShowApplicationDetails.Name = "tsmShowApplicationDetails";
            this.tsmShowApplicationDetails.Size = new System.Drawing.Size(292, 24);
            this.tsmShowApplicationDetails.Text = "Show Application Details";
            this.tsmShowApplicationDetails.Click += new System.EventHandler(this.tsmShowApplicationDetails_Click);
            // 
            // cmsApplicationsManageMenu
            // 
            this.cmsApplicationsManageMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsApplicationsManageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowApplicationDetails,
            this.toolStripMenuItem1,
            this.tsmEditApplication,
            this.tsmDeleteApplication,
            this.toolStripMenuItem2,
            this.tsmCancelApplication,
            this.toolStripMenuItem3,
            this.tsmScheduleTest,
            this.toolStripMenuItem4,
            this.tsmIssueDrivingLicenseFirstTime,
            this.toolStripMenuItem5,
            this.tsmShowLicense,
            this.tsmShowPersonLicenseHistory});
            this.cmsApplicationsManageMenu.Name = "cmsPeopleManageMenu";
            this.cmsApplicationsManageMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsApplicationsManageMenu.Size = new System.Drawing.Size(293, 226);
            this.cmsApplicationsManageMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplicationsManageMenu_Opening);
            // 
            // tsmShowPersonLicenseHistory
            // 
            this.tsmShowPersonLicenseHistory.Name = "tsmShowPersonLicenseHistory";
            this.tsmShowPersonLicenseHistory.Size = new System.Drawing.Size(292, 24);
            this.tsmShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsmShowPersonLicenseHistory.Click += new System.EventHandler(this.tsmShowPersonLicenseHistory_Click);
            // 
            // lbRecordsCountValue
            // 
            this.lbRecordsCountValue.AutoSize = true;
            this.lbRecordsCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCountValue.Location = new System.Drawing.Point(159, 596);
            this.lbRecordsCountValue.Name = "lbRecordsCountValue";
            this.lbRecordsCountValue.Size = new System.Drawing.Size(60, 22);
            this.lbRecordsCountValue.TabIndex = 25;
            this.lbRecordsCountValue.Text = "[????]";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1109, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(172, 46);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCount.Location = new System.Drawing.Point(61, 596);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(107, 22);
            this.lbRecordsCount.TabIndex = 23;
            this.lbRecordsCount.Text = "# Records : ";
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(424, 106);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(261, 28);
            this.tbFilter.TabIndex = 22;
            this.tbFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFilter_KeyUp);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "Driving Class",
            "National No",
            "Full Name",
            "Passed Test",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(143, 106);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(254, 30);
            this.cbFilter.TabIndex = 21;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(59, 109);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(56, 22);
            this.lbFilter.TabIndex = 20;
            this.lbFilter.Text = "Filter";
            // 
            // dgvLocalLicenseApplicationsList
            // 
            this.dgvLocalLicenseApplicationsList.AllowUserToAddRows = false;
            this.dgvLocalLicenseApplicationsList.AllowUserToDeleteRows = false;
            this.dgvLocalLicenseApplicationsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLocalLicenseApplicationsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLocalLicenseApplicationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenseApplicationsList.ContextMenuStrip = this.cmsApplicationsManageMenu;
            this.dgvLocalLicenseApplicationsList.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvLocalLicenseApplicationsList.Location = new System.Drawing.Point(56, 148);
            this.dgvLocalLicenseApplicationsList.Name = "dgvLocalLicenseApplicationsList";
            this.dgvLocalLicenseApplicationsList.ReadOnly = true;
            this.dgvLocalLicenseApplicationsList.RowHeadersWidth = 51;
            this.dgvLocalLicenseApplicationsList.RowTemplate.Height = 24;
            this.dgvLocalLicenseApplicationsList.Size = new System.Drawing.Size(1224, 430);
            this.dgvLocalLicenseApplicationsList.TabIndex = 28;
            this.dgvLocalLicenseApplicationsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalLicenseApplicationsList_CellDoubleClick);
            // 
            // lbApplicationsManagement
            // 
            this.lbApplicationsManagement.AutoSize = true;
            this.lbApplicationsManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationsManagement.ForeColor = System.Drawing.Color.Red;
            this.lbApplicationsManagement.Location = new System.Drawing.Point(418, 29);
            this.lbApplicationsManagement.Name = "lbApplicationsManagement";
            this.lbApplicationsManagement.Size = new System.Drawing.Size(482, 32);
            this.lbApplicationsManagement.TabIndex = 26;
            this.lbApplicationsManagement.Text = "Local Driving License Applications";
            // 
            // pbAddNewLocalLicenseApplication
            // 
            this.pbAddNewLocalLicenseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddNewLocalLicenseApplication.Image = global::DVLD.Properties.Resources.Add_Application;
            this.pbAddNewLocalLicenseApplication.Location = new System.Drawing.Point(1193, 73);
            this.pbAddNewLocalLicenseApplication.Name = "pbAddNewLocalLicenseApplication";
            this.pbAddNewLocalLicenseApplication.Size = new System.Drawing.Size(88, 64);
            this.pbAddNewLocalLicenseApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddNewLocalLicenseApplication.TabIndex = 27;
            this.pbAddNewLocalLicenseApplication.TabStop = false;
            this.pbAddNewLocalLicenseApplication.Click += new System.EventHandler(this.pbAddNewLocalLicenseApplication_Click);
            // 
            // frmLocalLicenseApplicationsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 642);
            this.Controls.Add(this.pbAddNewLocalLicenseApplication);
            this.Controls.Add(this.lbRecordsCountValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.dgvLocalLicenseApplicationsList);
            this.Controls.Add(this.lbApplicationsManagement);
            this.Name = "frmLocalLicenseApplicationsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving Licenses Applications Management";
            this.Load += new System.EventHandler(this.frmLocalLicenseApplicationsManagement_Load);
            this.cmsApplicationsManageMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApplicationsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewLocalLicenseApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAddNewLocalLicenseApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmIssueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmStreetTest;
        private System.Windows.Forms.ToolStripMenuItem tsmWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleTest;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmEditApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowApplicationDetails;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationsManageMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
        private System.Windows.Forms.Label lbRecordsCountValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.DataGridView dgvLocalLicenseApplicationsList;
        private System.Windows.Forms.Label lbApplicationsManagement;
    }
}