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
                int userId = UserInfo.UserId;

                string Budgetquery = @"
                                    SELECT Budget_amount 
                                    FROM Budget 
                                    WHERE user_id = @UserId AND MONTH(Budget_month) = @Month";
                var Budgetresult = queryExecutor.ExecuteSelectQuery<decimal>(Budgetquery, new { UserId = userId, Month = currentMonth });
                if (Budgetresult != null && Budgetresult.Any())
                {
                    UserInfo.budget = Budgetresult.First();
                    Budget_amount.Text = (UserInfo.budget).ToString();
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
    }
}
