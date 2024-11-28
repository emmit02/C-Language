namespace LogicMines
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            close_button = new Button();
            Register_panel = new Panel();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            Email_tB = new TextBox();
            pictureBox3 = new PictureBox();
            password_tbr = new TextBox();
            label6 = new Label();
            Username_tbr = new TextBox();
            linkLabel4 = new LinkLabel();
            registerbtn = new Button();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            Register_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // close_button
            // 
            close_button.BackgroundImage = (Image)resources.GetObject("close_button.BackgroundImage");
            close_button.BackgroundImageLayout = ImageLayout.Stretch;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.Location = new Point(763, 9);
            close_button.Name = "close_button";
            close_button.Size = new Size(27, 25);
            close_button.TabIndex = 14;
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // Register_panel
            // 
            Register_panel.BackColor = Color.Transparent;
            Register_panel.Controls.Add(label5);
            Register_panel.Controls.Add(pictureBox5);
            Register_panel.Controls.Add(label7);
            Register_panel.Controls.Add(Email_tB);
            Register_panel.Controls.Add(pictureBox3);
            Register_panel.Controls.Add(password_tbr);
            Register_panel.Controls.Add(label6);
            Register_panel.Controls.Add(Username_tbr);
            Register_panel.Controls.Add(linkLabel4);
            Register_panel.Controls.Add(registerbtn);
            Register_panel.Controls.Add(pictureBox4);
            Register_panel.Controls.Add(label4);
            Register_panel.Location = new Point(292, 56);
            Register_panel.Name = "Register_panel";
            Register_panel.Size = new Size(283, 340);
            Register_panel.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 159);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(11, 77);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 64);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 11;
            label7.Text = "Email";
            // 
            // Email_tB
            // 
            Email_tB.Location = new Point(49, 82);
            Email_tB.Name = "Email_tB";
            Email_tB.Size = new Size(202, 23);
            Email_tB.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // password_tbr
            // 
            password_tbr.Location = new Point(49, 177);
            password_tbr.Name = "password_tbr";
            password_tbr.Size = new Size(202, 23);
            password_tbr.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 110);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 4;
            label6.Text = "Username";
            // 
            // Username_tbr
            // 
            Username_tbr.Location = new Point(49, 128);
            Username_tbr.Name = "Username_tbr";
            Username_tbr.Size = new Size(202, 23);
            Username_tbr.TabIndex = 3;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.LinkColor = Color.FromArgb(192, 192, 255);
            linkLabel4.Location = new Point(101, 203);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(99, 15);
            linkLabel4.TabIndex = 1;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Forget Password?";
            // 
            // registerbtn
            // 
            registerbtn.FlatAppearance.MouseOverBackColor = Color.Crimson;
            registerbtn.FlatStyle = FlatStyle.Flat;
            registerbtn.ForeColor = Color.Transparent;
            registerbtn.Location = new Point(69, 254);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(162, 34);
            registerbtn.TabIndex = 0;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(7, 160);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 30);
            label4.Name = "label4";
            label4.Size = new Size(109, 17);
            label4.TabIndex = 7;
            label4.Text = "Let's Get Started";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(Register_panel);
            Controls.Add(close_button);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            Register_panel.ResumeLayout(false);
            Register_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button close_button;
        private Panel Register_panel;
        private Label label5;
        private PictureBox pictureBox5;
        private Label label7;
        private TextBox Email_tB;
        private PictureBox pictureBox3;
        private TextBox password_tbr;
        private Label label6;
        private TextBox Username_tbr;
        private LinkLabel linkLabel4;
        private Button registerbtn;
        private PictureBox pictureBox4;
        private Label label4;
    }
}