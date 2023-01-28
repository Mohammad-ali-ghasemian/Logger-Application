namespace Logger_App
{
    partial class removeUserForm
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
            this.removeUserDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.removeUserDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // removeUserDgv
            // 
            this.removeUserDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.removeUserDgv.Location = new System.Drawing.Point(2, 2);
            this.removeUserDgv.Name = "removeUserDgv";
            this.removeUserDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.removeUserDgv.Size = new System.Drawing.Size(240, 372);
            this.removeUserDgv.TabIndex = 0;
            this.removeUserDgv.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.removeUserDgv_UserDeletingRow);
            // 
            // removeUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(244, 376);
            this.Controls.Add(this.removeUserDgv);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "removeUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logger - Remove User";
            this.Load += new System.EventHandler(this.removeUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.removeUserDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView removeUserDgv;
    }
}