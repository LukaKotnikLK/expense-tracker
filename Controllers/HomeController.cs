using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using expense_tracker.Models;

namespace expense_tracker.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var expense = new Expense
        {
            Id = 1,
            Title = "Example Expense",
            Amount = 100.00m,
            Date = DateTime.Now.ToString("dd/MM/yyyy")
        };
        return View(expense);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Info()
    {
        return View();
    }

    public IActionResult ExpenseList()
    {
        var expenses = new List<Expense>
        {
            new Expense { Id = 1, Title = "Groceries", Amount = 150.75m, Date = "01/09/2024" },
            new Expense { Id = 2, Title = "Rent", Amount = 1200.00m, Date = "03/09/2024" },
            new Expense { Id = 3, Title = "Utilities", Amount = 200.50m, Date = "05/09/2024" }
        };

        return View(expenses);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
