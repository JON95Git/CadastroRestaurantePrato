using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descrição da minha página";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Minha página de contato";

            return View();
        }
    }
}