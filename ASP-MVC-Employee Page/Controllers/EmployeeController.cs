using ASP_MVC_Employee_Page.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Employee_Page.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employees = new List<Employee>();

            employees.Add(new Employee { EmployeeId = 1, FirstName = "abood", LastName = "essa", Email = "abood@essa.com", Department = "IT" });
            employees.Add(new Employee { EmployeeId = 2, FirstName = "hammood", LastName = "sabanja", Email = "hammood@sabanja.com", Department = "HR" });
            employees.Add(new Employee { EmployeeId = 3, FirstName = "fatema", LastName = "khaled", Email = "fatema@khaled.com", Department = "HR" });
            employees.Add(new Employee { EmployeeId = 4, FirstName = "hasan", LastName = "hussain", Email = "hasan@hussain.com", Department = "HR" });
            employees.Add(new Employee { EmployeeId = 5, FirstName = "yousef", LastName = "almutref", Email = "yousef@almutref.com", Department = "MUSIC" });

            return View(employees);
        }
    }
}
