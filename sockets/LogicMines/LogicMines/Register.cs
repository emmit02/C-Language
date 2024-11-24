using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace LogicMines
{
    public partial class Register : Form
    {
        private string connectionString;
        private Login login;

        public Register()
        {
            InitializeComponent();

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            login = new Login();
            login.ShowDialog();
            this.Visible = false;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            int server = 3306;
            string database = "scanner";
            string uid = "root";
            string pwd = "root";

            connectionString = $"server={server};database={database};uid={uid};pwd={pwd};";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string email = Email_tB.Text;
            string username = Username_tbr.Text;
            string password = password_tbr.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Users (FirstName, email, Password) " +
                               "VALUES (@username, @email, @password)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User successfully signed up!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            this.Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Close();
        }
    }
}
