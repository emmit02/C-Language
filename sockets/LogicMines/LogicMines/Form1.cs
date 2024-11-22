using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogicMines
{
    public partial class Form1 : Form
    {
        private int targetX;
        public Form1()
        {
            InitializeComponent();
            Login_btn.Click += (s, e) => StartAnimation(0);
            Register_btn.Click += (s, e) => StartAnimation(-400);
            timer1.Tick += AnimatePanels;
        }
        private void StartAnimation(int xTarget)
        {
            targetX = xTarget;
            timer1.Start();
        }
        private void AnimatePanels(object sender, EventArgs e)
        {
            // Calculate the direction and distance to move
            int step = 20;
            int currentX = Login_panel.Location.X;

            if (currentX != targetX)
            {
                int newX = currentX + (currentX < targetX ? step : -step);

                // Prevent overshooting
                if ((currentX < targetX && newX > targetX) || (currentX > targetX && newX < targetX))
                    newX = targetX;

                Login_panel.Location = new Point(newX, Login_panel.Location.Y);
                Register_panel.Location = new Point(newX + 400, Register_panel.Location.Y);
            }
            else
            {
                timer1.Stop(); 
            }
        }

        /*

                private void log_button_Click(object sender, EventArgs e)
                {
                    if (username_tB.Text == "" || password_tB.Text == "")
                    {
                        MessageBox.Show("Invalid Username or Passsword");       
                        username_tB.Focus();
                        password_tB.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Successfully Login");
                    }
                }

        */
        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
  
    }
}
