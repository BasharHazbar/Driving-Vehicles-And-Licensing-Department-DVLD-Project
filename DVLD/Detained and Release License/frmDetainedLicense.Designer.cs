namespace DVLD.Detained_and_Release_License
{
    partial class frmDetainedLicense
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
            this.lbShowDetainedLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbCreatedByValue = new System.Windows.Forms.Label();
            this.gbDetainedInfo = new System.Windows.Forms.GroupBox();
            this.tbFees = new System.Windows.Forms.MaskedTextBox();
            this.lb1LicenseID = new System.Windows.Forms.Label();
            this.lb1LicenseIDValue = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbDetainedDate = new System.Windows.Forms.Label();
            this.lbDetainedDateValue = new System.Windows.Forms.Label();
            this.lbDetainedID = new System.Windows.Forms.Label();
            this.lbDetainedIDValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlLicenseCard = new DVLD.Controls.ctrlLicenseCard();
            this.lbShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbFindLicense = new System.Windows.Forms.PictureBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.btnDetained = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.gbDetainedInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLicense)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbShowDetainedLicenseInfo
            // 
            this.lbShowDetainedLicenseInfo.AutoSize = true;
            this.lbShowDetainedLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowDetainedLicenseInfo.Location = new System.Drawing.Point(308, 670);
            this.lbShowDetainedLicenseInfo.Name = "lbShowDetainedLicenseInfo";
            this.lbShowDetainedLicenseInfo.Size = new System.Drawing.Size(218, 20);
            this.lbShowDetainedLicenseInfo.TabIndex = 75;
            this.lbShowDetainedLicenseInfo.TabStop = true;
            this.lbShowDetainedLicenseInfo.Text = "Show Detained License Info";
            this.lbShowDetainedLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowDetainedLicenseInfo_LinkClicked);
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
            // gbDetainedInfo
            // 
            this.gbDetainedInfo.Controls.Add(this.tbFees);
            this.gbDetainedInfo.Controls.Add(this.lbCreatedBy);
            this.gbDetainedInfo.Controls.Add(this.lbCreatedByValue);
            this.gbDetainedInfo.Controls.Add(this.lb1LicenseID);
            this.gbDetainedInfo.Controls.Add(this.lb1LicenseIDValue);
            this.gbDetainedInfo.Controls.Add(this.lbFees);
            this.gbDetainedInfo.Controls.Add(this.lbDetainedDate);
            this.gbDetainedInfo.Controls.Add(this.lbDetainedDateValue);
            this.gbDetainedInfo.Controls.Add(this.lbDetainedID);
            this.gbDetainedInfo.Controls.Add(this.lbDetainedIDValue);
            this.gbDetainedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetainedInfo.Location = new System.Drawing.Point(96, 473);
            this.gbDetainedInfo.Name = "gbDetainedInfo";
            this.gbDetainedInfo.Size = new System.Drawing.Size(967, 172);
            this.gbDetainedInfo.TabIndex = 69;
            this.gbDetainedInfo.TabStop = false;
            this.gbDetainedInfo.Text = "Detained Info";
            // 
            // tbFees
            // 
            this.tbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFees.Location = new System.Drawing.Point(210, 113);
            this.tbFees.Mask = "00000";
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(156, 27);
            this.tbFees.TabIndex = 2;
            this.tbFees.ValidatingType = typeof(int);
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
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(6, 113);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(56, 20);
            this.lbFees.TabIndex = 28;
            this.lbFees.Text = "Fees:";
            // 
            // lbDetainedDate
            // 
            this.lbDetainedDate.AutoSize = true;
            this.lbDetainedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedDate.Location = new System.Drawing.Point(6, 80);
            this.lbDetainedDate.Name = "lbDetainedDate";
            this.lbDetainedDate.Size = new System.Drawing.Size(136, 20);
            this.lbDetainedDate.TabIndex = 24;
            this.lbDetainedDate.Text = "Detained Date:";
            // 
            // lbDetainedDateValue
            // 
            this.lbDetainedDateValue.AutoSize = true;
            this.lbDetainedDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedDateValue.Location = new System.Drawing.Point(206, 80);
            this.lbDetainedDateValue.Name = "lbDetainedDateValue";
            this.lbDetainedDateValue.Size = new System.Drawing.Size(61, 20);
            this.lbDetainedDateValue.TabIndex = 25;
            this.lbDetainedDateValue.Text = "[????]";
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
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(765, 653);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 48);
            this.btnClose.TabIndex = 71;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLicenseCard
            // 
            this.ctrlLicenseCard.Location = new System.Drawing.Point(96, 149);
            this.ctrlLicenseCard.Name = "ctrlLicenseCard";
            this.ctrlLicenseCard.Size = new System.Drawing.Size(966, 318);
            this.ctrlLicenseCard.TabIndex = 73;
            // 
            // lbShowLicenseHistory
            // 
            this.lbShowLicenseHistory.AutoSize = true;
            this.lbShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicenseHistory.Location = new System.Drawing.Point(99, 670);
            this.lbShowLicenseHistory.Name = "lbShowLicenseHistory";
            this.lbShowLicenseHistory.Size = new System.Drawing.Size(173, 20);
            this.lbShowLicenseHistory.TabIndex = 74;
            this.lbShowLicenseHistory.TabStop = true;
            this.lbShowLicenseHistory.Text = "Show License History";
            this.lbShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicenseHistory_LinkClicked);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(448, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(251, 32);
            this.lbTitle.TabIndex = 68;
            this.lbTitle.Text = "Detained License";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btnDetained
            // 
            this.btnDetained.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetained.Location = new System.Drawing.Point(931, 653);
            this.btnDetained.Name = "btnDetained";
            this.btnDetained.Size = new System.Drawing.Size(138, 48);
            this.btnDetained.TabIndex = 70;
            this.btnDetained.Text = "Detained";
            this.btnDetained.UseVisualStyleBackColor = true;
            this.btnDetained.Click += new System.EventHandler(this.btnDetained_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.pbFindLicense);
            this.gbFilter.Controls.Add(this.tbFind);
            this.gbFilter.Controls.Add(this.lbLicenseID);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(96, 45);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(966, 98);
            this.gbFilter.TabIndex = 72;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // frmDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 715);
            this.Controls.Add(this.lbShowDetainedLicenseInfo);
            this.Controls.Add(this.gbDetainedInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlLicenseCard);
            this.Controls.Add(this.lbShowLicenseHistory);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnDetained);
            this.Controls.Add(this.gbFilter);
            this.Name = "frmDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detained License";
            this.Load += new System.EventHandler(this.frmDetainedLicense_Load);
            this.gbDetainedInfo.ResumeLayout(false);
            this.gbDetainedInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLicense)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbShowDetainedLicenseInfo;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbCreatedByValue;
        private System.Windows.Forms.GroupBox gbDetainedInfo;
        private System.Windows.Forms.Label lb1LicenseID;
        private System.Windows.Forms.Label lb1LicenseIDValue;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbDetainedDate;
        private System.Windows.Forms.Label lbDetainedDateValue;
        private System.Windows.Forms.Label lbDetainedID;
        private System.Windows.Forms.Label lbDetainedIDValue;
        private System.Windows.Forms.Button btnClose;
        private Controls.ctrlLicenseCard ctrlLicenseCard;
        private System.Windows.Forms.LinkLabel lbShowLicenseHistory;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbFindLicense;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Button btnDetained;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.MaskedTextBox tbFees;
    }
}