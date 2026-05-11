namespace expense_tracker.Models
{
    public class Expense
    {
        public required int Id { get; set; }

        public required string Title { get; set; }

        public required decimal Amount { get; set; }

        public required string Date { get; set;}
    }
}