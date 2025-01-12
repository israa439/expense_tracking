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
    public partial class occ_expense_form : Form
    {
        public string ExpenseName { get; private set; }
        public decimal ExpenseAmount { get; private set; }
        public occ_expense_form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (string.IsNullOrWhiteSpace(txtExpenseName.Text))
            {
                MessageBox.Show("Expense Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set the properties
            ExpenseName = txtExpenseName.Text;
            ExpenseAmount = amount;

            // Close the form with DialogResult.OK to indicate success
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void occ_expense_form_Load(object sender, EventArgs e)
        {

        }
    }
}
