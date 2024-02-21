using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AverageCalculator1.Models;

namespace AverageCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateAverage(double number1, double number2)
        {
            double average = (number1 + number2) / 2;
            ViewBag.Average = average;
            return View("Index");
        }
    }
}
