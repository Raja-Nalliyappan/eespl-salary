using Microsoft.AspNetCore.Mvc;

namespace Salary_calculation.Controllers
{
    public class SalaryCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
