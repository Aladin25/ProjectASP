using Microsoft.AspNetCore.Mvc;

namespace ProjectASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
