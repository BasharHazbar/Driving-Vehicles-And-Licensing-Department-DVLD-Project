namespace DVLD.Local_Driving_Licenses
{
    partial class frmTestApointmentsManagement
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
            this.lbAppointments = new System.Windows.Forms.Label();
            this.lbRecordsCountValue = new System.Windows.Forms.Label();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTestAppointmentsList = new System.Windows.Forms.DataGridView();
            this.lbTitleTestType = new System.Windows.Forms.Label();
            this.ctrlApplicationCard = new DVLD.Controls.ctrlApplicationCard();
            this.ctmEditTakeTest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAppointmentsList = new System.Windows.Forms.Label();
            this.pbAddTestAppointment = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointmentsList)).BeginInit();
            this.ctmEditTakeTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddTestAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAppointments
            // 
            this.lbAppointments.AutoSize = true;
            this.lbAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppointments.Location = new System.Drawing.Point(80, 407);
            this.lbAppointments.Name = "lbAppointments";
            this.lbAppointments.Size = new System.Drawing.Size(124, 22);
            this.lbAppointments.TabIndex = 51;
            this.lbAppointments.Text = "Appointments:";
            // 
            // lbRecordsCountValue
            // 
            this.lbRecordsCountValue.AutoSize = true;
            this.lbRecordsCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCountValue.Location = new System.Drawing.Point(199, 733);
            this.lbRecordsCountValue.Name = "lbRecordsCountValue";
            this.lbRecordsCountValue.Size = new System.Drawing.Size(60, 22);
            this.lbRecordsCountValue.TabIndex = 50;
            this.lbRecordsCountValue.Text = "[????]";
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCount.Location = new System.Drawing.Point(80, 733);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(107, 22);
            this.lbRecordsCount.TabIndex = 49;
            this.lbRecordsCount.Text = "# Records : ";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(853, 719);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 48);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvTestAppointmentsList
            // 
            this.dgvTestAppointmentsList.AllowUserToAddRows = false;
            this.dgvTestAppointmentsList.AllowUserToDeleteRows = false;
            this.dgvTestAppointmentsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTestAppointmentsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTestAppointmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppointmentsList.ContextMenuStrip = this.ctmEditTakeTest;
            this.dgvTestAppointmentsList.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvTestAppointmentsList.Location = new System.Drawing.Point(84, 474);
            this.dgvTestAppointmentsList.Name = "dgvTestAppointmentsList";
            this.dgvTestAppointmentsList.ReadOnly = true;
            this.dgvTestAppointmentsList.RowHeadersWidth = 51;
            this.dgvTestAppointmentsList.RowTemplate.Height = 24;
            this.dgvTestAppointmentsList.Size = new System.Drawing.Size(927, 234);
            this.dgvTestAppointmentsList.TabIndex = 47;
            // 
            // lbTitleTestType
            // 
            this.lbTitleTestType.AutoSize = true;
            this.lbTitleTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleTestType.ForeColor = System.Drawing.Color.Red;
            this.lbTitleTestType.Location = new System.Drawing.Point(362, 17);
            this.lbTitleTestType.Name = "lbTitleTestType";
            this.lbTitleTestType.Size = new System.Drawing.Size(346, 32);
            this.lbTitleTestType.TabIndex = 46;
            this.lbTitleTestType.Text = "Vision Test Appointment";
            // 
            // ctrlApplicationCard
            // 
            this.ctrlApplicationCard.Location = new System.Drawing.Point(84, 56);
            this.ctrlApplicationCard.Name = "ctrlApplicationCard";
            this.ctrlApplicationCard.Size = new System.Drawing.Size(927, 375);
            this.ctrlApplicationCard.TabIndex = 52;
            // 
            // ctmEditTakeTest
            // 
            this.ctmEditTakeTest.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmEditTakeTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.tsmTakeTest});
            this.ctmEditTakeTest.Name = "ctmEditTakeTest";
            this.ctmEditTakeTest.Size = new System.Drawing.Size(138, 52);
            this.ctmEditTakeTest.Opening += new System.ComponentModel.CancelEventHandler(this.ctmEditTakeTest_Opening);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(137, 24);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmTakeTest
            // 
            this.tsmTakeTest.Name = "tsmTakeTest";
            this.tsmTakeTest.Size = new System.Drawing.Size(137, 24);
            this.tsmTakeTest.Text = "Take Test";
            this.tsmTakeTest.Click += new System.EventHandler(this.tsmTakeTest_Click);
            // 
            // lbAppointmentsList
            // 
            this.lbAppointmentsList.AutoSize = true;
            this.lbAppointmentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppointmentsList.Location = new System.Drawing.Point(80, 438);
            this.lbAppointmentsList.Name = "lbAppointmentsList";
            this.lbAppointmentsList.Size = new System.Drawing.Size(124, 22);
            this.lbAppointmentsList.TabIndex = 54;
            this.lbAppointmentsList.Text = "Appointments:";
            // 
            // pbAddTestAppointment
            // 
            this.pbAddTestAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddTestAppointment.Image = global::DVLD.Properties.Resources.AddingTestApointment;
            this.pbAddTestAppointment.Location = new System.Drawing.Point(937, 427);
            this.pbAddTestAppointment.Name = "pbAddTestAppointment";
            this.pbAddTestAppointment.Size = new System.Drawing.Size(74, 42);
            this.pbAddTestAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddTestAppointment.TabIndex = 55;
            this.pbAddTestAppointment.TabStop = false;
            this.pbAddTestAppointment.Click += new System.EventHandler(this.pbAddTestAppointment_Click);
            // 
            // frmTestApointmentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 803);
            this.Controls.Add(this.pbAddTestAppointment);
            this.Controls.Add(this.lbAppointmentsList);
            this.Controls.Add(this.ctrlApplicationCard);
            this.Controls.Add(this.lbAppointments);
            this.Controls.Add(this.lbRecordsCountValue);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTestAppointmentsList);
            this.Controls.Add(this.lbTitleTestType);
            this.Name = "frmTestApointmentsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Appointments Management";
            this.Load += new System.EventHandler(this.frmTestApointmentsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointmentsList)).EndInit();
            this.ctmEditTakeTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddTestAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAppointments;
        private System.Windows.Forms.Label lbRecordsCountValue;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTestAppointmentsList;
        private System.Windows.Forms.Label lbTitleTestType;
        private Controls.ctrlApplicationCard ctrlApplicationCard;
        private System.Windows.Forms.ContextMenuStrip ctmEditTakeTest;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmTakeTest;
        private System.Windows.Forms.Label lbAppointmentsList;
        private System.Windows.Forms.PictureBox pbAddTestAppointment;
    }
}