using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Cattion.Models;
using Cattion.ViewModels;

namespace Cattion.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private ApplicationDbContext _context;
        public CustomerController()
        {
             _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        [Authorize(Roles = "CanManageCustomers")]
        public ActionResult New()
        {
            var membership = _context.memberships.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                Customer = new Customer(),
               memberships = membership
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index","Customer");
        }
        public ActionResult Details(int? id)
        {
            var customers = _context.Customers.Include(c => c.Membership).SingleOrDefault(c => c.id == id); 
            if (customers == null)
                return HttpNotFound();

            return View(customers);
        }
        
        public ActionResult Index()
        {
            var  customers = _context.Customers.Include(c=>c.Membership).Include(c=>c.Cats).ToList();
            if (customers == null)
                return HttpNotFound();
            if (User.IsInRole("CanManageCustomers"))
                return View(customers);
            else
                return View("ReadOnlyList", customers);

        }
    }
}