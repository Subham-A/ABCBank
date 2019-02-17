using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Authorize(Roles = "Loans")]
    public class LoansController : Controller
    {
        // GET: Loans
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public ActionResult GetLoans()
        {
            using (var context = new ApplicationDbContext())
            {
                return View(context.RequestCollection.Where(r => !r.IsFullfilled && r.Service == Services.Loans).ToList());
            }

        }
    }
}