using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Authorize(Roles = "New Account")]
    public class NewAccountController : Controller
    {
        // GET: NewAccount
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public ActionResult GetNewAccount()
        {
            using (var context = new ApplicationDbContext())
            {
                return View(context.RequestCollection.Where(r => !r.IsFullfilled && r.Service == Services.NewAccount).ToList());
            }

        }
    }
}