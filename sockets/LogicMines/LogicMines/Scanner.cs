using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicMines
{
    public partial class Scanner : Form
    {
        private ConditionSet conditionSet;
        public Scanner()
        {
            InitializeComponent();
            conditionSet = new ConditionSet();
        }


        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a client and send the condition set
                Client client = new Client("127.0.0.1", 9000);
                client.SendAndReceive(conditionSet);

                MessageBox.Show("Condition set sent to the server and response received.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        

        private void addconditionbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected variable and operator
                Variable var1 = (Variable)variable_cmb.SelectedIndex;
                Operation op = (Operation)operator_cmb.SelectedIndex;
                bool isValue = IsValueCheckBox.Checked;

                // Create a new condition
                Condition condition = new Condition
                {
                    Var1 = var1,
                    Op = op,
                    IsValue = isValue
                };

                if (isValue)
                {
                    // Get value from TextBox
                    condition.Value = float.Parse(values_tb.Text);
                }
                else
                {
                    // Get the second variable
                    condition.Var2 = (Variable)var2_cmb.SelectedIndex;
                }

                // Add the condition to the condition set
                conditionSet.Conditions.Add(condition);

                MessageBox.Show("Condition added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
