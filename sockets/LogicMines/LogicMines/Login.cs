using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogicMines
{
    public partial class Login : Form
    {
        private Register register;
        public Login()
        {
            InitializeComponent();
        }
        private void Register_btn_Click(object sender, EventArgs e)
        {
            register = new Register();
            register.ShowDialog();
            this.Visible = false;
        }
        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
