using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracking_App.Shared
{
    public class UserInfo
    {
        public static int UserId { get; set; }
        public static decimal budget {  get; set; }
        public static decimal savings { get; set; }
        public static decimal scheduled_expenses { get; set; }
        public static decimal occasional_expenses { get; set; }

    }
}
