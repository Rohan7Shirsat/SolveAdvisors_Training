using Microsoft.AspNetCore.Mvc;

namespace MVC_Application.Controllers
{
    public class TaskList : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
