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
    public partial class SignUp : Form
    {
        private queryExecutor queryExecutor;
        public SignUp()
        {
            InitializeComponent();
            queryExecutor = new queryExecutor();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
           
            string username = username_signup_field.Text.Trim();
            string password = password_signup_field.Text.Trim();
            string email = Email_signup_field.Text.Trim();
            string fullName = FullName_signup_field.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
           
                string checkEmailQuery = "SELECT COUNT(*) FROM [User] WHERE email = @Email";
                var emailCheckResult = queryExecutor.ExecuteSelectQuery<int>(checkEmailQuery, new { Email = email });

                if (emailCheckResult.First() > 0)
                {
                    MessageBox.Show("This email is already in use. Please use a different email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hash the password
                string hashedPassword = HashPassword(password);
                int userId = GenerateUniqueUserId();

                // Insert the new user into the database
                string insertQuery = "INSERT INTO [User] (user_id, user_name, email, password, FullName) VALUES (@UserId, @UserName, @Email, @Password, @FullName)";
                var parameters = new
                {
                    UserId = userId,
                    UserName = username,
                    Email = email,
                    Password = hashedPassword,
                    FullName = fullName
                };

                int rowsAffected = queryExecutor.ExecuteNonQuery(insertQuery, parameters);

                if (rowsAffected > 0)
                {
                    UserInfo.UserId = userId;
                    Home nav = new Home();
                    this.Hide();
                    nav.Show();
                }
                else
                {
                    MessageBox.Show("An error occurred during sign-up. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
        private int GenerateUniqueUserId()
        {
            Random random = new Random();
            int userId;
            IEnumerable<int> idCheckResult;


            do
            {
                userId = random.Next(100000, 999999); 
                string checkIdQuery = "SELECT COUNT(*) FROM [User] WHERE user_id = @UserId";
                idCheckResult = queryExecutor.ExecuteSelectQuery<int>(checkIdQuery, new { UserId = userId });

            } while (idCheckResult.First() > 0);

            return userId;
        }

        private void navToSignin_Click(object sender, EventArgs e)
        {
            signin nav = new signin();
            this.Hide();
            nav.Show();
        }

        
    }
}
