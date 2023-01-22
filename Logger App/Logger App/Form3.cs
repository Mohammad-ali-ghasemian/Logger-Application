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
    public partial class adminHomepageForm : Form
    {
        public adminHomepageForm()
        {
            InitializeComponent();
        }

        private void logoutLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm.adminhomepageform.Hide();
            loginForm.loginform.Show();
        }

        private void adminHomepageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
