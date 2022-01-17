using MovieApp.Models;
using MovieApp.Models.MVVM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
    public class CustomerController : Controller
    {
        //dans CustomerController générer les données automatiquement:

         ApplicationDbContext  _db;
        public CustomerController()
        {
            _db = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var movie2 = new Movie() { Name = "Movie 1" };
            /* var customers2 = new List<Customer>
             {
                 new Customer { Id = 1, Name = "Client 1" },
                 new Customer { Id = 2, Name = "Client 2" },
             };
            */

            //var customers2 = GetCustomers().ToList();
            //remplacer GetCustomers() par _db.customers : 
             var customers2 = _db.customers.ToList();

            CustomerMovieVM customerMovieVM = new CustomerMovieVM
            {
                movie = movie2,
                customers = customers2
            };
            return View(customerMovieVM);
        }
        public ActionResult List()
        {
            var customers = _db.customers.Include(c=> c.membershiptype).ToList();
            return View(customers);
        }
            public ActionResult Details(int id)
        {
           // var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            //remplacer GetCustomers() par _db.customers : 
            var customer = _db.customers.Include(c => c.membershiptype).SingleOrDefault(c => c.Id == id);
            return View(customer);
        }
        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id=1,Name ="Client 1"},
                new Customer{Id = 2,Name ="Client 2"},
            };
        }
    }
}