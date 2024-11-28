using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LogicMines
{
    public partial class Main : Form
    {
        Data.Connection con = new Data.Connection();
        public Main()
        {
            InitializeComponent();
            Login_btn.Visible = false;
            button1.Visible = false;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            var loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Connection.dataSource();
                con.connOpen();
                MessageBox.Show("Operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login_btn.Visible = true;
                button1.Visible = true;
                con.connClose();

            }catch(Exception ex)
            {
                MessageBox.Show("Operation incompleted :", ex.Message , MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.connClose();
            }
            finally
            {

            }
        }
    }
}
