using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDugun.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Slider() //<div id=home>
        {
            return View();
        }

        public ActionResult Story()
        {
            return View();
        }

        public ActionResult Timer()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Wedding()
        {
            return View();
        }

        public ActionResult Rezervasyon()
        {
            return View();
        }
    }
}