namespace DVLD.Application_Types
{
    partial class frmApplicationTypesManagement
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
            this.lbApplicationTypesManagemant = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvApplicationTypesList = new System.Windows.Forms.DataGridView();
            this.cmsApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEditApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypesList)).BeginInit();
            this.cmsApplicationTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRecordsCountValue
            // 
            this.lbRecordsCountValue.AutoSize = true;
            this.lbRecordsCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCountValue.Location = new System.Drawing.Point(148, 514);
            this.lbRecordsCountValue.Name = "lbRecordsCountValue";
            this.lbRecordsCountValue.Size = new System.Drawing.Size(60, 22);
            this.lbRecordsCountValue.TabIndex = 34;
            this.lbRecordsCountValue.Text = "[????]";
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCount.Location = new System.Drawing.Point(29, 514);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(107, 22);
            this.lbRecordsCount.TabIndex = 33;
            this.lbRecordsCount.Text = "# Records : ";
            // 
            // lbApplicationTypesManagemant
            // 
            this.lbApplicationTypesManagemant.AutoSize = true;
            this.lbApplicationTypesManagemant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationTypesManagemant.ForeColor = System.Drawing.Color.Red;
            this.lbApplicationTypesManagemant.Location = new System.Drawing.Point(155, 37);
            this.lbApplicationTypesManagemant.Name = "lbApplicationTypesManagemant";
            this.lbApplicationTypesManagemant.Size = new System.Drawing.Size(441, 32);
            this.lbApplicationTypesManagemant.TabIndex = 32;
            this.lbApplicationTypesManagemant.Text = "Application Types Management";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(632, 503);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 41);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvApplicationTypesList
            // 
            this.dgvApplicationTypesList.AllowUserToAddRows = false;
            this.dgvApplicationTypesList.AllowUserToDeleteRows = false;
            this.dgvApplicationTypesList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvApplicationTypesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvApplicationTypesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationTypesList.ContextMenuStrip = this.cmsApplicationTypes;
            this.dgvApplicationTypesList.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvApplicationTypesList.Location = new System.Drawing.Point(33, 131);
            this.dgvApplicationTypesList.Name = "dgvApplicationTypesList";
            this.dgvApplicationTypesList.ReadOnly = true;
            this.dgvApplicationTypesList.RowHeadersWidth = 51;
            this.dgvApplicationTypesList.RowTemplate.Height = 24;
            this.dgvApplicationTypesList.Size = new System.Drawing.Size(730, 366);
            this.dgvApplicationTypesList.TabIndex = 30;
            // 
            // cmsApplicationTypes
            // 
            this.cmsApplicationTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditApplicationTypes});
            this.cmsApplicationTypes.Name = "cmsApplicationTypes";
            this.cmsApplicationTypes.Size = new System.Drawing.Size(227, 56);
            // 
            // tsmEditApplicationTypes
            // 
            this.tsmEditApplicationTypes.Name = "tsmEditApplicationTypes";
            this.tsmEditApplicationTypes.Size = new System.Drawing.Size(226, 24);
            this.tsmEditApplicationTypes.Text = "Edit Application Types";
            this.tsmEditApplicationTypes.Click += new System.EventHandler(this.tsmEditApplicationTypes_Click);
            // 
            // frmApplicationTypesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 556);
            this.Controls.Add(this.lbRecordsCountValue);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.lbApplicationTypesManagemant);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvApplicationTypesList);
            this.Name = "frmApplicationTypesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Types Management";
            this.Load += new System.EventHandler(this.frmApplicationTypesManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypesList)).EndInit();
            this.cmsApplicationTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecordsCountValue;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Label lbApplicationTypesManagemant;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvApplicationTypesList;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmEditApplicationTypes;
    }
}