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
            this.logBtn = new System.Windows.Forms.Button();
            this.userDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userDgv)).BeginInit();
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
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.DarkGray;
            this.logBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.logBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.Location = new System.Drawing.Point(7, 41);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(333, 28);
            this.logBtn.TabIndex = 5;
            this.logBtn.Text = "see log";
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // userDgv
            // 
            this.userDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDgv.Location = new System.Drawing.Point(1, 75);
            this.userDgv.Name = "userDgv";
            this.userDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDgv.Size = new System.Drawing.Size(342, 385);
            this.userDgv.TabIndex = 6;
            // 
            // userHomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.userDgv);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.logoutLinkLbl);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "userHomepageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logger - User Home Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userHomepageForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.userDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLinkLbl;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.DataGridView userDgv;
    }
}