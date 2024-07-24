namespace DVLD.Controls
{
    partial class ctrlFindPersonCard
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
            this.pbAddPerson = new System.Windows.Forms.PictureBox();
            this.pbFind = new System.Windows.Forms.PictureBox();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.lbFind = new System.Windows.Forms.Label();
            this.ctrlPersonCard = new DVLD.Controls.ctrlPersonCard();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.pbAddPerson);
            this.gbFilter.Controls.Add(this.pbFind);
            this.gbFilter.Controls.Add(this.cbFind);
            this.gbFilter.Controls.Add(this.tbFind);
            this.gbFilter.Controls.Add(this.lbFind);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(6, 13);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(896, 99);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // pbAddPerson
            // 
            this.pbAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddPerson.Image = global::DVLD.Properties.Resources.Add_Person;
            this.pbAddPerson.Location = new System.Drawing.Point(766, 26);
            this.pbAddPerson.Name = "pbAddPerson";
            this.pbAddPerson.Size = new System.Drawing.Size(91, 50);
            this.pbAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddPerson.TabIndex = 5;
            this.pbAddPerson.TabStop = false;
            this.pbAddPerson.Click += new System.EventHandler(this.pbAddPerson_Click);
            // 
            // pbFind
            // 
            this.pbFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFind.Image = global::DVLD.Properties.Resources.Find_Person;
            this.pbFind.Location = new System.Drawing.Point(649, 26);
            this.pbFind.Name = "pbFind";
            this.pbFind.Size = new System.Drawing.Size(91, 50);
            this.pbFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFind.TabIndex = 4;
            this.pbFind.TabStop = false;
            this.pbFind.Click += new System.EventHandler(this.pbFind_Click);
            // 
            // cbFind
            // 
            this.cbFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Items.AddRange(new object[] {
            "Person ID",
            "National NO"});
            this.cbFind.Location = new System.Drawing.Point(99, 40);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(242, 28);
            this.cbFind.TabIndex = 3;
            this.cbFind.SelectedIndexChanged += new System.EventHandler(this.cbFind_SelectedIndexChanged);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(370, 41);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(240, 27);
            this.tbFind.TabIndex = 2;
            this.tbFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFind_KeyDown);
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFind.Location = new System.Drawing.Point(24, 41);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(55, 22);
            this.lbFind.TabIndex = 0;
            this.lbFind.Text = "Find:";
            // 
            // ctrlPersonCard
            // 
            this.ctrlPersonCard.Location = new System.Drawing.Point(3, 130);
            this.ctrlPersonCard.Name = "ctrlPersonCard";
            this.ctrlPersonCard.Size = new System.Drawing.Size(906, 300);
            this.ctrlPersonCard.TabIndex = 1;
            // 
            // ctrlFindPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlFindPersonCard";
            this.Size = new System.Drawing.Size(910, 432);
            this.Load += new System.EventHandler(this.ctrlFindPersonCard_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private ctrlPersonCard ctrlPersonCard;
        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.PictureBox pbFind;
        private System.Windows.Forms.PictureBox pbAddPerson;
    }
}
