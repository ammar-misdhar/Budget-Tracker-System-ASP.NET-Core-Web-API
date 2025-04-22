using System.ComponentModel.DataAnnotations;

namespace PersonalBudgetTrackerAPI.Models
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
