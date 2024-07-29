namespace DVLD
{
    partial class frmMain
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
            this.msMainMenuDvld = new System.Windows.Forms.MenuStrip();
            this.aplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLocalDrivingLicenseServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInternationalDrivingLicense2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReplacementForADamageOrLostDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedDrivingLicsenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalDrivingLicense2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInternationalDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.detainedLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPeopleManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDriversManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsersManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuDvld.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenuDvld
            // 
            this.msMainMenuDvld.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenuDvld.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicationsToolStripMenuItem,
            this.tsmPeopleManagement,
            this.tsmDriversManagement,
            this.tsmUsersManagement,
            this.accountSettingsToolStripMenuItem});
            this.msMainMenuDvld.Location = new System.Drawing.Point(0, 0);
            this.msMainMenuDvld.Name = "msMainMenuDvld";
            this.msMainMenuDvld.Size = new System.Drawing.Size(1223, 80);
            this.msMainMenuDvld.TabIndex = 2;
            this.msMainMenuDvld.Text = "menuStrip1";
            // 
            // aplicationsToolStripMenuItem
            // 
            this.aplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLiToolStripMenuItem,
            this.applicationManagementToolStripMenuItem,
            this.toolStripMenuItem2,
            this.detainedLicencesToolStripMenuItem,
            this.tsmManageApplicationTypes,
            this.tsmManageTestTypes});
            this.aplicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aplicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Applications;
            this.aplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aplicationsToolStripMenuItem.Name = "aplicationsToolStripMenuItem";
            this.aplicationsToolStripMenuItem.Size = new System.Drawing.Size(207, 76);
            this.aplicationsToolStripMenuItem.Text = "&Applications";
            // 
            // drivingLiToolStripMenuItem
            // 
            this.drivingLiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLocalDrivingLicenseServiceToolStripMenuItem,
            this.tsmRenewDrivingLicense,
            this.tsmReplacementForADamageOrLostDrivingLicense,
            this.toolStripMenuItem1,
            this.releaseDetainedDrivingLicsenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLiToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingLiToolStripMenuItem.Name = "drivingLiToolStripMenuItem";
            this.drivingLiToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.drivingLiToolStripMenuItem.Text = "Driving Licence Services";
            // 
            // newLocalDrivingLicenseServiceToolStripMenuItem
            // 
            this.newLocalDrivingLicenseServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalDrivingLicense,
            this.tsmInternationalDrivingLicense2});
            this.newLocalDrivingLicenseServiceToolStripMenuItem.Name = "newLocalDrivingLicenseServiceToolStripMenuItem";
            this.newLocalDrivingLicenseServiceToolStripMenuItem.Size = new System.Drawing.Size(500, 26);
            this.newLocalDrivingLicenseServiceToolStripMenuItem.Text = "New Driving License Service";
            // 
            // tsmLocalDrivingLicense
            // 
            this.tsmLocalDrivingLicense.Name = "tsmLocalDrivingLicense";
            this.tsmLocalDrivingLicense.Size = new System.Drawing.Size(320, 26);
            this.tsmLocalDrivingLicense.Text = "Local Driving License";
            this.tsmLocalDrivingLicense.Click += new System.EventHandler(this.tsmLocalDrivingLicense_Click);
            // 
            // tsmInternationalDrivingLicense2
            // 
            this.tsmInternationalDrivingLicense2.Name = "tsmInternationalDrivingLicense2";
            this.tsmInternationalDrivingLicense2.Size = new System.Drawing.Size(320, 26);
            this.tsmInternationalDrivingLicense2.Text = "International Driving License";
            this.tsmInternationalDrivingLicense2.Click += new System.EventHandler(this.tsmInternationalDrivingLicense2_Click);
            // 
            // tsmRenewDrivingLicense
            // 
            this.tsmRenewDrivingLicense.Name = "tsmRenewDrivingLicense";
            this.tsmRenewDrivingLicense.Size = new System.Drawing.Size(500, 26);
            this.tsmRenewDrivingLicense.Text = "Renew Driving License Service";
            this.tsmRenewDrivingLicense.Click += new System.EventHandler(this.tsmRenewDrivingLicense_Click);
            // 
            // tsmReplacementForADamageOrLostDrivingLicense
            // 
            this.tsmReplacementForADamageOrLostDrivingLicense.Name = "tsmReplacementForADamageOrLostDrivingLicense";
            this.tsmReplacementForADamageOrLostDrivingLicense.Size = new System.Drawing.Size(500, 26);
            this.tsmReplacementForADamageOrLostDrivingLicense.Text = "Replacement for a Damage or Lost Driving License";
            this.tsmReplacementForADamageOrLostDrivingLicense.Click += new System.EventHandler(this.tsmReplacementForADamageOrLostDrivingLicense_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(497, 6);
            // 
            // releaseDetainedDrivingLicsenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicsenseToolStripMenuItem.Name = "releaseDetainedDrivingLicsenseToolStripMenuItem";
            this.releaseDetainedDrivingLicsenseToolStripMenuItem.Size = new System.Drawing.Size(500, 26);
            this.releaseDetainedDrivingLicsenseToolStripMenuItem.Text = "Release Detained Driving Licsense";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(500, 26);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // applicationManagementToolStripMenuItem
            // 
            this.applicationManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalDrivingLicense2,
            this.tsmInternationalDrivingLicense});
            this.applicationManagementToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationManagementToolStripMenuItem.Name = "applicationManagementToolStripMenuItem";
            this.applicationManagementToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.applicationManagementToolStripMenuItem.Text = "Application Management";
            // 
            // tsmLocalDrivingLicense2
            // 
            this.tsmLocalDrivingLicense2.Name = "tsmLocalDrivingLicense2";
            this.tsmLocalDrivingLicense2.Size = new System.Drawing.Size(320, 26);
            this.tsmLocalDrivingLicense2.Text = "Local Driving License ";
            this.tsmLocalDrivingLicense2.Click += new System.EventHandler(this.tsmLocalDrivingLicense2_Click);
            // 
            // tsmInternationalDrivingLicense
            // 
            this.tsmInternationalDrivingLicense.Name = "tsmInternationalDrivingLicense";
            this.tsmInternationalDrivingLicense.Size = new System.Drawing.Size(320, 26);
            this.tsmInternationalDrivingLicense.Text = "International Driving License";
            this.tsmInternationalDrivingLicense.Click += new System.EventHandler(this.tsmInternationalDrivingLicense_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(305, 6);
            // 
            // detainedLicencesToolStripMenuItem
            // 
            this.detainedLicencesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detainedLicencesToolStripMenuItem.Name = "detainedLicencesToolStripMenuItem";
            this.detainedLicencesToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.detainedLicencesToolStripMenuItem.Text = "Detained Licences";
            // 
            // tsmManageApplicationTypes
            // 
            this.tsmManageApplicationTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmManageApplicationTypes.Name = "tsmManageApplicationTypes";
            this.tsmManageApplicationTypes.Size = new System.Drawing.Size(308, 26);
            this.tsmManageApplicationTypes.Text = "Manage Application Types";
            this.tsmManageApplicationTypes.Click += new System.EventHandler(this.tsmManageApplicationTypes_Click);
            // 
            // tsmManageTestTypes
            // 
            this.tsmManageTestTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmManageTestTypes.Name = "tsmManageTestTypes";
            this.tsmManageTestTypes.Size = new System.Drawing.Size(308, 26);
            this.tsmManageTestTypes.Text = "Manage Test Types";
            this.tsmManageTestTypes.Click += new System.EventHandler(this.tsmManageTestTypes_Click);
            // 
            // tsmPeopleManagement
            // 
            this.tsmPeopleManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmPeopleManagement.Image = global::DVLD.Properties.Resources.People;
            this.tsmPeopleManagement.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsmPeopleManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmPeopleManagement.Name = "tsmPeopleManagement";
            this.tsmPeopleManagement.Size = new System.Drawing.Size(157, 76);
            this.tsmPeopleManagement.Text = "&People";
            this.tsmPeopleManagement.Click += new System.EventHandler(this.tsmPeopleManagement_Click);
            // 
            // tsmDriversManagement
            // 
            this.tsmDriversManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDriversManagement.Image = global::DVLD.Properties.Resources.Drivers;
            this.tsmDriversManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDriversManagement.Name = "tsmDriversManagement";
            this.tsmDriversManagement.Size = new System.Drawing.Size(159, 76);
            this.tsmDriversManagement.Text = "&Drivers";
            this.tsmDriversManagement.Click += new System.EventHandler(this.tsmDriversManagement_Click);
            // 
            // tsmUsersManagement
            // 
            this.tsmUsersManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmUsersManagement.Image = global::DVLD.Properties.Resources.Users;
            this.tsmUsersManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmUsersManagement.Name = "tsmUsersManagement";
            this.tsmUsersManagement.Size = new System.Drawing.Size(145, 76);
            this.tsmUsersManagement.Text = "&Users";
            this.tsmUsersManagement.Click += new System.EventHandler(this.tsmUsersManagement_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCurrentUser,
            this.tsmChangePassword,
            this.tsmLogout});
            this.accountSettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Acount_Setting;
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(246, 76);
            this.accountSettingsToolStripMenuItem.Text = "A&ccount Settings";
            // 
            // tsmCurrentUser
            // 
            this.tsmCurrentUser.Name = "tsmCurrentUser";
            this.tsmCurrentUser.Size = new System.Drawing.Size(250, 32);
            this.tsmCurrentUser.Text = "Current User";
            this.tsmCurrentUser.Click += new System.EventHandler(this.tsmCurrentUser_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(250, 32);
            this.tsmChangePassword.Text = "Change Password";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(250, 32);
            this.tsmLogout.Text = "Sing Out";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 643);
            this.Controls.Add(this.msMainMenuDvld);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.msMainMenuDvld.ResumeLayout(false);
            this.msMainMenuDvld.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmUsersManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmDriversManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmPeopleManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem detainedLicencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalDrivingLicense2;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicsenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmReplacementForADamageOrLostDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmRenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalDrivingLicense2;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem newLocalDrivingLicenseServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationManagementToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMainMenuDvld;
    }
}