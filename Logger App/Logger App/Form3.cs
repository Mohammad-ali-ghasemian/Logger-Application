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
    public partial class adminHomepageForm : Form
    {
        public adminHomepageForm()
        {
            InitializeComponent();
        }

        private void logoutLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm.loginform.actionLogger("logout");
            dataTable.Rows.Clear();
            adminDgv.Refresh();

            loginForm.adminhomepageform.Hide();
            loginForm.loginform.Show();
        }

        private void adminHomepageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            addMemberForm addmemberform = new addMemberForm();
            addmemberform.ShowDialog();
        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {
            removeUserForm removeuserform = new removeUserForm();
            removeuserform.ShowDialog();
        }

        DataTable dataTable = new DataTable();
        private void logBtn_Click(object sender, EventArgs e)
        {
            loginForm.loginform.command.CommandText = "SELECT * from Log";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = loginForm.loginform.command;
            adapter.Fill(dataTable);
            adminDgv.DataSource = dataTable;
        }
    }
}
