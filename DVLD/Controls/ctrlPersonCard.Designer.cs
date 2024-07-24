namespace DVLD.Controls
{
    partial class ctrlPersonCard
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
            this.lbEditPersonInfo = new System.Windows.Forms.LinkLabel();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.lbCountryValue = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbAddressValue = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbDateOfBirthValue = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPhoneValue = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbGendorValue = new System.Windows.Forms.Label();
            this.lbGendor = new System.Windows.Forms.Label();
            this.lbNationalNOValue = new System.Windows.Forms.Label();
            this.lbNationalNO = new System.Windows.Forms.Label();
            this.lbEmailValue = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNameValue = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPersonIDValue = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.gbPersonInformation = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.gbPersonInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEditPersonInfo
            // 
            this.lbEditPersonInfo.ActiveLinkColor = System.Drawing.Color.SlateBlue;
            this.lbEditPersonInfo.AutoSize = true;
            this.lbEditPersonInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbEditPersonInfo.Location = new System.Drawing.Point(704, 55);
            this.lbEditPersonInfo.Name = "lbEditPersonInfo";
            this.lbEditPersonInfo.Size = new System.Drawing.Size(128, 20);
            this.lbEditPersonInfo.TabIndex = 21;
            this.lbEditPersonInfo.TabStop = true;
            this.lbEditPersonInfo.Text = "Edit Person Info";
            this.lbEditPersonInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbEditPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbEditPersonInfo_LinkClicked);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.Person_Male;
            this.pbPersonImage.Location = new System.Drawing.Point(680, 88);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(191, 190);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 20;
            this.pbPersonImage.TabStop = false;
            // 
            // lbCountryValue
            // 
            this.lbCountryValue.AutoSize = true;
            this.lbCountryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountryValue.Location = new System.Drawing.Point(533, 199);
            this.lbCountryValue.Name = "lbCountryValue";
            this.lbCountryValue.Size = new System.Drawing.Size(55, 20);
            this.lbCountryValue.TabIndex = 19;
            this.lbCountryValue.Text = "[????]";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(397, 199);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(80, 20);
            this.lbCountry.TabIndex = 18;
            this.lbCountry.Text = "Country:";
            // 
            // lbAddressValue
            // 
            this.lbAddressValue.AutoSize = true;
            this.lbAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddressValue.Location = new System.Drawing.Point(156, 240);
            this.lbAddressValue.Name = "lbAddressValue";
            this.lbAddressValue.Size = new System.Drawing.Size(55, 20);
            this.lbAddressValue.TabIndex = 17;
            this.lbAddressValue.Text = "[????]";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(19, 240);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(84, 20);
            this.lbAddress.TabIndex = 16;
            this.lbAddress.Text = "Address:";
            // 
            // lbDateOfBirthValue
            // 
            this.lbDateOfBirthValue.AutoSize = true;
            this.lbDateOfBirthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirthValue.Location = new System.Drawing.Point(534, 121);
            this.lbDateOfBirthValue.Name = "lbDateOfBirthValue";
            this.lbDateOfBirthValue.Size = new System.Drawing.Size(55, 20);
            this.lbDateOfBirthValue.TabIndex = 15;
            this.lbDateOfBirthValue.Text = "[????]";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(397, 121);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(134, 20);
            this.lbDateOfBirth.TabIndex = 14;
            this.lbDateOfBirth.Text = "Date Of Birth: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 12;
            // 
            // lbPhoneValue
            // 
            this.lbPhoneValue.AutoSize = true;
            this.lbPhoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneValue.Location = new System.Drawing.Point(533, 159);
            this.lbPhoneValue.Name = "lbPhoneValue";
            this.lbPhoneValue.Size = new System.Drawing.Size(55, 20);
            this.lbPhoneValue.TabIndex = 11;
            this.lbPhoneValue.Text = "[????]";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(397, 159);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(67, 20);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "Phone:";
            // 
            // lbGendorValue
            // 
            this.lbGendorValue.AutoSize = true;
            this.lbGendorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGendorValue.Location = new System.Drawing.Point(156, 202);
            this.lbGendorValue.Name = "lbGendorValue";
            this.lbGendorValue.Size = new System.Drawing.Size(55, 20);
            this.lbGendorValue.TabIndex = 9;
            this.lbGendorValue.Text = "[????]";
            // 
            // lbGendor
            // 
            this.lbGendor.AutoSize = true;
            this.lbGendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGendor.Location = new System.Drawing.Point(19, 202);
            this.lbGendor.Name = "lbGendor";
            this.lbGendor.Size = new System.Drawing.Size(76, 20);
            this.lbGendor.TabIndex = 8;
            this.lbGendor.Text = "Gendor:";
            // 
            // lbNationalNOValue
            // 
            this.lbNationalNOValue.AutoSize = true;
            this.lbNationalNOValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNOValue.Location = new System.Drawing.Point(159, 123);
            this.lbNationalNOValue.Name = "lbNationalNOValue";
            this.lbNationalNOValue.Size = new System.Drawing.Size(55, 20);
            this.lbNationalNOValue.TabIndex = 7;
            this.lbNationalNOValue.Text = "[????]";
            // 
            // lbNationalNO
            // 
            this.lbNationalNO.AutoSize = true;
            this.lbNationalNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNO.Location = new System.Drawing.Point(19, 123);
            this.lbNationalNO.Name = "lbNationalNO";
            this.lbNationalNO.Size = new System.Drawing.Size(113, 20);
            this.lbNationalNO.TabIndex = 6;
            this.lbNationalNO.Text = "National No:";
            // 
            // lbEmailValue
            // 
            this.lbEmailValue.AutoSize = true;
            this.lbEmailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailValue.Location = new System.Drawing.Point(159, 161);
            this.lbEmailValue.Name = "lbEmailValue";
            this.lbEmailValue.Size = new System.Drawing.Size(55, 20);
            this.lbEmailValue.TabIndex = 5;
            this.lbEmailValue.Text = "[????]";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(19, 161);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(62, 20);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email:";
            // 
            // lbNameValue
            // 
            this.lbNameValue.AutoSize = true;
            this.lbNameValue.BackColor = System.Drawing.Color.Red;
            this.lbNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameValue.Location = new System.Drawing.Point(160, 89);
            this.lbNameValue.Name = "lbNameValue";
            this.lbNameValue.Size = new System.Drawing.Size(55, 20);
            this.lbNameValue.TabIndex = 3;
            this.lbNameValue.Text = "[????]";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(19, 89);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name:";
            // 
            // lbPersonIDValue
            // 
            this.lbPersonIDValue.AutoSize = true;
            this.lbPersonIDValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPersonIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonIDValue.Location = new System.Drawing.Point(160, 55);
            this.lbPersonIDValue.Name = "lbPersonIDValue";
            this.lbPersonIDValue.Size = new System.Drawing.Size(55, 20);
            this.lbPersonIDValue.TabIndex = 1;
            this.lbPersonIDValue.Text = "[????]";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(19, 55);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(99, 20);
            this.lbPersonID.TabIndex = 0;
            this.lbPersonID.Text = "Person ID:";
            // 
            // gbPersonInformation
            // 
            this.gbPersonInformation.Controls.Add(this.lbEditPersonInfo);
            this.gbPersonInformation.Controls.Add(this.pbPersonImage);
            this.gbPersonInformation.Controls.Add(this.lbCountryValue);
            this.gbPersonInformation.Controls.Add(this.lbCountry);
            this.gbPersonInformation.Controls.Add(this.lbAddressValue);
            this.gbPersonInformation.Controls.Add(this.lbAddress);
            this.gbPersonInformation.Controls.Add(this.lbDateOfBirthValue);
            this.gbPersonInformation.Controls.Add(this.lbDateOfBirth);
            this.gbPersonInformation.Controls.Add(this.label4);
            this.gbPersonInformation.Controls.Add(this.label5);
            this.gbPersonInformation.Controls.Add(this.lbPhoneValue);
            this.gbPersonInformation.Controls.Add(this.lbPhone);
            this.gbPersonInformation.Controls.Add(this.lbGendorValue);
            this.gbPersonInformation.Controls.Add(this.lbGendor);
            this.gbPersonInformation.Controls.Add(this.lbNationalNOValue);
            this.gbPersonInformation.Controls.Add(this.lbNationalNO);
            this.gbPersonInformation.Controls.Add(this.lbEmailValue);
            this.gbPersonInformation.Controls.Add(this.lbEmail);
            this.gbPersonInformation.Controls.Add(this.lbNameValue);
            this.gbPersonInformation.Controls.Add(this.lbName);
            this.gbPersonInformation.Controls.Add(this.lbPersonIDValue);
            this.gbPersonInformation.Controls.Add(this.lbPersonID);
            this.gbPersonInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonInformation.Location = new System.Drawing.Point(3, 3);
            this.gbPersonInformation.Name = "gbPersonInformation";
            this.gbPersonInformation.Size = new System.Drawing.Size(898, 295);
            this.gbPersonInformation.TabIndex = 1;
            this.gbPersonInformation.TabStop = false;
            this.gbPersonInformation.Text = "Person Information";
            // 
            // ctrlPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPersonInformation);
            this.Name = "ctrlPersonCard";
            this.Size = new System.Drawing.Size(906, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.gbPersonInformation.ResumeLayout(false);
            this.gbPersonInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbEditPersonInfo;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lbCountryValue;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbAddressValue;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbDateOfBirthValue;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPhoneValue;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbGendorValue;
        private System.Windows.Forms.Label lbGendor;
        private System.Windows.Forms.Label lbNationalNOValue;
        private System.Windows.Forms.Label lbNationalNO;
        private System.Windows.Forms.Label lbEmailValue;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNameValue;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPersonIDValue;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.GroupBox gbPersonInformation;
    }
}
