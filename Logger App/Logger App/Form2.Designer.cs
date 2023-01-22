namespace Logger_App
{
    partial class userHomepageForm
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
            this.logoutLinkLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // logoutLinkLbl
            // 
            this.logoutLinkLbl.AutoSize = true;
            this.logoutLinkLbl.Location = new System.Drawing.Point(4, 6);
            this.logoutLinkLbl.Name = "logoutLinkLbl";
            this.logoutLinkLbl.Size = new System.Drawing.Size(42, 15);
            this.logoutLinkLbl.TabIndex = 0;
            this.logoutLinkLbl.TabStop = true;
            this.logoutLinkLbl.Text = "logout";
            this.logoutLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLbl_LinkClicked);
            // 
            // userHomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.logoutLinkLbl);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "userHomepageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logger - User Home Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userHomepageForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLinkLbl;
    }
}