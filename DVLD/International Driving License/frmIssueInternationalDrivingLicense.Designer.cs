namespace DVLD.International_Driving_License
{
    partial class frmIssueInternationalDrivingLicense
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbApplicationInfo = new System.Windows.Forms.GroupBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbCreatedByValue = new System.Windows.Forms.Label();
            this.lbExpirationData = new System.Windows.Forms.Label();
            this.lbExpirationDataValue = new System.Windows.Forms.Label();
            this.lbLocalLicenseID = new System.Windows.Forms.Label();
            this.lbLocalLicenseIDValue = new System.Windows.Forms.Label();
            this.lbIntLicenseID = new System.Windows.Forms.Label();
            this.lbIntLicenseIDValue = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbFeesValue = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lbIssueDateValue = new System.Windows.Forms.Label();
            this.lbApplicationData = new System.Windows.Forms.Label();
            this.lbApplicationDataValue = new System.Windows.Forms.Label();
            this.lbILApplicationID = new System.Windows.Forms.Label();
            this.lbILApplicationIDValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.pbFindLicense = new System.Windows.Forms.PictureBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.lbShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lbShowLicense = new System.Windows.Forms.LinkLabel();
            this.ctrlLicenseCard = new DVLD.Controls.ctrlLicenseCard();
            this.gbApplicationInfo.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(297, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(483, 32);
            this.lbTitle.TabIndex = 48;
            this.lbTitle.Text = "Issue International Driving License";
            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Controls.Add(this.lbCreatedBy);
            this.gbApplicationInfo.Controls.Add(this.lbCreatedByValue);
            this.gbApplicationInfo.Controls.Add(this.lbExpirationData);
            this.gbApplicationInfo.Controls.Add(this.lbExpirationDataValue);
            this.gbApplicationInfo.Controls.Add(this.lbLocalLicenseID);
            this.gbApplicationInfo.Controls.Add(this.lbLocalLicenseIDValue);
            this.gbApplicationInfo.Controls.Add(this.lbIntLicenseID);
            this.gbApplicationInfo.Controls.Add(this.lbIntLicenseIDValue);
            this.gbApplicationInfo.Controls.Add(this.lbFees);
            this.gbApplicationInfo.Controls.Add(this.lbFeesValue);
            this.gbApplicationInfo.Controls.Add(this.lbIssueDate);
            this.gbApplicationInfo.Controls.Add(this.lbIssueDateValue);
            this.gbApplicationInfo.Controls.Add(this.lbApplicationData);
            this.gbApplicationInfo.Controls.Add(this.lbApplicationDataValue);
            this.gbApplicationInfo.Controls.Add(this.lbILApplicationID);
            this.gbApplicationInfo.Controls.Add(this.lbILApplicationIDValue);
            this.gbApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApplicationInfo.Location = new System.Drawing.Point(84, 495);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Size = new System.Drawing.Size(967, 200);
            this.gbApplicationInfo.TabIndex = 49;
            this.gbApplicationInfo.TabStop = false;
            this.gbApplicationInfo.Text = "Application Info";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(471, 151);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(109, 20);
            this.lbCreatedBy.TabIndex = 36;
            this.lbCreatedBy.Text = "Created By:";
            // 
            // lbCreatedByValue
            // 
            this.lbCreatedByValue.AutoSize = true;
            this.lbCreatedByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByValue.Location = new System.Drawing.Point(671, 151);
            this.lbCreatedByValue.Name = "lbCreatedByValue";
            this.lbCreatedByValue.Size = new System.Drawing.Size(61, 20);
            this.lbCreatedByValue.TabIndex = 37;
            this.lbCreatedByValue.Text = "[????]";
            // 
            // lbExpirationData
            // 
            this.lbExpirationData.AutoSize = true;
            this.lbExpirationData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationData.Location = new System.Drawing.Point(471, 115);
            this.lbExpirationData.Name = "lbExpirationData";
            this.lbExpirationData.Size = new System.Drawing.Size(145, 20);
            this.lbExpirationData.TabIndex = 34;
            this.lbExpirationData.Text = "Expiration Date:";
            // 
            // lbExpirationDataValue
            // 
            this.lbExpirationDataValue.AutoSize = true;
            this.lbExpirationDataValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDataValue.Location = new System.Drawing.Point(671, 115);
            this.lbExpirationDataValue.Name = "lbExpirationDataValue";
            this.lbExpirationDataValue.Size = new System.Drawing.Size(61, 20);
            this.lbExpirationDataValue.TabIndex = 35;
            this.lbExpirationDataValue.Text = "[????]";
            // 
            // lbLocalLicenseID
            // 
            this.lbLocalLicenseID.AutoSize = true;
            this.lbLocalLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalLicenseID.Location = new System.Drawing.Point(471, 80);
            this.lbLocalLicenseID.Name = "lbLocalLicenseID";
            this.lbLocalLicenseID.Size = new System.Drawing.Size(158, 20);
            this.lbLocalLicenseID.TabIndex = 32;
            this.lbLocalLicenseID.Text = "Local License ID:";
            // 
            // lbLocalLicenseIDValue
            // 
            this.lbLocalLicenseIDValue.AutoSize = true;
            this.lbLocalLicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalLicenseIDValue.Location = new System.Drawing.Point(671, 80);
            this.lbLocalLicenseIDValue.Name = "lbLocalLicenseIDValue";
            this.lbLocalLicenseIDValue.Size = new System.Drawing.Size(61, 20);
            this.lbLocalLicenseIDValue.TabIndex = 33;
            this.lbLocalLicenseIDValue.Text = "[????]";
            // 
            // lbIntLicenseID
            // 
            this.lbIntLicenseID.AutoSize = true;
            this.lbIntLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntLicenseID.Location = new System.Drawing.Point(471, 44);
            this.lbIntLicenseID.Name = "lbIntLicenseID";
            this.lbIntLicenseID.Size = new System.Drawing.Size(132, 20);
            this.lbIntLicenseID.TabIndex = 30;
            this.lbIntLicenseID.Text = "I.L.License ID:";
            // 
            // lbIntLicenseIDValue
            // 
            this.lbIntLicenseIDValue.AutoSize = true;
            this.lbIntLicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntLicenseIDValue.Location = new System.Drawing.Point(671, 44);
            this.lbIntLicenseIDValue.Name = "lbIntLicenseIDValue";
            this.lbIntLicenseIDValue.Size = new System.Drawing.Size(61, 20);
            this.lbIntLicenseIDValue.TabIndex = 31;
            this.lbIntLicenseIDValue.Text = "[????]";
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(6, 151);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(56, 20);
            this.lbFees.TabIndex = 28;
            this.lbFees.Text = "Fees:";
            // 
            // lbFeesValue
            // 
            this.lbFeesValue.AutoSize = true;
            this.lbFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeesValue.Location = new System.Drawing.Point(206, 151);
            this.lbFeesValue.Name = "lbFeesValue";
            this.lbFeesValue.Size = new System.Drawing.Size(61, 20);
            this.lbFeesValue.TabIndex = 29;
            this.lbFeesValue.Text = "[????]";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDate.Location = new System.Drawing.Point(6, 115);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(106, 20);
            this.lbIssueDate.TabIndex = 26;
            this.lbIssueDate.Text = "Issue Date:";
            // 
            // lbIssueDateValue
            // 
            this.lbIssueDateValue.AutoSize = true;
            this.lbIssueDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDateValue.Location = new System.Drawing.Point(206, 115);
            this.lbIssueDateValue.Name = "lbIssueDateValue";
            this.lbIssueDateValue.Size = new System.Drawing.Size(61, 20);
            this.lbIssueDateValue.TabIndex = 27;
            this.lbIssueDateValue.Text = "[????]";
            // 
            // lbApplicationData
            // 
            this.lbApplicationData.AutoSize = true;
            this.lbApplicationData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationData.Location = new System.Drawing.Point(6, 80);
            this.lbApplicationData.Name = "lbApplicationData";
            this.lbApplicationData.Size = new System.Drawing.Size(154, 20);
            this.lbApplicationData.TabIndex = 24;
            this.lbApplicationData.Text = "Application Data:";
            // 
            // lbApplicationDataValue
            // 
            this.lbApplicationDataValue.AutoSize = true;
            this.lbApplicationDataValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDataValue.Location = new System.Drawing.Point(206, 80);
            this.lbApplicationDataValue.Name = "lbApplicationDataValue";
            this.lbApplicationDataValue.Size = new System.Drawing.Size(61, 20);
            this.lbApplicationDataValue.TabIndex = 25;
            this.lbApplicationDataValue.Text = "[????]";
            // 
            // lbILApplicationID
            // 
            this.lbILApplicationID.AutoSize = true;
            this.lbILApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbILApplicationID.Location = new System.Drawing.Point(6, 44);
            this.lbILApplicationID.Name = "lbILApplicationID";
            this.lbILApplicationID.Size = new System.Drawing.Size(159, 20);
            this.lbILApplicationID.TabIndex = 22;
            this.lbILApplicationID.Text = "I.L.Application ID:";
            // 
            // lbILApplicationIDValue
            // 
            this.lbILApplicationIDValue.AutoSize = true;
            this.lbILApplicationIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbILApplicationIDValue.Location = new System.Drawing.Point(206, 44);
            this.lbILApplicationIDValue.Name = "lbILApplicationIDValue";
            this.lbILApplicationIDValue.Size = new System.Drawing.Size(61, 20);
            this.lbILApplicationIDValue.TabIndex = 23;
            this.lbILApplicationIDValue.Text = "[????]";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(747, 706);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 48);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueLicense.Location = new System.Drawing.Point(913, 706);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(138, 48);
            this.btnIssueLicense.TabIndex = 54;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.pbFindLicense);
            this.gbFilter.Controls.Add(this.tbFind);
            this.gbFilter.Controls.Add(this.lbLicenseID);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(84, 67);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(966, 98);
            this.gbFilter.TabIndex = 56;
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
            this.tbFind.TabIndex = 2;
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
            // lbShowLicenseHistory
            // 
            this.lbShowLicenseHistory.AutoSize = true;
            this.lbShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicenseHistory.Location = new System.Drawing.Point(81, 724);
            this.lbShowLicenseHistory.Name = "lbShowLicenseHistory";
            this.lbShowLicenseHistory.Size = new System.Drawing.Size(173, 20);
            this.lbShowLicenseHistory.TabIndex = 58;
            this.lbShowLicenseHistory.TabStop = true;
            this.lbShowLicenseHistory.Text = "Show License History";
            this.lbShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicenseHistory_LinkClicked);
            // 
            // lbShowLicense
            // 
            this.lbShowLicense.AutoSize = true;
            this.lbShowLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicense.Location = new System.Drawing.Point(290, 724);
            this.lbShowLicense.Name = "lbShowLicense";
            this.lbShowLicense.Size = new System.Drawing.Size(114, 20);
            this.lbShowLicense.TabIndex = 59;
            this.lbShowLicense.TabStop = true;
            this.lbShowLicense.Text = "Show License";
            this.lbShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicense_LinkClicked);
            // 
            // ctrlLicenseCard
            // 
            this.ctrlLicenseCard.Location = new System.Drawing.Point(84, 171);
            this.ctrlLicenseCard.Name = "ctrlLicenseCard";
            this.ctrlLicenseCard.Size = new System.Drawing.Size(966, 318);
            this.ctrlLicenseCard.TabIndex = 57;
            // 
            // frmIssueInternationalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 767);
            this.Controls.Add(this.lbShowLicense);
            this.Controls.Add(this.lbShowLicenseHistory);
            this.Controls.Add(this.ctrlLicenseCard);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.gbApplicationInfo);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmIssueInternationalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue International Driving License";
            this.Load += new System.EventHandler(this.frmIssueInternationalDrivingLicense_Load);
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbApplicationInfo;
        private System.Windows.Forms.Label lbILApplicationID;
        private System.Windows.Forms.Label lbILApplicationIDValue;
        private System.Windows.Forms.Label lbApplicationData;
        private System.Windows.Forms.Label lbApplicationDataValue;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label lbIssueDateValue;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbFeesValue;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbCreatedByValue;
        private System.Windows.Forms.Label lbExpirationData;
        private System.Windows.Forms.Label lbExpirationDataValue;
        private System.Windows.Forms.Label lbLocalLicenseID;
        private System.Windows.Forms.Label lbLocalLicenseIDValue;
        private System.Windows.Forms.Label lbIntLicenseID;
        private System.Windows.Forms.Label lbIntLicenseIDValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.PictureBox pbFindLicense;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label lbLicenseID;
        private Controls.ctrlLicenseCard ctrlLicenseCard;
        private System.Windows.Forms.LinkLabel lbShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lbShowLicense;
    }
}