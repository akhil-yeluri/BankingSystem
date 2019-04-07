using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingSystem.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult ManagerPage()
        {
            return View();
        }

        public ActionResult ManagerAdd()
        {
            return View();
        }

        public ActionResult CheckIdAvailability()
        {
            
            return Content("true");
        }

        public ActionResult CustomerSuccessfullyAdded()
        {
            return Content("Customer Registered Successfully");
        }


        public ActionResult ManagerEdit()
        {
            return View();
        }
    }
}