using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using StarshipFailing.Models;

namespace StarshipFailing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "StarShip Failing";
            Description description = new Description();
            description.roomDescription = System.IO.File.ReadAllText(@"D:\Starship_Failing\StarshipFailing\StarshipFailing\Story\Description1.txt");
            return View(description);
        }
    }
}
