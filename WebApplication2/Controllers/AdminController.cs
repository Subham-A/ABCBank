using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        

        [HttpGet]
        public ActionResult GetPendingRequest()
        {
            using (var context = new ApplicationDbContext())
            {
                return View(context.RequestCollection.Where(r => !r.IsFullfilled).ToList());
            }

        }

        [HttpGet]
        public ActionResult GetFullfilledRequest()
        {
            using (var context = new ApplicationDbContext())
            {
                return View(context.RequestCollection.Where(r => r.IsFullfilled).ToList());
            }

        }

    }
}