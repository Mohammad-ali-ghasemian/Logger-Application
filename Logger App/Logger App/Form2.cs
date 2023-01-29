using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger_App
{
    public partial class userHomepageForm : Form
    {
        public userHomepageForm()
        {
            InitializeComponent();
        }

        private void userHomepageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm.loginform.actionLogger("logout");
            //clear data grid view
            dataTable.Rows.Clear();
            userDgv.Refresh();

            loginForm.userhomepageform.Hide();
            loginForm.loginform.Show();
        }

        DataTable dataTable = new DataTable();
        private void logBtn_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            userDgv.Refresh();

            loginForm.loginform.command.CommandText = "SELECT * from Log where role != 'admin'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = loginForm.loginform.command;
            adapter.Fill(dataTable);
            userDgv.DataSource = dataTable;
        }
    }
}
