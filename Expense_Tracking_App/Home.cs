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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addBudgetIcon_Click(object sender, EventArgs e)
        {
            //Budget nav = new Budget();
            //this.Hide();
            //nav.Show();
        }

        private void addBSavingsIcon_Click(object sender, EventArgs e)
        {
            Savings nav = new Savings();
            this.Hide();
            nav.Show();
        }
    }
}
