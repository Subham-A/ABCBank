using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Authorize(Roles = "Enquiry,Funds Transfer,Deposit,Loans,New Account,Grievance,Admin")]
    public class RequestController : Controller
    {
        // GET: Request
        public ActionResult Index()
        {
            return View();
        }

   

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var request = context.RequestCollection.FirstOrDefault(r => r.Id == id);
                
                if(request != null)
                {
                    return View(new EditViewModel {
                         Id=request.Id,
                        CustomerName =request.CustomerName,
                         City=request.City,
                          AccountNumber=request.AccountNumber,
                           Address=request.Address,
                            ActionTaken=request.IsFullfilled,
                             Service=request.Service
                    });
                }
                else
                {
                    return View();
                }
               
            }
                
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel model)
        {
            using (var context = new ApplicationDbContext())
            {
                var request = context.RequestCollection.FirstOrDefault(r => r.Id == model.Id);

                if (request != null)
                {
                    
                    request.IsFullfilled = model.ActionTaken;
                    context.SaveChanges();
                }
                


                return RedirectToAction("Index", "Home");
            }
        }

    }
}