using BudgetTrackerAPI.Models;

namespace BudgetTrackerAPI.Services
{
    public class TaxService
    {
        private static readonly Dictionary<string, decimal> StateTaxRates = new()
        {
            { "FL", 0.00m },
            { "CA", 0.10m },
            { "NY", 0.09m },
            { "TX", 0.00m },
            { "GA", 0.06m },
            // Add more as needed
        };

        public decimal GetAfterTaxIncome(Income income)
        {
            decimal taxRate = StateTaxRates.TryGetValue(income.State, out var rate) ? rate : 0.05m;
            return income.Amount * (1 - taxRate);
        }
    }
}