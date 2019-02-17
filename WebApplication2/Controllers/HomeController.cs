using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize(Roles = "Engineering, Finance")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult NewRequest()
        {
            return View();
        }



        [HttpPost]
        public ActionResult NewRequest(Request model)
        {
            using (var context = new ApplicationDbContext())
            {
                context.RequestCollection.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
                
        }

    }
}