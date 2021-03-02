using System;
using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    // localhost:5000/home
    public class HomeController : Controller
    {
        // localhost:5000/home/index
        public IActionResult Index() // action
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat>12?"Have a good day":"Good morning,";
            ViewBag.Username = "Taha";
            return View();
        }
        // localhost:5000/home/about
        public IActionResult About() // action
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}