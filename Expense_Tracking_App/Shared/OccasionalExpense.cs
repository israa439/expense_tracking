using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracking_App.Shared
{
    public class OccasionalExpense
    {
        public string OccExpenseName { get; set; }
        public decimal OccExpenseAmount { get; set; }
        public DateTime OccExpenseMonth { get; set; }
        public int UserId { get; set; }
    }
}
