using Microsoft.AspNetCore.Mvc;
using ProjectASP.Models;

namespace ProjectASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CustomerReader reader=new CustomerReader();
            reader.GetCustomers();
            System.Console.WriteLine("");
            return View("Index");
        }
    }
}
