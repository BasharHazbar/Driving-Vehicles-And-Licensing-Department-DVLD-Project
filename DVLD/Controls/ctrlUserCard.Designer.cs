namespace DVLD.Controls
{
    partial class ctrlUserCard
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
            this.gbUserInformation = new System.Windows.Forms.GroupBox();
            this.lbIsAtiveValue = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbUserNameValue = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserIDValue = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.gbUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserInformation
            // 
            this.gbUserInformation.Controls.Add(this.lbIsAtiveValue);
            this.gbUserInformation.Controls.Add(this.lbIsActive);
            this.gbUserInformation.Controls.Add(this.lbUserNameValue);
            this.gbUserInformation.Controls.Add(this.lbUserName);
            this.gbUserInformation.Controls.Add(this.lbUserIDValue);
            this.gbUserInformation.Controls.Add(this.lbUserID);
            this.gbUserInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserInformation.Location = new System.Drawing.Point(3, 3);
            this.gbUserInformation.Name = "gbUserInformation";
            this.gbUserInformation.Size = new System.Drawing.Size(870, 105);
            this.gbUserInformation.TabIndex = 1;
            this.gbUserInformation.TabStop = false;
            this.gbUserInformation.Text = "User Information";
            // 
            // lbIsAtiveValue
            // 
            this.lbIsAtiveValue.AutoSize = true;
            this.lbIsAtiveValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsAtiveValue.Location = new System.Drawing.Point(697, 48);
            this.lbIsAtiveValue.Name = "lbIsAtiveValue";
            this.lbIsAtiveValue.Size = new System.Drawing.Size(55, 20);
            this.lbIsAtiveValue.TabIndex = 5;
            this.lbIsAtiveValue.Text = "[????]";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.Location = new System.Drawing.Point(591, 48);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(100, 20);
            this.lbIsActive.TabIndex = 4;
            this.lbIsActive.Text = "Is Active : ";
            // 
            // lbUserNameValue
            // 
            this.lbUserNameValue.AutoSize = true;
            this.lbUserNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNameValue.Location = new System.Drawing.Point(454, 51);
            this.lbUserNameValue.Name = "lbUserNameValue";
            this.lbUserNameValue.Size = new System.Drawing.Size(55, 20);
            this.lbUserNameValue.TabIndex = 3;
            this.lbUserNameValue.Text = "[????]";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(327, 49);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(112, 20);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Username : ";
            // 
            // lbUserIDValue
            // 
            this.lbUserIDValue.AutoSize = true;
            this.lbUserIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserIDValue.Location = new System.Drawing.Point(188, 48);
            this.lbUserIDValue.Name = "lbUserIDValue";
            this.lbUserIDValue.Size = new System.Drawing.Size(55, 20);
            this.lbUserIDValue.TabIndex = 1;
            this.lbUserIDValue.Text = "[????]";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(88, 48);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(92, 20);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "User ID : ";
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbUserInformation);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(880, 116);
            this.gbUserInformation.ResumeLayout(false);
            this.gbUserInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserInformation;
        private System.Windows.Forms.Label lbIsAtiveValue;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbUserNameValue;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserIDValue;
        private System.Windows.Forms.Label lbUserID;
    }
}
