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
    public partial class removeUserForm : Form
    {
        public removeUserForm()
        {
            InitializeComponent();
        }

        private void removeUserDgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //remove user from database
            loginForm.loginform.command.CommandText = $"DELETE FROM Users where username = '{removeUserDgv.SelectedRows[0].Cells[3].Value.ToString()}'";
            if (loginForm.loginform.connection.State != ConnectionState.Open)
                loginForm.loginform.connection.Open();
            loginForm.loginform.command.ExecuteNonQuery();
            loginForm.loginform.connection.Close();

            //log
            loginForm.loginform.actionLogger($"remove member: {removeUserDgv.SelectedRows[0].Cells[3].Value.ToString()}");

            loginForm.loginform.connection.Close();
        }

        private void removeUserForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            loginForm.loginform.command.CommandText = "SELECT * from Users";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = loginForm.loginform.command;
            adapter.Fill(dataTable);
            removeUserDgv.DataSource = dataTable;
        }
    }
}
