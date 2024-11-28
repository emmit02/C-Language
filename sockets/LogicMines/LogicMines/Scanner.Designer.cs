namespace LogicMines
{
    partial class Scanner
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
            variable_cmb = new ComboBox();
            operator_cmb = new ComboBox();
            values_tb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            submit = new Button();
            cmpvariable = new Label();
            var2_cmb = new ComboBox();
            IsValueCheckBox = new CheckBox();
            addconditionbutton = new Button();
            SuspendLayout();
            // 
            // variable_cmb
            // 
            variable_cmb.FormattingEnabled = true;
            variable_cmb.Items.AddRange(new object[] { "BidQty", "BidPrice", "AskQty", "AskPrice" });
            variable_cmb.Location = new Point(42, 198);
            variable_cmb.Margin = new Padding(5);
            variable_cmb.Name = "variable_cmb";
            variable_cmb.Size = new Size(188, 33);
            variable_cmb.TabIndex = 0;
            // 
            // operator_cmb
            // 
            operator_cmb.FormattingEnabled = true;
            operator_cmb.Items.AddRange(new object[] { ">", "<", "==", ">=", "<=" });
            operator_cmb.Location = new Point(256, 198);
            operator_cmb.Margin = new Padding(5);
            operator_cmb.Name = "operator_cmb";
            operator_cmb.Size = new Size(188, 33);
            operator_cmb.TabIndex = 1;
            // 
            // values_tb
            // 
            values_tb.Location = new Point(561, 134);
            values_tb.Margin = new Padding(5);
            values_tb.Name = "values_tb";
            values_tb.Size = new Size(199, 33);
            values_tb.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 158);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 3;
            label1.Text = "variable";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 166);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 4;
            label2.Text = "operator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(561, 94);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 5;
            label3.Text = "value";
            // 
            // submit
            // 
            submit.Location = new Point(294, 354);
            submit.Name = "submit";
            submit.Size = new Size(175, 37);
            submit.TabIndex = 6;
            submit.Text = "submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // cmpvariable
            // 
            cmpvariable.AutoSize = true;
            cmpvariable.Location = new Point(561, 250);
            cmpvariable.Margin = new Padding(5, 0, 5, 0);
            cmpvariable.Name = "cmpvariable";
            cmpvariable.Size = new Size(169, 25);
            cmpvariable.TabIndex = 8;
            cmpvariable.Text = "compared variable";
            // 
            // var2_cmb
            // 
            var2_cmb.FormattingEnabled = true;
            var2_cmb.Items.AddRange(new object[] { "BidQty", "BidPrice", "AskQty", "AskPrice" });
            var2_cmb.Location = new Point(561, 284);
            var2_cmb.Margin = new Padding(5);
            var2_cmb.Name = "var2_cmb";
            var2_cmb.Size = new Size(188, 33);
            var2_cmb.TabIndex = 7;
            // 
            // IsValueCheckBox
            // 
            IsValueCheckBox.AutoSize = true;
            IsValueCheckBox.Location = new Point(461, 138);
            IsValueCheckBox.Name = "IsValueCheckBox";
            IsValueCheckBox.Size = new Size(92, 29);
            IsValueCheckBox.TabIndex = 9;
            IsValueCheckBox.Text = "if value";
            IsValueCheckBox.UseVisualStyleBackColor = true;
            // 
            // addconditionbutton
            // 
            addconditionbutton.Location = new Point(42, 40);
            addconditionbutton.Name = "addconditionbutton";
            addconditionbutton.Size = new Size(214, 52);
            addconditionbutton.TabIndex = 10;
            addconditionbutton.Text = "add condition";
            addconditionbutton.UseVisualStyleBackColor = true;
            addconditionbutton.Click += addconditionbutton_Click;
            // 
            // Scanner
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 442);
            Controls.Add(addconditionbutton);
            Controls.Add(IsValueCheckBox);
            Controls.Add(cmpvariable);
            Controls.Add(var2_cmb);
            Controls.Add(submit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(values_tb);
            Controls.Add(operator_cmb);
            Controls.Add(variable_cmb);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Scanner";
            Text = "Scanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox variable_cmb;
        private ComboBox operator_cmb;
        private TextBox values_tb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button submit;
        private Label cmpvariable;
        private ComboBox var2_cmb;
        private CheckBox IsValueCheckBox;
        private Button addconditionbutton;
    }
}