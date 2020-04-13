using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult Index_Test()
        {
            return View();
        }
        public ViewResult Index()
        {
            return View();
        }
        public ContentResult Index1()
        {
            return Content("<h3>Zain Ul Hassan </h3>");
        }

    }
}