using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheCorridorGroupMd.Controllers
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
            ViewBag.TheMessage = "Send us a quick message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO:    SEND MESSAGE 
            ViewBag.TheMessage = "Thanks we got your message.";
            return View();
        }
    }
}