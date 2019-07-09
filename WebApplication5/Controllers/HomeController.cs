using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GotoHome()
        {
           ViewData["Mytime"] = DateTime.Now.ToString();
            TempData["val"] = "Hello";
            return View("MyHomepage");
        }
    }
}