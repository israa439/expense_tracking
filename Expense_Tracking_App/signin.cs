namespace Expense_Tracking_App
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Auth_Load);

        }

        private void Auth_Load(object sender, EventArgs e)
        {
            signInContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void navToSignup_Click(object sender, EventArgs e)
        {
            SignUp nav = new SignUp();
            this.Hide();
            nav.Show();
        }

        private void Auth_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void Signin_btn_Click(object sender, EventArgs e)
        {
            Home nav = new Home();
            this.Hide();
            nav.Show();
        }

        private void text_Click(object sender, EventArgs e)
        {

        }
    }
}
