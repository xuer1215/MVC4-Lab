using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites_Git.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Greeting = GreetingMessage();
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }

        private static string GreetingMessage()
        {
            return DateTime.Now.Hour < 12 ? "Good morning" : "Good afternoon";
        }

    }
}
