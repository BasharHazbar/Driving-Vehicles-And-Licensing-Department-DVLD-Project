namespace DVLD.Detained_and_Release_License
{
    partial class frmReleaseLicense
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.pbFindLicense = new System.Windows.Forms.PictureBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbCreatedByValue = new System.Windows.Forms.Label();
            this.lb1LicenseID = new System.Windows.Forms.Label();
            this.lb1LicenseIDValue = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbReleasedDate = new System.Windows.Forms.Label();
            this.lbReleasedDateValue = new System.Windows.Forms.Label();
            this.lbShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDetainedID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbDetainedIDValue = new System.Windows.Forms.Label();
            this.lbShowReleaseLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gbDetainedInfo = new System.Windows.Forms.GroupBox();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.lbApplicationIDValue = new System.Windows.Forms.Label();
            this.lbTotalFeesValue = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.lbFanFeesValue = new System.Windows.Forms.Label();
            this.lbFanFees = new System.Windows.Forms.Label();
            this.lbApplicationFeesValue = new System.Windows.Forms.Label();
            this.btnRelease = new System.Windows.Forms.Button();
            this.ctrlLicenseCard = new DVLD.Controls.ctrlLicenseCard();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLicense)).BeginInit();
            this.gbDetainedInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.pbFindLicense);
            this.gbFilter.Controls.Add(this.tbFind);
            this.gbFilter.Controls.Add(this.lbLicenseID);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(89, 44);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(966, 98);
            this.gbFilter.TabIndex = 80;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // pbFindLicense
            // 
            this.pbFindLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFindLicense.Image = global::DVLD.Properties.Resources.Find_Person;
            this.pbFindLicense.Location = new System.Drawing.Point(413, 34);
            this.pbFindLicense.Name = "pbFindLicense";
            this.pbFindLicense.Size = new System.Drawing.Size(74, 42);
            this.pbFindLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFindLicense.TabIndex = 3;
            this.pbFindLicense.TabStop = false;
            this.pbFindLicense.Click += new System.EventHandler(this.pbFindLicense_Click);
            // 
            // tbFind
            // 
            this.tbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFind.Location = new System.Drawing.Point(160, 42);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(233, 27);
            this.tbFind.TabIndex = 1;
            this.tbFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFind_KeyDown);
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(19, 43);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(110, 22);
            this.lbLicenseID.TabIndex = 0;
            this.lbLicenseID.Text = "License ID:";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(471, 80);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(109, 20);
            this.lbCreatedBy.TabIndex = 36;
            this.lbCreatedBy.Text = "Created By:";
            // 
            // lbCreatedByValue
            // 
            this.lbCreatedByValue.AutoSize = true;
            this.lbCreatedByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByValue.Location = new System.Drawing.Point(694, 80);
            this.lbCreatedByValue.Name = "lbCreatedByValue";
            this.lbCreatedByValue.Size = new System.Drawing.Size(61, 20);
            this.lbCreatedByValue.TabIndex = 37;
            this.lbCreatedByValue.Text = "[????]";
            // 
            // lb1LicenseID
            // 
            this.lb1LicenseID.AutoSize = true;
            this.lb1LicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1LicenseID.Location = new System.Drawing.Point(471, 44);
            this.lb1LicenseID.Name = "lb1LicenseID";
            this.lb1LicenseID.Size = new System.Drawing.Size(106, 20);
            this.lb1LicenseID.TabIndex = 30;
            this.lb1LicenseID.Text = "License ID:";
            // 
            // lb1LicenseIDValue
            // 
            this.lb1LicenseIDValue.AutoSize = true;
            this.lb1LicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1LicenseIDValue.Location = new System.Drawing.Point(694, 44);
            this.lb1LicenseIDValue.Name = "lb1LicenseIDValue";
            this.lb1LicenseIDValue.Size = new System.Drawing.Size(61, 20);
            this.lb1LicenseIDValue.TabIndex = 31;
            this.lb1LicenseIDValue.Text = "[????]";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(6, 113);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(155, 20);
            this.lbApplicationFees.TabIndex = 28;
            this.lbApplicationFees.Text = "Application Fees:";
            // 
            // lbReleasedDate
            // 
            this.lbReleasedDate.AutoSize = true;
            this.lbReleasedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReleasedDate.Location = new System.Drawing.Point(6, 80);
            this.lbReleasedDate.Name = "lbReleasedDate";
            this.lbReleasedDate.Size = new System.Drawing.Size(139, 20);
            this.lbReleasedDate.TabIndex = 24;
            this.lbReleasedDate.Text = "Released Date:";
            // 
            // lbReleasedDateValue
            // 
            this.lbReleasedDateValue.AutoSize = true;
            this.lbReleasedDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReleasedDateValue.Location = new System.Drawing.Point(206, 80);
            this.lbReleasedDateValue.Name = "lbReleasedDateValue";
            this.lbReleasedDateValue.Size = new System.Drawing.Size(61, 20);
            this.lbReleasedDateValue.TabIndex = 25;
            this.lbReleasedDateValue.Text = "[????]";
            // 
            // lbShowLicenseHistory
            // 
            this.lbShowLicenseHistory.AutoSize = true;
            this.lbShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicenseHistory.Location = new System.Drawing.Point(88, 701);
            this.lbShowLicenseHistory.Name = "lbShowLicenseHistory";
            this.lbShowLicenseHistory.Size = new System.Drawing.Size(173, 20);
            this.lbShowLicenseHistory.TabIndex = 82;
            this.lbShowLicenseHistory.TabStop = true;
            this.lbShowLicenseHistory.Text = "Show License History";
            this.lbShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicenseHistory_LinkClicked);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(441, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(240, 32);
            this.lbTitle.TabIndex = 76;
            this.lbTitle.Text = "Release License";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDetainedID
            // 
            this.lbDetainedID.AutoSize = true;
            this.lbDetainedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedID.Location = new System.Drawing.Point(6, 44);
            this.lbDetainedID.Name = "lbDetainedID";
            this.lbDetainedID.Size = new System.Drawing.Size(115, 20);
            this.lbDetainedID.TabIndex = 22;
            this.lbDetainedID.Text = "Detained ID:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(754, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 48);
            this.btnClose.TabIndex = 79;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbDetainedIDValue
            // 
            this.lbDetainedIDValue.AutoSize = true;
            this.lbDetainedIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedIDValue.Location = new System.Drawing.Point(206, 44);
            this.lbDetainedIDValue.Name = "lbDetainedIDValue";
            this.lbDetainedIDValue.Size = new System.Drawing.Size(61, 20);
            this.lbDetainedIDValue.TabIndex = 23;
            this.lbDetainedIDValue.Text = "[????]";
            // 
            // lbShowReleaseLicenseInfo
            // 
            this.lbShowReleaseLicenseInfo.AutoSize = true;
            this.lbShowReleaseLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowReleaseLicenseInfo.Location = new System.Drawing.Point(297, 701);
            this.lbShowReleaseLicenseInfo.Name = "lbShowReleaseLicenseInfo";
            this.lbShowReleaseLicenseInfo.Size = new System.Drawing.Size(212, 20);
            this.lbShowReleaseLicenseInfo.TabIndex = 83;
            this.lbShowReleaseLicenseInfo.TabStop = true;
            this.lbShowReleaseLicenseInfo.Text = "Show Release License Info";
            this.lbShowReleaseLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowReleaseLicenseInfo_LinkClicked);
            // 
            // gbDetainedInfo
            // 
            this.gbDetainedInfo.Controls.Add(this.lbApplicationID);
            this.gbDetainedInfo.Controls.Add(this.lbApplicationIDValue);
            this.gbDetainedInfo.Controls.Add(this.lbTotalFeesValue);
            this.gbDetainedInfo.Controls.Add(this.lbTotalFees);
            this.gbDetainedInfo.Controls.Add(this.lbFanFeesValue);
            this.gbDetainedInfo.Controls.Add(this.lbFanFees);
            this.gbDetainedInfo.Controls.Add(this.lbApplicationFeesValue);
            this.gbDetainedInfo.Controls.Add(this.lbCreatedBy);
            this.gbDetainedInfo.Controls.Add(this.lbCreatedByValue);
            this.gbDetainedInfo.Controls.Add(this.lb1LicenseID);
            this.gbDetainedInfo.Controls.Add(this.lb1LicenseIDValue);
            this.gbDetainedInfo.Controls.Add(this.lbApplicationFees);
            this.gbDetainedInfo.Controls.Add(this.lbReleasedDate);
            this.gbDetainedInfo.Controls.Add(this.lbReleasedDateValue);
            this.gbDetainedInfo.Controls.Add(this.lbDetainedID);
            this.gbDetainedInfo.Controls.Add(this.lbDetainedIDValue);
            this.gbDetainedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetainedInfo.Location = new System.Drawing.Point(89, 472);
            this.gbDetainedInfo.Name = "gbDetainedInfo";
            this.gbDetainedInfo.Size = new System.Drawing.Size(967, 206);
            this.gbDetainedInfo.TabIndex = 77;
            this.gbDetainedInfo.TabStop = false;
            this.gbDetainedInfo.Text = "Detained Info";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Location = new System.Drawing.Point(471, 149);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(133, 20);
            this.lbApplicationID.TabIndex = 43;
            this.lbApplicationID.Text = "Application ID:";
            // 
            // lbApplicationIDValue
            // 
            this.lbApplicationIDValue.AutoSize = true;
            this.lbApplicationIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationIDValue.Location = new System.Drawing.Point(694, 149);
            this.lbApplicationIDValue.Name = "lbApplicationIDValue";
            this.lbApplicationIDValue.Size = new System.Drawing.Size(61, 20);
            this.lbApplicationIDValue.TabIndex = 44;
            this.lbApplicationIDValue.Text = "[????]";
            // 
            // lbTotalFeesValue
            // 
            this.lbTotalFeesValue.AutoSize = true;
            this.lbTotalFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFeesValue.Location = new System.Drawing.Point(206, 149);
            this.lbTotalFeesValue.Name = "lbTotalFeesValue";
            this.lbTotalFeesValue.Size = new System.Drawing.Size(61, 20);
            this.lbTotalFeesValue.TabIndex = 42;
            this.lbTotalFeesValue.Text = "[$$$$]";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(6, 149);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(104, 20);
            this.lbTotalFees.TabIndex = 41;
            this.lbTotalFees.Text = "Total Fees:";
            // 
            // lbFanFeesValue
            // 
            this.lbFanFeesValue.AutoSize = true;
            this.lbFanFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFanFeesValue.Location = new System.Drawing.Point(694, 113);
            this.lbFanFeesValue.Name = "lbFanFeesValue";
            this.lbFanFeesValue.Size = new System.Drawing.Size(61, 20);
            this.lbFanFeesValue.TabIndex = 40;
            this.lbFanFeesValue.Text = "[$$$$]";
            // 
            // lbFanFees
            // 
            this.lbFanFees.AutoSize = true;
            this.lbFanFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFanFees.Location = new System.Drawing.Point(471, 113);
            this.lbFanFees.Name = "lbFanFees";
            this.lbFanFees.Size = new System.Drawing.Size(93, 20);
            this.lbFanFees.TabIndex = 39;
            this.lbFanFees.Text = "Fan Fees:";
            // 
            // lbApplicationFeesValue
            // 
            this.lbApplicationFeesValue.AutoSize = true;
            this.lbApplicationFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesValue.Location = new System.Drawing.Point(206, 113);
            this.lbApplicationFeesValue.Name = "lbApplicationFeesValue";
            this.lbApplicationFeesValue.Size = new System.Drawing.Size(61, 20);
            this.lbApplicationFeesValue.TabIndex = 38;
            this.lbApplicationFeesValue.Text = "[$$$$]";
            // 
            // btnRelease
            // 
            this.btnRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.Location = new System.Drawing.Point(920, 684);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(138, 48);
            this.btnRelease.TabIndex = 78;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // ctrlLicenseCard
            // 
            this.ctrlLicenseCard.Location = new System.Drawing.Point(89, 148);
            this.ctrlLicenseCard.Name = "ctrlLicenseCard";
            this.ctrlLicenseCard.Size = new System.Drawing.Size(966, 318);
            this.ctrlLicenseCard.TabIndex = 81;
            // 
            // frmReleaseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 749);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lbShowLicenseHistory);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbShowReleaseLicenseInfo);
            this.Controls.Add(this.gbDetainedInfo);
            this.Controls.Add(this.ctrlLicenseCard);
            this.Controls.Add(this.btnRelease);
            this.Name = "frmReleaseLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release License";
            this.Load += new System.EventHandler(this.frmReleaseLicense_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLicense)).EndInit();
            this.gbDetainedInfo.ResumeLayout(false);
            this.gbDetainedInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.PictureBox pbFindLicense;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbCreatedByValue;
        private System.Windows.Forms.Label lb1LicenseID;
        private System.Windows.Forms.Label lb1LicenseIDValue;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbReleasedDate;
        private System.Windows.Forms.Label lbReleasedDateValue;
        private System.Windows.Forms.LinkLabel lbShowLicenseHistory;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDetainedID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbDetainedIDValue;
        private System.Windows.Forms.LinkLabel lbShowReleaseLicenseInfo;
        private System.Windows.Forms.GroupBox gbDetainedInfo;
        private Controls.ctrlLicenseCard ctrlLicenseCard;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Label lbApplicationFeesValue;
        private System.Windows.Forms.Label lbFanFeesValue;
        private System.Windows.Forms.Label lbFanFees;
        private System.Windows.Forms.Label lbTotalFeesValue;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label lbApplicationIDValue;
    }
}