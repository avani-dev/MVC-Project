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
        public ContentResult ContentMEthod()
        {
            return Content("<h3>Zain Ul Hassan </h3>");
        }
        public ContentResult ContentMethod1()
        {
            return Content("<h3>Zain Ul Hassan</h3>", "text/html");
        }
        public ContentResult ContentMethod11()
        {
            return Content(
            "<script> alert('Hi! I am Zain Ul Hassan') </script>"
                );
        }
    }
}