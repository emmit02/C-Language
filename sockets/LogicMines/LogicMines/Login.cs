using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogicMines
{
    public partial class Login : Form
    {
        private static string connectionString = "Server=3306;Database=scanner;Uid=root;Pwd=root;";

        public Login()
        {
            InitializeComponent();

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_tB.Text;
            string password = password_tB.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login successful!", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error");
                }
            }
        }
    }
}
