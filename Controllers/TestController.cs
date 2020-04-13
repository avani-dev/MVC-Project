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
        public JsonResult Index1()
        {
            return Json(new { Name = "Zain Ul Hassan", ID = 1 });
        }
        public RedirectResult RedirectMethod()
        {
            return Redirect("https://www.c-sharpcorner.com/members/zain-ul-hassan2");
        }
        //public RedirectToRouteResult RedirectToRouteMethod()
        //{
        //    return RedirectToRoute(new { controller = "Student", action = "Name" });
        //}
        public HttpStatusCodeResult HttpResultMethod()
        {
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.Unauthorized);
        }
        public HttpStatusCodeResult UnauthorizedMethod()
        {
            return new HttpUnauthorizedResult("Sorry! You don't have access.");
        }
        public HttpNotFoundResult NotfoundMethod()
        {
            return HttpNotFound("Sorry!! You don't have access");
        }
    }
}