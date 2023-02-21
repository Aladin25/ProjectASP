using Microsoft.AspNetCore.Mvc;
using ProjectASP.Models;

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
