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
    public partial class loginForm : Form
    {
        public static loginForm loginform = new Logger_App.loginForm();
        public static userHomepageForm userhomepageform = new userHomepageForm();
        public static adminHomepageForm adminhomepageform = new adminHomepageForm();

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String password = passwordTxt.Text;



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

        private void loginForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\loggerDB.mdf;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT firstname from Users where username = 'maligh99'";

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            userhomepageform.fillDgv(dataTable);
        }
    }
}
