using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesFeedBacks.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.as dfas df ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.asd fsaf sadf ";

            return View();
        }
    }
}