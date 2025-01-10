using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracking_App.Shared
{
    public class ScheduledExpense
    {
        public string SchExpenseName { get; set; }
        public decimal SchExpenseAmount { get; set; }
        public int UserId { get; set; }
    }
}
