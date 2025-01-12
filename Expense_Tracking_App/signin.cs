using System.Text;
using Expense_Tracking_App.Database;
using Expense_Tracking_App.Shared;

namespace Expense_Tracking_App
{
    public partial class signin : Form
    {
        private queryExecutor queryExecutor;
        public signin()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Auth_Load);
            queryExecutor = new queryExecutor();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void Auth_Load(object sender, EventArgs e)
        {
            signInContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        }

        private void navToSignup_Click(object sender, EventArgs e)
        {
            SignUp nav = new SignUp();
            this.Hide();
            nav.Show();
        }

        private void Signin_btn_Click(object sender, EventArgs e)
        {
            string username = username_signin_field.Text.Trim();
            string password = password_signin_field.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Retrieve the stored hashed password and user_id from the database
                string query = "SELECT user_id, password FROM [User] WHERE user_name = @UserName";
                var parameters = new { UserName = username };
                var results = queryExecutor.ExecuteSelectQuery<dynamic>(query, parameters);

                // Check if the user exists
                if (results.Any())
                {
                    var user = results.First();
                    int userId = user.user_id;
                    string storedHashedPassword = user.password;

                    // Hash the entered password and compare it with the stored hashed password
                    if (VerifyPassword(password, storedHashedPassword))
                    {
                        UserInfo.UserId = userId;

                        Home nav = new Home();
                        this.Hide();
                        nav.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            string hashedEnteredPassword = HashPassword(plainPassword);
            return hashedEnteredPassword == hashedPassword;
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


    }
}
