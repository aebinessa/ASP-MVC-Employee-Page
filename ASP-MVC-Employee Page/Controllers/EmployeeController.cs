using ASP_MVC_Employee_Page.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Employee_Page.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = [
            new Employee { EmployeeId = 1, FirstName = "abood", LastName = "essa", Email = "abood@essa.com", Department = "IT" },
            new Employee { EmployeeId = 2, FirstName = "hammood", LastName = "sabanja", Email = "hammood@sabanja.com", Department = "HR" },
            new Employee { EmployeeId = 3, FirstName = "fatema", LastName = "khaled", Email = "fatema@khaled.com", Department = "HR" },
            new Employee { EmployeeId = 4, FirstName = "hasan", LastName = "hussain", Email = "hasan@hussain.com", Department = "HR" },
            new Employee { EmployeeId = 5, FirstName = "yousef", LastName = "almutref", Email = "yousef@almutref.com", Department = "MUSIC" },

            ];
        public IActionResult Index()
        {
            

           
            return View(employees);
        }

        public IActionResult Details(int id) 
        {

           
            var employee = employees.SingleOrDefault(a => a.EmployeeId == id);
            if(employee == null)
            {
                return RedirectToAction("Index");
            }
            return View(employee);
        
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(AddEmployeeForm form)
        {
            if (ModelState.IsValid)
            {
                var firstName = form.FirstName;
                var lastName = form.LastName;
                var email = form.Email;
                var department = form.Department;
                employees.Add(new Employee { FirstName = firstName, LastName = lastName, Email = email, Department = department });
            }

            return RedirectToAction("Index");
        }

    }
}
