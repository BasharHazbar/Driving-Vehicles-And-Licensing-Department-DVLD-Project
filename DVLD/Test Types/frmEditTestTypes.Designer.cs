namespace DVLD.Test_Types
{
    partial class frmEditTestTypes
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
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.lbTittle = new System.Windows.Forms.Label();
            this.tbTittle = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbFees = new System.Windows.Forms.MaskedTextBox();
            this.lbTestTypeIDValue = new System.Windows.Forms.Label();
            this.lbTestTypeID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbUpdateApplicationTypes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Location = new System.Drawing.Point(120, 173);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(302, 96);
            this.tbDescription.TabIndex = 53;
            this.tbDescription.Text = "";
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(19, 120);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(46, 20);
            this.lbTittle.TabIndex = 52;
            this.lbTittle.Text = "Tittle";
            // 
            // tbTittle
            // 
            this.tbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTittle.Location = new System.Drawing.Point(120, 120);
            this.tbTittle.Name = "tbTittle";
            this.tbTittle.Size = new System.Drawing.Size(302, 28);
            this.tbTittle.TabIndex = 51;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(19, 173);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(95, 20);
            this.lbDescription.TabIndex = 50;
            this.lbDescription.Text = "Description";
            // 
            // tbFees
            // 
            this.tbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFees.Location = new System.Drawing.Point(116, 284);
            this.tbFees.Mask = "00000";
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(302, 27);
            this.tbFees.TabIndex = 43;
            this.tbFees.ValidatingType = typeof(int);
            // 
            // lbTestTypeIDValue
            // 
            this.lbTestTypeIDValue.AutoSize = true;
            this.lbTestTypeIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestTypeIDValue.Location = new System.Drawing.Point(116, 80);
            this.lbTestTypeIDValue.Name = "lbTestTypeIDValue";
            this.lbTestTypeIDValue.Size = new System.Drawing.Size(36, 20);
            this.lbTestTypeIDValue.TabIndex = 49;
            this.lbTestTypeIDValue.Text = "???";
            // 
            // lbTestTypeID
            // 
            this.lbTestTypeID.AutoSize = true;
            this.lbTestTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestTypeID.Location = new System.Drawing.Point(19, 80);
            this.lbTestTypeID.Name = "lbTestTypeID";
            this.lbTestTypeID.Size = new System.Drawing.Size(26, 20);
            this.lbTestTypeID.TabIndex = 48;
            this.lbTestTypeID.Text = "ID";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(198, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 43);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(318, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 43);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(19, 291);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(46, 20);
            this.lbFees.TabIndex = 47;
            this.lbFees.Text = "Fees";
            // 
            // lbUpdateApplicationTypes
            // 
            this.lbUpdateApplicationTypes.AutoSize = true;
            this.lbUpdateApplicationTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdateApplicationTypes.ForeColor = System.Drawing.Color.Red;
            this.lbUpdateApplicationTypes.Location = new System.Drawing.Point(36, 20);
            this.lbUpdateApplicationTypes.Name = "lbUpdateApplicationTypes";
            this.lbUpdateApplicationTypes.Size = new System.Drawing.Size(363, 32);
            this.lbUpdateApplicationTypes.TabIndex = 46;
            this.lbUpdateApplicationTypes.Text = "Update Application Types";
            // 
            // frmEditTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 395);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.tbTittle);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbFees);
            this.Controls.Add(this.lbTestTypeIDValue);
            this.Controls.Add(this.lbTestTypeID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbFees);
            this.Controls.Add(this.lbUpdateApplicationTypes);
            this.Name = "frmEditTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditTestTypes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.TextBox tbTittle;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.MaskedTextBox tbFees;
        private System.Windows.Forms.Label lbTestTypeIDValue;
        private System.Windows.Forms.Label lbTestTypeID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbUpdateApplicationTypes;
    }
}