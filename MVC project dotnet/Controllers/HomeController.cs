using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_project_dotnet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
         
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A little bit about us..";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us for more information.";

            return View();
        }
    }
}