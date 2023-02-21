using Microsoft.AspNetCore.Mvc;
using ProjectASP.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectASP.Controllers
{
    public class GraficController : Controller
    {
        public IActionResult Index()
        {
            CustomerReader customer = new CustomerReader();
            var customers=customer.GetCustomers();
            List<GraficGrup> graficGrups = customers
     .GroupBy(c => c.City)
     .Select(g => new GraficGrup
     {
         City = g.Key,
         Count = g.Count()
     })
     .ToList();

            return View("Index", graficGrups);
            
        }
    }
}
