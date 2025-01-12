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
using System.Windows.Forms.DataVisualization.Charting;
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
            LoadScheduledExpensesChart();
            CreateBarChart();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
    SELECT TOP 1 Budget_amount, Budget_month 
    FROM Budget 
    WHERE user_id = @UserId 
    ORDER BY Budget_month DESC";
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
            SELECT SUM(sch_expense_amount) AS TotalExpenses 
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

        private void AddOccExpIcon_Click(object sender, EventArgs e)
        {
            OccExpenses nav = new OccExpenses();
            this.Hide();
            nav.Show();

        }
        private void LoadScheduledExpensesChart()
        {

            var scheduledExpenses = Get_Sch_Expenses(UserInfo.UserId);

            if (scheduledExpenses.Length == 0)
            {
                MessageBox.Show("No scheduled expenses available to display.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Chart pieChart = new Chart
            {
                Size = new Size(400, 400),
                BackColor = Color.Transparent
            };


            ChartArea chartArea = new ChartArea("MainArea")
            {
                BackColor = Color.Transparent
            };
            pieChart.ChartAreas.Add(chartArea);


            Series series = new Series("Scheduled Expenses")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = false
            };

            foreach (var expense in scheduledExpenses)
            {
                if (expense.SchExpenseAmount > 0)
                {
                    series.Points.AddXY(expense.SchExpenseName, expense.SchExpenseAmount);
                }
            }


            foreach (var point in series.Points)
            {
                double percentage = (point.YValues[0] / series.Points.Sum(p => p.YValues[0])) * 100;
                point.ToolTip = $"{point.AxisLabel}: {percentage:F2}%";
            }


            series["PieLabelStyle"] = "Disabled";
            series.BorderWidth = 1;
            series.BorderColor = Color.Black;

            pieChart.Series.Add(series);


            Legend legend = new Legend("MainLegend")
            {
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center,
                BackColor = Color.Transparent
            };
            pieChart.Legends.Add(legend);


        
            int x = 10;
            int y = this.ClientSize.Height - pieChart.Height - 20;
            pieChart.Location = new Point(x, y);


            this.Controls.Add(pieChart);
        }
        private void CreateBarChart()
        {
           
            var OccasionalExpenses = Get_Exp_Expenses(UserInfo.UserId);

           
            Chart barChart = new Chart();

            ChartArea chartArea = new ChartArea("MainArea")
            {
                AxisX = { Title = "Categories" },
                AxisY = { Title = "Amount (USD)" },
                BackColor = Color.Transparent 
            };
            chartArea.AxisX.MajorGrid.Enabled = false; chartArea.AxisX.MinorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.MinorGrid.Enabled = false;
            barChart.ChartAreas.Add(chartArea);

           
            Series series = new Series("Expenses")
            {
                ChartType = SeriesChartType.Bar,
               
            };

           
            foreach (var expense in OccasionalExpenses)
            {
                int pointIndex = series.Points.AddXY(expense.OccExpenseName, expense.OccExpenseAmount);
                series.Points[pointIndex].ToolTip = $"{expense.OccExpenseName}: {expense.OccExpenseAmount:C}";
            }

            barChart.Series.Add(series);

          
            Legend legend = new Legend("MainLegend")
            {
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center,
                BackColor = Color.Transparent 
            };
            barChart.Legends.Add(legend);

          
            barChart.Width = 600; 
            barChart.Height = 400; 
            barChart.BackColor = Color.Transparent;


            int x = this.ClientSize.Width - barChart.Width - 150;
            int y = this.ClientSize.Height - barChart.Height - 20; 
            barChart.Location = new Point(x, y);

            
            this.Controls.Add(barChart);
        }

        private ScheduledExpense[] Get_Sch_Expenses(int userId)
        {

            // SQL query to fetch scheduled expenses for the given user
            string query = @"
        SELECT sch_expense_name AS SchExpenseName, 
               sch_expense_amount AS SchExpenseAmount 
        FROM Scheduled_Expenses 
        WHERE user_id = @UserId
    ";

            // Execute the query and fetch data
            var scheduledExpenses = queryExecutor.ExecuteSelectQuery<ScheduledExpense>(query, new { UserId = userId });

            // Return the result as an array
            return scheduledExpenses.ToArray();
        }
        private OccasionalExpense[] Get_Exp_Expenses(int userId)
        {


            string query = @"
    SELECT occ_expense_name AS OccExpenseName, 
           occ_expense_amount AS OccExpenseAmount, 
          
           user_id AS UserId
    FROM [Occasional_Expenses]
    WHERE user_id = @UserId AND MONTH(occ_expense_month) = MONTH(GETDATE()) AND YEAR(occ_expense_month) = YEAR(GETDATE());
    ";
            var results = queryExecutor.ExecuteSelectQuery<OccasionalExpense>(query, new { UserId = userId });
            return results.ToArray();
        }
    }



}
