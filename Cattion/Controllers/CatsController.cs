using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cattion.Models;
using System.Data.Entity;
using Cattion.ViewModels;

namespace Cattion.Controllers
{
    public class CatsController : Controller
    {
        // GET: Cats
        private ApplicationDbContext _context;
        public CatsController()
        {
             _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [Authorize(Roles ="CanManageCustomers")]
        public ActionResult New()
        {
            var Cats = new Cats();
            return View(Cats);
        }
        [HttpPost]
        public ActionResult Create(Cats cats)
        {
            _context.cats.Add(cats);
            _context.SaveChanges();
            return RedirectToAction("Index", "Cats");
        }

        [Route("Cats/CatDetail/{name}")]
        

        public ActionResult CatDetail(string name)
        {
            var cat = _context.cats.SingleOrDefault(c=>c.name==name);
            return View(cat);
        }
        public ActionResult Index()
        {
            var cat = _context.cats.ToList();
            if (User.IsInRole("CanManageCustomers"))
                return View(cat);
            else
                return View("ReadOnlyList", cat);
        }
        
       
    }
    
}