namespace expense_tracker.Models;

public class AddExpense
{
    public static List<Expense> Expenses = new List<Expense>
        {
            new Expense { Id = 1, Title = "Groceries", Amount = 150.75m, Date = new DateTime(2024, 9, 1) },
            new Expense { Id = 2, Title = "Rent", Amount = 1200.00m, Date = new DateTime(2024, 9, 3) },
            new Expense { Id = 3, Title = "Utilities", Amount = 200.50m, Date = new DateTime(2024, 9, 5) }
        };

    public int addExpense(Expense expense)
    {
        expense.Id = Expenses.Count + 1;
        expense.Date = DateTime.Now.Date;
        Expenses.Add(expense);
        return expense.Id;
    }

    public Expense GetExpenseById(int id)
    {
        var expense = Expenses.FirstOrDefault(e => e.Id == id);
        if (expense == null) throw new ArgumentException($"Expense with id {id} not found"); // throw an exception or return null based on your design choice
        return expense;
    }
}
