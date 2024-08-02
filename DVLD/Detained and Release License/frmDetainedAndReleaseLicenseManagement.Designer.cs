namespace DVLD.Detained_and_Release_License
{
    partial class frmDetainedAndReleaseLicenseManagement
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
            System.Windows.Forms.PictureBox pbDetainedLicense;
            System.Windows.Forms.PictureBox pbReleaseLicense;
            this.lbRecordsCountValue = new System.Windows.Forms.Label();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.dgvDetainedLicenseList = new System.Windows.Forms.DataGridView();
            this.cmsDetainedLicenseManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.cbFindByIsRelease = new System.Windows.Forms.ComboBox();
            pbDetainedLicense = new System.Windows.Forms.PictureBox();
            pbReleaseLicense = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pbDetainedLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pbReleaseLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenseList)).BeginInit();
            this.cmsDetainedLicenseManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDetainedLicense
            // 
            pbDetainedLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            pbDetainedLicense.Image = global::DVLD.Properties.Resources.Add_Application;
            pbDetainedLicense.Location = new System.Drawing.Point(1252, 88);
            pbDetainedLicense.Name = "pbDetainedLicense";
            pbDetainedLicense.Size = new System.Drawing.Size(88, 64);
            pbDetainedLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbDetainedLicense.TabIndex = 57;
            pbDetainedLicense.TabStop = false;
            pbDetainedLicense.Click += new System.EventHandler(this.pbDetainedLicense_Click);
            // 
            // pbReleaseLicense
            // 
            pbReleaseLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            pbReleaseLicense.Image = global::DVLD.Properties.Resources.Add_Application;
            pbReleaseLicense.Location = new System.Drawing.Point(1131, 88);
            pbReleaseLicense.Name = "pbReleaseLicense";
            pbReleaseLicense.Size = new System.Drawing.Size(88, 64);
            pbReleaseLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbReleaseLicense.TabIndex = 58;
            pbReleaseLicense.TabStop = false;
            pbReleaseLicense.Click += new System.EventHandler(this.pbReleaseLicense_Click);
            // 
            // lbRecordsCountValue
            // 
            this.lbRecordsCountValue.AutoSize = true;
            this.lbRecordsCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCountValue.Location = new System.Drawing.Point(157, 541);
            this.lbRecordsCountValue.Name = "lbRecordsCountValue";
            this.lbRecordsCountValue.Size = new System.Drawing.Size(60, 22);
            this.lbRecordsCountValue.TabIndex = 55;
            this.lbRecordsCountValue.Text = "[????]";
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCount.Location = new System.Drawing.Point(38, 541);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(107, 22);
            this.lbRecordsCount.TabIndex = 54;
            this.lbRecordsCount.Text = "# Records : ";
            // 
            // dgvDetainedLicenseList
            // 
            this.dgvDetainedLicenseList.AllowUserToAddRows = false;
            this.dgvDetainedLicenseList.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenseList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDetainedLicenseList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetainedLicenseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenseList.ContextMenuStrip = this.cmsDetainedLicenseManagement;
            this.dgvDetainedLicenseList.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvDetainedLicenseList.Location = new System.Drawing.Point(42, 158);
            this.dgvDetainedLicenseList.Name = "dgvDetainedLicenseList";
            this.dgvDetainedLicenseList.ReadOnly = true;
            this.dgvDetainedLicenseList.RowHeadersWidth = 51;
            this.dgvDetainedLicenseList.RowTemplate.Height = 24;
            this.dgvDetainedLicenseList.Size = new System.Drawing.Size(1298, 366);
            this.dgvDetainedLicenseList.TabIndex = 48;
            // 
            // cmsDetainedLicenseManagement
            // 
            this.cmsDetainedLicenseManagement.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDetainedLicenseManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowPersonDetails,
            this.tsmShowLicenseDetails,
            this.tsmShowPersonLicenseHistory,
            this.toolStripMenuItem1,
            this.tsmReleaseDetainedLicense});
            this.cmsDetainedLicenseManagement.Name = "cmsIntLicensesManagement";
            this.cmsDetainedLicenseManagement.Size = new System.Drawing.Size(265, 134);
            this.cmsDetainedLicenseManagement.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDetainedLicenseManagement_Opening);
            // 
            // tsmShowPersonDetails
            // 
            this.tsmShowPersonDetails.Name = "tsmShowPersonDetails";
            this.tsmShowPersonDetails.Size = new System.Drawing.Size(264, 24);
            this.tsmShowPersonDetails.Text = "Show Person Details";
            this.tsmShowPersonDetails.Click += new System.EventHandler(this.tsmShowPersonDetails_Click);
            // 
            // tsmShowLicenseDetails
            // 
            this.tsmShowLicenseDetails.Name = "tsmShowLicenseDetails";
            this.tsmShowLicenseDetails.Size = new System.Drawing.Size(264, 24);
            this.tsmShowLicenseDetails.Text = "Show License Details";
            this.tsmShowLicenseDetails.Click += new System.EventHandler(this.tsmShowLicenseDetails_Click);
            // 
            // tsmShowPersonLicenseHistory
            // 
            this.tsmShowPersonLicenseHistory.Name = "tsmShowPersonLicenseHistory";
            this.tsmShowPersonLicenseHistory.Size = new System.Drawing.Size(264, 24);
            this.tsmShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsmShowPersonLicenseHistory.Click += new System.EventHandler(this.tsmShowPersonLicenseHistory_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(261, 6);
            // 
            // tsmReleaseDetainedLicense
            // 
            this.tsmReleaseDetainedLicense.Name = "tsmReleaseDetainedLicense";
            this.tsmReleaseDetainedLicense.Size = new System.Drawing.Size(264, 24);
            this.tsmReleaseDetainedLicense.Text = "Release Detained License";
            this.tsmReleaseDetainedLicense.Click += new System.EventHandler(this.tsmReleaseDetainedLicense_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(488, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(391, 36);
            this.lbTitle.TabIndex = 53;
            this.lbTitle.Text = "List Detained Management";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1209, 536);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 52);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbFilterBy
            // 
            this.tbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilterBy.Location = new System.Drawing.Point(390, 106);
            this.tbFilterBy.Name = "tbFilterBy";
            this.tbFilterBy.Size = new System.Drawing.Size(234, 28);
            this.tbFilterBy.TabIndex = 51;
            this.tbFilterBy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFilterBy_KeyUp);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Detained ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(120, 106);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(234, 30);
            this.cbFilterBy.TabIndex = 50;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(38, 109);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(56, 22);
            this.lbFilter.TabIndex = 49;
            this.lbFilter.Text = "Filter";
            // 
            // cbFindByIsRelease
            // 
            this.cbFindByIsRelease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindByIsRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFindByIsRelease.FormattingEnabled = true;
            this.cbFindByIsRelease.IntegralHeight = false;
            this.cbFindByIsRelease.Items.AddRange(new object[] {
            "None",
            "Yes",
            "No"});
            this.cbFindByIsRelease.Location = new System.Drawing.Point(389, 103);
            this.cbFindByIsRelease.Name = "cbFindByIsRelease";
            this.cbFindByIsRelease.Size = new System.Drawing.Size(121, 30);
            this.cbFindByIsRelease.TabIndex = 59;
            this.cbFindByIsRelease.SelectedIndexChanged += new System.EventHandler(this.cbFindByIsRelease_SelectedIndexChanged);
            // 
            // frmDetainedAndReleaseLicenseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 594);
            this.Controls.Add(this.cbFindByIsRelease);
            this.Controls.Add(pbReleaseLicense);
            this.Controls.Add(pbDetainedLicense);
            this.Controls.Add(this.lbRecordsCountValue);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.dgvDetainedLicenseList);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lbFilter);
            this.Name = "frmDetainedAndReleaseLicenseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detained And Release License Management";
            this.Load += new System.EventHandler(this.frmDetainedAndReleaseLicenseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(pbDetainedLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pbReleaseLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenseList)).EndInit();
            this.cmsDetainedLicenseManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecordsCountValue;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.DataGridView dgvDetainedLicenseList;
        private System.Windows.Forms.ContextMenuStrip cmsDetainedLicenseManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmReleaseDetainedLicense;
        private System.Windows.Forms.ComboBox cbFindByIsRelease;
    }
}