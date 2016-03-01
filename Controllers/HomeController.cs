using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace TestSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tech()
        {
            ViewData["Message"] = "Will it work?";

            return View();
        }

        public IActionResult Legs()
        {
            ViewData["Message"] = "I'll never be Usain Bolt or Mo Farah...";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
