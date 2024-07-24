namespace DVLD.Application_Types
{
    partial class frmEditApplicationTypes
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
            this.tbFees = new System.Windows.Forms.MaskedTextBox();
            this.lbApplicationTypeValue = new System.Windows.Forms.Label();
            this.lbApplicationType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.tbTittle = new System.Windows.Forms.TextBox();
            this.lbUpdateApplicationTypes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFees
            // 
            this.tbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFees.Location = new System.Drawing.Point(125, 171);
            this.tbFees.Mask = "00000";
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(302, 27);
            this.tbFees.TabIndex = 30;
            this.tbFees.ValidatingType = typeof(int);
            // 
            // lbApplicationTypeValue
            // 
            this.lbApplicationTypeValue.AutoSize = true;
            this.lbApplicationTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationTypeValue.Location = new System.Drawing.Point(121, 79);
            this.lbApplicationTypeValue.Name = "lbApplicationTypeValue";
            this.lbApplicationTypeValue.Size = new System.Drawing.Size(36, 20);
            this.lbApplicationTypeValue.TabIndex = 37;
            this.lbApplicationTypeValue.Text = "???";
            // 
            // lbApplicationType
            // 
            this.lbApplicationType.AutoSize = true;
            this.lbApplicationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationType.Location = new System.Drawing.Point(30, 79);
            this.lbApplicationType.Name = "lbApplicationType";
            this.lbApplicationType.Size = new System.Drawing.Size(26, 20);
            this.lbApplicationType.TabIndex = 36;
            this.lbApplicationType.Text = "ID";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(209, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 43);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(329, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 43);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(30, 178);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(46, 20);
            this.lbFees.TabIndex = 35;
            this.lbFees.Text = "Fees";
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(30, 129);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(46, 20);
            this.lbTittle.TabIndex = 34;
            this.lbTittle.Text = "Tittle";
            // 
            // tbTittle
            // 
            this.tbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTittle.Location = new System.Drawing.Point(125, 124);
            this.tbTittle.Name = "tbTittle";
            this.tbTittle.Size = new System.Drawing.Size(302, 28);
            this.tbTittle.TabIndex = 29;
            // 
            // lbUpdateApplicationTypes
            // 
            this.lbUpdateApplicationTypes.AutoSize = true;
            this.lbUpdateApplicationTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdateApplicationTypes.ForeColor = System.Drawing.Color.Red;
            this.lbUpdateApplicationTypes.Location = new System.Drawing.Point(44, 20);
            this.lbUpdateApplicationTypes.Name = "lbUpdateApplicationTypes";
            this.lbUpdateApplicationTypes.Size = new System.Drawing.Size(363, 32);
            this.lbUpdateApplicationTypes.TabIndex = 33;
            this.lbUpdateApplicationTypes.Text = "Update Application Types";
            // 
            // frmEditApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 288);
            this.Controls.Add(this.tbFees);
            this.Controls.Add(this.lbApplicationTypeValue);
            this.Controls.Add(this.lbApplicationType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbFees);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.tbTittle);
            this.Controls.Add(this.lbUpdateApplicationTypes);
            this.Name = "frmEditApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Application Types";
            this.Load += new System.EventHandler(this.frmEditApplicationTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbFees;
        private System.Windows.Forms.Label lbApplicationTypeValue;
        private System.Windows.Forms.Label lbApplicationType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.TextBox tbTittle;
        private System.Windows.Forms.Label lbUpdateApplicationTypes;
    }
}