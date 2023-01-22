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
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "admin" && passwordTxt.Text == "admin")
            {
                userHomepageForm userhomepageform = new userHomepageForm();
                this.Hide();
                userhomepageform.Show();
            }
        }
    }
}
