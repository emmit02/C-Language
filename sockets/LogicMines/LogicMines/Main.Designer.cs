namespace LogicMines
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label9 = new Label();
            label8 = new Label();
            Login_btn = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(235, 139);
            label9.Name = "label9";
            label9.Size = new Size(244, 52);
            label9.TabIndex = 22;
            label9.Text = "Blind Concept";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(241, 109);
            label8.Name = "label8";
            label8.Size = new Size(94, 17);
            label8.TabIndex = 21;
            label8.Text = "Welcome to   ";
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.Transparent;
            Login_btn.FlatAppearance.MouseOverBackColor = Color.Crimson;
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.ForeColor = SystemColors.ControlLight;
            Login_btn.Location = new Point(235, 209);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(97, 35);
            Login_btn.TabIndex = 20;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(354, 208);
            button1.Name = "button1";
            button1.Size = new Size(97, 35);
            button1.TabIndex = 23;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(235, 265);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 24;
            button2.Text = "Establish Connection";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Login_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label8;
        private Button Login_btn;
        private Button button1;
        private Button button2;
    }
}