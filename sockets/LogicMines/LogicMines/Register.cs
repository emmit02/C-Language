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
    //    public static MySqlConnection connectionString = new MySqlConnection();
        public string server = "8.0.40";
        public string database = "scanner";
        public string uid = "root";
        

        public Register()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string Username = Username_tbr.Text;
            string Email = Email_tB.Text;
            string Password = password_tbr.Text;

            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.Open();
                string query = "INSERT INTO users ( userid, FirstName, email, password) " +
                               "VALUES (@idUser, @Username, @Email, @Password)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Password", Password);

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
            
            Application.Exit();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            /*int server = 3306;
            string database = "scanner";
            string uid = "root";
            string dbpassword = "root";

            connectionString = $"server={server};database={database};uid={uid};pwd={dbpassword};";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Database connection successful!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }*/
        }
    }
}
