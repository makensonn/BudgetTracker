using BudgetTrackerAPI.Models;

namespace BudgetTrackerAPI.Services
{
    public class BudgetService
    {
        public Dictionary<string, decimal> ApplyBudgetRule(decimal totalIncome)
        {
            return new Dictionary<string, decimal>
            {
                { "Needs", totalIncome * 0.50m },
                { "Wants", totalIncome * 0.30m },
                { "Savings", totalIncome * 0.20m }
            };
        }
    }
}