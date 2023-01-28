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

        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\loggerDB.mdf;Integrated Security=True");
        public SqlCommand command = new SqlCommand();

        public String userLoggedIn;
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            command.CommandText = $"SELECT username from Users where username = '{usernameTxt.Text}'";

            if (connection.State != ConnectionState.Open)
                connection.Open();
            String username = (String)command.ExecuteScalar();
            command.CommandText = $"SELECT password from Users where username = '{usernameTxt.Text}'";
            String password = (String)command.ExecuteScalar();

            //check member info with database
            if (username == null || password != passwordTxt.Text)
            {
                errorProvider1.SetError(loginBtn, "wrong username or password");
            }
            else
            {
                command.CommandText = $"SELECT [role] from Users where username = '{usernameTxt.Text}'";
                String role = (String)command.ExecuteScalar();
                if (role == "admin")
                {
                    this.Hide();
                    loginform.Hide();
                    adminhomepageform.Show();
                }
                else
                {
                    this.Hide();
                    loginform.Hide();
                    userhomepageform.Show();
                }
                //remember which user logged in
                userLoggedIn = usernameTxt.Text;
                loginform.userLoggedIn = usernameTxt.Text;

                //insert login log
                actionLogger("login");
            }
            connection.Close();
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            setCommand();
            loginform.setCommand();
        }
        private void setCommand()
        {
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }

        public void actionLogger(String action)
        {
            if(connection.State != ConnectionState.Open)
                connection.Open();

            command.CommandText = $"SELECT firstname from Users where username = '{userLoggedIn}'";
            String firstname = (String)command.ExecuteScalar();
            command.CommandText = $"SELECT lastname from Users where username = '{userLoggedIn}'";
            String lastname = (String)command.ExecuteScalar();
            command.CommandText = $"SELECT role from Users where username = '{userLoggedIn}'";
            String role = (String)command.ExecuteScalar();
            DateTime now = DateTime.Now;
            String dateTime = now.ToString();
            command.CommandText = $"INSERT INTO Log VALUES('{action}', '{dateTime}', '{firstname}', '{lastname}', '{role}')";
            command.ExecuteNonQuery();
        }
    }
}
