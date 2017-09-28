using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DandelionWeb.Controllers
{
    //[RoutePrefix("")]
    public class HomeController : Controller
    {
        //[Route("")]
        public ActionResult Index()
        {
            return View("NgApp");
           // return View();
        }
        [Route("trip")]
        [Route("location")]
        [Route("person")]
        public ActionResult AppBookmarkableRoutes()
        {
            return View("NgApp");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}