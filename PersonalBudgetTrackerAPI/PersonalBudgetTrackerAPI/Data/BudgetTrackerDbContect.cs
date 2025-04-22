using Microsoft.EntityFrameworkCore;
using PersonalBudgetTrackerAPI.Models;

namespace PersonalBudgetTrackerAPI.Data
{
    public class BudgetTrackerDbContect : DbContext
    {
        public BudgetTrackerDbContect(DbContextOptions<BudgetTrackerDbContect>options):base (options) 
        {

        }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
