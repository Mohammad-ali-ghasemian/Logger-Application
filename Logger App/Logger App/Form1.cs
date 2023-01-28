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
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\loggerDB.mdf;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT username from Users where username = '{usernameTxt.Text}'";
            
            connection.Open();
            String username = (String)command.ExecuteScalar();
            command.CommandText = $"SELECT password from Users where username = '{usernameTxt.Text}'";
            String password = (String)command.ExecuteScalar();

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
                command.CommandText = $"SELECT firstname from Users where username = '{usernameTxt.Text}'";
                String firstname = (String)command.ExecuteScalar();
                command.CommandText = $"SELECT lastname from Users where username = '{usernameTxt.Text}'";
                String lastname = (String)command.ExecuteScalar();
                String action = "login";
                DateTime now = DateTime.Now;
                String dateTime = now.ToString();
                command.CommandText = $"INSERT INTO Log VALUES('{action}', '{dateTime}', '{firstname}', '{lastname}')";
                command.ExecuteNonQuery();
            }
            connection.Close();
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
            command.CommandText = "SELECT * from Users where username = 'maligh9'";

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            userhomepageform.fillDgv(dataTable);

            connection.Open();
            object dr = command.ExecuteScalar();
            if (dr == null)
            {
                MessageBox.Show("empty");
            }
            else
            {
                MessageBox.Show(dr.ToString());
            }
            
            connection.Close();

            DateTime now = DateTime.Now;
            MessageBox.Show(now.ToString());
        }
    }
}
