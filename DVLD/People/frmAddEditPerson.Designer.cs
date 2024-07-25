namespace DVLD.People
{
    partial class frmAddEditPerson
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
            this.lbPersonID = new System.Windows.Forms.Label();
            this.lbPersonIDValue = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNationalNO = new System.Windows.Forms.Label();
            this.lbGendor = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.gbPersonInformation = new System.Windows.Forms.GroupBox();
            this.lbMode = new System.Windows.Forms.Label();
            this.lbRemoveImage = new System.Windows.Forms.Label();
            this.lbSetImage = new System.Windows.Forms.Label();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDataOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbAddress = new System.Windows.Forms.RichTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.lbLast = new System.Windows.Forms.Label();
            this.lbThird = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.lbFirst = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.tbThird = new System.Windows.Forms.TextBox();
            this.epValidating = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdLoadingImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.gbPersonInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidating)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(16, 69);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(99, 20);
            this.lbPersonID.TabIndex = 22;
            this.lbPersonID.Text = "Person ID:";
            // 
            // lbPersonIDValue
            // 
            this.lbPersonIDValue.AutoSize = true;
            this.lbPersonIDValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPersonIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonIDValue.Location = new System.Drawing.Point(137, 70);
            this.lbPersonIDValue.Name = "lbPersonIDValue";
            this.lbPersonIDValue.Size = new System.Drawing.Size(37, 20);
            this.lbPersonIDValue.TabIndex = 23;
            this.lbPersonIDValue.Text = "N/A";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(16, 103);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 20);
            this.lbName.TabIndex = 24;
            this.lbName.Text = "Name:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(16, 218);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(62, 20);
            this.lbEmail.TabIndex = 26;
            this.lbEmail.Text = "Email:";
            // 
            // lbNationalNO
            // 
            this.lbNationalNO.AutoSize = true;
            this.lbNationalNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNO.Location = new System.Drawing.Point(16, 140);
            this.lbNationalNO.Name = "lbNationalNO";
            this.lbNationalNO.Size = new System.Drawing.Size(113, 20);
            this.lbNationalNO.TabIndex = 28;
            this.lbNationalNO.Text = "National No:";
            // 
            // lbGendor
            // 
            this.lbGendor.AutoSize = true;
            this.lbGendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGendor.Location = new System.Drawing.Point(16, 179);
            this.lbGendor.Name = "lbGendor";
            this.lbGendor.Size = new System.Drawing.Size(76, 20);
            this.lbGendor.TabIndex = 30;
            this.lbGendor.Text = "Gendor:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(445, 177);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(67, 20);
            this.lbPhone.TabIndex = 32;
            this.lbPhone.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 35;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(445, 137);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(134, 20);
            this.lbDateOfBirth.TabIndex = 36;
            this.lbDateOfBirth.Text = "Date Of Birth: ";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(16, 261);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(84, 20);
            this.lbAddress.TabIndex = 38;
            this.lbAddress.Text = "Address:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(445, 215);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(80, 20);
            this.lbCountry.TabIndex = 40;
            this.lbCountry.Text = "Country:";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.Person_Male;
            this.pbPersonImage.Location = new System.Drawing.Point(831, 140);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(191, 190);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 42;
            this.pbPersonImage.TabStop = false;
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(368, 96);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(195, 27);
            this.tbSecond.TabIndex = 2;
            this.tbSecond.Validating += new System.ComponentModel.CancelEventHandler(this.tbSecond_Validating);
            // 
            // gbPersonInformation
            // 
            this.gbPersonInformation.Controls.Add(this.lbMode);
            this.gbPersonInformation.Controls.Add(this.lbRemoveImage);
            this.gbPersonInformation.Controls.Add(this.lbSetImage);
            this.gbPersonInformation.Controls.Add(this.cbCountries);
            this.gbPersonInformation.Controls.Add(this.tbPhone);
            this.gbPersonInformation.Controls.Add(this.btnClose);
            this.gbPersonInformation.Controls.Add(this.btnSave);
            this.gbPersonInformation.Controls.Add(this.dtpDataOfBirth);
            this.gbPersonInformation.Controls.Add(this.tbAddress);
            this.gbPersonInformation.Controls.Add(this.tbEmail);
            this.gbPersonInformation.Controls.Add(this.rbFemale);
            this.gbPersonInformation.Controls.Add(this.rbMale);
            this.gbPersonInformation.Controls.Add(this.tbNationalNo);
            this.gbPersonInformation.Controls.Add(this.lbLast);
            this.gbPersonInformation.Controls.Add(this.lbThird);
            this.gbPersonInformation.Controls.Add(this.lbSecond);
            this.gbPersonInformation.Controls.Add(this.lbFirst);
            this.gbPersonInformation.Controls.Add(this.tbFirst);
            this.gbPersonInformation.Controls.Add(this.tbLast);
            this.gbPersonInformation.Controls.Add(this.tbThird);
            this.gbPersonInformation.Controls.Add(this.tbSecond);
            this.gbPersonInformation.Controls.Add(this.pbPersonImage);
            this.gbPersonInformation.Controls.Add(this.lbCountry);
            this.gbPersonInformation.Controls.Add(this.lbAddress);
            this.gbPersonInformation.Controls.Add(this.lbDateOfBirth);
            this.gbPersonInformation.Controls.Add(this.label4);
            this.gbPersonInformation.Controls.Add(this.label5);
            this.gbPersonInformation.Controls.Add(this.lbPhone);
            this.gbPersonInformation.Controls.Add(this.lbGendor);
            this.gbPersonInformation.Controls.Add(this.lbNationalNO);
            this.gbPersonInformation.Controls.Add(this.lbEmail);
            this.gbPersonInformation.Controls.Add(this.lbName);
            this.gbPersonInformation.Controls.Add(this.lbPersonIDValue);
            this.gbPersonInformation.Controls.Add(this.lbPersonID);
            this.gbPersonInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonInformation.Location = new System.Drawing.Point(12, 12);
            this.gbPersonInformation.Name = "gbPersonInformation";
            this.gbPersonInformation.Size = new System.Drawing.Size(1047, 445);
            this.gbPersonInformation.TabIndex = 2;
            this.gbPersonInformation.TabStop = false;
            this.gbPersonInformation.Text = "Add / Edit Person";
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.ForeColor = System.Drawing.Color.Red;
            this.lbMode.Location = new System.Drawing.Point(433, 23);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(149, 29);
            this.lbMode.TabIndex = 63;
            this.lbMode.Text = "Add Person";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRemoveImage
            // 
            this.lbRemoveImage.AutoSize = true;
            this.lbRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemoveImage.Location = new System.Drawing.Point(898, 373);
            this.lbRemoveImage.Name = "lbRemoveImage";
            this.lbRemoveImage.Size = new System.Drawing.Size(70, 20);
            this.lbRemoveImage.TabIndex = 62;
            this.lbRemoveImage.Text = "Remove";
            this.lbRemoveImage.Click += new System.EventHandler(this.lbRemoveImage_Click);
            // 
            // lbSetImage
            // 
            this.lbSetImage.AutoSize = true;
            this.lbSetImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetImage.Location = new System.Drawing.Point(890, 341);
            this.lbSetImage.Name = "lbSetImage";
            this.lbSetImage.Size = new System.Drawing.Size(84, 20);
            this.lbSetImage.TabIndex = 61;
            this.lbSetImage.Text = "Set Image";
            this.lbSetImage.Click += new System.EventHandler(this.lbSetImage_Click);
            // 
            // cbCountries
            // 
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(601, 218);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(195, 28);
            this.cbCountries.TabIndex = 60;
            this.cbCountries.Validating += new System.ComponentModel.CancelEventHandler(this.cbCountries_Validating);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(601, 179);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(195, 27);
            this.tbPhone.TabIndex = 9;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(484, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 46);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(654, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 46);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDataOfBirth
            // 
            this.dtpDataOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataOfBirth.Location = new System.Drawing.Point(601, 135);
            this.dtpDataOfBirth.Name = "dtpDataOfBirth";
            this.dtpDataOfBirth.Size = new System.Drawing.Size(195, 27);
            this.dtpDataOfBirth.TabIndex = 6;
            // 
            // tbAddress
            // 
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Location = new System.Drawing.Point(141, 261);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(655, 100);
            this.tbAddress.TabIndex = 56;
            this.tbAddress.Text = "";
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddress_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(141, 215);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(195, 27);
            this.tbEmail.TabIndex = 10;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(251, 176);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 24);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(141, 177);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 24);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Location = new System.Drawing.Point(141, 137);
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.Size = new System.Drawing.Size(195, 27);
            this.tbNationalNo.TabIndex = 5;
            this.tbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tbNationalNo_Validating);
            // 
            // lbLast
            // 
            this.lbLast.AutoSize = true;
            this.lbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLast.Location = new System.Drawing.Point(890, 69);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(46, 20);
            this.lbLast.TabIndex = 51;
            this.lbLast.Text = "Last";
            // 
            // lbThird
            // 
            this.lbThird.AutoSize = true;
            this.lbThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThird.Location = new System.Drawing.Point(661, 69);
            this.lbThird.Name = "lbThird";
            this.lbThird.Size = new System.Drawing.Size(52, 20);
            this.lbThird.TabIndex = 50;
            this.lbThird.Text = "Third";
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecond.Location = new System.Drawing.Point(432, 69);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(71, 20);
            this.lbSecond.TabIndex = 49;
            this.lbSecond.Text = "Second";
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirst.Location = new System.Drawing.Point(211, 69);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(48, 20);
            this.lbFirst.TabIndex = 48;
            this.lbFirst.Text = "First";
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(141, 96);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(195, 27);
            this.tbFirst.TabIndex = 1;
            this.tbFirst.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirst_Validating);
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(827, 96);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(195, 27);
            this.tbLast.TabIndex = 4;
            this.tbLast.Validating += new System.ComponentModel.CancelEventHandler(this.tbLast_Validating);
            // 
            // tbThird
            // 
            this.tbThird.Location = new System.Drawing.Point(601, 96);
            this.tbThird.Name = "tbThird";
            this.tbThird.Size = new System.Drawing.Size(195, 27);
            this.tbThird.TabIndex = 3;
            // 
            // epValidating
            // 
            this.epValidating.ContainerControl = this;
            // 
            // ofdLoadingImage
            // 
            this.ofdLoadingImage.FileName = "openFileDialog1";
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 461);
            this.Controls.Add(this.gbPersonInformation);
            this.Name = "frmAddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Person";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.gbPersonInformation.ResumeLayout(false);
            this.gbPersonInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label lbPersonIDValue;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNationalNO;
        private System.Windows.Forms.Label lbGendor;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.GroupBox gbPersonInformation;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.TextBox tbThird;
        private System.Windows.Forms.Label lbFirst;
        private System.Windows.Forms.Label lbLast;
        private System.Windows.Forms.Label lbThird;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.TextBox tbNationalNo;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RichTextBox tbAddress;
        private System.Windows.Forms.ErrorProvider epValidating;
        private System.Windows.Forms.DateTimePicker dtpDataOfBirth;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.Label lbSetImage;
        private System.Windows.Forms.Label lbRemoveImage;
        private System.Windows.Forms.OpenFileDialog ofdLoadingImage;
        private System.Windows.Forms.Label lbMode;
    }
}