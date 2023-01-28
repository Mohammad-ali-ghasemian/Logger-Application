using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger_App
{
    public partial class addMemberForm : Form
    {
        public addMemberForm()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && ((TextBox)control).Text == "")
                {
                    errorProvider1.SetError(insertBtn, "some boxes are left empty");
                    return;
                }
            }

            //add member to database
            loginForm.loginform.command.CommandText = $"INSERT INTO Users(firstname, lastname, username, password, age, salary, role) VALUES('{firstnameTxt.Text}', '{lastnameTxt.Text}', '{usernameTxt.Text}','{passwordTxt.Text}', {2023 - int.Parse(birthYearTxt.Text)}, {int.Parse(salaryTxt.Text)}, '{roleTxt.Text}')";
            if (loginForm.loginform.connection.State != ConnectionState.Open)
                loginForm.loginform.connection.Open();
            loginForm.loginform.command.ExecuteNonQuery();
            loginForm.loginform.connection.Close();

            //insert add member log
            loginForm.loginform.actionLogger($"add member: {usernameTxt.Text}");

            this.Close();
        }
    }
}
