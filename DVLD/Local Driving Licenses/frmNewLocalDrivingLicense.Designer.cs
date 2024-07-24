namespace DVLD.Local_Driving_Licenses
{
    partial class frmNewLocalDrivingLicense
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
            this.tcNewLocalDrivingLicense = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlFindPersonCard = new DVLD.Controls.ctrlFindPersonCard();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.lbCreatedByValue = new System.Windows.Forms.Label();
            this.lbApplicationFeesValue = new System.Windows.Forms.Label();
            this.lbApplicationDateValue = new System.Windows.Forms.Label();
            this.lbLDLAppIDValue = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbLDLAppID = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcNewLocalDrivingLicense.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcNewLocalDrivingLicense
            // 
            this.tcNewLocalDrivingLicense.Controls.Add(this.tbPersonInfo);
            this.tcNewLocalDrivingLicense.Controls.Add(this.tpApplicationInfo);
            this.tcNewLocalDrivingLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcNewLocalDrivingLicense.Location = new System.Drawing.Point(59, 70);
            this.tcNewLocalDrivingLicense.Name = "tcNewLocalDrivingLicense";
            this.tcNewLocalDrivingLicense.SelectedIndex = 0;
            this.tcNewLocalDrivingLicense.Size = new System.Drawing.Size(997, 552);
            this.tcNewLocalDrivingLicense.TabIndex = 0;
            this.tcNewLocalDrivingLicense.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcNewLocalDrivingLicense_Selecting);
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.ctrlFindPersonCard);
            this.tbPersonInfo.Controls.Add(this.btnNext);
            this.tbPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(989, 519);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlFindPersonCard
            // 
            this.ctrlFindPersonCard.Location = new System.Drawing.Point(37, 28);
            this.ctrlFindPersonCard.Name = "ctrlFindPersonCard";
            this.ctrlFindPersonCard.Size = new System.Drawing.Size(910, 415);
            this.ctrlFindPersonCard.TabIndex = 50;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(809, 459);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 48);
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpApplicationInfo.Controls.Add(this.cbLicenseClasses);
            this.tpApplicationInfo.Controls.Add(this.lbCreatedByValue);
            this.tpApplicationInfo.Controls.Add(this.lbApplicationFeesValue);
            this.tpApplicationInfo.Controls.Add(this.lbApplicationDateValue);
            this.tpApplicationInfo.Controls.Add(this.lbLDLAppIDValue);
            this.tpApplicationInfo.Controls.Add(this.lbCreatedBy);
            this.tpApplicationInfo.Controls.Add(this.lbApplicationFees);
            this.tpApplicationInfo.Controls.Add(this.label3);
            this.tpApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.tpApplicationInfo.Controls.Add(this.lbLDLAppID);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 29);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(989, 519);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(345, 196);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(333, 30);
            this.cbLicenseClasses.TabIndex = 10;
            // 
            // lbCreatedByValue
            // 
            this.lbCreatedByValue.AutoSize = true;
            this.lbCreatedByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByValue.Location = new System.Drawing.Point(339, 294);
            this.lbCreatedByValue.Name = "lbCreatedByValue";
            this.lbCreatedByValue.Size = new System.Drawing.Size(60, 22);
            this.lbCreatedByValue.TabIndex = 9;
            this.lbCreatedByValue.Text = "[????]";
            // 
            // lbApplicationFeesValue
            // 
            this.lbApplicationFeesValue.AutoSize = true;
            this.lbApplicationFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesValue.Location = new System.Drawing.Point(340, 248);
            this.lbApplicationFeesValue.Name = "lbApplicationFeesValue";
            this.lbApplicationFeesValue.Size = new System.Drawing.Size(60, 22);
            this.lbApplicationFeesValue.TabIndex = 8;
            this.lbApplicationFeesValue.Text = "[????]";
            // 
            // lbApplicationDateValue
            // 
            this.lbApplicationDateValue.AutoSize = true;
            this.lbApplicationDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDateValue.Location = new System.Drawing.Point(339, 148);
            this.lbApplicationDateValue.Name = "lbApplicationDateValue";
            this.lbApplicationDateValue.Size = new System.Drawing.Size(60, 22);
            this.lbApplicationDateValue.TabIndex = 6;
            this.lbApplicationDateValue.Text = "[????]";
            // 
            // lbLDLAppIDValue
            // 
            this.lbLDLAppIDValue.AutoSize = true;
            this.lbLDLAppIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLDLAppIDValue.Location = new System.Drawing.Point(341, 97);
            this.lbLDLAppIDValue.Name = "lbLDLAppIDValue";
            this.lbLDLAppIDValue.Size = new System.Drawing.Size(60, 22);
            this.lbLDLAppIDValue.TabIndex = 5;
            this.lbLDLAppIDValue.Text = "[????]";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(170, 290);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(110, 22);
            this.lbCreatedBy.TabIndex = 4;
            this.lbCreatedBy.Text = "Created By";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(127, 244);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(159, 22);
            this.lbApplicationFees.TabIndex = 3;
            this.lbApplicationFees.Text = "Application Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Classes";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(129, 144);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(157, 22);
            this.lbApplicationDate.TabIndex = 1;
            this.lbApplicationDate.Text = "Application Date";
            // 
            // lbLDLAppID
            // 
            this.lbLDLAppID.AutoSize = true;
            this.lbLDLAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLDLAppID.Location = new System.Drawing.Point(102, 95);
            this.lbLDLAppID.Name = "lbLDLAppID";
            this.lbLDLAppID.Size = new System.Drawing.Size(188, 22);
            this.lbLDLAppID.TabIndex = 0;
            this.lbLDLAppID.Text = "L.D.L Application ID";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(254, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(534, 32);
            this.lbTitle.TabIndex = 47;
            this.lbTitle.Text = "New Local Driving License Application";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(918, 628);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 48);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(752, 628);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 48);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 687);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tcNewLocalDrivingLicense);
            this.Name = "frmNewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Loca lDriving License";
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicense_Load);
            this.tcNewLocalDrivingLicense.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcNewLocalDrivingLicense;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbLDLAppID;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbCreatedByValue;
        private System.Windows.Forms.Label lbApplicationFeesValue;
        private System.Windows.Forms.Label lbApplicationDateValue;
        private System.Windows.Forms.Label lbLDLAppIDValue;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private Controls.ctrlFindPersonCard ctrlFindPersonCard;
    }
}