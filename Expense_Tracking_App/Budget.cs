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
    public partial class Budget : Form
    {
        private queryExecutor queryExecutor;
        public Budget()
        {
            InitializeComponent();
            queryExecutor = new queryExecutor();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home nav = new Home();
            this.Hide();
            nav.Show();

        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home nav = new Home();
            this.Hide();
            nav.Show();
        }

        private void Budget_Load(object sender, EventArgs e)
        {
            Budget_amount.Text = (UserInfo.budget).ToString();
        }

        private void Transfer_to_savings_Click(object sender, EventArgs e)
        {
            var currentBudget = UserInfo.budget;
            if (string.IsNullOrEmpty(Transfered_budget_amount.Text))
            {
                MessageBox.Show("Please fill in the transferred budget amount.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(Transfered_budget_amount.Text, out decimal transferAmount) || transferAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (currentBudget < transferAmount)
            {
                MessageBox.Show("Insufficient budget for this transfer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Query to update the Savings table
                string updateSavingsQuery = @"
            UPDATE Savings 
            SET Savings_amount = Savings_amount + @TransferAmount 
            WHERE user_id = @UserId";

                queryExecutor.ExecuteNonQuery(updateSavingsQuery, new { TransferAmount = transferAmount, UserId = UserInfo.UserId });

                // Query to update the Budget table
                string updateBudgetQuery = @"
            UPDATE Budget 
            SET Budget_amount = Budget_amount - @TransferAmount 
            WHERE user_id = @UserId AND MONTH(Budget_month) = @CurrentMonth";

                queryExecutor.ExecuteNonQuery(updateBudgetQuery, new { TransferAmount = transferAmount, UserId = UserInfo.UserId, CurrentMonth = DateTime.Now.Month });
                UserInfo.budget = UserInfo.budget - transferAmount;
                UserInfo.savings = UserInfo.savings + transferAmount;

                MessageBox.Show("Transfer successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Transfered_budget_amount.Text = string.Empty;
                Budget_Load(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Add_to_budget_Click(object sender, EventArgs e)
        {
            var currentBudget = UserInfo.budget;
            if (string.IsNullOrEmpty(Added_budget_amount.Text))
            {
                MessageBox.Show("Please fill in the added budget amount.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(Added_budget_amount.Text, out decimal addedAmount) || addedAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Query to update the Budget table
                string updateBudgetQuery = @"
            UPDATE Budget 
            SET Budget_amount = Budget_amount - @AddedAmount 
            WHERE user_id = @UserId AND MONTH(Budget_month) = @CurrentMonth";
                queryExecutor.ExecuteNonQuery(updateBudgetQuery, new { AddedAmount = addedAmount, UserId = UserInfo.UserId, CurrentMonth = DateTime.Now.Month });
                UserInfo.budget = UserInfo.budget + addedAmount;
                MessageBox.Show("Added to budget successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Added_budget_amount.Text = string.Empty;
                Budget_Load(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
