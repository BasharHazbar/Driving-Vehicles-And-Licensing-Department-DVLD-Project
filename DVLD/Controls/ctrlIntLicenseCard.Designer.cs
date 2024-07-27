namespace DVLD.Controls
{
    partial class ctrlIntLicenseCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.lbExpirationDateValue = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.lbDriverIDValue = new System.Windows.Forms.Label();
            this.lbDriverID = new System.Windows.Forms.Label();
            this.lbDateOfBirthValue = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbApplicationIDValue = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.lbNationalNoValue = new System.Windows.Forms.Label();
            this.lbNationalNo = new System.Windows.Forms.Label();
            this.lbGenderValue = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbIssueDateValue = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lbIntLicenseIDValue = new System.Windows.Forms.Label();
            this.lbIntLicenseID = new System.Windows.Forms.Label();
            this.lbNameValue = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gbIntLicenseInfo = new System.Windows.Forms.GroupBox();
            this.lbIsActiveValue = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbLicenseIDValue = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.gbIntLicenseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.Person_Male;
            this.pbPersonImage.Location = new System.Drawing.Point(738, 32);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(191, 190);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 26;
            this.pbPersonImage.TabStop = false;
            // 
            // lbExpirationDateValue
            // 
            this.lbExpirationDateValue.AutoSize = true;
            this.lbExpirationDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDateValue.Location = new System.Drawing.Point(558, 187);
            this.lbExpirationDateValue.Name = "lbExpirationDateValue";
            this.lbExpirationDateValue.Size = new System.Drawing.Size(55, 20);
            this.lbExpirationDateValue.TabIndex = 23;
            this.lbExpirationDateValue.Text = "[????]";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDate.Location = new System.Drawing.Point(390, 188);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(145, 20);
            this.lbExpirationDate.TabIndex = 22;
            this.lbExpirationDate.Text = "Expiration Date:";
            // 
            // lbDriverIDValue
            // 
            this.lbDriverIDValue.AutoSize = true;
            this.lbDriverIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDriverIDValue.Location = new System.Drawing.Point(558, 153);
            this.lbDriverIDValue.Name = "lbDriverIDValue";
            this.lbDriverIDValue.Size = new System.Drawing.Size(55, 20);
            this.lbDriverIDValue.TabIndex = 21;
            this.lbDriverIDValue.Text = "[????]";
            // 
            // lbDriverID
            // 
            this.lbDriverID.AutoSize = true;
            this.lbDriverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDriverID.Location = new System.Drawing.Point(390, 154);
            this.lbDriverID.Name = "lbDriverID";
            this.lbDriverID.Size = new System.Drawing.Size(92, 20);
            this.lbDriverID.TabIndex = 20;
            this.lbDriverID.Text = "Driver ID:";
            // 
            // lbDateOfBirthValue
            // 
            this.lbDateOfBirthValue.AutoSize = true;
            this.lbDateOfBirthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirthValue.Location = new System.Drawing.Point(558, 122);
            this.lbDateOfBirthValue.Name = "lbDateOfBirthValue";
            this.lbDateOfBirthValue.Size = new System.Drawing.Size(55, 20);
            this.lbDateOfBirthValue.TabIndex = 19;
            this.lbDateOfBirthValue.Text = "[????]";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(390, 124);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(128, 20);
            this.lbDateOfBirth.TabIndex = 18;
            this.lbDateOfBirth.Text = "Date Of Birth:";
            // 
            // lbApplicationIDValue
            // 
            this.lbApplicationIDValue.AutoSize = true;
            this.lbApplicationIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationIDValue.Location = new System.Drawing.Point(558, 64);
            this.lbApplicationIDValue.Name = "lbApplicationIDValue";
            this.lbApplicationIDValue.Size = new System.Drawing.Size(55, 20);
            this.lbApplicationIDValue.TabIndex = 17;
            this.lbApplicationIDValue.Text = "[????]";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Location = new System.Drawing.Point(390, 66);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(133, 20);
            this.lbApplicationID.TabIndex = 16;
            this.lbApplicationID.Text = "Application ID:";
            // 
            // lbNationalNoValue
            // 
            this.lbNationalNoValue.AutoSize = true;
            this.lbNationalNoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNoValue.Location = new System.Drawing.Point(165, 124);
            this.lbNationalNoValue.Name = "lbNationalNoValue";
            this.lbNationalNoValue.Size = new System.Drawing.Size(55, 20);
            this.lbNationalNoValue.TabIndex = 15;
            this.lbNationalNoValue.Text = "[????]";
            // 
            // lbNationalNo
            // 
            this.lbNationalNo.AutoSize = true;
            this.lbNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNo.Location = new System.Drawing.Point(6, 124);
            this.lbNationalNo.Name = "lbNationalNo";
            this.lbNationalNo.Size = new System.Drawing.Size(113, 20);
            this.lbNationalNo.TabIndex = 14;
            this.lbNationalNo.Text = "National No:";
            // 
            // lbGenderValue
            // 
            this.lbGenderValue.AutoSize = true;
            this.lbGenderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenderValue.Location = new System.Drawing.Point(165, 154);
            this.lbGenderValue.Name = "lbGenderValue";
            this.lbGenderValue.Size = new System.Drawing.Size(55, 20);
            this.lbGenderValue.TabIndex = 13;
            this.lbGenderValue.Text = "[????]";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(6, 154);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(76, 20);
            this.lbGender.TabIndex = 12;
            this.lbGender.Text = "Gender:";
            // 
            // lbIssueDateValue
            // 
            this.lbIssueDateValue.AutoSize = true;
            this.lbIssueDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDateValue.Location = new System.Drawing.Point(164, 188);
            this.lbIssueDateValue.Name = "lbIssueDateValue";
            this.lbIssueDateValue.Size = new System.Drawing.Size(55, 20);
            this.lbIssueDateValue.TabIndex = 11;
            this.lbIssueDateValue.Text = "[????]";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDate.Location = new System.Drawing.Point(4, 188);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(106, 20);
            this.lbIssueDate.TabIndex = 10;
            this.lbIssueDate.Text = "Issue Date:";
            // 
            // lbIntLicenseIDValue
            // 
            this.lbIntLicenseIDValue.AutoSize = true;
            this.lbIntLicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntLicenseIDValue.Location = new System.Drawing.Point(165, 66);
            this.lbIntLicenseIDValue.Name = "lbIntLicenseIDValue";
            this.lbIntLicenseIDValue.Size = new System.Drawing.Size(55, 20);
            this.lbIntLicenseIDValue.TabIndex = 5;
            this.lbIntLicenseIDValue.Text = "[????]";
            // 
            // lbIntLicenseID
            // 
            this.lbIntLicenseID.AutoSize = true;
            this.lbIntLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntLicenseID.Location = new System.Drawing.Point(6, 66);
            this.lbIntLicenseID.Name = "lbIntLicenseID";
            this.lbIntLicenseID.Size = new System.Drawing.Size(132, 20);
            this.lbIntLicenseID.TabIndex = 4;
            this.lbIntLicenseID.Text = "Int.License ID:";
            // 
            // lbNameValue
            // 
            this.lbNameValue.AutoSize = true;
            this.lbNameValue.BackColor = System.Drawing.SystemColors.Control;
            this.lbNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameValue.ForeColor = System.Drawing.Color.Brown;
            this.lbNameValue.Location = new System.Drawing.Point(164, 32);
            this.lbNameValue.Name = "lbNameValue";
            this.lbNameValue.Size = new System.Drawing.Size(61, 20);
            this.lbNameValue.TabIndex = 3;
            this.lbNameValue.Text = "[????]";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(6, 32);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name:";
            // 
            // gbIntLicenseInfo
            // 
            this.gbIntLicenseInfo.Controls.Add(this.lbLicenseIDValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbLicenseID);
            this.gbIntLicenseInfo.Controls.Add(this.lbIsActiveValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbIsActive);
            this.gbIntLicenseInfo.Controls.Add(this.pbPersonImage);
            this.gbIntLicenseInfo.Controls.Add(this.lbExpirationDateValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbExpirationDate);
            this.gbIntLicenseInfo.Controls.Add(this.lbDriverIDValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbDriverID);
            this.gbIntLicenseInfo.Controls.Add(this.lbDateOfBirthValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbDateOfBirth);
            this.gbIntLicenseInfo.Controls.Add(this.lbApplicationIDValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbApplicationID);
            this.gbIntLicenseInfo.Controls.Add(this.lbNationalNoValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbNationalNo);
            this.gbIntLicenseInfo.Controls.Add(this.lbGenderValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbGender);
            this.gbIntLicenseInfo.Controls.Add(this.lbIssueDateValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbIssueDate);
            this.gbIntLicenseInfo.Controls.Add(this.lbIntLicenseIDValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbIntLicenseID);
            this.gbIntLicenseInfo.Controls.Add(this.lbNameValue);
            this.gbIntLicenseInfo.Controls.Add(this.lbName);
            this.gbIntLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIntLicenseInfo.ForeColor = System.Drawing.Color.Black;
            this.gbIntLicenseInfo.Location = new System.Drawing.Point(3, 3);
            this.gbIntLicenseInfo.Name = "gbIntLicenseInfo";
            this.gbIntLicenseInfo.Size = new System.Drawing.Size(958, 246);
            this.gbIntLicenseInfo.TabIndex = 7;
            this.gbIntLicenseInfo.TabStop = false;
            this.gbIntLicenseInfo.Text = "Driver International License Info";
            // 
            // lbIsActiveValue
            // 
            this.lbIsActiveValue.AutoSize = true;
            this.lbIsActiveValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActiveValue.Location = new System.Drawing.Point(558, 93);
            this.lbIsActiveValue.Name = "lbIsActiveValue";
            this.lbIsActiveValue.Size = new System.Drawing.Size(55, 20);
            this.lbIsActiveValue.TabIndex = 30;
            this.lbIsActiveValue.Text = "[????]";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.Location = new System.Drawing.Point(390, 95);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(92, 20);
            this.lbIsActive.TabIndex = 29;
            this.lbIsActive.Text = "Is Active?";
            // 
            // lbLicenseIDValue
            // 
            this.lbLicenseIDValue.AutoSize = true;
            this.lbLicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseIDValue.Location = new System.Drawing.Point(165, 95);
            this.lbLicenseIDValue.Name = "lbLicenseIDValue";
            this.lbLicenseIDValue.Size = new System.Drawing.Size(55, 20);
            this.lbLicenseIDValue.TabIndex = 32;
            this.lbLicenseIDValue.Text = "[????]";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(6, 95);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(106, 20);
            this.lbLicenseID.TabIndex = 31;
            this.lbLicenseID.Text = "License ID:";
            // 
            // ctrlIntLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbIntLicenseInfo);
            this.Name = "ctrlIntLicenseDetails";
            this.Size = new System.Drawing.Size(965, 254);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.gbIntLicenseInfo.ResumeLayout(false);
            this.gbIntLicenseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lbExpirationDateValue;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label lbDriverIDValue;
        private System.Windows.Forms.Label lbDriverID;
        private System.Windows.Forms.Label lbDateOfBirthValue;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbApplicationIDValue;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label lbNationalNoValue;
        private System.Windows.Forms.Label lbNationalNo;
        private System.Windows.Forms.Label lbGenderValue;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbIssueDateValue;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label lbIntLicenseIDValue;
        private System.Windows.Forms.Label lbIntLicenseID;
        private System.Windows.Forms.Label lbNameValue;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbIntLicenseInfo;
        private System.Windows.Forms.Label lbIsActiveValue;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbLicenseIDValue;
        private System.Windows.Forms.Label lbLicenseID;
    }
}
