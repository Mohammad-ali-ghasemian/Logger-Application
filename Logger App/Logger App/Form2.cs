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
            loginForm loginform = new loginForm();
            this.Hide();
            loginform.Show();
        }
    }
}
