using System;
using System.Collections;
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
    public partial class Home : Form
    {
        private queryExecutor queryExecutor;
        public Home()
        {
            InitializeComponent();
            queryExecutor = new queryExecutor();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;
                int userId = UserInfo.UserId;
                //  Check if the current month is a new month
                string latestBudgetQuery = @"
    SELECT Budget_amount, Budget_month 
    FROM Budget 
    WHERE user_id = @UserId 
    ORDER BY Budget_month DESC 
    LIMIT 1";
                var latestBudgetResult = queryExecutor.ExecuteSelectQuery<(decimal BudgetAmount, DateTime BudgetMonth)>(
    latestBudgetQuery,
    new { UserId = userId });


                if (latestBudgetResult != null && latestBudgetResult.Any())
                {
                    var latestBudget = latestBudgetResult.First();
                    DateTime lastBudgetMonth = latestBudget.BudgetMonth;

                    if (lastBudgetMonth.Month != currentMonth || lastBudgetMonth.Year != currentYear)
                    {
                        // Add leftover budget to savings
                        decimal leftoverBudget = latestBudget.BudgetAmount;

                        if (leftoverBudget > 0)
                        {
                            string addToSavingsQuery = @"
                UPDATE Savings 
                SET Savings_amount = Savings_amount + @LeftoverBudget
                WHERE user_id = @UserId";
                            queryExecutor.ExecuteNonQuery(addToSavingsQuery, new { LeftoverBudget = leftoverBudget, UserId = userId });
                        }

                        // Reset budget to 0 for the new month
                        string resetBudgetQuery = @"
            UPDATE Budget 
            SET Budget_amount = 0 
            WHERE user_id = @UserId AND Budget_month = @LastBudgetMonth";
                        queryExecutor.ExecuteNonQuery(resetBudgetQuery, new { UserId = userId, LastBudgetMonth = lastBudgetMonth });

                        // Deduct scheduled expenses from the new budget
                        string scheduledExpensesQuery = @"
            SELECT SUM(sch_expense_amount) 
            FROM Scheduled_Expenses 
            WHERE user_id = @UserId";
                        var scheduledExpensesResult = queryExecutor.ExecuteSelectQuery<decimal>(
                            scheduledExpensesQuery,
                            new { UserId = userId });

                        decimal scheduledExpenses = scheduledExpensesResult.FirstOrDefault();
                        decimal newBudget = -scheduledExpenses;

                        // Update the budget for the new month
                        string updateBudgetQuery = @"
            INSERT INTO Budget (user_id, Budget_month, Budget_amount) 
            VALUES (@UserId, @CurrentDate, @NewBudget)";
                        queryExecutor.ExecuteNonQuery(updateBudgetQuery,
                            new { UserId = userId, CurrentDate = DateTime.Now, NewBudget = newBudget });


                        UserInfo.budget = newBudget;
                        Budget_amount.Text = newBudget.ToString();
                    }
                    else
                    {

                        UserInfo.budget = latestBudget.BudgetAmount;
                        Budget_amount.Text = UserInfo.budget.ToString();
                    }
                }
                else
                {
                    Budget_amount.Text = "0";

                }

                string Savingsquery = @"
                         SELECT Savings_amount 
                         FROM Savings 
                         WHERE user_id = @UserId 
";
                var SavingsResult = queryExecutor.ExecuteSelectQuery<decimal>(Savingsquery, new { UserId = userId });
                if (SavingsResult != null && SavingsResult.Any())
                {
                    UserInfo.savings = SavingsResult.First();
                    Savings_amount.Text = (UserInfo.savings).ToString();
                }
                else
                {
                    Savings_amount.Text = "0";

                }

                string SchExpquery = @"SELECT SUM(sch_expense_amount)
                                        FROM Scheduled_Expenses
                                        WHERE user_id = @UserId";
                var SchExpresult = queryExecutor.ExecuteSelectQuery<decimal?>(SchExpquery, new { UserId = userId, Month = currentMonth });
                if (SchExpresult != null && SchExpresult.Any())
                {
                    UserInfo.scheduled_expenses = SchExpresult.FirstOrDefault() ?? 0;
                    sch_expenses_amout.Text = (UserInfo.scheduled_expenses).ToString();
                }
                else
                {
                    sch_expenses_amout.Text = "0";
                }

                string OccExpquery = @"SELECT SUM(occ_expense_amount)
                                        FROM Occasional_Expenses
                                        WHERE user_id = @UserId AND MONTH(occ_expense_month) = @Month";
                var OccExpresult = queryExecutor.ExecuteSelectQuery<decimal?>(OccExpquery, new { UserId = userId, Month = currentMonth });
                if (OccExpresult != null && OccExpresult.Any())
                {
                    UserInfo.occasional_expenses = OccExpresult.FirstOrDefault() ?? 0;
                    occ_expenses_amount.Text = (UserInfo.occasional_expenses).ToString();
                }
                else
                {
                    occ_expenses_amount.Text = "0";
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while fetching budget: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addBudgetIcon_Click(object sender, EventArgs e)
        {
            Budget nav = new Budget();
            this.Hide();
            nav.Show();
        }

        private void addBSavingsIcon_Click(object sender, EventArgs e)
        {
            Savings nav = new Savings();
            this.Hide();
            nav.Show();
        }

        private void Savings_amount_Click(object sender, EventArgs e)
        {

        }

        private void addSchExpIcon_Click(object sender, EventArgs e)
        {
            SchExpenses nav = new SchExpenses();
            this.Hide();
            nav.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
