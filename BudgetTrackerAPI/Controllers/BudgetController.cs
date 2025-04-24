using Microsoft.AspNetCore.Mvc;
using BudgetTrackerAPI.Models;
using BudgetTrackerAPI.Services;

namespace BudgetTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BudgetController : ControllerBase
    {
        private readonly TaxService _taxService = new();
        private readonly BudgetService _budgetService = new();

        [HttpPost]
        public IActionResult CalculateBudget([FromBody] Income income)
        {
            var afterTax = _taxService.GetAfterTaxIncome(income);
            var budget = _budgetService.ApplyBudgetRule(afterTax);
            return Ok(new { AfterTaxIncome = afterTax, Budget = budget });
        }
    }
}