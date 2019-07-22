using MVCWebServiceDemo.Models;
using MVCWebServiceDemo.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebServiceDemo.Controllers
{
    public class HomeController : Controller
    {

        // Get Home
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
