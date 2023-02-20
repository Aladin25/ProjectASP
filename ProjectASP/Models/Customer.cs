using Microsoft.AspNetCore.Mvc;

namespace ProjectASP.Models
{
    public class Customer
    {
        
       public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Suffix { get; set; }
        public string CompanyName { get; set; }

        public string AddressLine { get; set; }

        public string City { get; set; }

    }
}
