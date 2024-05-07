using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Data;

namespace MVC_Task1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var employees=context.Employees.ToList();
            return View("Index", employees);
        }
    }
}
