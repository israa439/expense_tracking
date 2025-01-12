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
    public partial class OccExpenses : Form
    {
        private queryExecutor queryExecutor;
        public OccExpenses()
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
        private void OccExpenses_Load(object sender, EventArgs e)
        {
            LoadOccasionalExpensesAsCards();
        }
        public OccasionalExpense[] Get_Occ_Expenses(int userId)
        {
            string query = @"
    SELECT occ_expense_name AS OccExpenseName, 
           occ_expense_amount AS OccExpenseAmount, 
           occ_expense_month AS OccExpenseMonth, 
           user_id AS UserId
    FROM [Occasional_Expenses]
    WHERE user_id = @UserId AND MONTH(occ_expense_month) = MONTH(GETDATE()) AND YEAR(occ_expense_month) = YEAR(GETDATE());
    ";
            var results = queryExecutor.ExecuteSelectQuery<OccasionalExpense>(query, new { UserId = userId });
            return results.ToArray();
        }

        private void LoadOccasionalExpensesAsCards()
        {
            try
            {
                panelOccasionalExpenses.Controls.Clear();
                var expenses = Get_Occ_Expenses(UserInfo.UserId);

                int cardWidth = 300;
                int cardHeight = 110;
                int padding = 10;
                int cardsPerRow = 4;

                int x = padding;
                int y = padding;
                int count = 0;

                foreach (var expense in expenses)
                {
                    RoundedPanel card = new RoundedPanel
                    {
                        Size = new Size(cardWidth, cardHeight),
                        BorderRadius = 25,
                        BackgroundColor = Color.RoyalBlue,
                        BorderColor = Color.Gray,
                        Location = new Point(x, y + 20)
                    };

                    Button deleteButton = new Button
                    {
                        Size = new Size(30, 30),
                        Location = new Point(cardWidth - 35, 5),
                        BackColor = Color.Transparent,
                        FlatStyle = FlatStyle.Flat,
                        BackgroundImage = Image.FromFile("C:\\Users\\lenovo\\source\\repos\\Expense_Tracking_App\\Expense_Tracking_App\\Resources\\x_icon.png"),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Cursor = Cursors.Hand
                    };
                    deleteButton.FlatAppearance.BorderSize = 0;

                    deleteButton.Click += (sender, e) =>
                    {
                        DeleteOccasionalExpense(UserInfo.UserId, expense.OccExpenseName, card);
                        LoadOccasionalExpensesAsCards();
                    };

                    Label nameLabel = new Label
                    {
                        Text = $"Expense: {expense.OccExpenseName}",
                        Location = new Point(10, 10),
                        Size = new Size(300, 30),
                        ForeColor = Color.White,
                        BackColor = Color.RoyalBlue,
                        Font = new Font("Dubai", 13, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    Label amountLabel = new Label
                    {
                        Text = $"Amount: {expense.OccExpenseAmount:C}",
                        Location = new Point(10, 60),
                        Size = new Size(200, 25),
                        ForeColor = Color.White,
                        BackColor = Color.RoyalBlue,
                        Font = new Font("Dubai", 13, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    card.Controls.Add(deleteButton);
                    card.Controls.Add(nameLabel);
                    card.Controls.Add(amountLabel);

                    panelOccasionalExpenses.Controls.Add(card);

                    count++;
                    if (count % cardsPerRow == 0)
                    {
                        x = padding;
                        y += cardHeight + padding + 20;
                    }
                    else
                    {
                        x += cardWidth + padding;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void DeleteOccasionalExpense(int userId, string expenseName, Panel card)
        {
            try
            {
                var result = MessageBox.Show($"Are you sure you want to delete '{expenseName}'?",
                                             "Confirm Delete",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = @"
            DELETE FROM [Occasional_Expenses]
            WHERE user_id = @UserId AND occ_expense_name = @ExpenseName;
            ";

                    // Execute the delete query
                    int rowsAffected = queryExecutor.ExecuteNonQuery(query, new { UserId = userId, ExpenseName = expenseName });

                    if (rowsAffected > 0)
                    {
                        // Remove the card from the panel
                        panelOccasionalExpenses.Controls.Remove(card);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the expense. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Display_occ_form()
        {
            using (occ_expense_form popup = new occ_expense_form())
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    string expenseName = popup.ExpenseName;
                    decimal expenseAmount = popup.ExpenseAmount;
                    DateTime expenseMonth = DateTime.Now;

                    try
                    {
                        
                        if (expenseAmount > UserInfo.budget)
                        {
                            MessageBox.Show("The budget is not sufficient for this expense.", "Insufficient Budget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; 
                        }

                        string query = @"
                INSERT INTO Occasional_Expenses (user_id, occ_expense_name, occ_expense_amount, occ_expense_month)
                VALUES (@UserId, @ExpenseName, @ExpenseAmount, @ExpenseMonth)";
                        queryExecutor.ExecuteNonQuery(query, new
                        {
                            UserId = UserInfo.UserId,
                            ExpenseName = expenseName,
                            ExpenseAmount = expenseAmount,
                            ExpenseMonth = expenseMonth
                        });

                        string updateBudgetQuery = @"
            UPDATE Budget
            SET budget_amount = budget_amount - @ExpenseAmount
            WHERE user_id = @UserId";

                        queryExecutor.ExecuteNonQuery(updateBudgetQuery, new
                        {
                            UserId = UserInfo.UserId,
                            ExpenseAmount = expenseAmount
                        });
                        LoadOccasionalExpensesAsCards();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                        {
                            MessageBox.Show("Expense already added. Please use a different name",
                                            "Duplicate Entry",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void add_sch_exp_icon_Click(object sender, EventArgs e)
        {
            Display_occ_form();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Display_occ_form();
        }

       
    }
}
