using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
                return View();
        }

        [HttpPost]
        public ActionResult Add(Staff model)
        {
            using (var context = new ApplicationDbContext())
            {
                context.StaffCollection.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
        }


    }
}