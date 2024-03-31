using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Core.Models.Expense
{
    public class ExpenseViewModel
    {
        public int Id {  get; set; }
        public string TruckPlate { get; set; } = string.Empty;
        public decimal Amount { get; set; } 
        public string ExpenseType { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;
        public DateTime ExpenseDate { get; set; }

    }
}
