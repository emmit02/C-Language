
namespace LogicMines
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            close_button = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            login_button = new Button();
            linkLabel1 = new LinkLabel();
            username_tB = new TextBox();
            label1 = new Label();
            password_tB = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Login_panel = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Login_panel.SuspendLayout();
            SuspendLayout();
            // 
            // close_button
            // 
            close_button.BackgroundImage = (Image)resources.GetObject("close_button.BackgroundImage");
            close_button.BackgroundImageLayout = ImageLayout.Stretch;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.Location = new Point(769, 3);
            close_button.Name = "close_button";
            close_button.Size = new Size(27, 25);
            close_button.TabIndex = 0;
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 27);
            label3.Name = "label3";
            label3.Size = new Size(121, 17);
            label3.TabIndex = 7;
            label3.Text = "   Welcome Back   ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 166);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // login_button
            // 
            login_button.FlatAppearance.MouseOverBackColor = Color.Crimson;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.ForeColor = Color.Transparent;
            login_button.Location = new Point(73, 242);
            login_button.Name = "login_button";
            login_button.Size = new Size(162, 34);
            login_button.TabIndex = 0;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(192, 192, 255);
            linkLabel1.Location = new Point(105, 203);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(99, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password?";
            // 
            // username_tB
            // 
            username_tB.Location = new Point(53, 128);
            username_tB.Name = "username_tB";
            username_tB.Size = new Size(202, 23);
            username_tB.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 110);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // password_tB
            // 
            password_tB.Location = new Point(53, 177);
            password_tB.Name = "password_tB";
            password_tB.Size = new Size(202, 23);
            password_tB.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 159);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Login_panel
            // 
            Login_panel.BackColor = Color.Transparent;
            Login_panel.Controls.Add(label4);
            Login_panel.Controls.Add(pictureBox1);
            Login_panel.Controls.Add(label2);
            Login_panel.Controls.Add(password_tB);
            Login_panel.Controls.Add(label1);
            Login_panel.Controls.Add(username_tB);
            Login_panel.Controls.Add(linkLabel1);
            Login_panel.Controls.Add(login_button);
            Login_panel.Controls.Add(pictureBox2);
            Login_panel.Controls.Add(label3);
            Login_panel.Location = new Point(277, 33);
            Login_panel.Name = "Login_panel";
            Login_panel.Size = new Size(283, 340);
            Login_panel.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bradley Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(58, 50);
            label4.Name = "label4";
            label4.Size = new Size(166, 37);
            label4.TabIndex = 9;
            label4.Text = "Let's Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(Login_panel);
            Controls.Add(close_button);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Login_panel.ResumeLayout(false);
            Login_panel.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Button close_button;
        private Label label3;
        private PictureBox pictureBox2;
        private Button login_button;
        private LinkLabel linkLabel1;
        private TextBox username_tB;
        private Label label1;
        private TextBox password_tB;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel Login_panel;
        private Label label4;
    }
}
