using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers
{
    public class EmployeeController : Controller
    {   
        public IActionResult Employee()
        {
            List<Employee> msg = new List<Employee>()
            {
                new Employee(){Id = 1, FirstName = "John", LastName = "Doe", Age = 25},
                new Employee(){Id = 2, FirstName = "Jane", LastName = "Doe", Age = 22},
                new Employee(){Id = 3, FirstName = "John", LastName = "Smith", Age = 30}
            };
            return View("Employee", msg);
        }
    }
}