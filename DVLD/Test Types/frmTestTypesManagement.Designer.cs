namespace DVLD
{
    partial class frmTestTypesManagement
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
            this.lbRecordsCountValue = new System.Windows.Forms.Label();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTestTypesList = new System.Windows.Forms.DataGridView();
            this.cmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEditTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTestTypesManagement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypesList)).BeginInit();
            this.cmsTestTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRecordsCountValue
            // 
            this.lbRecordsCountValue.AutoSize = true;
            this.lbRecordsCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCountValue.Location = new System.Drawing.Point(192, 493);
            this.lbRecordsCountValue.Name = "lbRecordsCountValue";
            this.lbRecordsCountValue.Size = new System.Drawing.Size(60, 22);
            this.lbRecordsCountValue.TabIndex = 40;
            this.lbRecordsCountValue.Text = "[????]";
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCount.Location = new System.Drawing.Point(73, 493);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(107, 22);
            this.lbRecordsCount.TabIndex = 39;
            this.lbRecordsCount.Text = "# Records : ";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(849, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 51);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvTestTypesList
            // 
            this.dgvTestTypesList.AllowUserToAddRows = false;
            this.dgvTestTypesList.AllowUserToDeleteRows = false;
            this.dgvTestTypesList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTestTypesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTestTypesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypesList.ContextMenuStrip = this.cmsTestTypes;
            this.dgvTestTypesList.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvTestTypesList.Location = new System.Drawing.Point(77, 110);
            this.dgvTestTypesList.Name = "dgvTestTypesList";
            this.dgvTestTypesList.ReadOnly = true;
            this.dgvTestTypesList.RowHeadersWidth = 51;
            this.dgvTestTypesList.RowTemplate.Height = 24;
            this.dgvTestTypesList.Size = new System.Drawing.Size(903, 366);
            this.dgvTestTypesList.TabIndex = 36;
            // 
            // cmsTestTypes
            // 
            this.cmsTestTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditTestTypes});
            this.cmsTestTypes.Name = "cmsApplicationTypes";
            this.cmsTestTypes.Size = new System.Drawing.Size(211, 56);
            // 
            // tsmEditTestTypes
            // 
            this.tsmEditTestTypes.Name = "tsmEditTestTypes";
            this.tsmEditTestTypes.Size = new System.Drawing.Size(210, 24);
            this.tsmEditTestTypes.Text = "Edit Test Types";
            this.tsmEditTestTypes.Click += new System.EventHandler(this.tsmEditTestTypes_Click);
            // 
            // lbTestTypesManagement
            // 
            this.lbTestTypesManagement.AutoSize = true;
            this.lbTestTypesManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestTypesManagement.ForeColor = System.Drawing.Color.Red;
            this.lbTestTypesManagement.Location = new System.Drawing.Point(359, 9);
            this.lbTestTypesManagement.Name = "lbTestTypesManagement";
            this.lbTestTypesManagement.Size = new System.Drawing.Size(347, 32);
            this.lbTestTypesManagement.TabIndex = 41;
            this.lbTestTypesManagement.Text = "Test Types Management";
            // 
            // frmTestTypesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 539);
            this.Controls.Add(this.lbRecordsCountValue);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTestTypesList);
            this.Controls.Add(this.lbTestTypesManagement);
            this.Name = "frmTestTypesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Types";
            this.Load += new System.EventHandler(this.frmTestTypesManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypesList)).EndInit();
            this.cmsTestTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecordsCountValue;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTestTypesList;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmEditTestTypes;
        private System.Windows.Forms.Label lbTestTypesManagement;
    }
}