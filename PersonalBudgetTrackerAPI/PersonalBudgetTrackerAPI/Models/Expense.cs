using System.ComponentModel.DataAnnotations;

namespace PersonalBudgetTrackerAPI.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
