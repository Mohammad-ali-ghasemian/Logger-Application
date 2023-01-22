namespace Logger_App
{
    partial class adminHomepageForm
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
            this.adminDgv = new System.Windows.Forms.DataGridView();
            this.logBtn = new System.Windows.Forms.Button();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.removeUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutLinkLbl
            // 
            this.logoutLinkLbl.AutoSize = true;
            this.logoutLinkLbl.Location = new System.Drawing.Point(4, 6);
            this.logoutLinkLbl.Name = "logoutLinkLbl";
            this.logoutLinkLbl.Size = new System.Drawing.Size(42, 15);
            this.logoutLinkLbl.TabIndex = 1;
            this.logoutLinkLbl.TabStop = true;
            this.logoutLinkLbl.Text = "logout";
            this.logoutLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLbl_LinkClicked);
            // 
            // adminDgv
            // 
            this.adminDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDgv.Location = new System.Drawing.Point(1, 108);
            this.adminDgv.Name = "adminDgv";
            this.adminDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminDgv.Size = new System.Drawing.Size(342, 353);
            this.adminDgv.TabIndex = 8;
            // 
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.DarkGray;
            this.logBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.logBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.Location = new System.Drawing.Point(7, 74);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(333, 28);
            this.logBtn.TabIndex = 7;
            this.logBtn.Text = "see log";
            this.logBtn.UseVisualStyleBackColor = false;
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.BackColor = System.Drawing.Color.DarkGray;
            this.addMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.addMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberBtn.Location = new System.Drawing.Point(7, 40);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(152, 28);
            this.addMemberBtn.TabIndex = 9;
            this.addMemberBtn.Text = "add member";
            this.addMemberBtn.UseVisualStyleBackColor = false;
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.BackColor = System.Drawing.Color.DarkGray;
            this.removeUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.removeUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.removeUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUserBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUserBtn.Location = new System.Drawing.Point(188, 40);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(152, 28);
            this.removeUserBtn.TabIndex = 10;
            this.removeUserBtn.Text = "remove user";
            this.removeUserBtn.UseVisualStyleBackColor = false;
            // 
            // adminHomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.removeUserBtn);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.adminDgv);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.logoutLinkLbl);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "adminHomepageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logger - Admin Home Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminHomepageForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.adminDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLinkLbl;
        private System.Windows.Forms.DataGridView adminDgv;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button addMemberBtn;
        private System.Windows.Forms.Button removeUserBtn;
    }
}