using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith", Id = 1},
                new Customer {Name = "Mary Williams", Id = 2}
            };

            return View(customers);
        }

        public ActionResult Details(int? customerId)
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith", Id = 1},
                new Customer {Name = "Mary Williams", Id = 2}
            };

            var customer = customers.Find(c => c.Id == customerId);

            return View(customer);
        }
    }


}