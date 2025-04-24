namespace BudgetTrackerAPI.Models
{
    public class Income
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public decimal Amount { get; set; }
        public string Frequency { get; set; } // Weekly, Biweekly, Monthly, Yearly
        public string State { get; set; }
    }
}