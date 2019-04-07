using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingSystem.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomerPage()
        {
            return View();
        }
    }
}