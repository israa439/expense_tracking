using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Expense_Tracking_App.Database;
using Expense_Tracking_App.Shared;

namespace Expense_Tracking_App
{
    public partial class Savings : Form
    {
        private queryExecutor queryExecutor;
        public Savings()
        {
            InitializeComponent();
            queryExecutor = new queryExecutor();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home nav = new Home();
            this.Hide();
            nav.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home nav = new Home();
            this.Hide();
            nav.Show();
        }

        private void Savings_Load(object sender, EventArgs e)
        {
            savings_amount.Text = (UserInfo.savings).ToString();
        }

        private void Transfer_to_budget_Click(object sender, EventArgs e)
        {
            var currentSavings = UserInfo.savings;
            if (string.IsNullOrEmpty(Transfered_savings_amount.Text))
            {
                MessageBox.Show("Please fill in the transferred savings amount.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(Transfered_savings_amount.Text, out decimal transferAmount) || transferAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (currentSavings < transferAmount)
            {
                MessageBox.Show("Insufficient budget for this transfer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Query to update the Savings table
                string updateSavingsQuery = @"
            UPDATE Savings 
            SET Savings_amount = Savings_amount - @TransferAmount 
            WHERE user_id = @UserId";

                queryExecutor.ExecuteNonQuery(updateSavingsQuery, new { TransferAmount = transferAmount, UserId = UserInfo.UserId });

                // Query to update the Budget table
                string updateBudgetQuery = @"
            UPDATE Budget 
            SET Budget_amount = Budget_amount + @TransferAmount 
            WHERE user_id = @UserId AND MONTH(Budget_month) = @CurrentMonth";

                queryExecutor.ExecuteNonQuery(updateBudgetQuery, new { TransferAmount = transferAmount, UserId = UserInfo.UserId, CurrentMonth = DateTime.Now.Month });
                UserInfo.budget = UserInfo.budget + transferAmount;
                UserInfo.savings = UserInfo.savings - transferAmount;

                MessageBox.Show("Transfer successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Transfered_savings_amount.Text = string.Empty;
                Savings_Load(this, EventArgs.Empty);
            }
            catch (Exception ex) { }
        }

        private void Add_to_savings_Click(object sender, EventArgs e)
        {
            var currentSavings = UserInfo.savings;
            if (string.IsNullOrEmpty(Added_savings_amount.Text))
            {
                MessageBox.Show("Please fill in the added savings amount.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(Added_savings_amount.Text, out decimal addedAmount) || addedAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                
                string updateBudgetQuery = @"
      UPDATE Savings 
            SET Savings_amount = Savings_amount + @AddedAmount
            WHERE user_id = @UserId";
                queryExecutor.ExecuteNonQuery(updateBudgetQuery, new { AddedAmount = addedAmount, UserId = UserInfo.UserId });
                UserInfo.savings = UserInfo.savings + addedAmount;
                MessageBox.Show("Added to budget successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Added_savings_amount.Text = string.Empty;
                Savings_Load(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
