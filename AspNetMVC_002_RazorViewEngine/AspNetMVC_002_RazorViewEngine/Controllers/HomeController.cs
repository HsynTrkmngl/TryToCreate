using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_002_RazorViewEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult BoslukYazdirma()
        {
            return View();
        }

        public ActionResult HtmlYazdirma()
        {
            return View();
        }

        public ActionResult Donguler()
        {
            return View();
        }

        public ActionResult DongulerOzelKodlama()
        {
            return View();
        }

    }
}