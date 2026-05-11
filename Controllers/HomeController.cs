using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using expense_tracker.Models;
using System.Security.Cryptography.X509Certificates;

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
            Date = DateTime.Now
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

private static AddExpense _store = new AddExpense();

[HttpPost]
public IActionResult Post(Expense expense)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    int newExpenseId = _store.addExpense(expense);

    return RedirectToAction("ExpenseList");
}

[HttpGet("GetExpense/{id}")]
public IActionResult GetExpense(int id)
{
    try
    {
        var expense = _store.GetExpenseById(id);
        return Ok(expense);
    }
    catch (ArgumentException ex)
    {
        return NotFound(ex.Message);
    }
}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult ExpenseList()
    {
        var expenses = AddExpense.Expenses;
        return View(expenses);
    }
}
