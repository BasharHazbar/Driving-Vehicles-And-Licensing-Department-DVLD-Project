namespace DVLD.Renew_Local_Driving_License
{
    partial class frmRenewLocalDrivingLicense
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
            this.btnRenew = new System.Windows.Forms.Button();
            this.pbFindLicense = new System.Windows.Forms.PictureBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbCreatedByValue = new System.Windows.Forms.Label();
            this.lbExpirationData = new System.Windows.Forms.Label();
            this.lbExpirationDataValue = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.lbOldLicenseIDValue = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.lbRenewLicenseID = new System.Windows.Forms.Label();
            this.lbRenewLicenseIDValue = new System.Windows.Forms.Label();
            this.lbFeesValue = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lbShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbIssueDateValue = new System.Windows.Forms.Label();
            this.lbApplicationData = new System.Windows.Forms.Label();
            this.lbApplicationDataValue = new System.Windows.Forms.Label();
            this.lbRLApplicationID = new System.Windows.Forms.Label();
            this.lbRLApplicationIDValue = new System.Windows.Forms.Label();
            this.lbShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbRenewApplicationInfo = new System.Windows.Forms.GroupBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lbNotes = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.lbTotalFeesValue = new System.Windows.Forms.Label();
            this.lbLicenseFees = new System.Windows.Forms.Label();
            this.lbLicenseFeesValue = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ctrlLicenseCard = new DVLD.Controls.ctrlLicenseCard();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLicense)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.gbRenewApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Location = new System.Drawing.Point(909, 792);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(138, 48);
            this.btnRenew.TabIndex = 62;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
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
            this.lbCreatedByValue.Location = new System.Drawing.Point(694, 151);
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
            this.lbExpirationDataValue.Location = new System.Drawing.Point(694, 115);
            this.lbExpirationDataValue.Name = "lbExpirationDataValue";
            this.lbExpirationDataValue.Size = new System.Drawing.Size(61, 20);
            this.lbExpirationDataValue.TabIndex = 35;
            this.lbExpirationDataValue.Text = "[????]";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseID.Location = new System.Drawing.Point(471, 80);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(141, 20);
            this.lbOldLicenseID.TabIndex = 32;
            this.lbOldLicenseID.Text = "Old License ID:";
            // 
            // lbOldLicenseIDValue
            // 
            this.lbOldLicenseIDValue.AutoSize = true;
            this.lbOldLicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseIDValue.Location = new System.Drawing.Point(694, 80);
            this.lbOldLicenseIDValue.Name = "lbOldLicenseIDValue";
            this.lbOldLicenseIDValue.Size = new System.Drawing.Size(61, 20);
            this.lbOldLicenseIDValue.TabIndex = 33;
            this.lbOldLicenseIDValue.Text = "[????]";
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
            // lbRenewLicenseID
            // 
            this.lbRenewLicenseID.AutoSize = true;
            this.lbRenewLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewLicenseID.Location = new System.Drawing.Point(471, 44);
            this.lbRenewLicenseID.Name = "lbRenewLicenseID";
            this.lbRenewLicenseID.Size = new System.Drawing.Size(168, 20);
            this.lbRenewLicenseID.TabIndex = 30;
            this.lbRenewLicenseID.Text = "Renew License ID:";
            // 
            // lbRenewLicenseIDValue
            // 
            this.lbRenewLicenseIDValue.AutoSize = true;
            this.lbRenewLicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewLicenseIDValue.Location = new System.Drawing.Point(694, 44);
            this.lbRenewLicenseIDValue.Name = "lbRenewLicenseIDValue";
            this.lbRenewLicenseIDValue.Size = new System.Drawing.Size(61, 20);
            this.lbRenewLicenseIDValue.TabIndex = 31;
            this.lbRenewLicenseIDValue.Text = "[????]";
            // 
            // lbFeesValue
            // 
            this.lbFeesValue.AutoSize = true;
            this.lbFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeesValue.Location = new System.Drawing.Point(206, 151);
            this.lbFeesValue.Name = "lbFeesValue";
            this.lbFeesValue.Size = new System.Drawing.Size(61, 20);
            this.lbFeesValue.TabIndex = 29;
            this.lbFeesValue.Text = "[$$$$]";
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
            // lbShowLicenseHistory
            // 
            this.lbShowLicenseHistory.AutoSize = true;
            this.lbShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicenseHistory.Location = new System.Drawing.Point(77, 809);
            this.lbShowLicenseHistory.Name = "lbShowLicenseHistory";
            this.lbShowLicenseHistory.Size = new System.Drawing.Size(173, 20);
            this.lbShowLicenseHistory.TabIndex = 66;
            this.lbShowLicenseHistory.TabStop = true;
            this.lbShowLicenseHistory.Text = "Show License History";
            this.lbShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicenseHistory_LinkClicked);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.pbFindLicense);
            this.gbFilter.Controls.Add(this.tbFind);
            this.gbFilter.Controls.Add(this.lbLicenseID);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(92, 39);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(966, 98);
            this.gbFilter.TabIndex = 64;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
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
            // lbRLApplicationID
            // 
            this.lbRLApplicationID.AutoSize = true;
            this.lbRLApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRLApplicationID.Location = new System.Drawing.Point(6, 44);
            this.lbRLApplicationID.Name = "lbRLApplicationID";
            this.lbRLApplicationID.Size = new System.Drawing.Size(167, 20);
            this.lbRLApplicationID.TabIndex = 22;
            this.lbRLApplicationID.Text = "R.L.Application ID:";
            // 
            // lbRLApplicationIDValue
            // 
            this.lbRLApplicationIDValue.AutoSize = true;
            this.lbRLApplicationIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRLApplicationIDValue.Location = new System.Drawing.Point(206, 44);
            this.lbRLApplicationIDValue.Name = "lbRLApplicationIDValue";
            this.lbRLApplicationIDValue.Size = new System.Drawing.Size(61, 20);
            this.lbRLApplicationIDValue.TabIndex = 23;
            this.lbRLApplicationIDValue.Text = "[????]";
            // 
            // lbShowNewLicenseInfo
            // 
            this.lbShowNewLicenseInfo.AutoSize = true;
            this.lbShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowNewLicenseInfo.Location = new System.Drawing.Point(286, 809);
            this.lbShowNewLicenseInfo.Name = "lbShowNewLicenseInfo";
            this.lbShowNewLicenseInfo.Size = new System.Drawing.Size(184, 20);
            this.lbShowNewLicenseInfo.TabIndex = 67;
            this.lbShowNewLicenseInfo.TabStop = true;
            this.lbShowNewLicenseInfo.Text = "Show New License Info";
            this.lbShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicense_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(743, 792);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 48);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbRenewApplicationInfo
            // 
            this.gbRenewApplicationInfo.Controls.Add(this.rtbNotes);
            this.gbRenewApplicationInfo.Controls.Add(this.lbNotes);
            this.gbRenewApplicationInfo.Controls.Add(this.lbTotalFees);
            this.gbRenewApplicationInfo.Controls.Add(this.lbTotalFeesValue);
            this.gbRenewApplicationInfo.Controls.Add(this.lbLicenseFees);
            this.gbRenewApplicationInfo.Controls.Add(this.lbLicenseFeesValue);
            this.gbRenewApplicationInfo.Controls.Add(this.lbCreatedBy);
            this.gbRenewApplicationInfo.Controls.Add(this.lbCreatedByValue);
            this.gbRenewApplicationInfo.Controls.Add(this.lbExpirationData);
            this.gbRenewApplicationInfo.Controls.Add(this.lbExpirationDataValue);
            this.gbRenewApplicationInfo.Controls.Add(this.lbOldLicenseID);
            this.gbRenewApplicationInfo.Controls.Add(this.lbOldLicenseIDValue);
            this.gbRenewApplicationInfo.Controls.Add(this.lbRenewLicenseID);
            this.gbRenewApplicationInfo.Controls.Add(this.lbRenewLicenseIDValue);
            this.gbRenewApplicationInfo.Controls.Add(this.lbFees);
            this.gbRenewApplicationInfo.Controls.Add(this.lbFeesValue);
            this.gbRenewApplicationInfo.Controls.Add(this.lbIssueDate);
            this.gbRenewApplicationInfo.Controls.Add(this.lbIssueDateValue);
            this.gbRenewApplicationInfo.Controls.Add(this.lbApplicationData);
            this.gbRenewApplicationInfo.Controls.Add(this.lbApplicationDataValue);
            this.gbRenewApplicationInfo.Controls.Add(this.lbRLApplicationID);
            this.gbRenewApplicationInfo.Controls.Add(this.lbRLApplicationIDValue);
            this.gbRenewApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRenewApplicationInfo.Location = new System.Drawing.Point(92, 467);
            this.gbRenewApplicationInfo.Name = "gbRenewApplicationInfo";
            this.gbRenewApplicationInfo.Size = new System.Drawing.Size(967, 317);
            this.gbRenewApplicationInfo.TabIndex = 61;
            this.gbRenewApplicationInfo.TabStop = false;
            this.gbRenewApplicationInfo.Text = "Renew Application Info";
            // 
            // rtbNotes
            // 
            this.rtbNotes.BackColor = System.Drawing.Color.White;
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(210, 230);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(545, 70);
            this.rtbNotes.TabIndex = 50;
            this.rtbNotes.Text = "";
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotes.Location = new System.Drawing.Point(6, 227);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(64, 20);
            this.lbNotes.TabIndex = 42;
            this.lbNotes.Text = "Notes:";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(471, 189);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(104, 20);
            this.lbTotalFees.TabIndex = 40;
            this.lbTotalFees.Text = "Total Fees:";
            // 
            // lbTotalFeesValue
            // 
            this.lbTotalFeesValue.AutoSize = true;
            this.lbTotalFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFeesValue.Location = new System.Drawing.Point(694, 189);
            this.lbTotalFeesValue.Name = "lbTotalFeesValue";
            this.lbTotalFeesValue.Size = new System.Drawing.Size(61, 20);
            this.lbTotalFeesValue.TabIndex = 41;
            this.lbTotalFeesValue.Text = "[$$$$]";
            // 
            // lbLicenseFees
            // 
            this.lbLicenseFees.AutoSize = true;
            this.lbLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseFees.Location = new System.Drawing.Point(6, 189);
            this.lbLicenseFees.Name = "lbLicenseFees";
            this.lbLicenseFees.Size = new System.Drawing.Size(128, 20);
            this.lbLicenseFees.TabIndex = 38;
            this.lbLicenseFees.Text = "License Fees:";
            // 
            // lbLicenseFeesValue
            // 
            this.lbLicenseFeesValue.AutoSize = true;
            this.lbLicenseFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseFeesValue.Location = new System.Drawing.Point(206, 189);
            this.lbLicenseFeesValue.Name = "lbLicenseFeesValue";
            this.lbLicenseFeesValue.Size = new System.Drawing.Size(61, 20);
            this.lbLicenseFeesValue.TabIndex = 39;
            this.lbLicenseFeesValue.Text = "[$$$$]";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(369, 4);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(407, 32);
            this.lbTitle.TabIndex = 60;
            this.lbTitle.Text = "Renew Local Driving License";
            // 
            // ctrlLicenseCard
            // 
            this.ctrlLicenseCard.Location = new System.Drawing.Point(92, 143);
            this.ctrlLicenseCard.Name = "ctrlLicenseCard";
            this.ctrlLicenseCard.Size = new System.Drawing.Size(966, 318);
            this.ctrlLicenseCard.TabIndex = 65;
            // 
            // frmRenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 868);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.lbShowLicenseHistory);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlLicenseCard);
            this.Controls.Add(this.lbShowNewLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbRenewApplicationInfo);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmRenewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Local Driving License";
            this.Load += new System.EventHandler(this.frmRenewLocalDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLicense)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbRenewApplicationInfo.ResumeLayout(false);
            this.gbRenewApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.PictureBox pbFindLicense;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbCreatedByValue;
        private System.Windows.Forms.Label lbExpirationData;
        private System.Windows.Forms.Label lbExpirationDataValue;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label lbOldLicenseIDValue;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label lbRenewLicenseID;
        private System.Windows.Forms.Label lbRenewLicenseIDValue;
        private System.Windows.Forms.Label lbFeesValue;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.LinkLabel lbShowLicenseHistory;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lbFees;
        private Controls.ctrlLicenseCard ctrlLicenseCard;
        private System.Windows.Forms.Label lbIssueDateValue;
        private System.Windows.Forms.Label lbApplicationData;
        private System.Windows.Forms.Label lbApplicationDataValue;
        private System.Windows.Forms.Label lbRLApplicationID;
        private System.Windows.Forms.Label lbRLApplicationIDValue;
        private System.Windows.Forms.LinkLabel lbShowNewLicenseInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbRenewApplicationInfo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label lbTotalFeesValue;
        private System.Windows.Forms.Label lbLicenseFees;
        private System.Windows.Forms.Label lbLicenseFeesValue;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.RichTextBox rtbNotes;
    }
}