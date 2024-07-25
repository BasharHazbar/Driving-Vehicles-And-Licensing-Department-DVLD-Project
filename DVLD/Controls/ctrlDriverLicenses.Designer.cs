namespace DVLD.Controls
{
    partial class ctrlDriverLicenses
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
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.tcDriverLicense = new System.Windows.Forms.TabControl();
            this.tpLocalDrivingLicenses = new System.Windows.Forms.TabPage();
            this.lbLocalRecordsCountValue = new System.Windows.Forms.Label();
            this.dgvLocalDrivingLicensesList = new System.Windows.Forms.DataGridView();
            this.lbLocalRecordsCount = new System.Windows.Forms.Label();
            this.tpInternationalDrivingLicenses = new System.Windows.Forms.TabPage();
            this.lbInternationalRecordsCountValue = new System.Windows.Forms.Label();
            this.lbInternationalRecordsCount = new System.Windows.Forms.Label();
            this.dgvInternationalDrivingLicensesList = new System.Windows.Forms.DataGridView();
            this.gbDriverLicenses.SuspendLayout();
            this.tcDriverLicense.SuspendLayout();
            this.tpLocalDrivingLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicensesList)).BeginInit();
            this.tpInternationalDrivingLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDrivingLicensesList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.tcDriverLicense);
            this.gbDriverLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDriverLicenses.Location = new System.Drawing.Point(3, 0);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(1110, 355);
            this.gbDriverLicenses.TabIndex = 0;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // tcDriverLicense
            // 
            this.tcDriverLicense.Controls.Add(this.tpLocalDrivingLicenses);
            this.tcDriverLicense.Controls.Add(this.tpInternationalDrivingLicenses);
            this.tcDriverLicense.Location = new System.Drawing.Point(17, 24);
            this.tcDriverLicense.Name = "tcDriverLicense";
            this.tcDriverLicense.SelectedIndex = 0;
            this.tcDriverLicense.Size = new System.Drawing.Size(1078, 331);
            this.tcDriverLicense.TabIndex = 0;
            // 
            // tpLocalDrivingLicenses
            // 
            this.tpLocalDrivingLicenses.Controls.Add(this.lbLocalRecordsCountValue);
            this.tpLocalDrivingLicenses.Controls.Add(this.dgvLocalDrivingLicensesList);
            this.tpLocalDrivingLicenses.Controls.Add(this.lbLocalRecordsCount);
            this.tpLocalDrivingLicenses.Location = new System.Drawing.Point(4, 29);
            this.tpLocalDrivingLicenses.Name = "tpLocalDrivingLicenses";
            this.tpLocalDrivingLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalDrivingLicenses.Size = new System.Drawing.Size(1070, 298);
            this.tpLocalDrivingLicenses.TabIndex = 0;
            this.tpLocalDrivingLicenses.Text = "Local";
            this.tpLocalDrivingLicenses.UseVisualStyleBackColor = true;
            // 
            // lbLocalRecordsCountValue
            // 
            this.lbLocalRecordsCountValue.AutoSize = true;
            this.lbLocalRecordsCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalRecordsCountValue.Location = new System.Drawing.Point(144, 257);
            this.lbLocalRecordsCountValue.Name = "lbLocalRecordsCountValue";
            this.lbLocalRecordsCountValue.Size = new System.Drawing.Size(60, 22);
            this.lbLocalRecordsCountValue.TabIndex = 42;
            this.lbLocalRecordsCountValue.Text = "[????]";
            // 
            // dgvLocalDrivingLicensesList
            // 
            this.dgvLocalDrivingLicensesList.AllowUserToAddRows = false;
            this.dgvLocalDrivingLicensesList.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingLicensesList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLocalDrivingLicensesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLocalDrivingLicensesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicensesList.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvLocalDrivingLicensesList.Location = new System.Drawing.Point(27, 14);
            this.dgvLocalDrivingLicensesList.Name = "dgvLocalDrivingLicensesList";
            this.dgvLocalDrivingLicensesList.ReadOnly = true;
            this.dgvLocalDrivingLicensesList.RowHeadersWidth = 51;
            this.dgvLocalDrivingLicensesList.RowTemplate.Height = 24;
            this.dgvLocalDrivingLicensesList.Size = new System.Drawing.Size(1018, 229);
            this.dgvLocalDrivingLicensesList.TabIndex = 37;
            // 
            // lbLocalRecordsCount
            // 
            this.lbLocalRecordsCount.AutoSize = true;
            this.lbLocalRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalRecordsCount.Location = new System.Drawing.Point(25, 257);
            this.lbLocalRecordsCount.Name = "lbLocalRecordsCount";
            this.lbLocalRecordsCount.Size = new System.Drawing.Size(107, 22);
            this.lbLocalRecordsCount.TabIndex = 41;
            this.lbLocalRecordsCount.Text = "# Records : ";
            // 
            // tpInternationalDrivingLicenses
            // 
            this.tpInternationalDrivingLicenses.Controls.Add(this.lbInternationalRecordsCountValue);
            this.tpInternationalDrivingLicenses.Controls.Add(this.lbInternationalRecordsCount);
            this.tpInternationalDrivingLicenses.Controls.Add(this.dgvInternationalDrivingLicensesList);
            this.tpInternationalDrivingLicenses.Location = new System.Drawing.Point(4, 29);
            this.tpInternationalDrivingLicenses.Name = "tpInternationalDrivingLicenses";
            this.tpInternationalDrivingLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternationalDrivingLicenses.Size = new System.Drawing.Size(1070, 298);
            this.tpInternationalDrivingLicenses.TabIndex = 1;
            this.tpInternationalDrivingLicenses.Text = "International";
            this.tpInternationalDrivingLicenses.UseVisualStyleBackColor = true;
            // 
            // lbInternationalRecordsCountValue
            // 
            this.lbInternationalRecordsCountValue.AutoSize = true;
            this.lbInternationalRecordsCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalRecordsCountValue.Location = new System.Drawing.Point(137, 258);
            this.lbInternationalRecordsCountValue.Name = "lbInternationalRecordsCountValue";
            this.lbInternationalRecordsCountValue.Size = new System.Drawing.Size(60, 22);
            this.lbInternationalRecordsCountValue.TabIndex = 44;
            this.lbInternationalRecordsCountValue.Text = "[????]";
            // 
            // lbInternationalRecordsCount
            // 
            this.lbInternationalRecordsCount.AutoSize = true;
            this.lbInternationalRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalRecordsCount.Location = new System.Drawing.Point(17, 258);
            this.lbInternationalRecordsCount.Name = "lbInternationalRecordsCount";
            this.lbInternationalRecordsCount.Size = new System.Drawing.Size(107, 22);
            this.lbInternationalRecordsCount.TabIndex = 43;
            this.lbInternationalRecordsCount.Text = "# Records : ";
            // 
            // dgvInternationalDrivingLicensesList
            // 
            this.dgvInternationalDrivingLicensesList.AllowUserToAddRows = false;
            this.dgvInternationalDrivingLicensesList.AllowUserToDeleteRows = false;
            this.dgvInternationalDrivingLicensesList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInternationalDrivingLicensesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInternationalDrivingLicensesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalDrivingLicensesList.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvInternationalDrivingLicensesList.Location = new System.Drawing.Point(27, 15);
            this.dgvInternationalDrivingLicensesList.Name = "dgvInternationalDrivingLicensesList";
            this.dgvInternationalDrivingLicensesList.ReadOnly = true;
            this.dgvInternationalDrivingLicensesList.RowHeadersWidth = 51;
            this.dgvInternationalDrivingLicensesList.RowTemplate.Height = 24;
            this.dgvInternationalDrivingLicensesList.Size = new System.Drawing.Size(1018, 229);
            this.dgvInternationalDrivingLicensesList.TabIndex = 38;
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDriverLicenses);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1117, 354);
            this.gbDriverLicenses.ResumeLayout(false);
            this.tcDriverLicense.ResumeLayout(false);
            this.tpLocalDrivingLicenses.ResumeLayout(false);
            this.tpLocalDrivingLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicensesList)).EndInit();
            this.tpInternationalDrivingLicenses.ResumeLayout(false);
            this.tpInternationalDrivingLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDrivingLicensesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.TabControl tcDriverLicense;
        private System.Windows.Forms.TabPage tpLocalDrivingLicenses;
        private System.Windows.Forms.TabPage tpInternationalDrivingLicenses;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicensesList;
        private System.Windows.Forms.DataGridView dgvInternationalDrivingLicensesList;
        private System.Windows.Forms.Label lbLocalRecordsCountValue;
        private System.Windows.Forms.Label lbLocalRecordsCount;
        private System.Windows.Forms.Label lbInternationalRecordsCountValue;
        private System.Windows.Forms.Label lbInternationalRecordsCount;
    }
}
