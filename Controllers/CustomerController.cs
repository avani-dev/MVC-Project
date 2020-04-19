using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("MvcTest")]
        public ActionResult cust()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!!!";
            return View();
        }

        [Route("Mvctest/{customerName?}")]
       // [Route("Mvctest/{customerName=Avani}")]

        public ActionResult OtherTest(string customerName)
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }

    }
}