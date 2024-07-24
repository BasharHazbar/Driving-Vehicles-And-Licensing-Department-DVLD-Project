namespace DVLD.Controls
{
    partial class ctrlFindLicenseCard
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.pbFindLicense = new System.Windows.Forms.PictureBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.ctrlLicenseCard1 = new DVLD.Controls.ctrlLicenseCard();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.pbFindLicense);
            this.gbFilter.Controls.Add(this.tbFind);
            this.gbFilter.Controls.Add(this.lbLicenseID);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(541, 98);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // pbFindLicense
            // 
            this.pbFindLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFindLicense.Image = global::DVLD.Properties.Resources.Add_Person;
            this.pbFindLicense.Location = new System.Drawing.Point(394, 34);
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
            this.tbFind.Location = new System.Drawing.Point(141, 42);
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
            // ctrlLicenseCard1
            // 
            this.ctrlLicenseCard1.Location = new System.Drawing.Point(0, 103);
            this.ctrlLicenseCard1.Name = "ctrlLicenseCard1";
            this.ctrlLicenseCard1.Size = new System.Drawing.Size(966, 316);
            this.ctrlLicenseCard1.TabIndex = 4;
            // 
            // ctrlFindLicenseCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlLicenseCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlFindLicenseCard";
            this.Size = new System.Drawing.Size(967, 420);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindLicense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.PictureBox pbFindLicense;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label lbLicenseID;
        private ctrlLicenseCard ctrlLicenseCard1;
    }
}
