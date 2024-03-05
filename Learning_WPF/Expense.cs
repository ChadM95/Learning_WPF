using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_WPF
{
    class Expense
    {
        public string Category { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateIncurred { get; set; }

        public Expense(string category, decimal cost, DateTime dateIncurred)
        {
            Category = category;
            Cost = cost;
            DateIncurred = dateIncurred;
        }

        public Expense()
        {
        }

        public override string ToString()
        {
            return $"{Category} {Cost:C} {DateIncurred.ToShortDateString()}";
        }
    }
}
