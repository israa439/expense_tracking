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
    public partial class SchExpenses : Form
    {
        private queryExecutor queryExecutor;
        public SchExpenses()
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
        private void SchExpenses_Load(object sender, EventArgs e)
        {
            LoadScheduledExpensesAsCards();
        }
        public ScheduledExpense[] Get_Sch_Expenses(int userId)
        {
            string query = @"
        SELECT sch_expense_name AS SchExpenseName, 
               sch_expense_amount AS SchExpenseAmount, 
               user_id AS UserId
               FROM [Scheduled_Expenses]
               WHERE user_id = @UserId;
    ";
            var results = queryExecutor.ExecuteSelectQuery<ScheduledExpense>(query, new { UserId = userId });
            return results.ToArray();
        }

        private void LoadScheduledExpensesAsCards()
        {
            try
            {
                var expenses = Get_Sch_Expenses(UserInfo.UserId);
                panelScheduledExpenses.Controls.Clear();

                int cardWidth = 300; 
                int cardHeight = 80; 
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
                        BorderRadius = 10,
                        BackgroundColor = Color.CornflowerBlue,
                        BorderColor = Color.Gray,
                        Location = new Point(x, y+20)
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
                        DeleteScheduledExpense(UserInfo.UserId, expense.SchExpenseName, card);
                        LoadScheduledExpensesAsCards();
                    };

                    Label nameLabel = new Label
                    {
                        Text = $"Expense: {expense.SchExpenseName}",
                        Location = new Point(10, 10),
                        Size = new Size(200, 25),
                        ForeColor = Color.White,
                        BackColor = Color.CornflowerBlue, 
                        Font = new Font("Dubai", 13, FontStyle.Bold), 
                        TextAlign = ContentAlignment.MiddleLeft 
                    };

                    Label amountLabel = new Label
                    {
                        Text = $"Amount: {expense.SchExpenseAmount:C}",
                        Location = new Point(10, 40),
                        Size = new Size(200, 25),
                        ForeColor = Color.White,
                        BackColor = Color.CornflowerBlue, 
                        Font = new Font("Dubai", 13, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleLeft
                    };


                    
                    card.Controls.Add(deleteButton);
                    card.Controls.Add(nameLabel);
                    card.Controls.Add(amountLabel);

                  
                    panelScheduledExpenses.Controls.Add(card);

                    count++;
                    if (count % cardsPerRow == 0)
                    {
                        x = padding;
                        y += cardHeight + padding+20; 
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

        private void DeleteScheduledExpense(int userId, string expenseName, Panel card)
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
                DELETE FROM [Scheduled_Expenses]
                WHERE user_id = @UserId AND sch_expense_name = @ExpenseName;
            ";

                    // Execute the delete query
                    int rowsAffected = queryExecutor.ExecuteNonQuery(query, new { UserId = userId, ExpenseName = expenseName });

                    if (rowsAffected > 0)
                    {
                        // Remove the card from the panel
                        panelScheduledExpenses.Controls.Remove(card);
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

    }

}
