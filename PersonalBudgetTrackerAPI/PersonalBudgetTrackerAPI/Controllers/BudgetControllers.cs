using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalBudgetTrackerAPI.Data;
using PersonalBudgetTrackerAPI.Models;

namespace PersonalBudgetTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetControllers : ControllerBase
    {
        private readonly BudgetTrackerDbContect _context;
        public BudgetControllers(BudgetTrackerDbContect context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> AddBudget(Budget budget)
        {
            _context.Budgets.Add(budget);
            await _context.SaveChangesAsync();
            return Ok(budget);
        }

        [HttpGet]
        public async Task<IActionResult> GetBudget()
        {
            var budget = await _context.Budgets.OrderByDescending(b => b.Id).FirstOrDefaultAsync();
            return Ok(budget);
        }

        [HttpDelete("reset")]
        public async Task<IActionResult> Reset()
        {
            _context.Budgets.RemoveRange(_context.Budgets);
            _context.Expenses.RemoveRange(_context.Expenses);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
