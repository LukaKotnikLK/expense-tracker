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
            Amount = 100.00m
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
