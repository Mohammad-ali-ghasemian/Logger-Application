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
            loginForm.loginform.command.CommandText = 
                $"INSERT INTO Log VALUES('{firstnameTxt.Text}', '{lastnameTxt.Text}', '{usernameTxt.Text}','{passwordTxt.Text}', {2023 - int.Parse(birthYearTxt.Text)}, {int.Parse(salaryTxt.Text)}, '{roleTxt.Text}')";

            //insert add member log


            this.Close();
        }
    }
}
