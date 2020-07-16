using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoDatabase.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Homepage()
        {
            return View();
        }
    }
}