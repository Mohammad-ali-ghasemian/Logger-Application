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
    public partial class loginForm : Form
    {
        public static loginForm loginform = new Logger_App.loginForm();
        public static userHomepageForm userhomepageform = new userHomepageForm();
        public static adminHomepageForm adminhomepageform = new adminHomepageForm();
        public static addMemberForm addmemberform = new addMemberForm();

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "user" && passwordTxt.Text == "user")
            {
                this.Hide();
                loginform.Hide();
                userhomepageform.Show();
            }
            else if (usernameTxt.Text == "admin" && passwordTxt.Text == "admin")
            {
                this.Hide();
                loginform.Hide();
                adminhomepageform.Show();
            }
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
