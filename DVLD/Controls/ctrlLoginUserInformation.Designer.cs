namespace DVLD.Controls
{
    partial class ctrlLoginUserInformation
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
            this.ctrlPersonCard = new DVLD.Controls.ctrlPersonCard();
            this.ctrlUserCard = new DVLD.Controls.ctrlUserCard();
            this.SuspendLayout();
            // 
            // ctrlPersonCard
            // 
            this.ctrlPersonCard.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCard.Name = "ctrlPersonCard";
            this.ctrlPersonCard.Size = new System.Drawing.Size(906, 300);
            this.ctrlPersonCard.TabIndex = 0;
            // 
            // ctrlUserCard
            // 
            this.ctrlUserCard.Location = new System.Drawing.Point(12, 308);
            this.ctrlUserCard.Name = "ctrlUserCard";
            this.ctrlUserCard.Size = new System.Drawing.Size(880, 106);
            this.ctrlUserCard.TabIndex = 1;
            // 
            // ctrlLoginUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlUserCard);
            this.Controls.Add(this.ctrlPersonCard);
            this.Name = "ctrlLoginUserInformation";
            this.Size = new System.Drawing.Size(909, 439);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard;
        private ctrlUserCard ctrlUserCard;
    }
}
