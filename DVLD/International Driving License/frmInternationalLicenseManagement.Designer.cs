namespace DVLD.International_Driving_License
{
    partial class frmInternationalLicenseManagement
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
            System.Windows.Forms.PictureBox pbAddNewIntLicense;
            this.lbRecordsCountValue = new System.Windows.Forms.Label();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.dgvIntLicensesList = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.cbFindByIsActive = new System.Windows.Forms.ComboBox();
            this.cmsIntLicensesManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            pbAddNewIntLicense = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pbAddNewIntLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntLicensesList)).BeginInit();
            this.cmsIntLicensesManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAddNewIntLicense
            // 
            pbAddNewIntLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            pbAddNewIntLicense.Image = global::DVLD.Properties.Resources.Add_Application;
            pbAddNewIntLicense.Location = new System.Drawing.Point(1130, 69);
            pbAddNewIntLicense.Name = "pbAddNewIntLicense";
            pbAddNewIntLicense.Size = new System.Drawing.Size(88, 64);
            pbAddNewIntLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbAddNewIntLicense.TabIndex = 47;
            pbAddNewIntLicense.TabStop = false;
            pbAddNewIntLicense.Click += new System.EventHandler(this.pbAddNewIntLicense_Click);
            // 
            // lbRecordsCountValue
            // 
            this.lbRecordsCountValue.AutoSize = true;
            this.lbRecordsCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCountValue.Location = new System.Drawing.Point(182, 522);
            this.lbRecordsCountValue.Name = "lbRecordsCountValue";
            this.lbRecordsCountValue.Size = new System.Drawing.Size(60, 22);
            this.lbRecordsCountValue.TabIndex = 45;
            this.lbRecordsCountValue.Text = "[????]";
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCount.Location = new System.Drawing.Point(63, 522);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(107, 22);
            this.lbRecordsCount.TabIndex = 44;
            this.lbRecordsCount.Text = "# Records : ";
            // 
            // dgvIntLicensesList
            // 
            this.dgvIntLicensesList.AllowUserToAddRows = false;
            this.dgvIntLicensesList.AllowUserToDeleteRows = false;
            this.dgvIntLicensesList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvIntLicensesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvIntLicensesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntLicensesList.ContextMenuStrip = this.cmsIntLicensesManagement;
            this.dgvIntLicensesList.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvIntLicensesList.Location = new System.Drawing.Point(67, 139);
            this.dgvIntLicensesList.Name = "dgvIntLicensesList";
            this.dgvIntLicensesList.ReadOnly = true;
            this.dgvIntLicensesList.RowHeadersWidth = 51;
            this.dgvIntLicensesList.RowTemplate.Height = 24;
            this.dgvIntLicensesList.Size = new System.Drawing.Size(1151, 366);
            this.dgvIntLicensesList.TabIndex = 38;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(376, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(501, 36);
            this.lbTitle.TabIndex = 43;
            this.lbTitle.Text = "International License Management";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1087, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 52);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbFilterBy
            // 
            this.tbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilterBy.Location = new System.Drawing.Point(415, 87);
            this.tbFilterBy.Name = "tbFilterBy";
            this.tbFilterBy.Size = new System.Drawing.Size(234, 28);
            this.tbFilterBy.TabIndex = 41;
            this.tbFilterBy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFilterBy_KeyUp);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Int.License ID",
            "Application ID",
            "Driver ID",
            "L.License ID",
            "Issue Date",
            "Expiration Date",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(145, 87);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(234, 30);
            this.cbFilterBy.TabIndex = 40;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(63, 90);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(56, 22);
            this.lbFilter.TabIndex = 39;
            this.lbFilter.Text = "Filter";
            // 
            // cbFindByIsActive
            // 
            this.cbFindByIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindByIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFindByIsActive.FormattingEnabled = true;
            this.cbFindByIsActive.IntegralHeight = false;
            this.cbFindByIsActive.Items.AddRange(new object[] {
            "None",
            "Yes",
            "No"});
            this.cbFindByIsActive.Location = new System.Drawing.Point(414, 86);
            this.cbFindByIsActive.Name = "cbFindByIsActive";
            this.cbFindByIsActive.Size = new System.Drawing.Size(121, 30);
            this.cbFindByIsActive.TabIndex = 46;
            this.cbFindByIsActive.SelectedIndexChanged += new System.EventHandler(this.cbFindByIsActive_SelectedIndexChanged);
            // 
            // cmsIntLicensesManagement
            // 
            this.cmsIntLicensesManagement.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsIntLicensesManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowPersonDetails,
            this.tsmShowLicenseDetails,
            this.tsmShowPersonLicenseHistory});
            this.cmsIntLicensesManagement.Name = "cmsIntLicensesManagement";
            this.cmsIntLicensesManagement.Size = new System.Drawing.Size(265, 76);
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
            // frmInternationalLicenseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 581);
            this.Controls.Add(pbAddNewIntLicense);
            this.Controls.Add(this.cbFindByIsActive);
            this.Controls.Add(this.lbRecordsCountValue);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.dgvIntLicensesList);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lbFilter);
            this.Name = "frmInternationalLicenseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International License Management";
            this.Load += new System.EventHandler(this.frmInternationalLicenseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(pbAddNewIntLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntLicensesList)).EndInit();
            this.cmsIntLicensesManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecordsCountValue;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.DataGridView dgvIntLicensesList;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.ComboBox cbFindByIsActive;
        private System.Windows.Forms.ContextMenuStrip cmsIntLicensesManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
    }
}