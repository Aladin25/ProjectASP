using Microsoft.AspNetCore.Mvc;
using ProjectASP.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectASP.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index(string filter)
        {
            CustomerReader reader = new CustomerReader();
            List<Customer> list = reader.GetCustomers();
            var customers = list; 
            
            if (!string.IsNullOrEmpty(filter))
            {
                customers = customers.Where(c => c.City == filter).ToList();
            }
            return View("Index", customers);
           // ------------------------------
            //Непотрібно оскільки в таблиці використовується скріпт в якому міститься пошукова строка
           /* if (!string.IsNullOrEmpty(search))
            {
                customers = customers.Where(c =>
                    c.FirstName.Contains(search) ||
                    c.LastName.Contains(search) ||
                    c.AddressLine.Contains(search) ||
                    c.City.Contains(search) ||
                    c.CompanyName.Contains(search)).ToList();
            }
           */
            
        }
    }
}
