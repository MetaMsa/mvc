using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;  
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            Repository.Add(model);
            return View("FeedBack", model);
        }
    }
}   