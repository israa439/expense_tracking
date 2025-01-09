using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracking_App
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void password_signup_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {

        }

        private void navToSignin_Click(object sender, EventArgs e)
        {
            signin nav = new signin();
            this.Hide();
            nav.Show();
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            Home nav = new Home();
            this.Hide();
            nav.Show(); 
        }
    }
}
