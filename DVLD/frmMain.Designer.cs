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
            this.renewDrivingLicenseServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForALostDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDriversManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.peopleToolStripMenuItem,
            this.tsmDriversManagement,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.msMainMenuDvld.Location = new System.Drawing.Point(0, 0);
            this.msMainMenuDvld.Name = "msMainMenuDvld";
            this.msMainMenuDvld.Size = new System.Drawing.Size(1033, 80);
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
            this.renewDrivingLicenseServiceToolStripMenuItem,
            this.replacementForALostDrivingLicenseToolStripMenuItem,
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
            this.newLocalDrivingLicenseServiceToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
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
            // 
            // renewDrivingLicenseServiceToolStripMenuItem
            // 
            this.renewDrivingLicenseServiceToolStripMenuItem.Name = "renewDrivingLicenseServiceToolStripMenuItem";
            this.renewDrivingLicenseServiceToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
            this.renewDrivingLicenseServiceToolStripMenuItem.Text = "Renew Driving License Service";
            // 
            // replacementForALostDrivingLicenseToolStripMenuItem
            // 
            this.replacementForALostDrivingLicenseToolStripMenuItem.Name = "replacementForALostDrivingLicenseToolStripMenuItem";
            this.replacementForALostDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
            this.replacementForALostDrivingLicenseToolStripMenuItem.Text = "Replacement for a Lost Driving License";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(404, 6);
            // 
            // releaseDetainedDrivingLicsenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicsenseToolStripMenuItem.Name = "releaseDetainedDrivingLicsenseToolStripMenuItem";
            this.releaseDetainedDrivingLicsenseToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
            this.releaseDetainedDrivingLicsenseToolStripMenuItem.Text = "Release Detained Driving Licsense";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
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
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleToolStripMenuItem.Image = global::DVLD.Properties.Resources.People;
            this.peopleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(157, 76);
            this.peopleToolStripMenuItem.Text = "&People";
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
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = global::DVLD.Properties.Resources.Users;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(145, 76);
            this.usersToolStripMenuItem.Text = "&Users";
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
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(250, 32);
            this.tsmChangePassword.Text = "Change Password";
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(250, 32);
            this.tsmLogout.Text = "Sing Out";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 475);
            this.Controls.Add(this.msMainMenuDvld);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmDriversManagement;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem detainedLicencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalDrivingLicense2;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicsenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem replacementForALostDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalDrivingLicense2;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem newLocalDrivingLicenseServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationManagementToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMainMenuDvld;
    }
}